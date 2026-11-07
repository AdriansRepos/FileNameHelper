## 🌐 Jazyk / Language Selection

*Klikněte na sekci níže pro zobrazení v češtině nebo angličtině.*
*Click on a section below to toggle between Czech and English.*

---

<details open>
<summary>🇨🇿 <strong>ČEŠTINA (Czech Version)</strong></summary>

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

</details>

---

<details>
<summary>🇺🇸 <strong>ENGLISH (English Version)</strong></summary>

# FileNameHelper

A library for safely using any text (name, title) as part of a file or folder name in Windows.

## Method

### `NazevSouboru.OcistiProNazevSouboru`
Replaces characters not allowed in file/folder names with underscores and also converts spaces to underscores.

```csharp
NazevSouboru.OcistiProNazevSouboru("Novák Jan")  // "Novák_Jan"
```

## Usage

```csharp
string slozka = Path.Combine(korenovaSlozka, "Zamestnanci",
    $"{NazevSouboru.OcistiProNazevSouboru(zam.Prijmeni)}_{zam.OsobniCislo}");
```

## Installation as a NuGet Package

This library is also available as a package in GitHub Packages. You can easily add it to your project:

1. Set up your GitHub as a package source (if you don't have it in NuGet.config yet).
2. In the Package Manager Console, run the command:
```powershell
Install-Package FileNameHelper
```