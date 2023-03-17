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
using System.IO;
using System.Drawing.Drawing2D;

namespace bruhsplit
{
    public partial class Bruhsplit : Form
    {
        private bool dragging = false;
        private Point dragPoint = new Point();
        private string status = "None";
        private double startTime = 0;
        private double savedTime = 0;
        IDictionary<string, dynamic> options = new Dictionary<string, dynamic>();
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
        private void textBoxCheck(dynamic loopThrough, dynamic dict) {
            foreach (dynamic test in loopThrough) {
                if (test.Name == dict[0] + "Textbox") {
                    test.Text = dict[1];
                    break;
                };
            };
        }
        private async Task loadData() {
            string text = "";
            try {
                await Task.Run(() => { text = File.ReadAllText("options.txt"); });
            }
            catch (Exception) {
                Console.WriteLine("No data found");
            };
            if (text == "") { return; };
            string[] newData = text.Split(';'); // why does " and ' have a difference in c#
            foreach (var data in newData) {
                var dict = data.Split('=');
                if (dict[1] == "True" || dict[1] == "False") {
                    options[dict[0]] = dict[1] == "True";
                } else {
                    options[dict[0]] = dict[1];
                };
                Invoke((MethodInvoker)delegate {
                    foreach (dynamic test in optionsToolStripMenuItem.DropDownItems) {
                        if (test.Name == dict[0] + "Context") {
                            test.Checked = dict[1] == "True";
                        };
                    };
                    textBoxCheck(keybindSettingsToolStripMenuItem.DropDownItems,dict);
                    textBoxCheck(colorSettingsToolStripMenuItem.DropDownItems,dict);
                });
            };
        }

        public Bruhsplit() {
            InitializeComponent();
            setUpMovement(this);
            //setUpMovement(TimerText);
            TopMost = true;
            TimerText.AutoSize = true;
            TimerText.Text = "im pau";
            TimerText.Size = new Size(Width, Height);
            TimerText.BringToFront();
            MSTimer.BringToFront();
            TimerText2.BringToFront();
            MSTimer2.BringToFront();
            MSTimer.AutoSize = true;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            //MSTimer.BackColor = Color.SaddleBrown;
            //TransparencyKey = Color.SaddleBrown;
            //KeyPreview = true;
            MSTimer.BackColor = Color.Transparent;
            TimerText.BackColor = Color.Transparent;

            _globalKeyboardHook = new GlobalKeyboardHook();
            _globalKeyboardHook.KeyboardPressed += OnKeyPressed;

            Load += new EventHandler(Form1_Load);

            options.Add("LivesplitStyleFormatting", false);
            options.Add("SmallMSText", true);
            options.Add("GradientText", true);
            options.Add("HideAttempts", false);
            options.Add("StartKeybind", "F2");
            options.Add("PauseKeybind", "F3");
            options.Add("RunningColor", "144, 238, 144");
            options.Add("PausedColor", "211, 211, 211");
            options.Add("CompletedColor", "0, 255, 255");
            options.Add("Attempts", "0");
            Task.Run(async () => { await loadData(); });
        }
        private string formatTime(float time) {
            int min = (int)Math.Floor((time / 60) % 60);
            int sec = (int)Math.Floor(time % 60);
            int ms = (int)Math.Floor((time % 1) * 100);
            int hour = (int)Math.Floor(time / (60 * 60));
            var finalStr = "";

            if (hour == 0) {
                finalStr = String.Format("{0}:{1:D2}.{2:D2}", min, sec, ms);
            } else {
                finalStr = String.Format("{0}:{1:D2}:{2:D2}.{3:D2}", hour, min, sec, ms);
            }
            if (options["LivesplitStyleFormatting"] && min == 0 && hour == 0) {
                finalStr = String.Format("{0}.{1:D2}", sec, ms);
            }
            if (options["SmallMSText"]) {
                finalStr = finalStr.Substring(0, finalStr.Length - 3);
            }
            return finalStr;
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button != MouseButtons.Left) { return; }
            // DebugMsg.Text = "down";
            dragging = true;
            dragPoint = e.Location;
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e) {
            if (e.Button != MouseButtons.Left) { return; }
            // DebugMsg.Text = "up";
            dragging = false;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e) {
            if (dragging) {
                MoveWindow(Handle, Cursor.Position.X - dragPoint.X, Cursor.Position.Y - dragPoint.Y, Width, Height, true);
            }
        }

        private double getTime() {
            return (DateTimeOffset.Now.ToUnixTimeMilliseconds() - startTime) / 1000;
        }

        private void OnKeyPressed(object sender, GlobalKeyboardHookEventArgs e) {
            // EDT: No need to filter for VkSnapshot anymore. This now gets handled
            // through the constructor of GlobalKeyboardHook(...).
            if (e.KeyboardState == GlobalKeyboardHook.KeyboardState.KeyDown) {
                // Now you can access both, the key and virtual code
                Keys loggedKey = e.KeyboardData.Key;
                int loggedVkCode = e.KeyboardData.VirtualCode;
                if (loggedKey.ToString().ToLower() == options["StartKeybind"].ToLower()) {
                    if (status == "Running") {
                        status = "Ended";
                        savedTime = getTime();
                    } else if (status == "Ended") {
                        status = "None";
                    } else if (status == "None") {
                        status = "Running";
                        options["Attempts"] = (Int32.Parse(options["Attempts"]) + 1).ToString();
                        startTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
                    }
                } else if (loggedKey.ToString().ToLower() == options["PauseKeybind"].ToLower()) {
                    if (status == "Running") {
                        status = "Paused";
                        savedTime = getTime();
                    } else if (status == "Paused") {
                        status = "Running";
                        startTime = DateTimeOffset.Now.ToUnixTimeMilliseconds() - savedTime * 1000;
                    };
                }
            }
        }

        private string formatTimeMs(float timee) {
            return String.Format(".{0:D2}", (int)Math.Floor((timee % 1) * 100));
        }

        private void makeCapGradientText(Label og, Label cap) {
            if (!options["GradientText"]) {
                cap.Size = new Size(0, 0);
                return;
            }
            cap.Location = new Point(og.Location.X, og.Location.Y);
            cap.AutoSize = false;
            cap.Size = new Size(og.Size.Width, og.Size.Height / 2);
            cap.Text = og.Text;
            var oldColor = og.ForeColor;
            og.ForeColor = ControlPaint.Dark(oldColor, (float)-.2);
            cap.ForeColor = oldColor;
        }
        
        private Color stringToColor(string color) {
            var split = color.Split(',');
            var r = 255;
            var g = 255;
            var b = 255;
            try {
                r = Int32.Parse(split[0]);
                g = Int32.Parse(split[1]);
                b = Int32.Parse(split[2]);
            } catch { };

            return Color.FromArgb(r, g, b);
        }

        private void UpdateFrame(object sender, ElapsedEventArgs e) {
            Invoke(new Action(() => {
                if (status == "None") {
                    TimerText.Text = formatTime(0);
                    MSTimer.Text = formatTimeMs(0);
                    TimerText.ForeColor = stringToColor(options["PausedColor"]);
                } else if (status == "Running") {
                    var curTime = (float)getTime();
                    TimerText.Text = formatTime(curTime);
                    MSTimer.Text = formatTimeMs(curTime);
                    TimerText.ForeColor = stringToColor(options["RunningColor"]);
                } else if (status == "Ended") {
                    TimerText.Text = formatTime((float)savedTime);
                    MSTimer.Text = formatTimeMs((float)savedTime);
                    TimerText.ForeColor = stringToColor(options["CompletedColor"]);
                } else if (status == "Paused") {
                    TimerText.ForeColor = stringToColor(options["PausedColor"]);
                    TimerText.Text = formatTime((float)savedTime);
                    MSTimer.Text = formatTimeMs((float)savedTime);
                }
                var MSTimerWidth = MSTimer.Width;
                if (!options["SmallMSText"]) {
                    MSTimerWidth = 5;
                    MSTimer.Text = "";
                }
                MSTimer.ForeColor = TimerText.ForeColor;
                MSTimer.Location = new Point(Width - MSTimerWidth - 5, (50 - 48) / 2 + 14);
                TimerText.Location = new Point(Width - TimerText.Width - MSTimerWidth + 8, (50 - 48) / 2);
                makeCapGradientText(TimerText, TimerText2);
                makeCapGradientText(MSTimer, MSTimer2);
                AttemptsCount.Text = options["Attempts"];
                AttemptsCount.Visible = !options["HideAttempts"];
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
        private void optionHandlerText(ToolStripTextBox sender) {
            string[] seperate = { "Textbox" };
            string[] words = sender.Name.Split(seperate, StringSplitOptions.RemoveEmptyEntries);
            options[words[0]] = sender.Text;
            Task.Run(async () => { await saveData(); });
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e) {
            Environment.Exit(0);
        }

        private void LivesplitStyleFormattingContext_Click(object sender, EventArgs e) { optionHandler((ToolStripMenuItem)sender); }
        private void SmallMSTextContext_Click(object sender, EventArgs e) { optionHandler((ToolStripMenuItem)sender); }
        private void GradientTextContext_Click(object sender, EventArgs e) { optionHandler((ToolStripMenuItem)sender); }
        private void StartKeybindTextbox_LostFocus(object sender, EventArgs e) { optionHandlerText((ToolStripTextBox)sender); }
        private void PausedColorTextbox_LostFocus(object sender, EventArgs e) { optionHandlerText((ToolStripTextBox)sender); }
        private void RunningColorTextbox_LostFocus(object sender, EventArgs e) { optionHandlerText((ToolStripTextBox)sender); }
        private void CompletedColorTextbox_LostFocus(object sender, EventArgs e) { optionHandlerText((ToolStripTextBox)sender); }

        private void ResetAttemptsButton_Click(object sender, EventArgs e) {
            options["Attempts"] = "0";
            Task.Run(async () => { await saveData(); });
        }

        private void HideAttemptsContext_Click(object sender, EventArgs e) { optionHandler((ToolStripMenuItem)sender); }
    }
};