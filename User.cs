using System;
using SQLite;

namespace prototype
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int UserId{ get; set;}

		public string UserName{ get; set;}

		public string Password{ get; set;}

		public string Name{ get; set;}

		public string Street{ get; set;}

		public string Apartment{ get; set;}

		public string City{ get; set; }

		public string State{ get; set; }

		public int Zipcode{ get; set; }

		public int PhoneNo{ get; set; }

		public string Email{ get; set; }
    }
}
