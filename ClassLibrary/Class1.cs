using System;

namespace StudentsClass
{
    public class Student:IComparable<Student>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public char Division { get; set; }

        public int CompareTo(Student other)
        {
            return this.Id.CompareTo(other.Id);
        }
    }
}
