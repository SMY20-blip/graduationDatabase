namespace GraduationDatabase.Models
{
    public class Department
    {
        public int Id { get; set; } // Primary Key
        public string? Name { get; set; }

        public ICollection<Student>? Students { get; set; }
    }

}
