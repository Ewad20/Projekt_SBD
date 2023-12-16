namespace ZwierzePlus.Model
{
    public static class ZwierzeProviderSingleton
    {
        private static long ZwierzeId = -1;

        public static long GetZwierze()
        {
            return ZwierzeId;
        }

        public static void SetZwierze(long zwierzeId)
        {
            ZwierzeId = zwierzeId;
        }
    }
}
