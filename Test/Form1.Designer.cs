namespace Test
{
    partial class Suche
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.input_search = new System.Windows.Forms.TextBox();
            this.zurück_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(75, 106);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1006, 524);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // input_search
            // 
            this.input_search.Location = new System.Drawing.Point(75, 52);
            this.input_search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_search.Name = "input_search";
            this.input_search.Size = new System.Drawing.Size(1006, 26);
            this.input_search.TabIndex = 1;
            this.input_search.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // zurück_button
            // 
            this.zurück_button.Location = new System.Drawing.Point(14, 15);
            this.zurück_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.zurück_button.Name = "zurück_button";
            this.zurück_button.Size = new System.Drawing.Size(84, 29);
            this.zurück_button.TabIndex = 23;
            this.zurück_button.Text = "zurück";
            this.zurück_button.UseVisualStyleBackColor = true;
            this.zurück_button.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Suche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.zurück_button);
            this.Controls.Add(this.input_search);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Suche";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox input_search;
        private System.Windows.Forms.Button zurück_button;
    }
}

