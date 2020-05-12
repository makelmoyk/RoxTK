using System;
using System.Collections.Generic;
using System.Text;

namespace RoxTK.Models
{
    public class User
    {
        public User()
        {
            DateCreated = DateTime.Now;
        }
        
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime DateCreated { get; set; }
        public Role Role { get; set; }
    }

    public enum Role
    {
       User,
       Admin,
    }
}
