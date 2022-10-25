using System;

namespace my_book_store_app.Data.Models
{
    public class Books
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsRead { get; set; }
        public DateTime ? Dateread { get; set; }
        public int ? Rate { get; set; }
        public string CoverUrl { get; set; }
        public string Genre { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
