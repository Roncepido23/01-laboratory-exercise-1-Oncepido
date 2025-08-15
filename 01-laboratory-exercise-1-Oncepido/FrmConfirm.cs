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

        private DelegateText DelProgram, DelLastName, DelMiddleName, DelAddress;

        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;

        public FrmConfirm()
        {
            InitializeComponent();
        }


        private void FrmConfirm_Load(object sender, EventArgs e)
        {

        }
    }
}



