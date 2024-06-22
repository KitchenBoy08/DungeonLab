using System.Reflection;
using DungeonLab;
using MelonLoader;

[assembly: AssemblyTitle(DungeonLab.Main.Description)]
[assembly: AssemblyDescription(DungeonLab.Main.Description)]
[assembly: AssemblyCompany(DungeonLab.Main.Company)]
[assembly: AssemblyProduct(DungeonLab.Main.Name)]
[assembly: AssemblyCopyright("Developed by " + DungeonLab.Main.Author)]
[assembly: AssemblyTrademark(DungeonLab.Main.Company)]
[assembly: AssemblyVersion(DungeonLab.Main.Version)]
[assembly: AssemblyFileVersion(DungeonLab.Main.Version)]
[assembly: MelonInfo(typeof(DungeonLab.Main), DungeonLab.Main.Name, DungeonLab.Main.Version, DungeonLab.Main.Author, DungeonLab.Main.DownloadLink)]
[assembly: MelonColor(System.ConsoleColor.Gray)]

// Create and Setup a MelonGame Attribute to mark a Melon as Universal or Compatible with specific Games.
// If no MelonGame Attribute is found or any of the Values for any MelonGame Attribute on the Melon is null or empty it will be assumed the Melon is Universal.
// Values for MelonGame Attribute can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame("Stress Level Zero", "BONELAB")]