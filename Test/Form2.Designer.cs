﻿namespace Test
{
    partial class Verwaltung
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
            this.input_vorname = new System.Windows.Forms.TextBox();
            this.input_HR = new System.Windows.Forms.TextBox();
            this.input_city = new System.Windows.Forms.TextBox();
            this.input_telefon = new System.Windows.Forms.TextBox();
            this.input_straße = new System.Windows.Forms.TextBox();
            this.input_postleitzahl = new System.Windows.Forms.TextBox();
            this.input_nachname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.input_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label_kontakt = new System.Windows.Forms.Label();
            this.label_adresse = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.zurück_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input_vorname
            // 
            this.input_vorname.Location = new System.Drawing.Point(258, 118);
            this.input_vorname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_vorname.Name = "input_vorname";
            this.input_vorname.Size = new System.Drawing.Size(254, 26);
            this.input_vorname.TabIndex = 0;
            this.input_vorname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // input_HR
            // 
            this.input_HR.Location = new System.Drawing.Point(552, 340);
            this.input_HR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_HR.Name = "input_HR";
            this.input_HR.Size = new System.Drawing.Size(254, 26);
            this.input_HR.TabIndex = 1;
            // 
            // input_city
            // 
            this.input_city.Location = new System.Drawing.Point(552, 258);
            this.input_city.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_city.Name = "input_city";
            this.input_city.Size = new System.Drawing.Size(254, 26);
            this.input_city.TabIndex = 3;
            // 
            // input_telefon
            // 
            this.input_telefon.Location = new System.Drawing.Point(258, 486);
            this.input_telefon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_telefon.Name = "input_telefon";
            this.input_telefon.Size = new System.Drawing.Size(254, 26);
            this.input_telefon.TabIndex = 4;
            // 
            // input_straße
            // 
            this.input_straße.Location = new System.Drawing.Point(258, 340);
            this.input_straße.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_straße.Name = "input_straße";
            this.input_straße.Size = new System.Drawing.Size(254, 26);
            this.input_straße.TabIndex = 5;
            // 
            // input_postleitzahl
            // 
            this.input_postleitzahl.Location = new System.Drawing.Point(258, 258);
            this.input_postleitzahl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_postleitzahl.Name = "input_postleitzahl";
            this.input_postleitzahl.Size = new System.Drawing.Size(254, 26);
            this.input_postleitzahl.TabIndex = 6;
            // 
            // input_nachname
            // 
            this.input_nachname.Location = new System.Drawing.Point(552, 118);
            this.input_nachname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_nachname.Name = "input_nachname";
            this.input_nachname.Size = new System.Drawing.Size(254, 26);
            this.input_nachname.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Vorname";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 234);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Postleitzahl";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 315);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Straße";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 462);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Telefon";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(777, 611);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(156, 45);
            this.updateButton.TabIndex = 12;
            this.updateButton.Text = "Aktualisieren";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(592, 611);
            this.createButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(156, 45);
            this.createButton.TabIndex = 13;
            this.createButton.Text = "Erstellen";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // input_email
            // 
            this.input_email.Location = new System.Drawing.Point(550, 486);
            this.input_email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_email.Name = "input_email";
            this.input_email.Size = new System.Drawing.Size(254, 26);
            this.input_email.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(548, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nachname";
            // 
            // label_kontakt
            // 
            this.label_kontakt.AutoSize = true;
            this.label_kontakt.Location = new System.Drawing.Point(42, 402);
            this.label_kontakt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_kontakt.Name = "label_kontakt";
            this.label_kontakt.Size = new System.Drawing.Size(64, 20);
            this.label_kontakt.TabIndex = 16;
            this.label_kontakt.Text = "Kontakt";
            this.label_kontakt.Click += new System.EventHandler(this.label6_Click);
            // 
            // label_adresse
            // 
            this.label_adresse.AutoSize = true;
            this.label_adresse.Location = new System.Drawing.Point(42, 202);
            this.label_adresse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_adresse.Name = "label_adresse";
            this.label_adresse.Size = new System.Drawing.Size(68, 20);
            this.label_adresse.TabIndex = 17;
            this.label_adresse.Text = "Adresse";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(42, 74);
            this.label_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(51, 20);
            this.label_name.TabIndex = 18;
            this.label_name.Text = "Name";
            this.label_name.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(548, 315);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Hausnummer";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(548, 234);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Stadt";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(548, 462);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "E-Mail";
            // 
            // zurück_button
            // 
            this.zurück_button.Location = new System.Drawing.Point(15, 16);
            this.zurück_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.zurück_button.Name = "zurück_button";
            this.zurück_button.Size = new System.Drawing.Size(84, 29);
            this.zurück_button.TabIndex = 22;
            this.zurück_button.Text = "zurück";
            this.zurück_button.UseVisualStyleBackColor = true;
            this.zurück_button.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(969, 611);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 45);
            this.button2.TabIndex = 23;
            this.button2.Text = "Löschen";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Verwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 698);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.zurück_button);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_adresse);
            this.Controls.Add(this.label_kontakt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.input_email);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_nachname);
            this.Controls.Add(this.input_postleitzahl);
            this.Controls.Add(this.input_straße);
            this.Controls.Add(this.input_telefon);
            this.Controls.Add(this.input_city);
            this.Controls.Add(this.input_HR);
            this.Controls.Add(this.input_vorname);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Verwaltung";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_vorname;
        private System.Windows.Forms.TextBox input_HR;
        private System.Windows.Forms.TextBox input_city;
        private System.Windows.Forms.TextBox input_telefon;
        private System.Windows.Forms.TextBox input_straße;
        private System.Windows.Forms.TextBox input_postleitzahl;
        private System.Windows.Forms.TextBox input_nachname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox input_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_kontakt;
        private System.Windows.Forms.Label label_adresse;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button zurück_button;
        private System.Windows.Forms.Button button2;
    }
}