﻿namespace COVID_Management
{
    partial class Form7
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
            this.noOutOfCanButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.covidManagerLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.yesOutOfCanButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // noOutOfCanButton
            // 
            this.noOutOfCanButton.Location = new System.Drawing.Point(398, 237);
            this.noOutOfCanButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.noOutOfCanButton.Name = "noOutOfCanButton";
            this.noOutOfCanButton.Size = new System.Drawing.Size(281, 56);
            this.noOutOfCanButton.TabIndex = 24;
            this.noOutOfCanButton.Text = "No, I have not been outside of Canada or have come into close contact with someon" +
    "e who did";
            this.noOutOfCanButton.UseVisualStyleBackColor = true;
            this.noOutOfCanButton.Click += new System.EventHandler(this.noOutOfCanButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "who did? If yes, what day did you return/meet them?";
            // 
            // covidManagerLabel
            // 
            this.covidManagerLabel.AutoSize = true;
            this.covidManagerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.covidManagerLabel.Location = new System.Drawing.Point(22, 35);
            this.covidManagerLabel.Name = "covidManagerLabel";
            this.covidManagerLabel.Size = new System.Drawing.Size(642, 39);
            this.covidManagerLabel.TabIndex = 20;
            this.covidManagerLabel.Text = "COVID Daily Work-Fitness Questionnaire";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(659, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Did you recently return from outside of Canada within 14 days or came into close " +
    "contact with someone ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(29, 308);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // yesOutOfCanButton
            // 
            this.yesOutOfCanButton.Location = new System.Drawing.Point(29, 237);
            this.yesOutOfCanButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yesOutOfCanButton.Name = "yesOutOfCanButton";
            this.yesOutOfCanButton.Size = new System.Drawing.Size(281, 56);
            this.yesOutOfCanButton.TabIndex = 26;
            this.yesOutOfCanButton.Text = "Yes, I have been outside of Canada or have come into close contact with someone w" +
    "ho did";
            this.yesOutOfCanButton.UseVisualStyleBackColor = true;
            this.yesOutOfCanButton.Click += new System.EventHandler(this.yesOutOfCanButton_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.yesOutOfCanButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.noOutOfCanButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.covidManagerLabel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form7";
            this.Text = "Form7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button noOutOfCanButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label covidManagerLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button yesOutOfCanButton;
    }
}