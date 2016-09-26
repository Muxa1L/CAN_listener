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
            this.canFreq = new System.Windows.Forms.ComboBox();
            this.canSpeed = new System.Windows.Forms.ComboBox();
            this.ConfShield = new System.Windows.Forms.Button();
            messages = new System.Windows.Forms.ListView();
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DLC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            // canFreq
            // 
            this.canFreq.FormattingEnabled = true;
            this.canFreq.Location = new System.Drawing.Point(347, 10);
            this.canFreq.Name = "canFreq";
            this.canFreq.Size = new System.Drawing.Size(121, 21);
            this.canFreq.TabIndex = 3;
            this.canFreq.SelectedIndexChanged += new System.EventHandler(this.canFreq_SelectedIndexChanged);
            // 
            // canSpeed
            // 
            this.canSpeed.FormattingEnabled = true;
            this.canSpeed.Location = new System.Drawing.Point(474, 10);
            this.canSpeed.Name = "canSpeed";
            this.canSpeed.Size = new System.Drawing.Size(121, 21);
            this.canSpeed.TabIndex = 4;
            this.canSpeed.SelectedIndexChanged += new System.EventHandler(this.canSpeed_SelectedIndexChanged);
            // 
            // ConfShield
            // 
            this.ConfShield.Location = new System.Drawing.Point(601, 10);
            this.ConfShield.Name = "ConfShield";
            this.ConfShield.Size = new System.Drawing.Size(75, 23);
            this.ConfShield.TabIndex = 5;
            this.ConfShield.Text = "ConfShield";
            this.ConfShield.UseVisualStyleBackColor = true;
            this.ConfShield.Click += new System.EventHandler(this.ConfShield_Click);
            // 
            // messages
            // 
            messages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.type,
            this.ID,
            this.DLC,
            this.Data});
            messages.GridLines = true;
            messages.Location = new System.Drawing.Point(12, 39);
            messages.Name = "messages";
            messages.Size = new System.Drawing.Size(664, 287);
            messages.TabIndex = 6;
            messages.UseCompatibleStateImageBehavior = false;
            messages.View = System.Windows.Forms.View.Details;
            // 
            // type
            // 
            this.type.Text = "type";
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // DLC
            // 
            this.DLC.Text = "DLC";
            // 
            // Data
            // 
            this.Data.Text = "Data";
            this.Data.Width = 421;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 705);
            this.Controls.Add(messages);
            this.Controls.Add(this.ConfShield);
            this.Controls.Add(this.canSpeed);
            this.Controls.Add(this.canFreq);
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
        private System.Windows.Forms.ComboBox canFreq;
        private System.Windows.Forms.ComboBox canSpeed;
        private System.Windows.Forms.Button ConfShield;
        private static System.Windows.Forms.ListView messages;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader DLC;
        private System.Windows.Forms.ColumnHeader Data;
    }
}

