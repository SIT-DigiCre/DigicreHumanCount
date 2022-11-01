namespace DigicreHumanCount
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ruikeiCountLabel = new System.Windows.Forms.Label();
            this.currentCountLabel = new System.Windows.Forms.Label();
            this.enterBtn = new System.Windows.Forms.Button();
            this.reEnterBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.switchSerialComboBox = new System.Windows.Forms.ComboBox();
            this.connectBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ledSerialComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ruikeiCountLabel
            // 
            this.ruikeiCountLabel.AutoSize = true;
            this.ruikeiCountLabel.Font = new System.Drawing.Font("Yu Gothic UI", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ruikeiCountLabel.Location = new System.Drawing.Point(61, 72);
            this.ruikeiCountLabel.Name = "ruikeiCountLabel";
            this.ruikeiCountLabel.Size = new System.Drawing.Size(720, 221);
            this.ruikeiCountLabel.TabIndex = 0;
            this.ruikeiCountLabel.Text = "累計:0人";
            // 
            // currentCountLabel
            // 
            this.currentCountLabel.AutoSize = true;
            this.currentCountLabel.Font = new System.Drawing.Font("Yu Gothic UI", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentCountLabel.Location = new System.Drawing.Point(61, 340);
            this.currentCountLabel.Name = "currentCountLabel";
            this.currentCountLabel.Size = new System.Drawing.Size(720, 221);
            this.currentCountLabel.TabIndex = 1;
            this.currentCountLabel.Text = "現在:0人";
            // 
            // enterBtn
            // 
            this.enterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.enterBtn.Location = new System.Drawing.Point(41, 574);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(156, 88);
            this.enterBtn.TabIndex = 2;
            this.enterBtn.Text = "Enter";
            this.enterBtn.UseVisualStyleBackColor = false;
            // 
            // reEnterBtn
            // 
            this.reEnterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.reEnterBtn.Location = new System.Drawing.Point(231, 574);
            this.reEnterBtn.Name = "reEnterBtn";
            this.reEnterBtn.Size = new System.Drawing.Size(156, 88);
            this.reEnterBtn.TabIndex = 3;
            this.reEnterBtn.Text = "Re-Enter";
            this.reEnterBtn.UseVisualStyleBackColor = false;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.exitBtn.Location = new System.Drawing.Point(423, 574);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(156, 88);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            // 
            // switchSerialComboBox
            // 
            this.switchSerialComboBox.FormattingEnabled = true;
            this.switchSerialComboBox.Location = new System.Drawing.Point(100, 8);
            this.switchSerialComboBox.Name = "switchSerialComboBox";
            this.switchSerialComboBox.Size = new System.Drawing.Size(151, 28);
            this.switchSerialComboBox.TabIndex = 5;
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(504, 7);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(94, 29);
            this.connectBtn.TabIndex = 6;
            this.connectBtn.Text = "接続";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "スイッチ通信";
            // 
            // ledSerialComboBox
            // 
            this.ledSerialComboBox.FormattingEnabled = true;
            this.ledSerialComboBox.Location = new System.Drawing.Point(347, 8);
            this.ledSerialComboBox.Name = "ledSerialComboBox";
            this.ledSerialComboBox.Size = new System.Drawing.Size(151, 28);
            this.ledSerialComboBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "LED通信";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 701);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ledSerialComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.switchSerialComboBox);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.reEnterBtn);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.currentCountLabel);
            this.Controls.Add(this.ruikeiCountLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ruikeiCountLabel;
        private Label currentCountLabel;
        private Button enterBtn;
        private Button reEnterBtn;
        private Button exitBtn;
        private ComboBox switchSerialComboBox;
        private Button connectBtn;
        private Label label1;
        private ComboBox ledSerialComboBox;
        private Label label2;
    }
}