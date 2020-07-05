namespace COVID_Management
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.IThinkIHaveCovidLabel = new System.Windows.Forms.Label();
            this.ITestedPosForCovid = new System.Windows.Forms.Label();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(29, 379);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // IThinkIHaveCovidLabel
            // 
            this.IThinkIHaveCovidLabel.AutoSize = true;
            this.IThinkIHaveCovidLabel.Location = new System.Drawing.Point(26, 33);
            this.IThinkIHaveCovidLabel.Name = "IThinkIHaveCovidLabel";
            this.IThinkIHaveCovidLabel.Size = new System.Drawing.Size(364, 238);
            this.IThinkIHaveCovidLabel.TabIndex = 9;
            this.IThinkIHaveCovidLabel.Text = resources.GetString("IThinkIHaveCovidLabel.Text");
            // 
            // ITestedPosForCovid
            // 
            this.ITestedPosForCovid.AutoSize = true;
            this.ITestedPosForCovid.Location = new System.Drawing.Point(424, 33);
            this.ITestedPosForCovid.Name = "ITestedPosForCovid";
            this.ITestedPosForCovid.Size = new System.Drawing.Size(348, 238);
            this.ITestedPosForCovid.TabIndex = 10;
            this.ITestedPosForCovid.Text = resources.GetString("ITestedPosForCovid.Text");
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(26, 325);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(411, 51);
            this.instructionLabel.TabIndex = 11;
            this.instructionLabel.Text = "Please quarantine yourself for 14 days starting from today, \r\nwhen you first show" +
    "ed symptons, or the day you tested for covid\r\n.";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(685, 353);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 12;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.ITestedPosForCovid);
            this.Controls.Add(this.IThinkIHaveCovidLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label IThinkIHaveCovidLabel;
        private System.Windows.Forms.Label ITestedPosForCovid;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Button nextButton;
    }
}