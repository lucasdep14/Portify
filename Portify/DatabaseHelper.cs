using Npgsql;
using System;
using System.Data;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

public class AppSettings
{
    public string ConnectionString { get; set; }
}

public class DatabaseHelper
{
    private readonly string _connectionString;

    public DatabaseHelper()
    {
        // Lees de connectiestring uit config.json
        string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json");

        if (!File.Exists(configPath))   // Controleer of het bestand bestaat
        {
            throw new FileNotFoundException("Het bestand config.json ontbreekt! Zorg dat het is aangemaakt en op 'Copy if newer' staat.");
        }

        string jsonString = File.ReadAllText(configPath); // Lees de inhoud van het bestand
        var settings = JsonSerializer.Deserialize<AppSettings>(jsonString); // Deserialiseer de JSON naar een AppSettings-object

        _connectionString = settings.ConnectionString; // Sla de connectiestring op in een veld
    }

    // Voorbeeld: Alle klanten ophalen
    public async Task<DataTable> GetKlantenAsync()
    {
        var dataTable = new DataTable();

        using (var conn = new NpgsqlConnection(_connectionString))
        {
            await conn.OpenAsync();

            // DEZE QUERY IS AANGEPAST VOOR DE DROPDOWN_WEERGAVE:
            string query = @"
            SELECT *, 
            CONCAT_WS(' - ', NULLIF(naam, ''), NULLIF(bedrijf, ''), NULLIF(btw_nummer, '')) AS dropdown_weergave 
            FROM klanten 
            ORDER BY naam ASC";

            using (var cmd = new NpgsqlCommand(query, conn))
            {
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    dataTable.Load(reader);
                }
            }
        }

        return dataTable;
    }

    public async Task VoegKlantToeAsync(string naam, string bedrijf, string email)
    {
        using (var conn = new NpgsqlConnection(_connectionString))
        {
            await conn.OpenAsync();
            string query = "INSERT INTO klanten (naam, bedrijf, email) VALUES (@naam, @bedrijf, @email)";

            using (var cmd = new NpgsqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@naam", naam);
                cmd.Parameters.AddWithValue("@bedrijf", string.IsNullOrWhiteSpace(bedrijf) ? DBNull.Value : bedrijf);
                cmd.Parameters.AddWithValue("@email", string.IsNullOrWhiteSpace(email) ? DBNull.Value : email);

                await cmd.ExecuteNonQueryAsync();
            }
        }
    }
    public async Task<DataTable> GetAbonnementenAsync()
    {
        var dt = new DataTable();
        using (var conn = new NpgsqlConnection(_connectionString))
        {
            await conn.OpenAsync();
            // JOIN om de naam van de klant op te halen in plaats van alleen het ID
            string query = @"
            SELECT a.id, k.naam AS Klant, a.dienst, a.prijs, a.frequentie, a.startdatum 
            FROM abonnementen a
            JOIN klanten k ON a.klant_id = k.id
            ORDER BY a.startdatum DESC";

            using (var cmd = new NpgsqlCommand(query, conn))
            using (var reader = await cmd.ExecuteReaderAsync())
            {
                dt.Load(reader);
            }
        }
        return dt;
    }

    public async Task VoegAbonnementToeAsync(int klantId, string dienst, decimal prijs, string frequentie)
    {
        using (var conn = new NpgsqlConnection(_connectionString))
        {
            await conn.OpenAsync();
            string query = "INSERT INTO abonnementen (klant_id, dienst, prijs, frequentie) VALUES (@klantId, @dienst, @prijs, @frequentie)";

            using (var cmd = new NpgsqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@klantId", klantId);
                cmd.Parameters.AddWithValue("@dienst", dienst);
                cmd.Parameters.AddWithValue("@prijs", prijs);
                cmd.Parameters.AddWithValue("@frequentie", frequentie);
                await cmd.ExecuteNonQueryAsync();
            }
        }
    }

    public async Task<DataTable> GetTransactiesAsync()
    {
        var dt = new DataTable();
        using (var conn = new NpgsqlConnection(_connectionString))
        {
            await conn.OpenAsync();
            string query = "SELECT id, type, bedrag, beschrijving, datum FROM transacties ORDER BY datum DESC";
            using (var cmd = new NpgsqlCommand(query, conn))
            using (var reader = await cmd.ExecuteReaderAsync())
            {
                dt.Load(reader);
            }
        }
        return dt;
    }

    public async Task VoegTransactieToeAsync(string type, decimal bedrag, string beschrijving)
    {
        using (var conn = new NpgsqlConnection(_connectionString))
        {
            await conn.OpenAsync();
            string query = "INSERT INTO transacties (type, bedrag, beschrijving) VALUES (@type, @bedrag, @beschrijving)";
            using (var cmd = new NpgsqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@bedrag", bedrag);
                cmd.Parameters.AddWithValue("@beschrijving", beschrijving);
                await cmd.ExecuteNonQueryAsync();
            }
        }
    }

    public async Task<(decimal Inkomsten, decimal Uitgaven)> GetFinancieleTotalenAsync()
    {
        decimal inkomsten = 0;
        decimal uitgaven = 0;
        using (var conn = new NpgsqlConnection(_connectionString))
        {
            await conn.OpenAsync();
            string query = @"
            SELECT 
                COALESCE(SUM(CASE WHEN type = 'Inkomst' THEN bedrag ELSE 0 END), 0) AS TotaleInkomsten,
                COALESCE(SUM(CASE WHEN type = 'Uitgave' THEN bedrag ELSE 0 END), 0) AS TotaleUitgaven
            FROM transacties;";

            using (var cmd = new NpgsqlCommand(query, conn))
            using (var reader = await cmd.ExecuteReaderAsync())
            {
                if (await reader.ReadAsync())
                {
                    inkomsten = reader.GetDecimal(0);
                    uitgaven = reader.GetDecimal(1);
                }
            }
        }
        return (inkomsten, uitgaven);
    }


}