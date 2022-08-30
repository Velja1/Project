using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entities
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string RoleID { get; set; }
    }
}
