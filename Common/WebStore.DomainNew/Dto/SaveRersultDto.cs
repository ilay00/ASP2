using System;
using System.Collections.Generic;
using System.Text;

namespace WebStore.DomainNew.Dto
{
   public class SaveRersultDto
    {
        public SaveRersultDto()
        { }
        public SaveRersultDto(bool isSuccess, string errorMessage)
        {
            IsSuccess = isSuccess;
            Errors = new List<string>
            {
                errorMessage
            };
        }

        public SaveRersultDto(bool isSuccess)
        {
            IsSuccess = isSuccess;
        }

        public bool IsSuccess { get; set; }
            public IEnumerable<string>Errors { get; set; }
    }
}
