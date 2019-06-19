using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using LibraryAppCoreWeb.Models;

namespace LibraryAppCoreWeb.ViewModels
{
    public class BookFormViewModel
    {
        public int? Id { get; set; }

        public string Name { get; set; }

        [Display(Name = "Release date")]
        public DateTime ReleaseDate { get; set; }

        public IEnumerable<Author> Authors { get; set; }

        public string Title
        {
            get
            {
                return Id != 0 ? "Edit book" : "New book";
            }
        }

        public BookFormViewModel()
        {
            Id = 0;
        }

        public BookFormViewModel(Book book)
        {
            Id = book.Id;
            Name = book.Name;
            ReleaseDate = book.ReleaseDate;
        }

    }
}
