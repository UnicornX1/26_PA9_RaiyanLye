using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26_PA9_RaiyanLye
{
    public partial class Form1 : Form
    {
        string error = "Invalid Input.";
        string currencyerror = "Please select a currency.";
        double US = 0.74;
        double Japan = 81.97;
        double Malaysian = 3.01;
        public Form1()
        {
            InitializeComponent();
        }

        private void EventLog1_EntryWritten(object sender, System.Diagnostics.EntryWrittenEventArgs e)
        {

        }

        private void Rb_US_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Convert_Click(object sender, EventArgs e)
        {
            try
            {
                double amount = Convert.ToDouble(txt_Amount.Text);
                try
                {
                    if (rb_US.Checked)
                    {
                        double Converted = amount * US;
                        txt_Converted.Text = Converted.ToString();
                    }
                    else if (rb_Yen.Checked)
                    {
                        double Converted = amount * Japan;
                        txt_Converted.Text = Converted.ToString();
                    }
                }
                catch
                {
                    txt_Converted.Text = currencyerror;
                }
            }
            catch
            {
                txt_Converted.Text = error;
            }
        }
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Amount.Clear();
            txt_Converted.Clear();
        }

        private void Btn_Clear_Click_1(object sender, EventArgs e)
        {
            txt_Converted.Clear();
            txt_Amount.Clear();
        }
    }
}
