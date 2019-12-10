using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using WebAppSATES.Domain.Entities.Base;
using WebAppSATES.Domain.Entities.Base.Interfaces;

namespace WebAppSATES.Domain.Entities
{
    [Table("Sections")]
    public class Section : NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }

        public int? ParentId { get; set; }

        [ForeignKey(nameof(ParentId))]
        public virtual Section ParentSections { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}