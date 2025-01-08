namespace GraduationDatabase.Models
{
    public class Thesis
    {
        public int Id { get; set; } // Primary Key
        public string? Title { get; set; }
        public int StudentId { get; set; }
        public int SupervisorId { get; set; }


        public Student? Student { get; set; }
        public Supervisor? Supervisor { get; set; }
        public ICollection<Review>? Reviews { get; set; }
    }
}




