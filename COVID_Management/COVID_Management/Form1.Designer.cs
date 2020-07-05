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
            this.companyLogoPicture = new System.Windows.Forms.PictureBox();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.covidNewsLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.toDoLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.goodMorningLabel = new System.Windows.Forms.Label();
            this.covidManagerLabel = new System.Windows.Forms.Label();
            this.quarantineScheduleButton = new System.Windows.Forms.Button();
            this.didYouTestPosForCovidLabel = new System.Windows.Forms.Label();
            this.yesCovidPosButton = new System.Windows.Forms.Button();
            this.noCovidNegButton = new System.Windows.Forms.Button();
            this.unsureIfCovidPosButton = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyLogoPicture)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.managerNameLabel);
            this.groupBox3.Controls.Add(this.companyLogoPicture);
            this.groupBox3.Controls.Add(this.companyNameLabel);
            this.groupBox3.Location = new System.Drawing.Point(633, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(117, 112);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            // 
            // managerNameLabel
            // 
            this.managerNameLabel.AutoSize = true;
            this.managerNameLabel.Location = new System.Drawing.Point(6, 89);
            this.managerNameLabel.Name = "managerNameLabel";
            this.managerNameLabel.Size = new System.Drawing.Size(105, 17);
            this.managerNameLabel.TabIndex = 10;
            this.managerNameLabel.Text = "Manager Name";
            // 
            // companyLogoPicture
            // 
            this.companyLogoPicture.Location = new System.Drawing.Point(6, 36);
            this.companyLogoPicture.Name = "companyLogoPicture";
            this.companyLogoPicture.Size = new System.Drawing.Size(100, 50);
            this.companyLogoPicture.TabIndex = 11;
            this.companyLogoPicture.TabStop = false;
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Location = new System.Drawing.Point(3, 16);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(108, 17);
            this.companyNameLabel.TabIndex = 8;
            this.companyNameLabel.Text = "Company Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.covidNewsLabel);
            this.groupBox2.Location = new System.Drawing.Point(38, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 205);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // covidNewsLabel
            // 
            this.covidNewsLabel.AutoSize = true;
            this.covidNewsLabel.Location = new System.Drawing.Point(6, 14);
            this.covidNewsLabel.Name = "covidNewsLabel";
            this.covidNewsLabel.Size = new System.Drawing.Size(347, 204);
            this.covidNewsLabel.TabIndex = 3;
            this.covidNewsLabel.Text = resources.GetString("covidNewsLabel.Text");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.unsureIfCovidPosButton);
            this.groupBox1.Controls.Add(this.noCovidNegButton);
            this.groupBox1.Controls.Add(this.yesCovidPosButton);
            this.groupBox1.Controls.Add(this.didYouTestPosForCovidLabel);
            this.groupBox1.Controls.Add(this.quarantineScheduleButton);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(409, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 205);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(337, 21);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Complete daily COVID work-fitness questionnaire";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // toDoLabel
            // 
            this.toDoLabel.AutoSize = true;
            this.toDoLabel.Location = new System.Drawing.Point(261, 182);
            this.toDoLabel.Name = "toDoLabel";
            this.toDoLabel.Size = new System.Drawing.Size(83, 17);
            this.toDoLabel.TabIndex = 16;
            this.toDoLabel.Text = "Daily To-Do";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(35, 139);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(93, 17);
            this.dateLabel.TabIndex = 15;
            this.dateLabel.Text = "July 20, 2020";
            // 
            // goodMorningLabel
            // 
            this.goodMorningLabel.AutoSize = true;
            this.goodMorningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.goodMorningLabel.Location = new System.Drawing.Point(33, 109);
            this.goodMorningLabel.Name = "goodMorningLabel";
            this.goodMorningLabel.Size = new System.Drawing.Size(214, 26);
            this.goodMorningLabel.TabIndex = 14;
            this.goodMorningLabel.Text = "Good Morning, John!";
            // 
            // covidManagerLabel
            // 
            this.covidManagerLabel.AutoSize = true;
            this.covidManagerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.covidManagerLabel.Location = new System.Drawing.Point(31, 70);
            this.covidManagerLabel.Name = "covidManagerLabel";
            this.covidManagerLabel.Size = new System.Drawing.Size(308, 39);
            this.covidManagerLabel.TabIndex = 13;
            this.covidManagerLabel.Text = "COVID MANAGER";
            // 
            // quarantineScheduleButton
            // 
            this.quarantineScheduleButton.Location = new System.Drawing.Point(13, 155);
            this.quarantineScheduleButton.Name = "quarantineScheduleButton";
            this.quarantineScheduleButton.Size = new System.Drawing.Size(318, 36);
            this.quarantineScheduleButton.TabIndex = 8;
            this.quarantineScheduleButton.Text = "View my Quarantine Schedule";
            this.quarantineScheduleButton.UseVisualStyleBackColor = true;
            // 
            // didYouTestPosForCovidLabel
            // 
            this.didYouTestPosForCovidLabel.AutoSize = true;
            this.didYouTestPosForCovidLabel.Location = new System.Drawing.Point(6, 56);
            this.didYouTestPosForCovidLabel.Name = "didYouTestPosForCovidLabel";
            this.didYouTestPosForCovidLabel.Size = new System.Drawing.Size(210, 17);
            this.didYouTestPosForCovidLabel.TabIndex = 9;
            this.didYouTestPosForCovidLabel.Text = "Did you test positive for COVID?";
            // 
            // yesCovidPosButton
            // 
            this.yesCovidPosButton.Location = new System.Drawing.Point(13, 87);
            this.yesCovidPosButton.Name = "yesCovidPosButton";
            this.yesCovidPosButton.Size = new System.Drawing.Size(92, 22);
            this.yesCovidPosButton.TabIndex = 10;
            this.yesCovidPosButton.Text = "Yes";
            this.yesCovidPosButton.UseVisualStyleBackColor = true;
            this.yesCovidPosButton.Click += new System.EventHandler(this.yesCovidPosButton_Click);
            // 
            // noCovidNegButton
            // 
            this.noCovidNegButton.Location = new System.Drawing.Point(127, 87);
            this.noCovidNegButton.Name = "noCovidNegButton";
            this.noCovidNegButton.Size = new System.Drawing.Size(89, 22);
            this.noCovidNegButton.TabIndex = 11;
            this.noCovidNegButton.Text = "No";
            this.noCovidNegButton.UseVisualStyleBackColor = true;
            // 
            // unsureIfCovidPosButton
            // 
            this.unsureIfCovidPosButton.Location = new System.Drawing.Point(241, 87);
            this.unsureIfCovidPosButton.Name = "unsureIfCovidPosButton";
            this.unsureIfCovidPosButton.Size = new System.Drawing.Size(89, 22);
            this.unsureIfCovidPosButton.TabIndex = 12;
            this.unsureIfCovidPosButton.Text = "Unsure";
            this.unsureIfCovidPosButton.UseVisualStyleBackColor = true;
            this.unsureIfCovidPosButton.Click += new System.EventHandler(this.unsureIfCovidPosButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toDoLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.goodMorningLabel);
            this.Controls.Add(this.covidManagerLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyLogoPicture)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button noCovidNegButton;
        private System.Windows.Forms.Button yesCovidPosButton;
        private System.Windows.Forms.Label didYouTestPosForCovidLabel;
        private System.Windows.Forms.Button unsureIfCovidPosButton;
    }
}

