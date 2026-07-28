namespace DayOneMVCRasElbar.Models
{
    public class StudentBL
    {
        List<Student> students;
        public StudentBL()
        {
            students = new List<Student>();

            students.Add(new Student()
            {
                Id = 1,
                Name = "Arwa",
                ImageUrl="1.jpg",
                Gpa = 4f,
                Department = "CS"

            });
            students.Add(new Student()
            {
                Id = 2,
                Name = "Nada",
                ImageUrl = "2.jpg",
                Gpa = 3.5f,
                Department = "It"

            });
            students.Add(new Student()
            {
                Id = 3,
                Name = "Kareem",
                ImageUrl = "3.jpg",
                Gpa = 3.5f,
                Department = "IT"

            });
            students.Add(new Student()
            {
                Id = 4,
                Name = "Ali",
                ImageUrl = "3.jpg",
                Gpa = 3.5f,
                Department = "CS"

            });

        }

        public List<Student> GetAllStudents()
        {
            return students;
        }

        public Student Details(int id) 
        { 
            return students.FirstOrDefault(x=>x.Id == id);
        }

    }
}
