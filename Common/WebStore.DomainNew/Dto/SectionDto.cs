using System;
using System.Collections.Generic;
using System.Text;
using WebStore.DomainNew.Entities.Base.Interfaces;

namespace WebStore.DomainNew.Dto
{
    class SectionDto : INamedEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
