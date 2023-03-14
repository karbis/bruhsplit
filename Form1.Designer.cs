
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
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DebugMsg = new System.Windows.Forms.Label();
            this.TimerText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DebugMsg
            // 
            this.DebugMsg.AutoSize = true;
            this.DebugMsg.ForeColor = System.Drawing.Color.White;
            this.DebugMsg.Location = new System.Drawing.Point(35, 85);
            this.DebugMsg.Name = "DebugMsg";
            this.DebugMsg.Size = new System.Drawing.Size(0, 13);
            this.DebugMsg.TabIndex = 0;
            // 
            // TimerText
            // 
            this.TimerText.AutoSize = true;
            this.TimerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 55F);
            this.TimerText.ForeColor = System.Drawing.Color.White;
            this.TimerText.Location = new System.Drawing.Point(12, 9);
            this.TimerText.Name = "TimerText";
            this.TimerText.Size = new System.Drawing.Size(235, 85);
            this.TimerText.TabIndex = 1;
            this.TimerText.Text = "label1";
            // 
            // Bruhsplit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(400, 100);
            this.Controls.Add(this.TimerText);
            this.Controls.Add(this.DebugMsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bruhsplit";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DebugMsg;
        private System.Windows.Forms.Label TimerText;
    }
}

