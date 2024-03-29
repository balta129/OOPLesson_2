using System;

namespace OOPLesson2_P2.Concrete
{
    public class Class
    {
        public string Name; // Field
        private List<Student> _students = new List<Student>(); // Field
        public Student[] Students // Property that only has get
        {
            get // Get method of the property
            {
                return this._students.ToArray();
            }
        }

        public Class(Student[] students) // Constructor with single parameter
        {
            foreach (Student student in students)
            {
                if (student.Class != null)
                {
                    student.Class._students.Remove(student);
                }
                
                student.Class = this; // Set

                this._students.Add(student);
            }
        }
    }
}