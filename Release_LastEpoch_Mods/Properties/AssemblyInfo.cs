using MelonLoader;
using System.Runtime.InteropServices;


[assembly: MelonInfo(typeof(LastEpochMods.Main), "LastEpochMods", "3.2.3", "Ash")]
[assembly: MelonGame("Eleventh Hour Games", "Last Epoch")]
#if NET5_0_OR_GREATER
[assembly: VerifyLoaderVersion(0, 6, 1, true)]
#else
[assembly: VerifyLoaderVersion(0, 5, 7, false)]
#endif

// L'affectation de la valeur false à ComVisible rend les types invisibles dans cet assembly
// aux composants COM. Si vous devez accéder à un type dans cet assembly à partir de
// COM, affectez la valeur true à l'attribut ComVisible sur ce type.
[assembly: ComVisible(false)]