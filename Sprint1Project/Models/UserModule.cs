﻿using Microsoft.OData.Edm;

namespace Sprint1Project.Models
{
    public class UserModule
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
