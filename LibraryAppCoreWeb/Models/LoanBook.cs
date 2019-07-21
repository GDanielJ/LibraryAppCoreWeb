using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LibraryAppCoreWeb.Models
{
    public class LoanBook
    {
        [Required]
        public int LoanId { get; set; }

        public Loan Loan { get; set; }

        [Required]
        public int BookId { get; set; }

        [Required]
        public Book Book { get; set; }

    }
}
