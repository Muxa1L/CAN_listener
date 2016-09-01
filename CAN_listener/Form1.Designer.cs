namespace CAN_listener
{
    partial class Form1
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
            this.portSelector = new System.Windows.Forms.ComboBox();
            this.openPortBtn = new System.Windows.Forms.Button();
            this.baudRate = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // portSelector
            // 
            this.portSelector.FormattingEnabled = true;
            this.portSelector.Location = new System.Drawing.Point(12, 12);
            this.portSelector.Name = "portSelector";
            this.portSelector.Size = new System.Drawing.Size(121, 21);
            this.portSelector.TabIndex = 0;
            // 
            // openPortBtn
            // 
            this.openPortBtn.Location = new System.Drawing.Point(266, 10);
            this.openPortBtn.Name = "openPortBtn";
            this.openPortBtn.Size = new System.Drawing.Size(75, 23);
            this.openPortBtn.TabIndex = 1;
            this.openPortBtn.Text = "Open";
            this.openPortBtn.UseVisualStyleBackColor = true;
            this.openPortBtn.Click += new System.EventHandler(this.openPortBtn_Click);
            // 
            // baudRate
            // 
            this.baudRate.FormattingEnabled = true;
            this.baudRate.Location = new System.Drawing.Point(139, 12);
            this.baudRate.Name = "baudRate";
            this.baudRate.Size = new System.Drawing.Size(121, 21);
            this.baudRate.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 705);
            this.Controls.Add(this.baudRate);
            this.Controls.Add(this.openPortBtn);
            this.Controls.Add(this.portSelector);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox portSelector;
        private System.Windows.Forms.Button openPortBtn;
        private System.Windows.Forms.ComboBox baudRate;
    }
}

