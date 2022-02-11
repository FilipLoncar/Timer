
namespace Timer
{
    partial class Countdown
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
            this.components = new System.ComponentModel.Container();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelRemainTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.flash = new System.Windows.Forms.Timer(this.components);
            this.blink = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(658, 384);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(130, 54);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelTime
            // 
            this.labelTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.Black;
            this.labelTime.Location = new System.Drawing.Point(181, 157);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(98, 108);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "0";
            // 
            // labelRemainTime
            // 
            this.labelRemainTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelRemainTime.AutoSize = true;
            this.labelRemainTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRemainTime.Location = new System.Drawing.Point(189, 28);
            this.labelRemainTime.Name = "labelRemainTime";
            this.labelRemainTime.Size = new System.Drawing.Size(416, 55);
            this.labelRemainTime.TabIndex = 2;
            this.labelRemainTime.Text = "minutes remaining";
            // 
            // timer
            // 
            this.timer.Interval = 60000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // flash
            // 
            this.flash.Enabled = true;
            this.flash.Interval = 1000;
            this.flash.Tick += new System.EventHandler(this.flash_Tick);
            // 
            // blink
            // 
            this.blink.Enabled = true;
            this.blink.Interval = 1000;
            this.blink.Tick += new System.EventHandler(this.blink_Tick);
            // 
            // Countdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelRemainTime);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonClose);
            this.Name = "Countdown";
            this.Text = "Countdown";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelRemainTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer flash;
        private System.Windows.Forms.Timer blink;
    }
}