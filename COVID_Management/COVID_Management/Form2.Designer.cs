namespace COVID_Management
{
    partial class Form2
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // covidManagerLabel
            // 
            this.covidManagerLabel.AutoSize = true;
            this.covidManagerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.covidManagerLabel.Location = new System.Drawing.Point(12, 9);
            this.covidManagerLabel.Name = "covidManagerLabel";
            this.covidManagerLabel.Size = new System.Drawing.Size(396, 39);
            this.covidManagerLabel.TabIndex = 14;
            this.covidManagerLabel.Text = "COVID-19 Questionnaire";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Fever(feeling hot to the touch, a temperature of 37.8 degrees Celsius or higher)",
            "Chills",
            "Cough that\'s new or worsening(continuous, more than usual)",
            "Barking cough, making a whistling noise when breathing(croup)",
            "Shortness of breath(out of breath, unable to breathe deeply)",
            "Sore throat",
            "Difficulty swallowing",
            "Runny nose(not related to seasonal allergies or other known causes or conditions)" +
                "",
            "Stuffy or congested nose(not related to seasonal allergies or other known causes " +
                "or conditions)",
            "Lost sense of taste or smell",
            "Pink eye(conjunctivitis)",
            "Headache that’s unusual or long lasting",
            "Digestive issues like nausea/vomiting, diarrhea, stomach pain (not related to oth" +
                "er known causes or conditions)",
            "Muscle aches that are unusual or long lasting",
            "Extreme tiredness that is unusual(fatigue, lack of energy)",
            "Falling down often",
            "For young children and infants: sluggishness or lack of appetite",
            "None of the above "});
            this.checkedListBox1.Location = new System.Drawing.Point(12, 51);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(776, 344);
            this.checkedListBox1.TabIndex = 15;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(713, 415);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 16;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.covidManagerLabel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label covidManagerLabel;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button submitButton;
    }
}