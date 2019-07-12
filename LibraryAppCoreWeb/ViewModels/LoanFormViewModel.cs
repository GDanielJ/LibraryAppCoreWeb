using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryAppCoreWeb.Models;

namespace LibraryAppCoreWeb.ViewModels
{
    public class LoanFormViewModel
    {
        public int? Id { get; set; }
        public Member Member { get; set; }
        public ICollection<LoanBook> LoanBooks { get; set; }
        public DateTime? CheckOutDate { get; set; }
        public DateTime? DueDate { get; set; }
        public IEnumerable<Book> Books { get; set; }
        public string Title
        {
            get
            {
                return Id != 0 ? "Edit loan" : "New loan";
            }
        }

        public LoanFormViewModel()
        {
            Id = 0;
        }

        public LoanFormViewModel(Loan loan)
        {
            Id = loan.Id;
            CheckOutDate = loan.CheckOutDate;
            DueDate = loan.DueDate;
        }
    }
}
