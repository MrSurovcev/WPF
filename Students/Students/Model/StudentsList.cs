using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Model
{
    internal class StudentsList
    {
        private List<Student> _students;
        public List<Student> Students
        {
            get { return _students; }
            set { _students = value; }
        }


        // Добавляет нового пользователя
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
        // Удаляет пользователя
        public void DeliteStudent(Student student)
        {
            Students.Remove(student);
        }
    }
}
