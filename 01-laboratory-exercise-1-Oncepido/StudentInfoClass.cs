using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_laboratory_exercise_1_Oncepido
{
    internal class StudentInfoClass
    {
        public delegate long DelegateNumber(long number);
        public delegate string DelegateString(string text);

        // string Variables
        public static string FirstName = " ";
        public static string LastName = " ";
        public static string MiddleName = " ";
        public static string Address = " ";
        public static string Program = " ";

        // long variables
        public static long Age = 0;
        public static long ContactNo = 0;
        public static long StudentNo = 0;



        public static string GetFirstName(String FirstName)
        {
            return FirstName;
        }

        public static string GetLastName(String LastName)
        {
            return LastName;
        }

        public static string GetMiddleName(String MiddleName)
        {
            return MiddleName;
        }

        public static string GetAddress(String Address)
        {
            return Address;
        }       

        public static long GetAge(long Age)
        {
            return Age;
        }   

        public static long GetContactNo(long ContactNo)
        {
            return ContactNo;
        }       

        public static string GetLabelProgram(string Program)
        {
            return Program;
        }   

        public static long GetStudentNo(long StudentNo)
        {
            return StudentNo;
        }       


    }
}

       