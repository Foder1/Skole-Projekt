using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semesterprojekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ejendomsmæglerDataSet3.tilSalgBolig' table. You can move, or remove it, as needed.
            this.tilSalgBoligTableAdapter.Fill(this.ejendomsmæglerDataSet3.tilSalgBolig);
            // TODO: This line of code loads data into the 'ejendomsmæglerDataSet2.Sælger' table. You can move, or remove it, as needed.
            this.sælgerTableAdapter.Fill(this.ejendomsmæglerDataSet2.Sælger);
            // TODO: This line of code loads data into the 'ejendomsmæglerDataSet1.solgtBolig' table. You can move, or remove it, as needed.
            this.solgtBoligTableAdapter.Fill(this.ejendomsmæglerDataSet1.solgtBolig);
            // TODO: This line of code loads data into the 'ejendomsmæglerDataSet.Køber' table. You can move, or remove it, as needed.
            this.køberTableAdapter.Fill(this.ejendomsmæglerDataSet.Køber);

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Form Købervindue = new Købervindue();
            Købervindue.Show();
        }
    }
}
