﻿using System;
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
using System.IO;

namespace bruhsplit
{
    public partial class Bruhsplit : Form
    {
        private bool dragging = false;
        private Point dragPoint = new Point();
        private string status = "None";
        private double startTime = 0;
        IDictionary<string, bool> options = new Dictionary<string, bool>();
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        private GlobalKeyboardHook _globalKeyboardHook;
        private System.Timers.Timer aTimer;

        private void setUpMovement(Control obj) {
            obj.MouseUp += new MouseEventHandler(Form1_MouseUp);
            obj.MouseDown += new MouseEventHandler(Form1_MouseDown);
            obj.MouseMove += new MouseEventHandler(Form1_MouseMove);
        }
        private async Task saveData() {
            string saveStr = "";
            foreach (var kvp in options) {
                saveStr += kvp.Key + "=" + kvp.Value + ";";
            };
            await Task.Run(() => File.WriteAllText("options.txt", saveStr));
        }
        private async Task loadData() {
            string text = "";
            try {
                await Task.Run(() => { text = File.ReadAllText("options.txt"); });
            } catch (Exception) {
                Console.WriteLine("No data found");
            };
            if (text == "") { return; };
            string[] newData = text.Split(';'); // why does " and ' have a difference in c#
            foreach (var data in newData) {
                var dict = data.Split('=');
                options[dict[0]] = dict[1] == "True";
                foreach (ToolStripMenuItem test in optionsToolStripMenuItem.DropDownItems) {
                    if (test.Name == dict[0] + "Context") {
                        test.Checked = dict[1] == "True";
                        break;
                    };
                };
            };
        }

        public Bruhsplit()
        {
            InitializeComponent();
            setUpMovement(this);
            //setUpMovement(TimerText);
            Console.WriteLine("HELLO");
            TopMost = true;
            TimerText.AutoSize = true;
            TimerText.Text = "im pau";
            TimerText.Size = new Size(Width, Height);
            //KeyPreview = true;

            _globalKeyboardHook = new GlobalKeyboardHook();
            _globalKeyboardHook.KeyboardPressed += OnKeyPressed;

            Load += new EventHandler(Form1_Load);

            options.Add("LivesplitStyleFormatting", false);
            Task.Run(async () => { await loadData(); });
        }
        private string formatTime(float time)
        {
            int min = (int)Math.Floor((time / 60)%60);
            int sec = (int)Math.Floor(time % 60);
            int ms = (int)Math.Floor((time % 1) * 100);
            int hour = (int)Math.Floor(time/(60*60));

            if (options["LivesplitStyleFormatting"] && min == 0 && hour == 0) {
                return String.Format("{0}.{1:D2}", sec, ms);
            }
            if (hour == 0) {
                return String.Format("{0}:{1:D2}.{2:D2}", min, sec, ms);
            } else {
                return String.Format("{0}:{1:D2}:{2:D2}.{3:D2}", hour, min, sec, ms);
            }
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
                    TimerText.Text = formatTime(0);
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

        private void optionHandler(ToolStripMenuItem sender) {
            sender.Checked = !sender.Checked;
            string[] seperate = { "Context" };
            string[] words = sender.Name.Split(seperate, StringSplitOptions.RemoveEmptyEntries);
            options[words[0]] = sender.Checked;
            Task.Run(async () => { await saveData(); });
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e) {
            Environment.Exit(0);
        }

        private void LivesplitStyleFormattingContext_Click(object sender, EventArgs e) {
            optionHandler((ToolStripMenuItem)sender);
        }
    }
}
