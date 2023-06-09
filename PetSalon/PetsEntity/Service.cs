using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsEntity
{
    public class Service
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// Название услуги
        /// </summary>
        public string? ServiceName { get; set; }
        /// <summary>
        /// Цена 
        /// </summary>
        public long Price { get; set; }
        /// <summary>
        /// Длительность услуги
        /// </summary>
        public int Time { get; set; }

        public ICollection<Animal>? Animals { get; set; }
        /// <summary>
        /// Идентификатор работника
        /// </summary>
        public long WorkerId { get; set; }
        /// <summary>
        /// Работник
        /// </summary>
        public Worker? Worker { get; set; }
    }
}
    

