using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Timers;


namespace bruhsplit
{
    public partial class Bruhsplit : Form
    {
        private bool dragging = false;
        private Point dragPoint = new Point();
        private string status = "None";
        private double startTime = 0;
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        private GlobalKeyboardHook _globalKeyboardHook;
        private System.Timers.Timer aTimer;

        private void setUpMovement(Control obj) {
            obj.MouseUp += new MouseEventHandler(Form1_MouseUp);
            obj.MouseDown += new MouseEventHandler(Form1_MouseDown);
            obj.MouseMove += new MouseEventHandler(Form1_MouseMove);
        }

        public Bruhsplit()
        {
            InitializeComponent();
            setUpMovement(this);
            //setUpMovement(TimerText);
            TopMost = true;
            TimerText.AutoSize = true;
            TimerText.Text = "im pau";
            TimerText.Size = new Size(Width, Height);
            //KeyPreview = true;

            _globalKeyboardHook = new GlobalKeyboardHook();
            _globalKeyboardHook.KeyboardPressed += OnKeyPressed;

            Load += new EventHandler(Form1_Load);
        }
        private string formatTime(float time)
        {
            int min = (int)Math.Floor(time / 60);
            int sec = (int)Math.Floor(time % 60);
            int ms = (int)Math.Floor((time % 1) * 100);
            return String.Format("{0}:{1:D2}.{2:D2}", min,sec,ms);
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) { return; }
            // DebugMsg.Text = "down";
            dragging = true;
            dragPoint = e.Location;
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) { return; }
            // DebugMsg.Text = "up";
            dragging = false;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging) {
                MoveWindow(Handle, Cursor.Position.X-dragPoint.X, Cursor.Position.Y - dragPoint.Y, Width,Height,true);
            }
        }

        private void OnKeyPressed(object sender, GlobalKeyboardHookEventArgs e)
        {
            // EDT: No need to filter for VkSnapshot anymore. This now gets handled
            // through the constructor of GlobalKeyboardHook(...).
            if (e.KeyboardState == GlobalKeyboardHook.KeyboardState.KeyDown)
            {
                // Now you can access both, the key and virtual code
                Keys loggedKey = e.KeyboardData.Key;
                int loggedVkCode = e.KeyboardData.VirtualCode;
                if (loggedKey.ToString() == "F1") {
                    if (status == "Running") {
                        status = "Paused";
                    } else if (status == "Paused") {
                        status = "None";
                    } else if (status == "None") {
                        status = "Running";
                        startTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
                    }
                }
            }
        }

        private void UpdateFrame(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() => {
                TimerText.Location = new Point(Width - TimerText.Width-5, (100-85)/2);
                if (status == "None") {
                    TimerText.Text = "0:00.00";
                    TimerText.ForeColor = Color.LightGray;
                } else if (status == "Running") {
                    TimerText.Text = formatTime((float)(DateTimeOffset.Now.ToUnixTimeMilliseconds()-startTime)/1000);
                    TimerText.ForeColor = Color.Green;
                } else if (status == "Paused") {
                    TimerText.ForeColor = Color.Cyan;
                }
            }));
        }
        private void Form1_Load(object sender, EventArgs e) {
            aTimer = new System.Timers.Timer(1000 / 60);
            aTimer.Elapsed += UpdateFrame;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }
    }
}
