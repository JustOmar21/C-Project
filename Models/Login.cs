using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Project.Models
{
    internal class Login
    {
        public required string Email { get; set; }
        public required string Type { get; set; }
        public required string Password { get; set; }

        //Add composite primary key { Email , Type } Status:Done
        //Remember when adding a new member to add his account email and type here
    }
}
