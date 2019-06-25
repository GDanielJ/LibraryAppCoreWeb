using System;
using System.ComponentModel.DataAnnotations;


namespace LibraryAppCoreWeb.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Display(Name = "Release date")]
        public DateTime ReleaseDate { get; set; }

        public Author Author { get; set; }

        public int AuthorId { get; set; }
    }
}
