using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Operations
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable("Person Contact");
        static int count = 0;
        public Form1()
        {
            InitializeComponent();
            dataGridView.DataSource = dt;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image Files(*.jpg; *.jpeg; *.gif;*.bmp;)|*.jpg; *.jpeg; *.gif;*.bmp;";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(op.FileName);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1Load(object sender, EventArgs e)
        {
            
            dt.Columns.Add("ID");
            dt.Columns.Add("Full Name");
            dt.Columns.Add("Phone Number");
            dt.Columns.Add("Email");
            dt.Columns.Add("Address");


        }
        private void validateUserEntry()
        {
            // Checks the value of the text.
            if (txtFullName.Text.Length == 0 || txtPhoneNumber.Text.Length == 0 || txtEmail.Text.Length == 0 || txtAddress.Text.Length == 0)
            {
                // Initializes the variables to pass to the MessageBox.Show method.
                string message = "Fill out one or more fields";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    // Closes the parent form.
                    this.Close();
                }
            }
            else
            {
                count += 1;
                dt.Rows.Add(count, txtFullName.Text, txtPhoneNumber.Text, txtEmail.Text, txtAddress.Text);             
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            validateUserEntry();    
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
