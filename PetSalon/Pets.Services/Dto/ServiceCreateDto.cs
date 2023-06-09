using Pets.Services.Mapper;
using PetsEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets.Services.Dto
{
    public class ServiceCreateDto : IMapTo<Service> 
    {
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

        public WorkerDto? Worker { get; set; }
    }
}
