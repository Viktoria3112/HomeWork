using Pets.Services.Mapper;
using PetsEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets.Services.Dto
{
    public class AnimalCreateDto : IMapTo<Animal>
    {
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
        
    }
}
