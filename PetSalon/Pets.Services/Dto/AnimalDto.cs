using Pets.Services.Mapper;
using PetsEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets.Services.Dto
{
    public class AnimalDto : IMapFrom<Animal>
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

        public PersonDto? Person { get; set; }
    }
}
