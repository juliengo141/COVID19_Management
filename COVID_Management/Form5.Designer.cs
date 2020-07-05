﻿namespace COVID_Management
{
    partial class Form5
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
            this.covidManagerLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 10.2F);
            this.label1.Location = new System.Drawing.Point(20, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to your daily COVID Questionnaire. ";
            // 
            // covidManagerLabel
            // 
            this.covidManagerLabel.AutoSize = true;
            this.covidManagerLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.covidManagerLabel.Font = new System.Drawing.Font("Lucida Sans", 36F, System.Drawing.FontStyle.Bold);
            this.covidManagerLabel.Location = new System.Drawing.Point(12, 9);
            this.covidManagerLabel.Name = "covidManagerLabel";
            this.covidManagerLabel.Size = new System.Drawing.Size(705, 136);
            this.covidManagerLabel.TabIndex = 14;
            this.covidManagerLabel.Text = "COVID Daily Work-\r\nFitness Questionnaire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 10.2F);
            this.label2.Location = new System.Drawing.Point(20, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(629, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "The purpose of this questionnaire is to assess if you are fit to go to work. ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 10.2F);
            this.label3.Location = new System.Drawing.Point(20, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(521, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Answer all questions truthfully and to the best of your ability";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 10.2F);
            this.label4.Location = new System.Drawing.Point(20, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Click \"Next\" to get started";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 10.2F);
            this.button1.Location = new System.Drawing.Point(521, 287);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 34);
            this.button1.TabIndex = 18;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::COVID_Management.Properties.Resources.Light_gray_image;
            this.pictureBox1.Location = new System.Drawing.Point(-55, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(783, 162);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(226)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(717, 360);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.covidManagerLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label covidManagerLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}