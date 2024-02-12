using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tournament1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Btn_c_Tournament_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtbox_Tournament_Name.Text == "")
                {
                    MessageBox.Show("Enter a Tournament Name");
                    txtbox_Tournament_Name.Focus();
                }
                else if (txtbox_Entry_Fees.Text == "")
                {
                    MessageBox.Show("Enter a Entry Fees");
                    txtbox_Entry_Fees.Focus();
                }
                else
                {
                    Form2 f2 = new Form2();
                    double result;
                    Tournament_Data.Tournament_name = txtbox_Tournament_Name.Text;
                    if (double.TryParse(txtbox_Entry_Fees.Text, out result))
                    {
                        Tournament_Data.EntryFee = double.Parse(txtbox_Entry_Fees.Text);
                        Form.ActiveForm.Hide();
                        f2.Show();
                    }
                    else
                    {
                        MessageBox.Show("Enter a Valid Value");
                        txtbox_Entry_Fees.Text = "";
                        txtbox_Entry_Fees.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter a Valid Input");
            }
                
            }
        }
    }

