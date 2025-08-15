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

        private DelegateString DelProgram, DelLastName, DelMiddleName, DelAddress;

        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;



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

                
            }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
        

        private void label1_StudentNumber_Click(object sender, EventArgs e)
        {

        }

        



        public FrmConfirm()
        {
            InitializeComponent();
        }


       
    }
}



