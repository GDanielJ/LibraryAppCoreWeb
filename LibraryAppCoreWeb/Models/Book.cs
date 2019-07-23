using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace LibraryAppCoreWeb.Models
{
    public class Book
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Display(Name = "Release date")]
        public DateTime ReleaseDate { get; set; }

        public Author Author { get; set; }

        public int AuthorId { get; set; }

        public ICollection<LoanBook> LoanBooks { get; set; }
    }
}
