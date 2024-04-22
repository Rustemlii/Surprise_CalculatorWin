namespace Surprise_CalculatorWin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            buttonOther = new Button();
            buttonSilmeButov = new Button();
            buttonSilmeTekTek = new Button();
            buttonFaiz = new Button();
            buttonBolme = new Button();
            buttonVurma = new Button();
            buttonCixma = new Button();
            buttonToplama = new Button();
            buttonBeraber = new Button();
            buttonVergul = new Button();
            button0 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            bttn1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 56);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(327, 45);
            textBox1.TabIndex = 1;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonOther);
            groupBox1.Controls.Add(buttonSilmeButov);
            groupBox1.Controls.Add(buttonSilmeTekTek);
            groupBox1.Controls.Add(buttonFaiz);
            groupBox1.Controls.Add(buttonBolme);
            groupBox1.Controls.Add(buttonVurma);
            groupBox1.Controls.Add(buttonCixma);
            groupBox1.Controls.Add(buttonToplama);
            groupBox1.Controls.Add(buttonBeraber);
            groupBox1.Controls.Add(buttonVergul);
            groupBox1.Controls.Add(button0);
            groupBox1.Controls.Add(button9);
            groupBox1.Controls.Add(button8);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(bttn1);
            groupBox1.Location = new Point(12, 107);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(327, 297);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // buttonOther
            // 
            buttonOther.BackColor = Color.FromArgb(192, 192, 255);
            buttonOther.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonOther.Location = new Point(6, 239);
            buttonOther.Name = "buttonOther";
            buttonOther.Size = new Size(74, 46);
            buttonOther.TabIndex = 0;
            buttonOther.Text = "Close";
            buttonOther.UseVisualStyleBackColor = false;
            buttonOther.Click += buttonOther_Click;
            // 
            // buttonSilmeButov
            // 
            buttonSilmeButov.BackColor = Color.SpringGreen;
            buttonSilmeButov.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonSilmeButov.Location = new Point(6, 31);
            buttonSilmeButov.Name = "buttonSilmeButov";
            buttonSilmeButov.Size = new Size(74, 46);
            buttonSilmeButov.TabIndex = 0;
            buttonSilmeButov.Text = "AC";
            buttonSilmeButov.UseVisualStyleBackColor = false;
            buttonSilmeButov.Click += buttonSilmeButov_Click;
            // 
            // buttonSilmeTekTek
            // 
            buttonSilmeTekTek.BackColor = Color.Red;
            buttonSilmeTekTek.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonSilmeTekTek.Location = new Point(86, 31);
            buttonSilmeTekTek.Name = "buttonSilmeTekTek";
            buttonSilmeTekTek.Size = new Size(74, 46);
            buttonSilmeTekTek.TabIndex = 0;
            buttonSilmeTekTek.Text = "X";
            buttonSilmeTekTek.UseVisualStyleBackColor = false;
            buttonSilmeTekTek.Click += buttonSilmeTekTek_Click;
            // 
            // buttonFaiz
            // 
            buttonFaiz.BackColor = Color.FromArgb(255, 128, 255);
            buttonFaiz.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonFaiz.Location = new Point(166, 31);
            buttonFaiz.Name = "buttonFaiz";
            buttonFaiz.Size = new Size(74, 46);
            buttonFaiz.TabIndex = 0;
            buttonFaiz.Text = "%";
            buttonFaiz.UseVisualStyleBackColor = false;
            buttonFaiz.Click += buttonFaiz_Click;
            // 
            // buttonBolme
            // 
            buttonBolme.BackColor = Color.FromArgb(255, 128, 255);
            buttonBolme.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonBolme.Location = new Point(246, 31);
            buttonBolme.Name = "buttonBolme";
            buttonBolme.Size = new Size(74, 46);
            buttonBolme.TabIndex = 0;
            buttonBolme.Text = "/";
            buttonBolme.UseVisualStyleBackColor = false;
            buttonBolme.Click += buttonBolme_Click;
            // 
            // buttonVurma
            // 
            buttonVurma.BackColor = Color.FromArgb(255, 128, 255);
            buttonVurma.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonVurma.Location = new Point(246, 83);
            buttonVurma.Name = "buttonVurma";
            buttonVurma.Size = new Size(74, 46);
            buttonVurma.TabIndex = 0;
            buttonVurma.Text = "*";
            buttonVurma.UseVisualStyleBackColor = false;
            buttonVurma.Click += buttonVurma_Click;
            // 
            // buttonCixma
            // 
            buttonCixma.BackColor = Color.FromArgb(255, 128, 255);
            buttonCixma.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonCixma.Location = new Point(246, 135);
            buttonCixma.Name = "buttonCixma";
            buttonCixma.Size = new Size(74, 46);
            buttonCixma.TabIndex = 0;
            buttonCixma.Text = "-";
            buttonCixma.UseVisualStyleBackColor = false;
            buttonCixma.Click += buttonCixma_Click;
            // 
            // buttonToplama
            // 
            buttonToplama.BackColor = Color.FromArgb(255, 128, 255);
            buttonToplama.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonToplama.Location = new Point(246, 187);
            buttonToplama.Name = "buttonToplama";
            buttonToplama.Size = new Size(74, 46);
            buttonToplama.TabIndex = 0;
            buttonToplama.Text = "+";
            buttonToplama.UseVisualStyleBackColor = false;
            buttonToplama.Click += buttonToplama_Click;
            // 
            // buttonBeraber
            // 
            buttonBeraber.BackColor = Color.FromArgb(0, 192, 0);
            buttonBeraber.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonBeraber.Location = new Point(246, 239);
            buttonBeraber.Name = "buttonBeraber";
            buttonBeraber.Size = new Size(74, 46);
            buttonBeraber.TabIndex = 0;
            buttonBeraber.Text = "=";
            buttonBeraber.UseVisualStyleBackColor = false;
            buttonBeraber.Click += buttonBeraber_Click;
            // 
            // buttonVergul
            // 
            buttonVergul.BackColor = Color.FromArgb(255, 128, 0);
            buttonVergul.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonVergul.Location = new Point(166, 239);
            buttonVergul.Name = "buttonVergul";
            buttonVergul.Size = new Size(74, 46);
            buttonVergul.TabIndex = 0;
            buttonVergul.Text = ",";
            buttonVergul.UseVisualStyleBackColor = false;
            buttonVergul.Click += buttonVergul_Click;
            // 
            // button0
            // 
            button0.BackColor = Color.Cyan;
            button0.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button0.Location = new Point(86, 239);
            button0.Name = "button0";
            button0.Size = new Size(74, 46);
            button0.TabIndex = 0;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += button0_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Cyan;
            button9.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button9.Location = new Point(166, 187);
            button9.Name = "button9";
            button9.Size = new Size(74, 46);
            button9.TabIndex = 0;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Cyan;
            button8.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button8.Location = new Point(86, 187);
            button8.Name = "button8";
            button8.Size = new Size(74, 46);
            button8.TabIndex = 0;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Cyan;
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button7.Location = new Point(6, 187);
            button7.Name = "button7";
            button7.Size = new Size(74, 46);
            button7.TabIndex = 0;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Cyan;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button6.Location = new Point(166, 135);
            button6.Name = "button6";
            button6.Size = new Size(74, 46);
            button6.TabIndex = 0;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Cyan;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button5.Location = new Point(86, 135);
            button5.Name = "button5";
            button5.Size = new Size(74, 46);
            button5.TabIndex = 0;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Cyan;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button4.Location = new Point(6, 135);
            button4.Name = "button4";
            button4.Size = new Size(74, 46);
            button4.TabIndex = 0;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Cyan;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(166, 83);
            button3.Name = "button3";
            button3.Size = new Size(74, 46);
            button3.TabIndex = 0;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Cyan;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(86, 83);
            button2.Name = "button2";
            button2.Size = new Size(74, 46);
            button2.TabIndex = 0;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // bttn1
            // 
            bttn1.BackColor = Color.Cyan;
            bttn1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            bttn1.Location = new Point(6, 83);
            bttn1.Name = "bttn1";
            bttn1.Size = new Size(74, 46);
            bttn1.TabIndex = 0;
            bttn1.Text = "1";
            bttn1.UseVisualStyleBackColor = false;
            bttn1.Click += bttn1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(349, 416);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private GroupBox groupBox1;
        private Button buttonOther;
        private Button buttonSilmeButov;
        private Button buttonSilmeTekTek;
        private Button buttonFaiz;
        private Button buttonBolme;
        private Button buttonVurma;
        private Button buttonCixma;
        private Button buttonToplama;
        private Button buttonBeraber;
        private Button buttonVergul;
        private Button button0;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button bttn1;
    }
}