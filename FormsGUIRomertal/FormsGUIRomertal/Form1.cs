using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsGUIRomertal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 10 oversættelser
            const string ROMAN_1 = "I";
            const string ROMAN_2 = "II";
            const string ROMAN_3 = "III";
            const string ROMAN_4 = "IV";
            const string ROMAN_5 = "V";
            const string ROMAN_6 = "VI";
            const string ROMAN_7 = "VII";
            const string ROMAN_8 = "VIII";
            const string ROMAN_9 = "IX";
            const string ROMAN_10 = "X";
           



            int number = 0;
            if(int.TryParse(textBox1.Text,out number))
            {
                if(number >= 1 && number <= 10)
                {
                    switch (number)
                    {
                        case 1:
                            label1.Text = ROMAN_1;
                            break;
                        case 2:
                            label1.Text = ROMAN_2;
                            break;
                        case 3:
                            label1.Text = ROMAN_3;
                            break;
                        case 4:
                            label1.Text = ROMAN_4;
                            break;
                        case 5:
                            label1.Text = ROMAN_5;
                            break;
                        case 6:
                            label1.Text = ROMAN_6;
                            break;
                        case 7:
                            label1.Text = ROMAN_7;
                            break;
                        case 8:
                            label1.Text = ROMAN_8;
                            break;
                        case 9:
                            label1.Text = ROMAN_9;
                            break;
                        case 10:
                            label1.Text = ROMAN_10;
                            break;
                        default:
                            label1.Text = "Kun 1 - 10";
                            break;



                    }
                }
                else
                {
                    MessageBox.Show("Kun tal fra 1 - 10", "Ugyldigt input");
                }
            }
            else
            {                      //Boxtext                          //boxnavn
                MessageBox.Show("Ugyldigt input, kun tal, kun 1 - 10","Ugyldig");
            }
        }

        
    }
}
