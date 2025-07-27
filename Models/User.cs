using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pollkit_server.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string DateJoined { get; set; } = DateTime.Now.ToString("dd/MM/yyyy");
    }
}