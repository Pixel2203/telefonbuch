using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form3 : System.Windows.Forms.Form
    {
        private bool connectionEstablished = false;
        public Form3()
        {
            InitializeComponent();
            this.connectionEstablished = DatabaseManager.EstablishConnection("127.0.0.1", "root", "Kaiser.331", "telefonbuch");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.connectionEstablished)
            {
                Form2 form2 = new Form2("w", null);
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Konnte keine Verbindung zur Datenbank aufbauen", "Verbindungsfehler");
            }
        
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (this.connectionEstablished)
            {
                this.Hide();
                Form1 form1 = new Form1();
                form1.ShowDialog();
                this.Close();
            }else
            {
                MessageBox.Show("Konnte keine Verbindung zur Datenbank aufbauen", "Verbindungsfehler");
            }
         
        }
    }
}
