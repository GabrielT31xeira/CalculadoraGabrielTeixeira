﻿namespace CalculadoraGabrielTeixeira
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.valor_1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // valor_1
            // 
            this.valor_1.Location = new System.Drawing.Point(12, 96);
            this.valor_1.Name = "valor_1";
            this.valor_1.Size = new System.Drawing.Size(108, 71);
            this.valor_1.TabIndex = 0;
            this.valor_1.Text = "1";
            this.valor_1.UseVisualStyleBackColor = true;
            this.valor_1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(266, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 71);
            this.button2.TabIndex = 1;
            this.button2.Text = "6";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 327);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 148);
            this.button3.TabIndex = 2;
            this.button3.Text = "0";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(266, 250);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 71);
            this.button4.TabIndex = 3;
            this.button4.Text = "9";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(137, 250);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 71);
            this.button5.TabIndex = 4;
            this.button5.Text = "8";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 250);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(108, 71);
            this.button6.TabIndex = 5;
            this.button6.Text = "7";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(137, 173);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(108, 71);
            this.button7.TabIndex = 6;
            this.button7.Text = "5";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 173);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(108, 71);
            this.button8.TabIndex = 7;
            this.button8.Text = "4";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(266, 96);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(108, 71);
            this.button9.TabIndex = 8;
            this.button9.Text = "3";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(137, 96);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(108, 71);
            this.button10.TabIndex = 9;
            this.button10.Text = "2";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button11.Location = new System.Drawing.Point(397, 250);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(108, 71);
            this.button11.TabIndex = 10;
            this.button11.Text = "x";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button12.Location = new System.Drawing.Point(397, 173);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(108, 71);
            this.button12.TabIndex = 11;
            this.button12.Text = "-";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button13.Location = new System.Drawing.Point(397, 96);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(108, 71);
            this.button13.TabIndex = 12;
            this.button13.Text = "+";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button14.Location = new System.Drawing.Point(397, 327);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(108, 71);
            this.button14.TabIndex = 13;
            this.button14.Text = "/";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button15.Location = new System.Drawing.Point(266, 327);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(108, 148);
            this.button15.TabIndex = 14;
            this.button15.Text = "=";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.MinimumSize = new System.Drawing.Size(489, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 70);
            this.label1.TabIndex = 15;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(138, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 70);
            this.button1.TabIndex = 16;
            this.button1.Text = "c";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button16.Location = new System.Drawing.Point(397, 404);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(108, 71);
            this.button16.TabIndex = 17;
            this.button16.Text = ",";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button17.Location = new System.Drawing.Point(137, 404);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(108, 71);
            this.button17.TabIndex = 18;
            this.button17.Text = "<-";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 502);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.valor_1);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button valor_1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
    }
}

