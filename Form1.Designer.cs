
namespace Timer
{
    partial class SetUp
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
            this.title = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.comboBoxHours = new System.Windows.Forms.ComboBox();
            this.comboBoxMinutes = new System.Windows.Forms.ComboBox();
            this.labelHours = new System.Windows.Forms.Label();
            this.labelMinuts = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(776, 66);
            this.title.TabIndex = 0;
            this.title.Text = "Countdown Timer";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(250, 144);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(293, 20);
            this.textBox.TabIndex = 1;
            // 
            // comboBoxHours
            // 
            this.comboBoxHours.FormattingEnabled = true;
            this.comboBoxHours.Location = new System.Drawing.Point(236, 270);
            this.comboBoxHours.Name = "comboBoxHours";
            this.comboBoxHours.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHours.TabIndex = 2;
            // 
            // comboBoxMinutes
            // 
            this.comboBoxMinutes.FormattingEnabled = true;
            this.comboBoxMinutes.Location = new System.Drawing.Point(504, 270);
            this.comboBoxMinutes.Name = "comboBoxMinutes";
            this.comboBoxMinutes.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMinutes.TabIndex = 3;
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.labelHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHours.Location = new System.Drawing.Point(168, 271);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(62, 20);
            this.labelHours.TabIndex = 4;
            this.labelHours.Text = "Hours:";
            // 
            // labelMinuts
            // 
            this.labelMinuts.AutoSize = true;
            this.labelMinuts.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.labelMinuts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinuts.Location = new System.Drawing.Point(421, 271);
            this.labelMinuts.Name = "labelMinuts";
            this.labelMinuts.Size = new System.Drawing.Size(77, 20);
            this.labelMinuts.TabIndex = 5;
            this.labelMinuts.Text = "Minutes:";
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(334, 332);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(132, 60);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.labelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestion.Location = new System.Drawing.Point(35, 144);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(178, 20);
            this.labelQuestion.TabIndex = 7;
            this.labelQuestion.Text = "What are you timing?";
            // 
            // SetUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelMinuts);
            this.Controls.Add(this.labelHours);
            this.Controls.Add(this.comboBoxMinutes);
            this.Controls.Add(this.comboBoxHours);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SetUp";
            this.Text = "Countdown Timer Set Up";
            this.Load += new System.EventHandler(this.SetUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ComboBox comboBoxHours;
        private System.Windows.Forms.ComboBox comboBoxMinutes;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Label labelMinuts;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelQuestion;
    }
}

