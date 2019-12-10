using System.ComponentModel.DataAnnotations;
using WebAppSATES.Domain.Entities.Base.Interfaces;

namespace WebAppSATES.Domain.Entities.Base
{
    /// <summary>Именованная сущность</summary>
    public abstract class NamedEntity : BaseEntity, INamedEntity
    {
        [Required]
        public string Name { get; set; }
    }
}