namespace bruhsplit
{
    partial class Bruhsplit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.TimerText = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.QuitStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LivesplitStyleFormattingContext = new System.Windows.Forms.ToolStripMenuItem();
            this.SmallMSTextContext = new System.Windows.Forms.ToolStripMenuItem();
            this.GradientTextContext = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.keybindSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartKeybindTextbox = new System.Windows.Forms.ToolStripTextBox();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PauseKeybindTextbox = new System.Windows.Forms.ToolStripTextBox();
            this.colorSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nothingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PausedColorTextbox = new System.Windows.Forms.ToolStripTextBox();
            this.runningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RunningColorTextbox = new System.Windows.Forms.ToolStripTextBox();
            this.completedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CompletedColorTextbox = new System.Windows.Forms.ToolStripTextBox();
            this.MSTimer = new System.Windows.Forms.Label();
            this.TimerText2 = new System.Windows.Forms.Label();
            this.MSTimer2 = new System.Windows.Forms.Label();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ResetAttemptsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.AttemptsCount = new System.Windows.Forms.Label();
            this.HideAttemptsContext = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimerText
            // 
            this.TimerText.AutoSize = true;
            this.TimerText.BackColor = System.Drawing.Color.Transparent;
            this.TimerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 31F, System.Drawing.FontStyle.Bold);
            this.TimerText.ForeColor = System.Drawing.Color.White;
            this.TimerText.Location = new System.Drawing.Point(12, -3);
            this.TimerText.Name = "TimerText";
            this.TimerText.Size = new System.Drawing.Size(138, 48);
            this.TimerText.TabIndex = 1;
            this.TimerText.Text = "label1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QuitStrip,
            this.optionsToolStripMenuItem,
            this.toolStripSeparator2,
            this.ResetAttemptsButton});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 98);
            // 
            // QuitStrip
            // 
            this.QuitStrip.Name = "QuitStrip";
            this.QuitStrip.Size = new System.Drawing.Size(180, 22);
            this.QuitStrip.Text = "Quit";
            this.QuitStrip.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LivesplitStyleFormattingContext,
            this.SmallMSTextContext,
            this.GradientTextContext,
            this.HideAttemptsContext,
            this.toolStripSeparator1,
            this.keybindSettingsToolStripMenuItem,
            this.colorSettingsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // LivesplitStyleFormattingContext
            // 
            this.LivesplitStyleFormattingContext.Name = "LivesplitStyleFormattingContext";
            this.LivesplitStyleFormattingContext.Size = new System.Drawing.Size(233, 22);
            this.LivesplitStyleFormattingContext.Text = "Livesplit-style time formatting";
            this.LivesplitStyleFormattingContext.Click += new System.EventHandler(this.LivesplitStyleFormattingContext_Click);
            // 
            // SmallMSTextContext
            // 
            this.SmallMSTextContext.Checked = true;
            this.SmallMSTextContext.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SmallMSTextContext.Name = "SmallMSTextContext";
            this.SmallMSTextContext.Size = new System.Drawing.Size(233, 22);
            this.SmallMSTextContext.Text = "Small MS Text";
            this.SmallMSTextContext.Click += new System.EventHandler(this.SmallMSTextContext_Click);
            // 
            // GradientTextContext
            // 
            this.GradientTextContext.Checked = true;
            this.GradientTextContext.CheckState = System.Windows.Forms.CheckState.Checked;
            this.GradientTextContext.Name = "GradientTextContext";
            this.GradientTextContext.Size = new System.Drawing.Size(233, 22);
            this.GradientTextContext.Text = "Gradient Text";
            this.GradientTextContext.Click += new System.EventHandler(this.GradientTextContext_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(230, 6);
            // 
            // keybindSettingsToolStripMenuItem
            // 
            this.keybindSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.StartKeybindTextbox,
            this.pauseToolStripMenuItem,
            this.PauseKeybindTextbox});
            this.keybindSettingsToolStripMenuItem.Name = "keybindSettingsToolStripMenuItem";
            this.keybindSettingsToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.keybindSettingsToolStripMenuItem.Text = "Keybind settings";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.startToolStripMenuItem.Text = "[Start/End]";
            // 
            // StartKeybindTextbox
            // 
            this.StartKeybindTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StartKeybindTextbox.Name = "StartKeybindTextbox";
            this.StartKeybindTextbox.Size = new System.Drawing.Size(100, 23);
            this.StartKeybindTextbox.Text = "F2";
            this.StartKeybindTextbox.LostFocus += new System.EventHandler(this.StartKeybindTextbox_LostFocus);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.pauseToolStripMenuItem.Text = "[Pause]";
            // 
            // PauseKeybindTextbox
            // 
            this.PauseKeybindTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PauseKeybindTextbox.Name = "PauseKeybindTextbox";
            this.PauseKeybindTextbox.Size = new System.Drawing.Size(100, 23);
            this.PauseKeybindTextbox.Text = "F3";
            // 
            // colorSettingsToolStripMenuItem
            // 
            this.colorSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nothingToolStripMenuItem,
            this.PausedColorTextbox,
            this.runningToolStripMenuItem,
            this.RunningColorTextbox,
            this.completedToolStripMenuItem,
            this.CompletedColorTextbox});
            this.colorSettingsToolStripMenuItem.Name = "colorSettingsToolStripMenuItem";
            this.colorSettingsToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.colorSettingsToolStripMenuItem.Text = "Color settings";
            // 
            // nothingToolStripMenuItem
            // 
            this.nothingToolStripMenuItem.Name = "nothingToolStripMenuItem";
            this.nothingToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.nothingToolStripMenuItem.Text = "[Paused/Nothing]";
            // 
            // PausedColorTextbox
            // 
            this.PausedColorTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PausedColorTextbox.Name = "PausedColorTextbox";
            this.PausedColorTextbox.Size = new System.Drawing.Size(100, 23);
            this.PausedColorTextbox.Text = "211, 211, 211";
            this.PausedColorTextbox.LostFocus += new System.EventHandler(this.PausedColorTextbox_LostFocus);
            // 
            // runningToolStripMenuItem
            // 
            this.runningToolStripMenuItem.Name = "runningToolStripMenuItem";
            this.runningToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.runningToolStripMenuItem.Text = "[Running]";
            // 
            // RunningColorTextbox
            // 
            this.RunningColorTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RunningColorTextbox.Name = "RunningColorTextbox";
            this.RunningColorTextbox.Size = new System.Drawing.Size(100, 23);
            this.RunningColorTextbox.Text = "144, 238, 144";
            this.RunningColorTextbox.LostFocus += new System.EventHandler(this.RunningColorTextbox_LostFocus);
            // 
            // completedToolStripMenuItem
            // 
            this.completedToolStripMenuItem.Name = "completedToolStripMenuItem";
            this.completedToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.completedToolStripMenuItem.Text = "[Completed]";
            // 
            // CompletedColorTextbox
            // 
            this.CompletedColorTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CompletedColorTextbox.Name = "CompletedColorTextbox";
            this.CompletedColorTextbox.Size = new System.Drawing.Size(100, 23);
            this.CompletedColorTextbox.Text = "0, 255, 255";
            this.CompletedColorTextbox.LostFocus += new System.EventHandler(this.CompletedColorTextbox_LostFocus);
            // 
            // MSTimer
            // 
            this.MSTimer.AutoSize = true;
            this.MSTimer.BackColor = System.Drawing.Color.Transparent;
            this.MSTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold);
            this.MSTimer.ForeColor = System.Drawing.Color.White;
            this.MSTimer.Location = new System.Drawing.Point(45, 9);
            this.MSTimer.Name = "MSTimer";
            this.MSTimer.Size = new System.Drawing.Size(99, 32);
            this.MSTimer.TabIndex = 2;
            this.MSTimer.Text = "label1";
            // 
            // TimerText2
            // 
            this.TimerText2.AutoSize = true;
            this.TimerText2.BackColor = System.Drawing.Color.Transparent;
            this.TimerText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 31F, System.Drawing.FontStyle.Bold);
            this.TimerText2.ForeColor = System.Drawing.Color.White;
            this.TimerText2.Location = new System.Drawing.Point(137, -5);
            this.TimerText2.Name = "TimerText2";
            this.TimerText2.Size = new System.Drawing.Size(138, 48);
            this.TimerText2.TabIndex = 3;
            this.TimerText2.Text = "label1";
            // 
            // MSTimer2
            // 
            this.MSTimer2.AutoSize = true;
            this.MSTimer2.BackColor = System.Drawing.Color.Transparent;
            this.MSTimer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold);
            this.MSTimer2.ForeColor = System.Drawing.Color.White;
            this.MSTimer2.Location = new System.Drawing.Point(137, 6);
            this.MSTimer2.Name = "MSTimer2";
            this.MSTimer2.Size = new System.Drawing.Size(99, 32);
            this.MSTimer2.TabIndex = 4;
            this.MSTimer2.Text = "label1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // ResetAttemptsButton
            // 
            this.ResetAttemptsButton.Name = "ResetAttemptsButton";
            this.ResetAttemptsButton.Size = new System.Drawing.Size(180, 22);
            this.ResetAttemptsButton.Text = "Reset Attempts";
            this.ResetAttemptsButton.Click += new System.EventHandler(this.ResetAttemptsButton_Click);
            // 
            // AttemptsCount
            // 
            this.AttemptsCount.AutoSize = true;
            this.AttemptsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.AttemptsCount.ForeColor = System.Drawing.Color.White;
            this.AttemptsCount.Location = new System.Drawing.Point(2, 1);
            this.AttemptsCount.Name = "AttemptsCount";
            this.AttemptsCount.Size = new System.Drawing.Size(14, 15);
            this.AttemptsCount.TabIndex = 5;
            this.AttemptsCount.Text = "0";
            // 
            // HideAttemptsContext
            // 
            this.HideAttemptsContext.Name = "HideAttemptsContext";
            this.HideAttemptsContext.Size = new System.Drawing.Size(233, 22);
            this.HideAttemptsContext.Text = "Hide attempts text";
            this.HideAttemptsContext.Click += new System.EventHandler(this.HideAttemptsContext_Click);
            // 
            // Bruhsplit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(250, 50);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.AttemptsCount);
            this.Controls.Add(this.MSTimer2);
            this.Controls.Add(this.TimerText2);
            this.Controls.Add(this.MSTimer);
            this.Controls.Add(this.TimerText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bruhsplit";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TimerText;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem QuitStrip;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LivesplitStyleFormattingContext;
        private System.Windows.Forms.Label MSTimer;
        private System.Windows.Forms.ToolStripMenuItem SmallMSTextContext;
        private System.Windows.Forms.Label TimerText2;
        private System.Windows.Forms.Label MSTimer2;
        private System.Windows.Forms.ToolStripMenuItem GradientTextContext;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem keybindSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox StartKeybindTextbox;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox PauseKeybindTextbox;
        private System.Windows.Forms.ToolStripMenuItem colorSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nothingToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox PausedColorTextbox;
        private System.Windows.Forms.ToolStripMenuItem runningToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox RunningColorTextbox;
        private System.Windows.Forms.ToolStripMenuItem completedToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox CompletedColorTextbox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ResetAttemptsButton;
        private System.Windows.Forms.Label AttemptsCount;
        private System.Windows.Forms.ToolStripMenuItem HideAttemptsContext;
    }
}