using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace BANKING_FORM_REGISTER
{
    public partial class FORM1 : Form
    {
        String connectionString = @"Data Source=KRISHNA-PC

                               \INFINITEDB;Initial Catalog=SB BANK ; Integrated Security=True;";




        public FORM1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        void clear()

        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text =
                textBox8.Text = textBox9.Text = textBox10.Text = textBox11.Text = "";



        }




        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox5.Text == "" || textBox9.Text == "" || textBox10.Text == "")

                MessageBox.Show("please fill mandatory films");

            else if (textBox10.Text != textBox11.Text)
                MessageBox.Show("password do not match");

            else
            {



                using (SqlConnection sqlCon = new SqlConnection(connectionString))

                {

                    try
                    {
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("CUSTOMER_ADD1", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;

                        sqlCmd.Parameters.AddWithValue("@CUSTOMER_NAME", textBox1.Text.Trim());

                        sqlCmd.Parameters.AddWithValue("@AGE", textBox2.Text.Trim());

                        sqlCmd.Parameters.AddWithValue("@GENDER", textBox3.Text.Trim());

                        sqlCmd.Parameters.AddWithValue("@PHONE_NO", textBox4.Text.Trim());

                        sqlCmd.Parameters.AddWithValue("@ACCOUNT_TYPE", textBox5.Text.Trim());

                        sqlCmd.Parameters.AddWithValue("@ADDRESS", textBox6.Text.Trim());

                        sqlCmd.Parameters.AddWithValue("@CITY", textBox7.Text.Trim());

                        sqlCmd.Parameters.AddWithValue("@STATE", textBox8.Text.Trim());

                        sqlCmd.Parameters.AddWithValue("@PINCODE", textBox9.Text.Trim());


                        sqlCmd.Parameters.AddWithValue("@PASSWORD", textBox10.Text.Trim());


                        sqlCmd.Parameters.AddWithValue("@CONFIRM_PASSWORD", textBox11.Text.Trim());
                        sqlCmd.ExecuteNonQuery();

                        MessageBox.Show("Registration is successful");

                        clear();

                    }

                    catch
                    {
                        MessageBox.Show("connection failed");
                    }



                }
            }
        }
    }
}
       
    
    
