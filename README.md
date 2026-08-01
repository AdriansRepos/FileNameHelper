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