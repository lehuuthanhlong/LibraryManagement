using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageLibraryApplication
{
    internal class BorrowerInformation
    {
        // Properties
        public int BorrowerID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string HomeAddress { get; set; }
        public DateTime DateOfBirth { get; set; }

        private List<BorrowerInformation> borrowerList = new List<BorrowerInformation>();

        public BorrowerInformation(int borrowerID, string fullName, string email, string homeAddress, DateTime dateOfBirth)
        {
            BorrowerID = borrowerID;
            FullName = fullName;
            Email = email;
            HomeAddress = homeAddress;
            DateOfBirth = dateOfBirth;
        }      
    }
}
