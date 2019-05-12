namespace Tetris_3._3
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OptVar5 = new System.Windows.Forms.RadioButton();
            this.OptVar4 = new System.Windows.Forms.RadioButton();
            this.OptVar3 = new System.Windows.Forms.RadioButton();
            this.OptVar2 = new System.Windows.Forms.RadioButton();
            this.OptVar1 = new System.Windows.Forms.RadioButton();
            this.CmdSicher = new System.Windows.Forms.Button();
            this.TxtWieOft1 = new System.Windows.Forms.TextBox();
            this.TxtWieLang = new System.Windows.Forms.TextBox();
            this.CmdStarten = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LblWieOft1 = new System.Windows.Forms.Label();
            this.LblWieOft2 = new System.Windows.Forms.Label();
            this.LblWieLange = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CmdPatchnotes = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.OptVar5);
            this.groupBox1.Controls.Add(this.OptVar4);
            this.groupBox1.Controls.Add(this.OptVar3);
            this.groupBox1.Controls.Add(this.OptVar2);
            this.groupBox1.Controls.Add(this.OptVar1);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(418, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Variationen";
            // 
            // OptVar5
            // 
            this.OptVar5.AutoSize = true;
            this.OptVar5.Location = new System.Drawing.Point(9, 213);
            this.OptVar5.Name = "OptVar5";
            this.OptVar5.Size = new System.Drawing.Size(229, 21);
            this.OptVar5.TabIndex = 4;
            this.OptVar5.Text = "Öffnet Tabs ohne zu stoppen";
            this.OptVar5.UseVisualStyleBackColor = true;
            // 
            // OptVar4
            // 
            this.OptVar4.AutoSize = true;
            this.OptVar4.Location = new System.Drawing.Point(9, 168);
            this.OptVar4.Name = "OptVar4";
            this.OptVar4.Size = new System.Drawing.Size(366, 21);
            this.OptVar4.TabIndex = 3;
            this.OptVar4.Text = "Öffnet bestimmte Zeit lang Tabs in einem Fenster";
            this.OptVar4.UseVisualStyleBackColor = true;
            // 
            // OptVar3
            // 
            this.OptVar3.AutoSize = true;
            this.OptVar3.Location = new System.Drawing.Point(9, 122);
            this.OptVar3.Name = "OptVar3";
            this.OptVar3.Size = new System.Drawing.Size(372, 21);
            this.OptVar3.TabIndex = 2;
            this.OptVar3.Text = "Öffnet bestimmte Anzahl an tabs in einem Fenster";
            this.OptVar3.UseVisualStyleBackColor = true;
            // 
            // OptVar2
            // 
            this.OptVar2.AutoSize = true;
            this.OptVar2.Location = new System.Drawing.Point(9, 76);
            this.OptVar2.Name = "OptVar2";
            this.OptVar2.Size = new System.Drawing.Size(259, 21);
            this.OptVar2.TabIndex = 1;
            this.OptVar2.Text = "Öffnet Chrome bestimmte Anzahl";
            this.OptVar2.UseVisualStyleBackColor = true;
            // 
            // OptVar1
            // 
            this.OptVar1.AutoSize = true;
            this.OptVar1.Location = new System.Drawing.Point(9, 34);
            this.OptVar1.Name = "OptVar1";
            this.OptVar1.Size = new System.Drawing.Size(251, 21);
            this.OptVar1.TabIndex = 0;
            this.OptVar1.Text = "Öffnet Chrome ohne zu stoppen";
            this.OptVar1.UseVisualStyleBackColor = true;
            this.OptVar1.CheckedChanged += new System.EventHandler(this.OptVar1_CheckedChanged);
            // 
            // CmdSicher
            // 
            this.CmdSicher.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CmdSicher.FlatAppearance.BorderSize = 0;
            this.CmdSicher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdSicher.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdSicher.Location = new System.Drawing.Point(13, 288);
            this.CmdSicher.Name = "CmdSicher";
            this.CmdSicher.Size = new System.Drawing.Size(143, 68);
            this.CmdSicher.TabIndex = 5;
            this.CmdSicher.Text = "Weiter";
            this.CmdSicher.UseVisualStyleBackColor = false;
            this.CmdSicher.Click += new System.EventHandler(this.CmdSicher_Click);
            // 
            // TxtWieOft1
            // 
            this.TxtWieOft1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtWieOft1.Location = new System.Drawing.Point(531, 89);
            this.TxtWieOft1.Name = "TxtWieOft1";
            this.TxtWieOft1.Size = new System.Drawing.Size(100, 22);
            this.TxtWieOft1.TabIndex = 6;
            this.TxtWieOft1.Visible = false;
            // 
            // TxtWieLang
            // 
            this.TxtWieLang.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtWieLang.Location = new System.Drawing.Point(612, 189);
            this.TxtWieLang.Name = "TxtWieLang";
            this.TxtWieLang.Size = new System.Drawing.Size(100, 22);
            this.TxtWieLang.TabIndex = 8;
            this.TxtWieLang.Visible = false;
            // 
            // CmdStarten
            // 
            this.CmdStarten.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CmdStarten.FlatAppearance.BorderSize = 0;
            this.CmdStarten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdStarten.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdStarten.Location = new System.Drawing.Point(330, 343);
            this.CmdStarten.Name = "CmdStarten";
            this.CmdStarten.Size = new System.Drawing.Size(208, 88);
            this.CmdStarten.TabIndex = 9;
            this.CmdStarten.Text = "Starten";
            this.CmdStarten.UseVisualStyleBackColor = false;
            this.CmdStarten.Visible = false;
            this.CmdStarten.Click += new System.EventHandler(this.CmdStarten_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(544, 141);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 12;
            this.textBox1.Visible = false;
            // 
            // LblWieOft1
            // 
            this.LblWieOft1.AutoSize = true;
            this.LblWieOft1.Location = new System.Drawing.Point(465, 92);
            this.LblWieOft1.Name = "LblWieOft1";
            this.LblWieOft1.Size = new System.Drawing.Size(60, 17);
            this.LblWieOft1.TabIndex = 13;
            this.LblWieOft1.Text = "Wie oft?";
            this.LblWieOft1.Visible = false;
            // 
            // LblWieOft2
            // 
            this.LblWieOft2.AutoSize = true;
            this.LblWieOft2.Location = new System.Drawing.Point(465, 144);
            this.LblWieOft2.Name = "LblWieOft2";
            this.LblWieOft2.Size = new System.Drawing.Size(73, 17);
            this.LblWieOft2.TabIndex = 14;
            this.LblWieOft2.Text = "Wie viele?";
            this.LblWieOft2.Visible = false;
            // 
            // LblWieLange
            // 
            this.LblWieLange.AutoSize = true;
            this.LblWieLange.Location = new System.Drawing.Point(465, 192);
            this.LblWieLange.Name = "LblWieLange";
            this.LblWieLange.Size = new System.Drawing.Size(141, 17);
            this.LblWieLange.TabIndex = 15;
            this.LblWieLange.Text = "Wie viele Sekunden?";
            this.LblWieLange.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(744, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 35);
            this.button1.TabIndex = 16;
            this.button1.Text = " ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(744, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 35);
            this.button2.TabIndex = 17;
            this.button2.Text = " ";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(814, 300);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 140);
            this.button3.TabIndex = 18;
            this.button3.Text = " ";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Blue;
            this.button4.Enabled = false;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(779, 405);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 35);
            this.button4.TabIndex = 19;
            this.button4.Text = " ";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Lime;
            this.button5.Enabled = false;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(744, 370);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 35);
            this.button5.TabIndex = 20;
            this.button5.Text = " ";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Lime;
            this.button6.Enabled = false;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(779, 335);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(35, 35);
            this.button6.TabIndex = 21;
            this.button6.Text = " ";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Fuchsia;
            this.button7.Enabled = false;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(709, 435);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(35, 35);
            this.button7.TabIndex = 22;
            this.button7.Text = " ";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Fuchsia;
            this.button8.Enabled = false;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(674, 400);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(35, 35);
            this.button8.TabIndex = 23;
            this.button8.Text = " ";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Fuchsia;
            this.button9.Enabled = false;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(674, 435);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(35, 35);
            this.button9.TabIndex = 24;
            this.button9.Text = " ";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Fuchsia;
            this.button10.Enabled = false;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(709, 400);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(35, 35);
            this.button10.TabIndex = 25;
            this.button10.Text = " ";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tetris", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(436, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 93);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tetris 3";
            // 
            // CmdPatchnotes
            // 
            this.CmdPatchnotes.BackColor = System.Drawing.Color.White;
            this.CmdPatchnotes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CmdPatchnotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdPatchnotes.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdPatchnotes.ForeColor = System.Drawing.Color.Maroon;
            this.CmdPatchnotes.Location = new System.Drawing.Point(12, 435);
            this.CmdPatchnotes.Name = "CmdPatchnotes";
            this.CmdPatchnotes.Size = new System.Drawing.Size(36, 29);
            this.CmdPatchnotes.TabIndex = 27;
            this.CmdPatchnotes.Text = "i";
            this.CmdPatchnotes.UseVisualStyleBackColor = false;
            this.CmdPatchnotes.Click += new System.EventHandler(this.CmdPatchnotes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(854, 471);
            this.Controls.Add(this.CmdPatchnotes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblWieLange);
            this.Controls.Add(this.LblWieOft2);
            this.Controls.Add(this.LblWieOft1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CmdStarten);
            this.Controls.Add(this.TxtWieLang);
            this.Controls.Add(this.TxtWieOft1);
            this.Controls.Add(this.CmdSicher);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(872, 518);
            this.MinimumSize = new System.Drawing.Size(872, 518);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton OptVar5;
        private System.Windows.Forms.RadioButton OptVar4;
        private System.Windows.Forms.RadioButton OptVar3;
        private System.Windows.Forms.RadioButton OptVar2;
        private System.Windows.Forms.RadioButton OptVar1;
        private System.Windows.Forms.Button CmdSicher;
        private System.Windows.Forms.TextBox TxtWieOft1;
        private System.Windows.Forms.TextBox TxtWieLang;
        private System.Windows.Forms.Button CmdStarten;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LblWieOft1;
        private System.Windows.Forms.Label LblWieOft2;
        private System.Windows.Forms.Label LblWieLange;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CmdPatchnotes;
    }
}

