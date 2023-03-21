using DR_Music_Records_API.Models;

namespace DR_Music_Records_API.Repositories
{
    public class RecordRepository
    {
        private int _nextId;
        private List<Record>? _records;

        public RecordRepository() 
        { 
            _nextId = 0;
            _records = new List<Record>()
            {
                new Record() { Id = _nextId++, title = "Thriller", artist = "Micheal Jackson", duration = 42, publicationYear = 1982},
                new Record() { Id = _nextId++, title = "Back in Black", artist = "AC/DC", duration = 42, publicationYear = 1980},
                new Record() { Id = _nextId++, title = "The Bodyguard", artist = "Whitney Houston", duration = 57, publicationYear = 1992},
                new Record() { Id = _nextId++, title = "The Dark Side of the Moon", artist = "Pink Floyd", duration = 42, publicationYear = 1973},
                new Record() { Id = _nextId++, title = "Hotel California", artist = "Eagles", duration = 43, publicationYear = 1976},
                new Record() { Id = _nextId++, title = "21", artist = "Adele", duration = 48, publicationYear = 2010}
            };
        }

        public List<Record>? GetAll() 
        { 
            List<Record>? records = new List<Record>(_records!);
            return records;
        }
    }
}
