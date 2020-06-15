using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _33_JolinTeo_PA9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Convert_Click(object sender, EventArgs e)
        {
            decimal USDollar = 0.74m;
            decimal JapaneseYen = 81.97m;
            decimal MalaysianRinggit = 3.01m;

            decimal Answer;

            try
            {
                decimal first = Convert.ToInt32(txt_Amount.Text);

                if (rb_US.Checked)
                {
                    Answer = first * USDollar;
                    txt_Converted.Text = Answer.ToString();
                }

                else if (rb_Yen.Checked)
                {
                    Answer = first * JapaneseYen;
                    txt_Converted.Text = Answer.ToString();
                }
                else if (rb_Ringgit.Checked)
                {
                    Answer = first * MalaysianRinggit;
                    txt_Converted.Text = Answer.ToString();
                }
                else
                {
                    MessageBox.Show("Please choose one of the currency");
                }

            }

            catch(FormatException)
            {
                MessageBox.Show("Please enter a valid amount.");
            }
        }

        
        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Amount.Clear();
            txt_Converted.Clear();
            rb_US.Checked = false;
            rb_Yen.Checked = false;
            rb_Ringgit.Checked = false;
        }
    }
}
