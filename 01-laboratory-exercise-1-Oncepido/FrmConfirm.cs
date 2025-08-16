using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _01_laboratory_exercise_1_Oncepido.StudentInfoClass;

namespace _01_laboratory_exercise_1_Oncepido
{
    public partial class FrmConfirm : Form
    {

        private DelegateString DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;

        private void FrmConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;

        public FrmConfirm()
        {
             InitializeComponent();
        }
        private void button1_Submit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registration Submitted Succesfully");

            DialogResult = DialogResult.OK;
            Close();

        }


        private void FrmConfirm_Load_1(object sender, EventArgs e)
        {
            {
                DelProgram = new DelegateString(GetLabelProgram);
                DelLastName = new DelegateString(GetLastName);
                DelFirstName = new DelegateString(GetFirstName);
                DelMiddleName = new DelegateString(GetMiddleName);
                DelAddress = new DelegateString(GetAddress);
                DelNumAge = new DelegateNumber(GetAge);
                DelNumContactNo = new DelegateNumber(GetContactNo);
                DelStudNo = new DelegateNumber(GetStudentNo);

                label4_FirstName.Text = DelFirstName(FirstName);
                label3_LastName.Text = DelLastName(LastName);
                label5_MiddleName.Text = DelMiddleName(MiddleName);
                label8_Address.Text = DelAddress(Address);
                label2_Program.Text = DelProgram(StudentInfoClass.Program);
                label6_Age.Text = DelNumAge(Age).ToString();
                label7_ContactNumber.Text = DelNumContactNo(ContactNo).ToString();
                label1_StudentNumber.Text = DelStudNo(StudentNo).ToString();

                    
            }



        }
    }
}



