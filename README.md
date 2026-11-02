# Portify 🚀

Portify is een C# WinForms desktopapplicatie, ontwikkeld voor student-zelfstandigen en freelancers om klanten, hostingdiensten, abonnementen en de financiële administratie overzichtelijk en veilig te beheren.

## 📋 Functionaliteiten

* **Klantenbeheer:** 
  * Klanten toevoegen met naam, bedrijf, e-mail en BTW-nummer.
  * Live zoekfunctie en slimme autocomplete-dropdown die zoekt op naam, bedrijf en BTW-nummer.
* **Diensten & Abonnementen:** 
  * Diensten (zoals webhosting, onderhoud of DJ-boekingen) koppelen aan specifieke klanten.
  * Flexibele frequenties instellen (Maandelijks, Jaarlijks, Eenmalig) met prijzen via een `NumericUpDown`.
* **Financiële Administratie:** 
  * Inkomsten en uitgaven bijhouden met beschrijvingen en datums.
  * Realtime berekening en weergave van de totale inkomsten en uitgaven via de database.

## 🛠️ Tech Stack & Infrastructuur

* **Frontend:** C# .NET (Windows Forms)
* **Database:** PostgreSQL (gehost op een eigen TrueNAS server)
* **Connectiviteit:** Veilige verbinding via een **Tailscale** mesh-netwerk (`100.x.x.x` IP-adressen)
* **Database Driver:** `Npgsql`

## 🔒 Beveiliging & Configuratie

Om gevoelige gegevens veilig te houden, maakt Portify gebruik van een lokaal configuratiebestand (`config.json`) dat buiten de publieke repository wordt gehouden via `.gitignore`.

### `config.json` voorbeeld:
Maak in de hoofdmap van je project een `config.json` bestand aan met de volgende structuur:

```json
{
  "ConnectionString": "Host=100.x.x.x;Database=jouw_database;Username=jouw_gebruiker;Password=jouw_wachtwoord"
}
