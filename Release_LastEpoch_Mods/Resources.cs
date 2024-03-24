namespace LastEpochMods
{
    using System.IO;

    internal class Resources
    {
        internal static byte[] Armor
        {
            get
            {
                using var stream = typeof(Resources).Assembly.GetManifestResourceStream($"{typeof(Resources).Namespace}.Resources.Armor.png")!;
                return GetByteArray(stream);
            }
        }
        internal static byte[] Boots
        {
            get
            {
                using var stream = typeof(Resources).Assembly.GetManifestResourceStream($"{typeof(Resources).Namespace}.Resources.Boots.png")!;
                return GetByteArray(stream);
            }
        }
        internal static byte[] Gloves
        {
            get
            {
                using var stream = typeof(Resources).Assembly.GetManifestResourceStream($"{typeof(Resources).Namespace}.Resources.Gloves.png")!;
                return GetByteArray(stream);
            }
        }
        internal static byte[] Headhunter
        {
            get
            {
                using var stream = typeof(Resources).Assembly.GetManifestResourceStream($"{typeof(Resources).Namespace}.Resources.Headhunter.png")!;
                return GetByteArray(stream);
            }
        }
        internal static byte[] HeadHunter_Buffs
        {
            get
            {
                using var stream = typeof(Resources).Assembly.GetManifestResourceStream($"{typeof(Resources).Namespace}.Resources.HeadHunter_Buffs.json")!;
                return GetByteArray(stream);
            }
        }
        internal static byte[] Helmet
        {
            get
            {
                using var stream = typeof(Resources).Assembly.GetManifestResourceStream($"{typeof(Resources).Namespace}.Resources.Helmet.png")!;
                return GetByteArray(stream);
            }
        }
        internal static byte[] PauseMenu_Bottom
        {
            get
            {
                using var stream = typeof(Resources).Assembly.GetManifestResourceStream($"{typeof(Resources).Namespace}.Resources.PauseMenu_Bottom.png")!;
                return GetByteArray(stream);
            }
        }
        internal static byte[] PauseMenu_Menu
        {
            get
            {
                using var stream = typeof(Resources).Assembly.GetManifestResourceStream($"{typeof(Resources).Namespace}.Resources.PauseMenu_Menu.png")!;
                return GetByteArray(stream);
            }
        }
        internal static byte[] Shield
        {
            get
            {
                using var stream = typeof(Resources).Assembly.GetManifestResourceStream($"{typeof(Resources).Namespace}.Resources.Shield.png")!;
                return GetByteArray(stream);
            }
        }
        internal static byte[] STAR_UNIQUE
        {
            get
            {
                using var stream = typeof(Resources).Assembly.GetManifestResourceStream($"{typeof(Resources).Namespace}.Resources.STAR_UNIQUE.png")!;
                return GetByteArray(stream);
            }
        }
        internal static byte[] Weapon
        {
            get
            {
                using var stream = typeof(Resources).Assembly.GetManifestResourceStream($"{typeof(Resources).Namespace}.Resources.Weapon.png")!;
                return GetByteArray(stream);
            }
        }

        private static byte[] GetByteArray(Stream stream)
        {
            if (stream is MemoryStream memStream)
            {
                return memStream.ToArray();
            }

            using (MemoryStream memoryStream = new MemoryStream())
            {
                stream.CopyTo(memoryStream);
                return memoryStream.ToArray();
            }
        }
    }
}
