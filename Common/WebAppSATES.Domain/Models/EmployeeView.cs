﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppSATES.Domain.Entities.Base.Interfaces;

namespace WebAppSATES.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
       

        public string Patronymic { get; set; }
        public int Age { get; set; }
    }
}
