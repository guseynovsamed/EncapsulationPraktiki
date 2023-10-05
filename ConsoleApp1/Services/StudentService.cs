using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    internal class StudentService
    {
        private Student[] GetAllStudent()
        {
            Student stu1 = new()
            {
                id = 1,
                name = "Semed",
                surname = "Huseynov",
                email = "Semed@gmail.com",
                age = 30,
                birthday = new(1993, 01, 02),
                address = "Ehmedli"

            };
            Student stu2 = new()
            {
                id = 2,
                name = "Ilham",
                surname = "Abasli",
                email = "Ilham@gmail.com",
                age = 19,
                birthday = new(2000, 01, 02),
                address = "Lokbatan"

            };
            Student stu3 = new()
            {
                id = 3,
                name = "Aqsin",
                surname = "Veliyev",
                email = "Aqsin@gmail.com",
                age = 20,
                birthday = new(1999, 01, 02),
                address = "Razin"   

            };
            return new Student[] { stu1, stu2, stu3 };

        }


        public Student[] GetShowStudent(DateTime startDate, DateTime endDate)
        {
            Student[] students = GetAllStudent();

            var result = students.Where(x => x.birthday > startDate && x.birthday < endDate).ToArray();

            return result;






        }





        public int GetShowAge(int id)
        {
            Student[] students = GetAllStudent();

            Student student = students.FirstOrDefault(x => x.id == id);

            int result = DateTime.Now.Year - student.birthday.Year;

            return result;

        }

    }
}
