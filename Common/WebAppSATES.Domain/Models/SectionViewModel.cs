using System.Collections.Generic;
using WebAppSATES.Domain.Entities.Base.Interfaces;

namespace WebAppSATES.Models
{
    public class SectionModel : INamedEntity, IOrderedEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }

        public List<SectionModel> ChildSections { get; set; } = new List<SectionModel>();

        public SectionModel ParentSection { get; set; }
    }
}
