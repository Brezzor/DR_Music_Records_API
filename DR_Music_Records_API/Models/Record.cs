namespace DR_Music_Records_API.Models
{
    public class Record
    {
        public int Id { get; set; }
        public string? title { get; set; }
        public string? artist { get; set; }
        public int duration { get; set; }
        public int publicationYear { get; set; }
    }
}
