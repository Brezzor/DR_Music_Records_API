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
                // Homework, Daft Punk, 74, 1997
            };
        }

        public List<Record>? GetAll(string? title, string? artist, int? duration, int? publicationYear) 
        { 
            List<Record>? records = new List<Record>(_records!);

            if (title != null)
            {
                records = records.FindAll(rec => rec.title!.Contains(title!, StringComparison.InvariantCultureIgnoreCase));
            }
            if (artist != null) 
            {
                records = records.FindAll(rec => rec.artist!.Contains(artist!, StringComparison.InvariantCultureIgnoreCase));
            }
            if (duration > 0)
            {
                records = records.FindAll(rec => rec.duration.Equals(duration));
            }
            if (publicationYear > 0)
            {
                records = records.FindAll(rec => rec.publicationYear.Equals(publicationYear));
            }

            return records;
        }

        public Record? addRecord(Record newRecord) 
        { 
            if (newRecord != null) 
            {
                newRecord.Id = _nextId++;
                _records!.Add(newRecord);
            }
            return newRecord;
        }
    }
}
