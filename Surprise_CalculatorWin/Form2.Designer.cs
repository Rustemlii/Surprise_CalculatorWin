namespace Surprise_CalculatorWin
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
            label1 = new Label();
            labelAd = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(144, 41);
            label1.TabIndex = 0;
            label1.Text = "Hörmətli";
            // 
            // labelAd
            // 
            labelAd.AutoSize = true;
            labelAd.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelAd.Location = new Point(153, 9);
            labelAd.Name = "labelAd";
            labelAd.Size = new Size(54, 41);
            labelAd.TabIndex = 0;
            labelAd.Text = "ad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(3, 50);
            label3.Name = "label3";
            label3.Size = new Size(736, 123);
            label3.TabIndex = 0;
            label3.Text = "bu proqram gizlilik \r\nməqsədilə hazırlanmışdır\r\nümid edirem yanlış yönlərə istifadə etmiyəcəksiniz\r\n";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 186);
            Controls.Add(label3);
            Controls.Add(labelAd);
            Controls.Add(label1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public Label labelAd;
        private Label label3;
    }
}