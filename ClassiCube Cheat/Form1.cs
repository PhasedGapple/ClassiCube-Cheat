using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ClassiCube_Cheat
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            [DllImport("kernel32.dll", SetLastError = true)]
            static extern bool WriteProcessMemory(
                IntPtr hProcess,
                IntPtr lpBaseAddress,
                byte[] lpBuffer,
                int nSize,
                out IntPtr lpNumberOfBytesWritten
            );
        }
        static class offsets
        {
            static class Player
            {
                static class Position
                {
                    public static int X = 0x30DAC8;
                    public static int Y = 0x30DACC;
                    public static int Z = 0x30DAD0;
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var process = Process.GetProcessesByName("ClassiCube")[0];
            IntPtr moduleBase = process.MainModule.BaseAddress;
            int pid = process.Id;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
