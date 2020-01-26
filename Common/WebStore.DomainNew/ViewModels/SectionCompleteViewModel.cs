using System;
using System.Collections.Generic;
using System.Text;

namespace WebStore.DomainNew.ViewModels
{
    public class Section
    {
        public IEnumerable<SectionViewModel> Sections { get; set; }
        public int? CurrentParentSectionId { get; set; }
        public int? CurrentSectionId { get; set; }
    }
}