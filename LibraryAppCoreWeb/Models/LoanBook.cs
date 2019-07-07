using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAppCoreWeb.Models
{
    public class LoanBook
    {
        public int LoanId { get; set; }
        public Loan Loan { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }

    }
}
