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
            this.IThinkIHaveCovidLabel = new System.Windows.Forms.Label();
            this.ITestedPosForCovid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IThinkIHaveCovidLabel
            // 
            this.IThinkIHaveCovidLabel.AutoSize = true;
            this.IThinkIHaveCovidLabel.Location = new System.Drawing.Point(29, 41);
            this.IThinkIHaveCovidLabel.Name = "IThinkIHaveCovidLabel";
            this.IThinkIHaveCovidLabel.Size = new System.Drawing.Size(402, 280);
            this.IThinkIHaveCovidLabel.TabIndex = 9;
            this.IThinkIHaveCovidLabel.Text = resources.GetString("IThinkIHaveCovidLabel.Text");
            // 
            // ITestedPosForCovid
            // 
            this.ITestedPosForCovid.AutoSize = true;
            this.ITestedPosForCovid.Location = new System.Drawing.Point(477, 41);
            this.ITestedPosForCovid.Name = "ITestedPosForCovid";
            this.ITestedPosForCovid.Size = new System.Drawing.Size(388, 280);
            this.ITestedPosForCovid.TabIndex = 10;
            this.ITestedPosForCovid.Text = resources.GetString("ITestedPosForCovid.Text");
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.ITestedPosForCovid);
            this.Controls.Add(this.IThinkIHaveCovidLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label IThinkIHaveCovidLabel;
        private System.Windows.Forms.Label ITestedPosForCovid;
    }
}