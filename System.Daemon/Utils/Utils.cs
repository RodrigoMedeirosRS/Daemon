namespace System.Daemon.Utils
{
    public static class Utils
    {
        public static int BoolToInt(bool input)
        {
            return input ? 1 : 0;
        }

        public static bool IsPair(int var)
        {
            return var % 2 == 0;
        }
    }
}