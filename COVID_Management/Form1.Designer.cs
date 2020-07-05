namespace COVID_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.managerNameLabel = new System.Windows.Forms.Label();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.covidNewsLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.yesCovidPosButton = new System.Windows.Forms.Button();
            this.didYouTestPosForCovidLabel = new System.Windows.Forms.Label();
            this.quarantineScheduleButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.toDoLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.goodMorningLabel = new System.Windows.Forms.Label();
            this.covidManagerLabel = new System.Windows.Forms.Label();
            this.companyLogoPicture = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyLogoPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Controls.Add(this.managerNameLabel);
            this.groupBox3.Controls.Add(this.companyLogoPicture);
            this.groupBox3.Controls.Add(this.companyNameLabel);
            this.groupBox3.Location = new System.Drawing.Point(792, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(119, 162);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            // 
            // managerNameLabel
            // 
            this.managerNameLabel.AutoSize = true;
            this.managerNameLabel.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.managerNameLabel.Location = new System.Drawing.Point(8, 116);
            this.managerNameLabel.Name = "managerNameLabel";
            this.managerNameLabel.Size = new System.Drawing.Size(87, 38);
            this.managerNameLabel.TabIndex = 10;
            this.managerNameLabel.Text = "Manager \r\nJane Doe";
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyNameLabel.Location = new System.Drawing.Point(6, 14);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(103, 19);
            this.companyNameLabel.TabIndex = 8;
            this.companyNameLabel.Text = "CANHacks";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.covidNewsLabel);
            this.groupBox2.Location = new System.Drawing.Point(12, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 285);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // covidNewsLabel
            // 
            this.covidNewsLabel.AutoSize = true;
            this.covidNewsLabel.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.covidNewsLabel.Location = new System.Drawing.Point(22, 24);
            this.covidNewsLabel.Name = "covidNewsLabel";
            this.covidNewsLabel.Size = new System.Drawing.Size(461, 228);
            this.covidNewsLabel.TabIndex = 3;
            this.covidNewsLabel.Text = resources.GetString("covidNewsLabel.Text");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.didYouTestPosForCovidLabel);
            this.groupBox1.Controls.Add(this.yesCovidPosButton);
            this.groupBox1.Controls.Add(this.quarantineScheduleButton);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.toDoLabel);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(516, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 285);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // yesCovidPosButton
            // 
            this.yesCovidPosButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.yesCovidPosButton.Location = new System.Drawing.Point(18, 182);
            this.yesCovidPosButton.Name = "yesCovidPosButton";
            this.yesCovidPosButton.Size = new System.Drawing.Size(186, 35);
            this.yesCovidPosButton.TabIndex = 10;
            this.yesCovidPosButton.Text = "If yes, click here";
            this.yesCovidPosButton.UseVisualStyleBackColor = false;
            this.yesCovidPosButton.Click += new System.EventHandler(this.yesCovidPosButton_Click);
            // 
            // didYouTestPosForCovidLabel
            // 
            this.didYouTestPosForCovidLabel.AutoSize = true;
            this.didYouTestPosForCovidLabel.Location = new System.Drawing.Point(14, 130);
            this.didYouTestPosForCovidLabel.Name = "didYouTestPosForCovidLabel";
            this.didYouTestPosForCovidLabel.Size = new System.Drawing.Size(367, 38);
            this.didYouTestPosForCovidLabel.TabIndex = 9;
            this.didYouTestPosForCovidLabel.Text = "Have you done the COVID-19 test within 5 \r\ndays of today?";
            // 
            // quarantineScheduleButton
            // 
            this.quarantineScheduleButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.quarantineScheduleButton.Location = new System.Drawing.Point(18, 223);
            this.quarantineScheduleButton.Name = "quarantineScheduleButton";
            this.quarantineScheduleButton.Size = new System.Drawing.Size(318, 36);
            this.quarantineScheduleButton.TabIndex = 8;
            this.quarantineScheduleButton.Text = "View my Quarantine Schedule";
            this.quarantineScheduleButton.UseVisualStyleBackColor = false;
            this.quarantineScheduleButton.Click += new System.EventHandler(this.quarantineScheduleButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(18, 57);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(332, 42);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Complete daily COVID work-fitness \r\nquestionnaire";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // toDoLabel
            // 
            this.toDoLabel.AutoSize = true;
            this.toDoLabel.Location = new System.Drawing.Point(14, 24);
            this.toDoLabel.Name = "toDoLabel";
            this.toDoLabel.Size = new System.Drawing.Size(108, 19);
            this.toDoLabel.TabIndex = 16;
            this.toDoLabel.Text = "Daily To-Do";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dateLabel.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.dateLabel.Location = new System.Drawing.Point(43, 137);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(122, 19);
            this.dateLabel.TabIndex = 15;
            this.dateLabel.Text = "July 20, 2020";
            // 
            // goodMorningLabel
            // 
            this.goodMorningLabel.AutoSize = true;
            this.goodMorningLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.goodMorningLabel.Font = new System.Drawing.Font("Lucida Sans", 13F);
            this.goodMorningLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.goodMorningLabel.Location = new System.Drawing.Point(42, 103);
            this.goodMorningLabel.Name = "goodMorningLabel";
            this.goodMorningLabel.Size = new System.Drawing.Size(231, 25);
            this.goodMorningLabel.TabIndex = 14;
            this.goodMorningLabel.Text = "Good Morning, John!";
            // 
            // covidManagerLabel
            // 
            this.covidManagerLabel.AutoSize = true;
            this.covidManagerLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.covidManagerLabel.Font = new System.Drawing.Font("Lucida Sans", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.covidManagerLabel.Location = new System.Drawing.Point(26, 35);
            this.covidManagerLabel.Name = "covidManagerLabel";
            this.covidManagerLabel.Size = new System.Drawing.Size(566, 68);
            this.covidManagerLabel.TabIndex = 13;
            this.covidManagerLabel.Text = "COVID MANAGER";
            // 
            // companyLogoPicture
            // 
            this.companyLogoPicture.BackColor = System.Drawing.Color.Transparent;
            this.companyLogoPicture.BackgroundImage = global::COVID_Management.Properties.Resources.Maple_Leaf_Image;
            this.companyLogoPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.companyLogoPicture.Location = new System.Drawing.Point(10, 36);
            this.companyLogoPicture.Name = "companyLogoPicture";
            this.companyLogoPicture.Size = new System.Drawing.Size(85, 71);
            this.companyLogoPicture.TabIndex = 11;
            this.companyLogoPicture.TabStop = false;
            this.companyLogoPicture.Click += new System.EventHandler(this.companyLogoPicture_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::COVID_Management.Properties.Resources.Light_gray_image;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(921, 195);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(226)))), ((int)(((byte)(209)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(923, 520);
            this.Controls.Add(this.covidManagerLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.goodMorningLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyLogoPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label managerNameLabel;
        private System.Windows.Forms.PictureBox companyLogoPicture;
        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label covidNewsLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label toDoLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label goodMorningLabel;
        private System.Windows.Forms.Label covidManagerLabel;
        private System.Windows.Forms.Button quarantineScheduleButton;
        private System.Windows.Forms.Button yesCovidPosButton;
        private System.Windows.Forms.Label didYouTestPosForCovidLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

