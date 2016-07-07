namespace DocuVeri_TestApp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdioBtnHot = new System.Windows.Forms.RadioButton();
            this.RdioBtnCold = new System.Windows.Forms.RadioButton();
            this.TxtBxCommand = new System.Windows.Forms.TextBox();
            this.BtnGetDress = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblStatus = new System.Windows.Forms.Label();
            this.LblStatusText = new System.Windows.Forms.Label();
            this.LblOutput = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdioBtnCold);
            this.groupBox1.Controls.Add(this.RdioBtnHot);
            this.groupBox1.Location = new System.Drawing.Point(24, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temperature Type";
            // 
            // RdioBtnHot
            // 
            this.RdioBtnHot.AutoSize = true;
            this.RdioBtnHot.Location = new System.Drawing.Point(19, 30);
            this.RdioBtnHot.Name = "RdioBtnHot";
            this.RdioBtnHot.Size = new System.Drawing.Size(42, 17);
            this.RdioBtnHot.TabIndex = 0;
            this.RdioBtnHot.TabStop = true;
            this.RdioBtnHot.Text = "Hot";
            this.RdioBtnHot.UseVisualStyleBackColor = true;
            // 
            // RdioBtnCold
            // 
            this.RdioBtnCold.AutoSize = true;
            this.RdioBtnCold.Location = new System.Drawing.Point(88, 30);
            this.RdioBtnCold.Name = "RdioBtnCold";
            this.RdioBtnCold.Size = new System.Drawing.Size(46, 17);
            this.RdioBtnCold.TabIndex = 1;
            this.RdioBtnCold.TabStop = true;
            this.RdioBtnCold.Text = "Cold";
            this.RdioBtnCold.UseVisualStyleBackColor = true;
            // 
            // TxtBxCommand
            // 
            this.TxtBxCommand.Location = new System.Drawing.Point(24, 104);
            this.TxtBxCommand.Name = "TxtBxCommand";
            this.TxtBxCommand.Size = new System.Drawing.Size(248, 20);
            this.TxtBxCommand.TabIndex = 1;
            // 
            // BtnGetDress
            // 
            this.BtnGetDress.Location = new System.Drawing.Point(24, 147);
            this.BtnGetDress.Name = "BtnGetDress";
            this.BtnGetDress.Size = new System.Drawing.Size(75, 23);
            this.BtnGetDress.TabIndex = 2;
            this.BtnGetDress.Text = "Get Dress";
            this.BtnGetDress.UseVisualStyleBackColor = true;
            this.BtnGetDress.Click += new System.EventHandler(this.BtnGetDress_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Command (Comma Seprated)";
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(24, 195);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(46, 13);
            this.LblStatus.TabIndex = 4;
            this.LblStatus.Text = "Status : ";
            // 
            // LblStatusText
            // 
            this.LblStatusText.AutoSize = true;
            this.LblStatusText.Location = new System.Drawing.Point(77, 195);
            this.LblStatusText.Name = "LblStatusText";
            this.LblStatusText.Size = new System.Drawing.Size(53, 13);
            this.LblStatusText.TabIndex = 5;
            this.LblStatusText.Text = "Unknown";
            // 
            // LblOutput
            // 
            this.LblOutput.AutoSize = true;
            this.LblOutput.Location = new System.Drawing.Point(24, 218);
            this.LblOutput.Name = "LblOutput";
            this.LblOutput.Size = new System.Drawing.Size(0, 13);
            this.LblOutput.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 262);
            this.Controls.Add(this.LblOutput);
            this.Controls.Add(this.LblStatusText);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGetDress);
            this.Controls.Add(this.TxtBxCommand);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Docu Verify Test";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdioBtnCold;
        private System.Windows.Forms.RadioButton RdioBtnHot;
        private System.Windows.Forms.TextBox TxtBxCommand;
        private System.Windows.Forms.Button BtnGetDress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.Label LblStatusText;
        private System.Windows.Forms.Label LblOutput;
    }
}

