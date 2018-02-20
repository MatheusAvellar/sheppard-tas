using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace SheppardTAS
{
    public partial class sheppardtas : Form {

        private KeyHandler f7handler;
        private List<Point> points;
        private bool running = false;
        private long counter = 0;

        public sheppardtas() {
            InitializeComponent();
            f7handler = new KeyHandler(Keys.F7, this);
            f7handler.Register();

            points = new List<Point>();
        }

        private void HandleHotkey() {
            if(!running) {
                points.Add(Cursor.Position);
                listbox.Items.Add(Cursor.Position, default_check_state.Checked);
                total_moves.Text = "Total: " + points.Count;
            }
        }

        private void reset_Click(object sender, EventArgs e) {
            points = new List<Point>();
            listbox.Items.Clear();
        }

        private void run_Click(object sender, EventArgs e) {
            execute();
        }

        private void execute() {
            reset_btn.Enabled = false;
            run_btn.Enabled = false;
            delaytext.Enabled = false;
      
            delaytext.Text = Regex.Replace(delaytext.Text, @"[^0-9]", "");
            if(delaytext.Text.Length <= 0) delaytext.Text = "0";
            
            int delay = 0;
            try {
                delay = int.Parse(delaytext.Text);
                delaytext.Text = delay.ToString();
                delaytext.ForeColor = Color.Black;
                delaytext.BackColor = Color.White;
            } catch(FormatException e) {
                delaytext.ForeColor = Color.Red;
                delaytext.BackColor = Color.LightGray;
            }
            Console.WriteLine("|" + delay + "|");
            for(int i = 0; i < points.Count; i++) {
                if(delay > 0) Thread.Sleep(delay);
                Cursor.Position = new Point(points[i].X, points[i].Y);
                if(listbox.GetItemChecked(i)) {
                    SimulateClick(points[i].X, points[i].Y);
                    counter++;
                }
            }
            clickcounter.Text = "Clicked " + counter + " times";

            Thread.Sleep(500);
            reset_btn.Enabled = true;
            run_btn.Enabled = true;
            delaytext.Enabled = true;
        }
        
        private void delaytext_TextChanged(object sender, EventArgs e) {
            delaytext.Text = Regex.Replace(delaytext.Text, @"[^0-9]", "");
        }


        [StructLayout(LayoutKind.Sequential)]
        public struct POINT {
            public int X;
            public int Y;

            public static implicit operator Point(POINT point) {
                return new Point(point.X, point.Y);
            }
        }

        public static Point GetCursorPosition() {
            POINT lpPoint;
            GetCursorPos(out lpPoint);

            return lpPoint;
        }
        protected override void WndProc(ref Message m) {
            if (m.Msg == Constants.WM_HOTKEY_MSG_ID)
                HandleHotkey();
            base.WndProc(ref m);
        }

        public static void SimulateClick(int x, int y) {
            DoClickMouse(0x2); // Left mouse button down
            DoClickMouse(0x4); // Left mouse button up
        }

        static void DoClickMouse(int mouseButton) {
            var input = new INPUT() {
                dwType = 0, // Mouse input
                mi = new MOUSEINPUT() { dwFlags = mouseButton }
            };

            if (SendInput(1, ref input, Marshal.SizeOf(input)) == 0) {
                throw new Exception();
            }
        }
        [StructLayout(LayoutKind.Sequential)]
        struct MOUSEINPUT {
            int dx;
            int dy;
            int mouseData;
            public int dwFlags;
            int time;
            IntPtr dwExtraInfo;
        }
        struct INPUT {
            public uint dwType;
            public MOUSEINPUT mi;
        }
        [DllImport("user32.dll", SetLastError = true)]
        static extern uint SendInput(uint cInputs, ref INPUT input, int size);
        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out POINT lpPoint);
    }
}
