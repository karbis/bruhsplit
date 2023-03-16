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
            this.MSTimer = new System.Windows.Forms.Label();
            this.TimerText2 = new System.Windows.Forms.Label();
            this.MSTimer2 = new System.Windows.Forms.Label();
            this.GradientTextContext = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimerText
            // 
            this.TimerText.AutoSize = true;
            this.TimerText.BackColor = System.Drawing.Color.Transparent;
            this.TimerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.TimerText.ForeColor = System.Drawing.Color.White;
            this.TimerText.Location = new System.Drawing.Point(115, -10);
            this.TimerText.Name = "TimerText";
            this.TimerText.Size = new System.Drawing.Size(126, 46);
            this.TimerText.TabIndex = 1;
            this.TimerText.Text = "label1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QuitStrip,
            this.optionsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
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
            this.GradientTextContext});
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
            // MSTimer
            // 
            this.MSTimer.AutoSize = true;
            this.MSTimer.BackColor = System.Drawing.Color.Transparent;
            this.MSTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.MSTimer.ForeColor = System.Drawing.Color.White;
            this.MSTimer.Location = new System.Drawing.Point(45, 9);
            this.MSTimer.Name = "MSTimer";
            this.MSTimer.Size = new System.Drawing.Size(86, 31);
            this.MSTimer.TabIndex = 2;
            this.MSTimer.Text = "label1";
            // 
            // TimerText2
            // 
            this.TimerText2.AutoSize = true;
            this.TimerText2.BackColor = System.Drawing.Color.Transparent;
            this.TimerText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.TimerText2.ForeColor = System.Drawing.Color.White;
            this.TimerText2.Location = new System.Drawing.Point(62, 2);
            this.TimerText2.Name = "TimerText2";
            this.TimerText2.Size = new System.Drawing.Size(126, 46);
            this.TimerText2.TabIndex = 3;
            this.TimerText2.Text = "label1";
            // 
            // MSTimer2
            // 
            this.MSTimer2.AutoSize = true;
            this.MSTimer2.BackColor = System.Drawing.Color.Transparent;
            this.MSTimer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.MSTimer2.ForeColor = System.Drawing.Color.White;
            this.MSTimer2.Location = new System.Drawing.Point(82, 10);
            this.MSTimer2.Name = "MSTimer2";
            this.MSTimer2.Size = new System.Drawing.Size(86, 31);
            this.MSTimer2.TabIndex = 4;
            this.MSTimer2.Text = "label1";
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
            // Bruhsplit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(250, 50);
            this.ContextMenuStrip = this.contextMenuStrip1;
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
    }
}