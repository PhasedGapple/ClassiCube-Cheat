using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ClassiCube_Cheat
{

    public partial class Form1 : Form
    {
        bool injected = false;
        IntPtr moduleBase;
        Process process;
        int pid;

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteProcessMemory(
            IntPtr hProcess,
            IntPtr lpBaseAddress,
            byte[] lpBuffer,
            int nSize,
            out IntPtr lpNumberOfBytesWritten
        );

        [DllImport("kernel32.dll")]
        static extern IntPtr OpenProcess(uint access, bool inherit, int pid);

        [DllImport("kernel32.dll")]
        static extern bool CloseHandle(IntPtr handle);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool ReadProcessMemory(
            IntPtr hProcess,
            IntPtr lpBaseAddress,
            byte[] lpBuffer,
            int nSize,
            out IntPtr lpNumberOfBytesRead
        );

        public Form1()
        {
            InitializeComponent();
        }

        public static class offsets
        {
            public static class Player
            {
                public static class Position
                {
                    public static int X = 0x2426B8;
                    public static int Y = 0x2426BC;
                    public static int Z = 0x2426C0;
                }

                public static class Cheats
                {
                    public static class Noclip
                    {
                        public static int Allowed = 0x242720;
                    }

                    public static class Speed
                    {
                        public static int Allowed = 0x24271D;
                    }

                    public static class Fly
                    {
                        public static int Allowed = 0x24271E;
                    }

                    public static class Respawn
                    {
                        public static int Allowed = 0x24271F;
                    }
                }
                public static int Horspeed = 0x242728;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            process = Process.GetProcessesByName("ClassiCube")[0];
            moduleBase = process.MainModule.BaseAddress;
            pid = process.Id;
            injected = true;
        }

        void write4b(int offset, byte[] value)
        {
            IntPtr Handle = OpenProcess(0x0020 | 0x0008 | 0x0010, false, pid);
            WriteProcessMemory(Handle, moduleBase + offset, value, 4, out _);
            CloseHandle(Handle);
        }

        void write1b(int offset, byte value)
        {
            IntPtr Handle = OpenProcess(0x0020 | 0x0008 | 0x0010, false, pid);
            byte[] buffer = { value };
            WriteProcessMemory(Handle, moduleBase + offset, buffer, 1, out _);
            CloseHandle(Handle);
        }

        byte read1b(int offset)
        {
            IntPtr handle = OpenProcess(0x0010 | 0x0400, false, pid);
            byte[] buffer = new byte[1];
            ReadProcessMemory(handle, moduleBase + offset, buffer, 1, out _);
            CloseHandle(handle);
            return buffer[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!injected)
            {
                MessageBox.Show("Please attach first!");
                return;
            }

            float x = float.Parse(textBox1.Text);
            float y = float.Parse(textBox2.Text);
            float z = float.Parse(textBox3.Text);

            write4b(offsets.Player.Position.X, BitConverter.GetBytes(x));
            write4b(offsets.Player.Position.Y, BitConverter.GetBytes(y));
            write4b(offsets.Player.Position.Z, BitConverter.GetBytes(z));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!injected)
            {
                MessageBox.Show("Please attach first!");
                return;
            }

            write1b(offsets.Player.Cheats.Noclip.Allowed, (byte)~read1b(offsets.Player.Cheats.Noclip.Allowed));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!injected)
            {
                MessageBox.Show("Please attach first!");
                return;
            }

            write1b(offsets.Player.Cheats.Fly.Allowed, (byte)~read1b(offsets.Player.Cheats.Fly.Allowed));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!injected)
            {
                MessageBox.Show("Please attach first!");
                return;
            }

            write1b(offsets.Player.Cheats.Speed.Allowed, (byte)~read1b(offsets.Player.Cheats.Speed.Allowed));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!injected)
            {
                MessageBox.Show("Please attach first!");
                return;
            }

            write1b(offsets.Player.Cheats.Respawn.Allowed, (byte)(read1b(offsets.Player.Cheats.Respawn.Allowed) == 0 ? 1 : 0));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!injected)
            {
                MessageBox.Show("Please attach first!");
                return;
            }

            float horspeed = float.Parse(textBox4.Text);
            write4b(offsets.Player.Horspeed, BitConverter.GetBytes(horspeed));
        }
    }
}
