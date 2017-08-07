namespace _3000_Reload
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
            this.label1 = new System.Windows.Forms.Label();
            this.textUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textUserId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.ChooseInput = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textInputFile = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPurge = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textStatus = new System.Windows.Forms.TextBox();
            this.btnConectionString = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textInputCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Azure URL";
            // 
            // textUrl
            // 
            this.textUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUrl.Location = new System.Drawing.Point(306, 12);
            this.textUrl.Name = "textUrl";
            this.textUrl.Size = new System.Drawing.Size(253, 26);
            this.textUrl.TabIndex = 1;
            this.textUrl.Text = "EC2AMAZ-P0FQ3QL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(611, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Azure UserID";
            // 
            // textUserId
            // 
            this.textUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUserId.Location = new System.Drawing.Point(723, 12);
            this.textUserId.Name = "textUserId";
            this.textUserId.Size = new System.Drawing.Size(139, 26);
            this.textUserId.TabIndex = 3;
            this.textUserId.Text = "Administrator";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(906, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Azure Password";
            // 
            // textPassword
            // 
            this.textPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.Location = new System.Drawing.Point(1036, 13);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(166, 26);
            this.textPassword.TabIndex = 5;
            this.textPassword.Text = "97GeneralHospital";
            // 
            // ChooseInput
            // 
            this.ChooseInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseInput.Location = new System.Drawing.Point(40, 62);
            this.ChooseInput.Name = "ChooseInput";
            this.ChooseInput.Size = new System.Drawing.Size(80, 35);
            this.ChooseInput.TabIndex = 6;
            this.ChooseInput.Text = "Select";
            this.ChooseInput.UseVisualStyleBackColor = true;
            this.ChooseInput.Click += new System.EventHandler(this.ChooseInput_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(137, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Input File";
            // 
            // textInputFile
            // 
            this.textInputFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInputFile.Location = new System.Drawing.Point(218, 66);
            this.textInputFile.Name = "textInputFile";
            this.textInputFile.Size = new System.Drawing.Size(632, 26);
            this.textInputFile.TabIndex = 8;
            this.textInputFile.Text = "C:\\Users\\Jam\\Downloads\\Chinese Pod\\CENTRAL\\_3000_.csv";
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(126, 114);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(80, 35);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(212, 114);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 35);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPurge
            // 
            this.btnPurge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurge.Location = new System.Drawing.Point(40, 114);
            this.btnPurge.Name = "btnPurge";
            this.btnPurge.Size = new System.Drawing.Size(80, 35);
            this.btnPurge.TabIndex = 11;
            this.btnPurge.Text = "Purge";
            this.btnPurge.UseVisualStyleBackColor = true;
            this.btnPurge.Click += new System.EventHandler(this.btnPurge_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Status";
            // 
            // textStatus
            // 
            this.textStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textStatus.Location = new System.Drawing.Point(94, 172);
            this.textStatus.Name = "textStatus";
            this.textStatus.Size = new System.Drawing.Size(756, 26);
            this.textStatus.TabIndex = 13;
            // 
            // btnConectionString
            // 
            this.btnConectionString.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectionString.Location = new System.Drawing.Point(40, 8);
            this.btnConectionString.Name = "btnConectionString";
            this.btnConectionString.Size = new System.Drawing.Size(145, 35);
            this.btnConectionString.TabIndex = 14;
            this.btnConectionString.Text = "Set Connection";
            this.btnConectionString.UseVisualStyleBackColor = true;
            this.btnConectionString.Click += new System.EventHandler(this.btnConectionString_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(937, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Input Count";
            // 
            // textInputCount
            // 
            this.textInputCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInputCount.Location = new System.Drawing.Point(1036, 66);
            this.textInputCount.Name = "textInputCount";
            this.textInputCount.Size = new System.Drawing.Size(166, 26);
            this.textInputCount.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 579);
            this.Controls.Add(this.textInputCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnConectionString);
            this.Controls.Add(this.textStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPurge);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.textInputFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ChooseInput);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textUserId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textUrl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textUserId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Button ChooseInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textInputFile;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPurge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textStatus;
        private System.Windows.Forms.Button btnConectionString;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textInputCount;
    }
}

