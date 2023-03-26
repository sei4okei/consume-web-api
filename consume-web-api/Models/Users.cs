using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consume_web_api.Models
{
    internal class Users
    {
        public int Id { get; set; }
        public string surname { get; set; }
        public string name { get; set; }
        public string patronymic { get; set; }
        public string login { get; set; }
        public string password { get; set; }
    }
}
