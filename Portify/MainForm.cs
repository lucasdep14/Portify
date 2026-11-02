using System.Data;

namespace Portify
{
    public partial class MainForm : Form
    {
        private readonly DatabaseHelper _db;
        public MainForm()
        {
            InitializeComponent();
            _db = new DatabaseHelper(); // Initialiseer de helper
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            if (cmbFrequentie.Items.Count == 0)
            {
                cmbFrequentie.Items.AddRange(new string[] { "Maandelijks", "Jaarlijks", "Eenmalig" });
            }

            await LaadKlantenInTabelAsync();
            await LaadKlantenDropdownAsync();
            await LaadAbonnementenInTabelAsync();
            await LaadFinancienAsync();
        }
        private async Task LaadKlantenInTabelAsync()
        {
            try
            {
                dgvKlanten.DataSource = await _db.GetKlantenAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fout bij laden van klanten: " + ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LaadFinancienAsync()
        {
            // 1. Laad de tabel
            dgvTransacties.DataSource = await _db.GetTransactiesAsync();

            // 2. Haal de totalen op en update de grote labels
            var totalen = await _db.GetFinancieleTotalenAsync();
            lblInkomsten.Text = $"Inkomsten: € {totalen.Inkomsten:N2}";
            lblUitgaven.Text = $"Uitgaven: € {totalen.Uitgaven:N2}";
        }

        private async void btnKlantToevoegen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaam.Text))
            {
                MessageBox.Show("De naam van de klant is verplicht!", "Let op", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                btnKlantToevoegen.Enabled = false; // Voorkom dubbelklikken tijdens laden

                // Voeg toe aan database
                await _db.VoegKlantToeAsync(txtNaam.Text, txtBedrijf.Text, txtEmail.Text);

                // Maak velden leeg
                txtNaam.Clear();
                txtBedrijf.Clear();
                txtEmail.Clear();

                // Ververs de tabel
                await LaadKlantenInTabelAsync();
                await LaadKlantenDropdownAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fout bij opslaan: " + ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnKlantToevoegen.Enabled = true;
            }
        }

        private async Task LaadKlantenDropdownAsync()
        {
            DataTable klanten = await _db.GetKlantenAsync();
            cmbKlanten.DataSource = klanten;

            // Gebruik de nieuwe gecombineerde kolom voor de weergave
            cmbKlanten.DisplayMember = "dropdown_weergave";
            cmbKlanten.ValueMember = "id";

            // Zet de automatische zoekfunctie (autocomplete) aan
            cmbKlanten.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbKlanten.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private async Task LaadAbonnementenInTabelAsync()
        {
            dgvAbonnementen.DataSource = await _db.GetAbonnementenAsync();
        }

        private async void btnDienstToevoegen_Click(object sender, EventArgs e)
        {
            if (cmbKlanten.SelectedValue == null || string.IsNullOrWhiteSpace(txtDienst.Text) || cmbFrequentie.SelectedItem == null)
            {
                MessageBox.Show("Vul alle velden in!", "Let op", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                btnDienstToevoegen.Enabled = false;

                // Haal het geselecteerde Klant ID op uit de dropdown
                int klantId = Convert.ToInt32(cmbKlanten.SelectedValue);
                decimal prijs = numPrijs.Value;
                string frequentie = cmbFrequentie.SelectedItem.ToString();

                await _db.VoegAbonnementToeAsync(klantId, txtDienst.Text, prijs, frequentie);

                txtDienst.Clear();
                numPrijs.Value = 0;
                await LaadAbonnementenInTabelAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fout: " + ex.Message);
            }
            finally
            {
                btnDienstToevoegen.Enabled = true;
            }
        }

        private async void btnTransactieToevoegen_Click(object sender, EventArgs e)
        {
            if (numTransactieBedrag.Value <= 0 || string.IsNullOrWhiteSpace(txtBeschrijving.Text))
            {
                MessageBox.Show("Vul een geldig bedrag en beschrijving in!", "Let op", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                btnTransactieToevoegen.Enabled = false;

                string type = rbInkomst.Checked ? "Inkomst" : "Uitgave";
                decimal bedrag = numTransactieBedrag.Value;
                string beschrijving = txtBeschrijving.Text;

                await _db.VoegTransactieToeAsync(type, bedrag, beschrijving);

                // Reset de invulvelden
                numTransactieBedrag.Value = 0;
                txtBeschrijving.Clear();
                rbInkomst.Checked = true;

                // Ververs het overzicht en de totalen
                await LaadFinancienAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fout bij opslaan: " + ex.Message);
            }
            finally
            {
                btnTransactieToevoegen.Enabled = true;
            }
        }
    }
}
