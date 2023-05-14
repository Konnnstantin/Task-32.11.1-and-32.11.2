using System;

namespace MvcStartApp.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }    
        public string LastName { get; set; }
        public DateTime JoinDate { get; set; }
    }
}
