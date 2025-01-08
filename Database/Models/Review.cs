namespace GraduationDatabase.Models
{
    public class Review
    {
        public int Id { get; set; } // Primary Key
        public string? Content { get; set; }
        public int ThesisId { get; set; }

        public Thesis? Thesis { get; set; }
    }
}
