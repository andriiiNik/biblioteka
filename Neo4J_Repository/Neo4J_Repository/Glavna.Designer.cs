namespace Neo4J_Repository
{
    partial class Glavna
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
            this.imePiscatb = new System.Windows.Forms.TextBox();
            this.delabtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.naslovKnjigetb = new System.Windows.Forms.TextBox();
            this.pronadjiKnjigubtn = new System.Windows.Forms.Button();
            this.dodajKnjigubtn = new System.Windows.Forms.Button();
            this.obrisiKnjigubtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime pisca";
            // 
            // imePiscatb
            // 
            this.imePiscatb.Location = new System.Drawing.Point(41, 125);
            this.imePiscatb.Name = "imePiscatb";
            this.imePiscatb.Size = new System.Drawing.Size(127, 20);
            this.imePiscatb.TabIndex = 1;
            // 
            // delabtn
            // 
            this.delabtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.delabtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delabtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.delabtn.Location = new System.Drawing.Point(193, 105);
            this.delabtn.Name = "delabtn";
            this.delabtn.Size = new System.Drawing.Size(103, 43);
            this.delabtn.TabIndex = 2;
            this.delabtn.Text = "Sva njegova dela";
            this.delabtn.UseVisualStyleBackColor = false;
            this.delabtn.Click += new System.EventHandler(this.delabtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(46, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Naslov knjige";
            // 
            // naslovKnjigetb
            // 
            this.naslovKnjigetb.Location = new System.Drawing.Point(41, 57);
            this.naslovKnjigetb.Name = "naslovKnjigetb";
            this.naslovKnjigetb.Size = new System.Drawing.Size(130, 20);
            this.naslovKnjigetb.TabIndex = 4;
            // 
            // pronadjiKnjigubtn
            // 
            this.pronadjiKnjigubtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pronadjiKnjigubtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pronadjiKnjigubtn.Location = new System.Drawing.Point(193, 35);
            this.pronadjiKnjigubtn.Name = "pronadjiKnjigubtn";
            this.pronadjiKnjigubtn.Size = new System.Drawing.Size(103, 42);
            this.pronadjiKnjigubtn.TabIndex = 5;
            this.pronadjiKnjigubtn.Text = "Pronadji \r\nknjigu\r\n";
            this.pronadjiKnjigubtn.UseVisualStyleBackColor = false;
            this.pronadjiKnjigubtn.Click += new System.EventHandler(this.pronadjiKnjigubtn_Click);
            // 
            // dodajKnjigubtn
            // 
            this.dodajKnjigubtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dodajKnjigubtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodajKnjigubtn.Location = new System.Drawing.Point(193, 181);
            this.dodajKnjigubtn.Name = "dodajKnjigubtn";
            this.dodajKnjigubtn.Size = new System.Drawing.Size(103, 48);
            this.dodajKnjigubtn.TabIndex = 6;
            this.dodajKnjigubtn.Text = "Dodaj \r\nKnjigu";
            this.dodajKnjigubtn.UseVisualStyleBackColor = false;
            this.dodajKnjigubtn.Click += new System.EventHandler(this.dodajKnjigubtn_Click);
            // 
            // obrisiKnjigubtn
            // 
            this.obrisiKnjigubtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.obrisiKnjigubtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obrisiKnjigubtn.Location = new System.Drawing.Point(322, 181);
            this.obrisiKnjigubtn.Name = "obrisiKnjigubtn";
            this.obrisiKnjigubtn.Size = new System.Drawing.Size(96, 48);
            this.obrisiKnjigubtn.TabIndex = 7;
            this.obrisiKnjigubtn.Text = "Obrisi\r\n Knjigu";
            this.obrisiKnjigubtn.UseVisualStyleBackColor = false;
            this.obrisiKnjigubtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(49, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 48);
            this.button1.TabIndex = 8;
            this.button1.Text = "Uclani";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Neo4J_Repository.Properties.Resources.biblioteka_58e69c6b65b7a;
            this.ClientSize = new System.Drawing.Size(464, 274);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.obrisiKnjigubtn);
            this.Controls.Add(this.dodajKnjigubtn);
            this.Controls.Add(this.pronadjiKnjigubtn);
            this.Controls.Add(this.naslovKnjigetb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.delabtn);
            this.Controls.Add(this.imePiscatb);
            this.Controls.Add(this.label1);
            this.Name = "Glavna";
            this.Text = "Glavna";
            this.Load += new System.EventHandler(this.Glavna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox imePiscatb;
        private System.Windows.Forms.Button delabtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox naslovKnjigetb;
        private System.Windows.Forms.Button pronadjiKnjigubtn;
        private System.Windows.Forms.Button dodajKnjigubtn;
        private System.Windows.Forms.Button obrisiKnjigubtn;
        private System.Windows.Forms.Button button1;
    }
}