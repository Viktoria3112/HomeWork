using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets.Services.Dto
{
    public class PersonCreateDto
    {
        public string? Name { get; set; }
        /// <summary>
        /// Номер телефона
        /// </summary>
        public long Number { get; set; }

        public RegularCustomerDto? RegularCustomer { get; set; }
    }
}
