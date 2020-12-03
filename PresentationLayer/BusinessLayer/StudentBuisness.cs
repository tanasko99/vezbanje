using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{

    
    public class StudentBuisness
    {
        private readonly StudentRepository studentRepository;
        public StudentBuisness()
        {
            this.studentRepository = new StudentRepository();
        }
        public List<Student> GetAllStudents()
        {
            return this.studentRepository.GetAllStudents();
        }
        public bool InsertStudent(Student s)
        {
            if (this.studentRepository.InsertStudent(s) > 0)
                return true;
            else
                return false;
        }
        public List<Student> GetStudentsGKavg(decimal avg)
        {
            return this.studentRepository.GetAllStudents().Where(s => s.AverageMark > avg).ToList();
        }
       
    }
}
