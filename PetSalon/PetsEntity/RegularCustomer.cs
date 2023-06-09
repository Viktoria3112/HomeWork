using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsEntity
{
    public class RegularCustomer
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Номер телефона
        /// </summary>
        public long Number { get; set; }

        public ICollection<Person>? Persons { get; set; }
    }
}
