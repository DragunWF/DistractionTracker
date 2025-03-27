namespace DistractionsTracker.Forms
{
    partial class DataSummaryForm
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
            label2 = new Label();
            panel1 = new Panel();
            leastFrequentDistractionLabel = new Label();
            mostFrequentDistractionLabel = new Label();
            totalDistractionTypesLabel = new Label();
            totalDistractionCountLabel = new Label();
            totalWorkSessionsLabel = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(83, 9);
            label2.Name = "label2";
            label2.Size = new Size(156, 23);
            label2.TabIndex = 7;
            label2.Text = "Data Summary";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(leastFrequentDistractionLabel);
            panel1.Controls.Add(mostFrequentDistractionLabel);
            panel1.Controls.Add(totalDistractionTypesLabel);
            panel1.Controls.Add(totalDistractionCountLabel);
            panel1.Controls.Add(totalWorkSessionsLabel);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(293, 150);
            panel1.TabIndex = 8;
            // 
            // leastFrequentDistractionLabel
            // 
            leastFrequentDistractionLabel.AutoSize = true;
            leastFrequentDistractionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            leastFrequentDistractionLabel.Location = new Point(168, 114);
            leastFrequentDistractionLabel.Name = "leastFrequentDistractionLabel";
            leastFrequentDistractionLabel.Size = new Size(39, 15);
            leastFrequentDistractionLabel.TabIndex = 9;
            leastFrequentDistractionLabel.Text = "[data]";
            // 
            // mostFrequentDistractionLabel
            // 
            mostFrequentDistractionLabel.AutoSize = true;
            mostFrequentDistractionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            mostFrequentDistractionLabel.Location = new Point(168, 89);
            mostFrequentDistractionLabel.Name = "mostFrequentDistractionLabel";
            mostFrequentDistractionLabel.Size = new Size(39, 15);
            mostFrequentDistractionLabel.TabIndex = 8;
            mostFrequentDistractionLabel.Text = "[data]";
            // 
            // totalDistractionTypesLabel
            // 
            totalDistractionTypesLabel.AutoSize = true;
            totalDistractionTypesLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            totalDistractionTypesLabel.Location = new Point(168, 64);
            totalDistractionTypesLabel.Name = "totalDistractionTypesLabel";
            totalDistractionTypesLabel.Size = new Size(39, 15);
            totalDistractionTypesLabel.TabIndex = 7;
            totalDistractionTypesLabel.Text = "[data]";
            // 
            // totalDistractionCountLabel
            // 
            totalDistractionCountLabel.AutoSize = true;
            totalDistractionCountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            totalDistractionCountLabel.Location = new Point(168, 40);
            totalDistractionCountLabel.Name = "totalDistractionCountLabel";
            totalDistractionCountLabel.Size = new Size(39, 15);
            totalDistractionCountLabel.TabIndex = 6;
            totalDistractionCountLabel.Text = "[data]";
            // 
            // totalWorkSessionsLabel
            // 
            totalWorkSessionsLabel.AutoSize = true;
            totalWorkSessionsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            totalWorkSessionsLabel.Location = new Point(168, 15);
            totalWorkSessionsLabel.Name = "totalWorkSessionsLabel";
            totalWorkSessionsLabel.Size = new Size(39, 15);
            totalWorkSessionsLabel.TabIndex = 5;
            totalWorkSessionsLabel.Text = "[data]";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 114);
            label6.Name = "label6";
            label6.Size = new Size(147, 15);
            label6.TabIndex = 4;
            label6.Text = "Least Frequent Distraction:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 89);
            label5.Name = "label5";
            label5.Size = new Size(147, 15);
            label5.TabIndex = 3;
            label5.Text = "Most Frequent Distraction:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 15);
            label4.Name = "label4";
            label4.Size = new Size(113, 15);
            label4.TabIndex = 2;
            label4.Text = "Total Work Sessions:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 64);
            label3.Name = "label3";
            label3.Size = new Size(127, 15);
            label3.TabIndex = 1;
            label3.Text = "Total Distraction Types:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 40);
            label1.Name = "label1";
            label1.Size = new Size(131, 15);
            label1.TabIndex = 0;
            label1.Text = "Total Distraction Count:";
            // 
            // OverallStatsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 212);
            Controls.Add(panel1);
            Controls.Add(label2);
            Name = "OverallStatsForm";
            Text = "Data Summary Form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Panel panel1;
        private Label label3;
        private Label label1;
        private Label label4;
        private Label label6;
        private Label label5;
        private Label leastFrequentDistractionLabel;
        private Label mostFrequentDistractionLabel;
        private Label totalDistractionTypesLabel;
        private Label totalDistractionCountLabel;
        private Label totalWorkSessionsLabel;
    }
}