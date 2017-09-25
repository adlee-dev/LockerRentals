using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LockerRentals
{
    public class Renter
    {
        public string PatronID { get; }
        public string Barcode { get; }
        public DateTime ExpirationDate { get; }
        public bool IsActive { get; }

        private string lastName;
        private string firstName;
        private string middleName;

        public string ShortName
        {
            get
            {
                return $"{firstName} {lastName}";
            }
        }

        public string LongName
        {
            get
            {
                return (middleName == null ? ShortName : $"{firstName} {middleName} {lastName}");
            }
        }

        public string DisplayName
        {
            get
            {
                return $"{lastName}, {firstName} {middleName}".Trim();
            }
        }

        public Renter(string patronID, string barcode, DateTime expirationDate, bool isActive, string lastName, string firstName, string middleName)
        {
            PatronID = patronID;
            Barcode = barcode;
            ExpirationDate = expirationDate;
            IsActive = isActive;
            this.lastName = lastName;
            this.firstName = firstName;
            this.middleName = middleName;
        }
    }
}
