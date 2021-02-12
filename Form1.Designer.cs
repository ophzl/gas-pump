namespace Essence2
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.thanks1 = new Essence2.Thanks();
            this.pleaseWaitDuplicata1 = new Essence2.PleaseWaitDuplicata();
            this.pleaseWait1 = new Essence2.PleaseWait();
            this.service1 = new Essence2.Service();
            this.checkout1 = new Essence2.Checkout();
            this.ticketChoice1 = new Essence2.TicketChoice();
            this.cardCode1 = new Essence2.CardCode();
            this.fuelChoice1 = new Essence2.FuelChoice();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(108, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "EN SERVICE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(12, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "INSEREZ VOTRE CARTE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(56, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(337, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "JUSQU\'A LA BUTEE";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Insérer la carte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.Location = new System.Drawing.Point(22, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(410, 39);
            this.label4.TabIndex = 4;
            this.label4.Text = "VEUILLEZ PATIENTER...";
            this.label4.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBox1.Location = new System.Drawing.Point(115, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 45);
            this.textBox1.TabIndex = 7;
            this.textBox1.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(80, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(304, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "RETIREZ VOTRE CARTE";
            this.label5.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Retirer carte";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label6.Location = new System.Drawing.Point(184, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label7.Location = new System.Drawing.Point(158, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 26);
            this.label7.TabIndex = 14;
            this.label7.Text = "POMPE N°1";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label8.Location = new System.Drawing.Point(184, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 26);
            this.label8.TabIndex = 16;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label9.Location = new System.Drawing.Point(104, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(250, 31);
            this.label9.TabIndex = 20;
            this.label9.Text = "MAX = 150.00 EUR";
            this.label9.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(147, 359);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "Retirer la pompe";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label10.Location = new System.Drawing.Point(104, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(270, 31);
            this.label10.TabIndex = 22;
            this.label10.Text = "DEBIT EN COURS...";
            this.label10.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(147, 359);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 23);
            this.button4.TabIndex = 23;
            this.button4.Text = "Fin";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label11.Location = new System.Drawing.Point(176, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 31);
            this.label11.TabIndex = 25;
            this.label11.Text = "label11";
            this.label11.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label13.Location = new System.Drawing.Point(66, 194);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(353, 31);
            this.label13.TabIndex = 27;
            this.label13.Text = "MONTANT TRANSACTION";
            this.label13.Visible = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(2, 381);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(74, 67);
            this.button5.TabIndex = 30;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // thanks1
            // 
            this.thanks1.Location = new System.Drawing.Point(63, 15);
            this.thanks1.Name = "thanks1";
            this.thanks1.Size = new System.Drawing.Size(317, 250);
            this.thanks1.TabIndex = 31;
            this.thanks1.Visible = false;
            // 
            // pleaseWaitDuplicata1
            // 
            this.pleaseWaitDuplicata1.Location = new System.Drawing.Point(12, 15);
            this.pleaseWaitDuplicata1.Name = "pleaseWaitDuplicata1";
            this.pleaseWaitDuplicata1.Size = new System.Drawing.Size(405, 185);
            this.pleaseWaitDuplicata1.TabIndex = 29;
            this.pleaseWaitDuplicata1.Visible = false;
            // 
            // pleaseWait1
            // 
            this.pleaseWait1.Location = new System.Drawing.Point(30, -3);
            this.pleaseWait1.Name = "pleaseWait1";
            this.pleaseWait1.Size = new System.Drawing.Size(390, 228);
            this.pleaseWait1.TabIndex = 24;
            this.pleaseWait1.Visible = false;
            // 
            // service1
            // 
            this.service1.Location = new System.Drawing.Point(2, 6);
            this.service1.Name = "service1";
            this.service1.Size = new System.Drawing.Size(438, 163);
            this.service1.TabIndex = 15;
            this.service1.Visible = false;
            // 
            // checkout1
            // 
            this.checkout1.Location = new System.Drawing.Point(29, -17);
            this.checkout1.Name = "checkout1";
            this.checkout1.Size = new System.Drawing.Size(391, 245);
            this.checkout1.TabIndex = 11;
            this.checkout1.Visible = false;
            // 
            // ticketChoice1
            // 
            this.ticketChoice1.Location = new System.Drawing.Point(45, 6);
            this.ticketChoice1.Name = "ticketChoice1";
            this.ticketChoice1.Size = new System.Drawing.Size(348, 432);
            this.ticketChoice1.TabIndex = 8;
            this.ticketChoice1.Visible = false;
            this.ticketChoice1.Load += new System.EventHandler(this.ticketChoice1_Load);
            // 
            // cardCode1
            // 
            this.cardCode1.Location = new System.Drawing.Point(98, 90);
            this.cardCode1.Name = "cardCode1";
            this.cardCode1.Size = new System.Drawing.Size(256, 348);
            this.cardCode1.TabIndex = 6;
            this.cardCode1.Visible = false;
            this.cardCode1.Load += new System.EventHandler(this.cardCode1_Load);
            // 
            // fuelChoice1
            // 
            this.fuelChoice1.Location = new System.Drawing.Point(62, 35);
            this.fuelChoice1.Name = "fuelChoice1";
            this.fuelChoice1.Size = new System.Drawing.Size(342, 382);
            this.fuelChoice1.TabIndex = 5;
            this.fuelChoice1.Visible = false;
            this.fuelChoice1.Load += new System.EventHandler(this.fuelChoice1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 450);
            this.Controls.Add(this.thanks1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pleaseWaitDuplicata1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pleaseWait1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.service1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkout1);
            this.Controls.Add(this.ticketChoice1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cardCode1);
            this.Controls.Add(this.fuelChoice1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private FuelChoice fuelChoice1;
        private CardCode cardCode1;
        private System.Windows.Forms.TextBox textBox1;
        private TicketChoice ticketChoice1;
        private System.Windows.Forms.Label label5;
        private Checkout checkout1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Service service1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button4;
        private PleaseWait pleaseWait1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private PleaseWaitDuplicata pleaseWaitDuplicata1;
        private System.Windows.Forms.Button button5;
        private Thanks thanks1;
    }
}

