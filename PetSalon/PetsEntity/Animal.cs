using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsEntity
{
    public class Animal 
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// Вид животного
        /// </summary>
        public string? Spacies { get; set; }
        public string? Name { get; set; }
        /// <summary>
        /// Возраст
        /// </summary
        public int Age { get; set; }
        /// <summary>
        /// Идентификатор хозяина
        /// </summary>
        public long PersonalId { get; set; }
        /// <summary>
        /// Хозяин
        /// </summary>
        public Person? Person { get; set; }
        /// <summary>
        /// Идентификатор услуги
        /// </summary>
        public long ServiceId { get; set; }
        /// <summary>
        /// Услуга
        /// </summary>
        public Service? Service { get; set; }

    }
}
    

