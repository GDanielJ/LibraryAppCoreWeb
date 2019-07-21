using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using LibraryAppCoreWeb.Models;

namespace LibraryAppCoreWeb.ViewModels
{
    public class LoanFormViewModel
    {
        public int? Id { get; set; }

        public Member Member { get; set; }

        [Display(Name = "Id of member")]
        public int MemberId { get; set; }
        public DateTime? CheckOutDate { get; set; }
        public DateTime? DueDate { get; set; }

        [Display(Name = "Id of book")]
        public int BookId { get; set; }
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
