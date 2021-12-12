using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Core_Test.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string NameRole { get; set; }

        public List<Person> Persons { get; set; } // навигационное свойство
    }
}
