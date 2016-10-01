﻿using RiderPOC.Common.ObjectModel;

namespace RiderPOC
{
    public class User : IUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }
        public int Id { get; set; }
    }
}