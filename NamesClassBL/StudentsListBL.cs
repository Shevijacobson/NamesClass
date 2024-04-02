using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using StudentsListDL;

namespace StudentsListBL
{
    public class StudentsListBL
    {
        ConnectionFile connectionFile;
        Student[] studentsArr;
        public StudentsListBL()
        {
            connectionFile = new ConnectionFile();

        }

        public Student[] GetNamesStudents()
        {
            string[] arr = connectionFile.ReadFileNames();
            studentsArr = new Student[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                string[] student = arr[i].Split(",");
                studentsArr[i] = new Student();
                studentsArr[i].Name = student[0];
                studentsArr[i].Age = student[1];

            }
            return studentsArr;
        }
    }
}
