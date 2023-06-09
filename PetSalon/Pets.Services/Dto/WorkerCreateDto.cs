using Pets.Services.Mapper;
using PetsEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets.Services.Dto
{
    public class WorkerCreateDto : IMapTo<Worker>
    {
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

    }
}

