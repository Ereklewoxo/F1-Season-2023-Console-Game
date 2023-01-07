using System.Runtime.InteropServices;

namespace CustomColor
{
    public static class CustomColor
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetConsoleMode(IntPtr hConsoleHandle, int mode);
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool GetConsoleMode(IntPtr handle, out int mode);
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetStdHandle(int handle);
        public static void Color()
        {
            var handle = GetStdHandle(-11);
            GetConsoleMode(handle, out int mode);
            SetConsoleMode(handle, mode | 0x4);
        }
    }
}