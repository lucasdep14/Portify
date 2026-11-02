namespace Portify
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            Klanten = new TabPage();
            txtEmail = new TextBox();
            txtBedrijf = new TextBox();
            txtNaam = new TextBox();
            dgvKlanten = new DataGridView();
            btnKlantToevoegen = new Button();
            label2 = new Label();
            label1 = new Label();
            Naam = new Label();
            Diensten = new TabPage();
            btnDienstToevoegen = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dgvAbonnementen = new DataGridView();
            cmbFrequentie = new ComboBox();
            numPrijs = new NumericUpDown();
            txtDienst = new TextBox();
            cmbKlanten = new ComboBox();
            Financiën = new TabPage();
            dgvTransacties = new DataGridView();
            btnTransactieToevoegen = new Button();
            txtBeschrijving = new TextBox();
            numTransactieBedrag = new NumericUpDown();
            rbInkomst = new RadioButton();
            rbUitgave = new RadioButton();
            lblUitgaven = new Label();
            lblInkomsten = new Label();
            tabControl1.SuspendLayout();
            Klanten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKlanten).BeginInit();
            Diensten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAbonnementen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrijs).BeginInit();
            Financiën.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransacties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTransactieBedrag).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Klanten);
            tabControl1.Controls.Add(Diensten);
            tabControl1.Controls.Add(Financiën);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // Klanten
            // 
            Klanten.Controls.Add(txtEmail);
            Klanten.Controls.Add(txtBedrijf);
            Klanten.Controls.Add(txtNaam);
            Klanten.Controls.Add(dgvKlanten);
            Klanten.Controls.Add(btnKlantToevoegen);
            Klanten.Controls.Add(label2);
            Klanten.Controls.Add(label1);
            Klanten.Controls.Add(Naam);
            Klanten.Location = new Point(4, 34);
            Klanten.Name = "Klanten";
            Klanten.Padding = new Padding(3);
            Klanten.Size = new Size(792, 412);
            Klanten.TabIndex = 0;
            Klanten.Text = "Klanten";
            Klanten.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(362, 45);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(244, 31);
            txtEmail.TabIndex = 8;
            // 
            // txtBedrijf
            // 
            txtBedrijf.Location = new Point(188, 45);
            txtBedrijf.Name = "txtBedrijf";
            txtBedrijf.Size = new Size(150, 31);
            txtBedrijf.TabIndex = 7;
            // 
            // txtNaam
            // 
            txtNaam.Location = new Point(8, 45);
            txtNaam.Name = "txtNaam";
            txtNaam.Size = new Size(150, 31);
            txtNaam.TabIndex = 6;
            // 
            // dgvKlanten
            // 
            dgvKlanten.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKlanten.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKlanten.Location = new Point(6, 82);
            dgvKlanten.Name = "dgvKlanten";
            dgvKlanten.RowHeadersWidth = 62;
            dgvKlanten.Size = new Size(778, 322);
            dgvKlanten.TabIndex = 5;
            // 
            // btnKlantToevoegen
            // 
            btnKlantToevoegen.FlatStyle = FlatStyle.Popup;
            btnKlantToevoegen.Location = new Point(621, 6);
            btnKlantToevoegen.Name = "btnKlantToevoegen";
            btnKlantToevoegen.Size = new Size(163, 70);
            btnKlantToevoegen.TabIndex = 4;
            btnKlantToevoegen.Text = "Klant toevoegen";
            btnKlantToevoegen.UseVisualStyleBackColor = true;
            btnKlantToevoegen.Click += btnKlantToevoegen_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(452, 3);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 3;
            label2.Text = "e-mail";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(231, 3);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 2;
            label1.Text = "Bedrijf";
            // 
            // Naam
            // 
            Naam.AutoSize = true;
            Naam.Location = new Point(46, 3);
            Naam.Name = "Naam";
            Naam.Size = new Size(59, 25);
            Naam.TabIndex = 1;
            Naam.Text = "Naam";
            // 
            // Diensten
            // 
            Diensten.Controls.Add(btnDienstToevoegen);
            Diensten.Controls.Add(label6);
            Diensten.Controls.Add(label5);
            Diensten.Controls.Add(label4);
            Diensten.Controls.Add(label3);
            Diensten.Controls.Add(dgvAbonnementen);
            Diensten.Controls.Add(cmbFrequentie);
            Diensten.Controls.Add(numPrijs);
            Diensten.Controls.Add(txtDienst);
            Diensten.Controls.Add(cmbKlanten);
            Diensten.Location = new Point(4, 34);
            Diensten.Name = "Diensten";
            Diensten.Padding = new Padding(3);
            Diensten.Size = new Size(792, 412);
            Diensten.TabIndex = 1;
            Diensten.Text = "Diensten";
            Diensten.UseVisualStyleBackColor = true;
            // 
            // btnDienstToevoegen
            // 
            btnDienstToevoegen.Location = new Point(663, 6);
            btnDienstToevoegen.Name = "btnDienstToevoegen";
            btnDienstToevoegen.Size = new Size(123, 84);
            btnDienstToevoegen.TabIndex = 9;
            btnDienstToevoegen.Text = "Toevoegen";
            btnDienstToevoegen.UseVisualStyleBackColor = true;
            btnDienstToevoegen.Click += btnDienstToevoegen_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(397, 10);
            label6.Name = "label6";
            label6.Size = new Size(44, 25);
            label6.TabIndex = 8;
            label6.Text = "Prijs";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(519, 10);
            label5.Name = "label5";
            label5.Size = new Size(95, 25);
            label5.TabIndex = 7;
            label5.Text = "Frequentie";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(249, 10);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 6;
            label4.Text = "Dienst";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 9);
            label3.Name = "label3";
            label3.Size = new Size(51, 25);
            label3.TabIndex = 5;
            label3.Text = "Klant";
            // 
            // dgvAbonnementen
            // 
            dgvAbonnementen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAbonnementen.Location = new Point(3, 96);
            dgvAbonnementen.Name = "dgvAbonnementen";
            dgvAbonnementen.RowHeadersWidth = 62;
            dgvAbonnementen.Size = new Size(781, 308);
            dgvAbonnementen.TabIndex = 4;
            // 
            // cmbFrequentie
            // 
            cmbFrequentie.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFrequentie.FormattingEnabled = true;
            cmbFrequentie.Items.AddRange(new object[] { "Maandelijks", "Jaarlijks", "Eenmalig" });
            cmbFrequentie.Location = new Point(475, 38);
            cmbFrequentie.Name = "cmbFrequentie";
            cmbFrequentie.Size = new Size(182, 33);
            cmbFrequentie.TabIndex = 3;
            // 
            // numPrijs
            // 
            numPrijs.DecimalPlaces = 2;
            numPrijs.Location = new Point(386, 40);
            numPrijs.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numPrijs.Name = "numPrijs";
            numPrijs.Size = new Size(83, 31);
            numPrijs.TabIndex = 2;
            // 
            // txtDienst
            // 
            txtDienst.Location = new Point(194, 38);
            txtDienst.Name = "txtDienst";
            txtDienst.Size = new Size(179, 31);
            txtDienst.TabIndex = 1;
            // 
            // cmbKlanten
            // 
            cmbKlanten.FormattingEnabled = true;
            cmbKlanten.Location = new Point(6, 37);
            cmbKlanten.Name = "cmbKlanten";
            cmbKlanten.Size = new Size(182, 33);
            cmbKlanten.TabIndex = 0;
            // 
            // Financiën
            // 
            Financiën.Controls.Add(dgvTransacties);
            Financiën.Controls.Add(btnTransactieToevoegen);
            Financiën.Controls.Add(txtBeschrijving);
            Financiën.Controls.Add(numTransactieBedrag);
            Financiën.Controls.Add(rbInkomst);
            Financiën.Controls.Add(rbUitgave);
            Financiën.Controls.Add(lblUitgaven);
            Financiën.Controls.Add(lblInkomsten);
            Financiën.Location = new Point(4, 34);
            Financiën.Name = "Financiën";
            Financiën.Padding = new Padding(3);
            Financiën.Size = new Size(792, 412);
            Financiën.TabIndex = 2;
            Financiën.Text = "Financiën";
            Financiën.UseVisualStyleBackColor = true;
            // 
            // dgvTransacties
            // 
            dgvTransacties.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransacties.Location = new Point(8, 104);
            dgvTransacties.Name = "dgvTransacties";
            dgvTransacties.RowHeadersWidth = 62;
            dgvTransacties.Size = new Size(778, 300);
            dgvTransacties.TabIndex = 8;
            // 
            // btnTransactieToevoegen
            // 
            btnTransactieToevoegen.Location = new Point(668, 6);
            btnTransactieToevoegen.Name = "btnTransactieToevoegen";
            btnTransactieToevoegen.Size = new Size(118, 93);
            btnTransactieToevoegen.TabIndex = 7;
            btnTransactieToevoegen.Text = "Toevoegen";
            btnTransactieToevoegen.UseVisualStyleBackColor = true;
            btnTransactieToevoegen.Click += btnTransactieToevoegen_Click;
            // 
            // txtBeschrijving
            // 
            txtBeschrijving.Location = new Point(287, 37);
            txtBeschrijving.Name = "txtBeschrijving";
            txtBeschrijving.Size = new Size(199, 31);
            txtBeschrijving.TabIndex = 6;
            // 
            // numTransactieBedrag
            // 
            numTransactieBedrag.DecimalPlaces = 2;
            numTransactieBedrag.Location = new Point(510, 38);
            numTransactieBedrag.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numTransactieBedrag.Name = "numTransactieBedrag";
            numTransactieBedrag.Size = new Size(119, 31);
            numTransactieBedrag.TabIndex = 5;
            // 
            // rbInkomst
            // 
            rbInkomst.AutoSize = true;
            rbInkomst.Checked = true;
            rbInkomst.Location = new Point(179, 18);
            rbInkomst.Name = "rbInkomst";
            rbInkomst.Size = new Size(102, 29);
            rbInkomst.TabIndex = 4;
            rbInkomst.TabStop = true;
            rbInkomst.Text = "Inkomst";
            rbInkomst.UseVisualStyleBackColor = true;
            // 
            // rbUitgave
            // 
            rbUitgave.AutoSize = true;
            rbUitgave.Location = new Point(179, 60);
            rbUitgave.Name = "rbUitgave";
            rbUitgave.Size = new Size(97, 29);
            rbUitgave.TabIndex = 3;
            rbUitgave.Text = "Uitgave";
            rbUitgave.UseVisualStyleBackColor = true;
            // 
            // lblUitgaven
            // 
            lblUitgaven.AutoSize = true;
            lblUitgaven.ForeColor = Color.Red;
            lblUitgaven.Location = new Point(18, 60);
            lblUitgaven.Name = "lblUitgaven";
            lblUitgaven.Size = new Size(125, 25);
            lblUitgaven.TabIndex = 2;
            lblUitgaven.Text = "Uitgaven: 0.00";
            // 
            // lblInkomsten
            // 
            lblInkomsten.AutoSize = true;
            lblInkomsten.ForeColor = Color.Lime;
            lblInkomsten.Location = new Point(18, 18);
            lblInkomsten.Name = "lblInkomsten";
            lblInkomsten.Size = new Size(139, 25);
            lblInkomsten.TabIndex = 0;
            lblInkomsten.Text = "Inkomsten: 0.00";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "MainForm";
            Text = "Portify";
            Load += MainForm_Load;
            tabControl1.ResumeLayout(false);
            Klanten.ResumeLayout(false);
            Klanten.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKlanten).EndInit();
            Diensten.ResumeLayout(false);
            Diensten.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAbonnementen).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrijs).EndInit();
            Financiën.ResumeLayout(false);
            Financiën.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransacties).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTransactieBedrag).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Klanten;
        private TabPage Diensten;
        private TabPage Financiën;
        private DataGridView dgvKlanten;
        private Button btnKlantToevoegen;
        private Label label2;
        private Label label1;
        private Label Naam;
        private TextBox txtEmail;
        private TextBox txtBedrijf;
        private TextBox txtNaam;
        private ComboBox cmbFrequentie;
        private NumericUpDown numPrijs;
        private TextBox txtDienst;
        private ComboBox cmbKlanten;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private DataGridView dgvAbonnementen;
        private Button btnDienstToevoegen;
        private Label lblUitgaven;
        private Label lblInkomsten;
        private RadioButton rbInkomst;
        private RadioButton rbUitgave;
        private NumericUpDown numTransactieBedrag;
        private DataGridView dgvTransacties;
        private Button btnTransactieToevoegen;
        private TextBox txtBeschrijving;
    }
}
