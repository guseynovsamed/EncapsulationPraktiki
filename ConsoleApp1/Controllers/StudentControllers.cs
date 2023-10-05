using ConsoleApp1.Models;
using ConsoleApp1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Controllers
{
    internal class StudentControllers
    {
        public void GetALlName()
        {
            DateTime startDate = new(1990, 01, 01);


            DateTime endDate = new(2000, 01, 01);



            StudentService studentService = new StudentService();

            Student[] studens = studentService.GetShowStudent(startDate, endDate);

            foreach (var student in studens)
            {
                Console.WriteLine(student.name);
            }
        }

        public void GetResult()
        {
            StudentService studentService = new StudentService();

            Console.WriteLine(studentService.GetShowAge(2));

        }
        
        
      
    

    }
}
