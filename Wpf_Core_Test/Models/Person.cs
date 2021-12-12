using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Core_Test.Models
{
    public class Person
    {
        public int Id { get; set; } // первичный ключ
        public string FirstName { get; set; } // имя
        public string LastName { get; set; } // фамилия
        public DateTime Birthday { get; set; } // дата рождения

        public int RoleId { get; set; } // внешний ключ
        public Role Role { get; set; } // навигационное свойство
    }
}
