using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bereau_application
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Figuig");
            comboBox1.Items.Add("Oujda");
            comboBox1.Items.Add("Fes");
            comboBox1.Items.Add("Berkan");
            comboBox1.Items.Add("Rabat");
            comboBox1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String nom = textBox1.Text;
            string ville = comboBox1.Text;

            if (nom.Length < 8 || nom.Length > 13)
            {
                MessageBox.Show("Le nom doit contenir entre 8 et 13");
            }
            else
            {
                label3.Text = "client pret : " + nom + " | ville : " + ville + ".";
            }
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is CheckBox cb && cb.Checked)
                {
                    label3.Text += " | " + cb.Text;
                }
            }

            if (radioButton1.Checked)
            {
                label3.Text = "Genre sélectionné : " + radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                label3.Text = "Genre sélectionné : " + radioButton2.Text;
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une option !");
            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            comboBox1.SelectedIndex = -1;
            label3.Text = "";

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
