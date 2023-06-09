using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsEntity
{
    public class Person
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

        public ICollection<Animal>? Animals { get; set; }
        /// <summary>
        /// идентификатор постоянного клиента
        /// </summary>
        public long RegularCustomerId { get; set; }
        /// <summary>
        /// Постоянный клиент
        /// </summary>
        public RegularCustomer? RegularCustomer { get; set; }

    }
}
    

