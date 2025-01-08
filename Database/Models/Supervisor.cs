namespace GraduationDatabase.Models
{
    public class Supervisor
    {
        public int Id { get; set; } // Primary Key
        public string? Name { get; set; }

        public ICollection<Thesis>? Theses { get; set; }
    }
}
