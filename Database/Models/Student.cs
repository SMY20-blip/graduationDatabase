namespace GraduationDatabase.Models
{
    public class Student
    {
        public int Id { get; set; } // Primary Key (Changed from 'object' to 'int')
        public string? Name { get; set; }
        public int DepartmentId { get; set; }

        public Department? Department { get; set; }
        public ICollection<Thesis>? Theses { get; set; }
    }
}
