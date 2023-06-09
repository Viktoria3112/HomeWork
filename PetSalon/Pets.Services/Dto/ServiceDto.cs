using Pets.Services.Mapper;
using PetsEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets.Services.Dto
{
    public class ServiceDto : IMapFrom<Service>
    {
        // <summary>
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

        public WorkerDto? Worker { get; set; }
    }
}
