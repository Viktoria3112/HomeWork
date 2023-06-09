using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsEntity
{
    public class Worker
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// Имя работника
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Стаж работы
        /// </summary>
        public int Experience { get; set; }
        /// <summary>
        /// Номер телефона
        /// </summary>
        public long Number { get; set; }
        /// <summary>
        /// Зарплата
        /// </summary>
        public long Salary { get; set; }

        public ICollection<Service>? Services { get; set; }
    }
}
