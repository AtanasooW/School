namespace School.ViewModels
{
    public class AddBookViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public string Author { get; set; } = null!;
        public string Category { get; set; } = null!;
    }
}
