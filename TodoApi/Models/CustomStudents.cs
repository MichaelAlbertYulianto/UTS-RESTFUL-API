using System.Collections.Generic;
using TodoApi.Models;

namespace TodoApi
{
    public class CustomStudents
    {
        public List<StudentInfo> students { get; set; }

        public CustomStudents(List<Students> students, List<Courses> courses)
        {
            this.students = new List<StudentInfo>();

            foreach (var student in students)
            {
                var studentInfo = new StudentInfo
                {
                    id = student.id,
                    name = student.name,
                    age = student.age,
                    courses = new List<Courses>()
                };

                foreach (var course in courses)
                {
                    if (course.student_id == student.id)
                    {
                        studentInfo.courses.Add(course);
                    }
                }

                this.students.Add(studentInfo);
            }
        }
    }

    public class StudentInfo
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public List<Courses> courses { get; set; }
    }
}
