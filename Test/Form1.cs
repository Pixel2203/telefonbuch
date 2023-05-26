﻿using System;
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
    public partial class Suche : Form
    {
        public Suche()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        List<string> items = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            items.AddRange(new string[] { "Cat", "Dog", "Carrots", "Brocolli" });

            foreach (string str in items)
            {
                listBox1.Items.Add(str);

            }
        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (string str in items)
            {
                if (str.ToUpper().Contains(input_search.Text.ToUpper()))
                {
                    listBox1.Items.Add(str);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Verwaltung form2 = new Verwaltung();
            form2.Show();

            //load user data
        }

        private void button2_Click(object sender, EventArgs e)
        {
             new Verwaltung().ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
        
             
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Startseite form3 = new Startseite();
            form3.Show();
            this.Hide();
        }
    }
}
