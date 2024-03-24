using MelonLoader;
using System.Reflection;
using System.Runtime.InteropServices;


[assembly: MelonInfo(typeof(LastEpochMods.Main), "LastEpochMods", "3.1.9", "Ash")]
[assembly: MelonGame("Eleventh Hour Games", "Last Epoch")]
[assembly: VerifyLoaderVersion(0, 6, 1, true)]
[assembly: MelonOptionalDependencies("System.Resources.Extensions", "System.Drawing.Common")]

// L'affectation de la valeur false à ComVisible rend les types invisibles dans cet assembly
// aux composants COM. Si vous devez accéder à un type dans cet assembly à partir de
// COM, affectez la valeur true à l'attribut ComVisible sur ce type.
[assembly: ComVisible(false)]