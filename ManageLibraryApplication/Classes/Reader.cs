using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageLibraryApplication
{
    internal class ReaderInformation 
    {
        public string ReaderName { get; set; }
        public string ReaderAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }

        private List<ReaderInformation> readerList = new List<ReaderInformation>();
        public ReaderInformation(string readerName, string readerAddress, string phoneNumber, string emailAddress)
        {
            ReaderName = readerName;
            ReaderAddress = readerAddress;
            PhoneNumber = phoneNumber;
            EmailAddress = emailAddress;
        }
       
    }
}

