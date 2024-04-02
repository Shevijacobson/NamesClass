using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsListDL
{
    public class ConnectionFile
    {
        string filePath = "C:\\Users\\משתמש\\3D Objects\\c#  מתקדם\\MySchool.txt";
        //string filePath = "C:\\Users\\משתמש\\3D Objects\\c#  מתקדם\\homeWork\\NamesClass\\MySchool.txtC:\\Users\\משתמש\\3D Objects\\c#  מתקדם\\homeWork\\NamesClass\\MySchool.txt";
        public string[] ReadFileNames()
        {
            return File.ReadAllLines(filePath);
        }
    }
}
