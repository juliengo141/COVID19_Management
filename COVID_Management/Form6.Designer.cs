namespace COVID_Management
{
    partial class Form6
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
            this.covidManagerLabel = new System.Windows.Forms.Label();
            this.COVIDPosButton = new System.Windows.Forms.Button();
            this.COVIDNegButton = new System.Windows.Forms.Button();
            this.COVIDResultsNotReceivedButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // covidManagerLabel
            // 
            this.covidManagerLabel.AutoSize = true;
            this.covidManagerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.covidManagerLabel.Location = new System.Drawing.Point(23, 49);
            this.covidManagerLabel.Name = "covidManagerLabel";
            this.covidManagerLabel.Size = new System.Drawing.Size(619, 36);
            this.covidManagerLabel.TabIndex = 15;
            this.covidManagerLabel.Text = "What were the results of your COVID-19 test?";
            // 
            // COVIDPosButton
            // 
            this.COVIDPosButton.Location = new System.Drawing.Point(52, 275);
            this.COVIDPosButton.Name = "COVIDPosButton";
            this.COVIDPosButton.Size = new System.Drawing.Size(161, 76);
            this.COVIDPosButton.TabIndex = 16;
            this.COVIDPosButton.Text = "I tested Positive for COVID 19";
            this.COVIDPosButton.UseVisualStyleBackColor = true;
            this.COVIDPosButton.Click += new System.EventHandler(this.COVIDPosButton_Click);
            // 
            // COVIDNegButton
            // 
            this.COVIDNegButton.Location = new System.Drawing.Point(297, 275);
            this.COVIDNegButton.Name = "COVIDNegButton";
            this.COVIDNegButton.Size = new System.Drawing.Size(161, 76);
            this.COVIDNegButton.TabIndex = 17;
            this.COVIDNegButton.Text = "I tested Negative for COVID 19";
            this.COVIDNegButton.UseVisualStyleBackColor = true;
            this.COVIDNegButton.Click += new System.EventHandler(this.COVIDNegButton_Click);
            // 
            // COVIDResultsNotReceivedButton
            // 
            this.COVIDResultsNotReceivedButton.Location = new System.Drawing.Point(552, 275);
            this.COVIDResultsNotReceivedButton.Name = "COVIDResultsNotReceivedButton";
            this.COVIDResultsNotReceivedButton.Size = new System.Drawing.Size(161, 76);
            this.COVIDResultsNotReceivedButton.TabIndex = 18;
            this.COVIDResultsNotReceivedButton.Text = "My results have not come in yet";
            this.COVIDResultsNotReceivedButton.UseVisualStyleBackColor = true;
            this.COVIDResultsNotReceivedButton.Click += new System.EventHandler(this.COVIDResultsNotReceivedButton_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.COVIDResultsNotReceivedButton);
            this.Controls.Add(this.COVIDNegButton);
            this.Controls.Add(this.COVIDPosButton);
            this.Controls.Add(this.covidManagerLabel);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label covidManagerLabel;
        private System.Windows.Forms.Button COVIDPosButton;
        private System.Windows.Forms.Button COVIDNegButton;
        private System.Windows.Forms.Button COVIDResultsNotReceivedButton;
    }
}