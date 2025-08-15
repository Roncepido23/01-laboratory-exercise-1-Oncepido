using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_laboratory_exercise_1_Oncepido
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox2.Items.Add("BS in Information Technology");
            comboBox2.Items.Add("BS in Computer Science");
            comboBox2.Items.Add("BS in Computer Engineering");
            comboBox2.Items.Add("BS in Tambay sa Bahay");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            StudentInfoClass.FirstName = textBox2_Student_Firstname.Text;

            StudentInfoClass.LastName = textBox4_Student_Lastname.Text; 

            StudentInfoClass.MiddleName = textBox3_Student_Middlename.Text;

            StudentInfoClass.Address = textBoxAddress.Text;

            StudentInfoClass.Program = comboBox2.SelectedItem.ToString();

            StudentInfoClass.Age = Convert.ToInt64(textBox1_Age.Text);  

            StudentInfoClass.ContactNo = Convert.ToInt64(textBox2_ContactNumber.Text);


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
