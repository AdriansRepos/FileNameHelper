# FileNameHelper

Knihovna pro bezpečné použití libovolného textu (jméno, název) jako součásti názvu souboru nebo složky ve Windows.

## Metoda

### `NazevSouboru.OcistiProNazevSouboru`
Nahradí znaky nepovolené v názvech souborů/složek podtržítkem a mezery taktéž převede na podtržítko.

```csharp
NazevSouboru.OcistiProNazevSouboru("Novák Jan")  // "Novák_Jan"
```

## Použití

```csharp
string slozka = Path.Combine(korenovaSlozka, "Zamestnanci",
    $"{NazevSouboru.OcistiProNazevSouboru(zam.Prijmeni)}_{zam.OsobniCislo}");
```

## Instalace jako NuGet balíček

Tato knihovna je dostupná také jako balíček v **GitHub Packages**. Můžete si ji snadno přidat do svého projektu:

1. Nastavte si jako zdroj balíčků váš GitHub (pokud ho ještě nemáte v NuGet.config).
2. V **Package Manager Console** spusťte příkaz:
   ```powershell
   Install-Package FileNameHelper
   ```
