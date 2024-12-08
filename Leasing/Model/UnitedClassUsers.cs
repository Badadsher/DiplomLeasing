﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leasing.Model
{
    public class UserView
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public long Number { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }
        public string Role { get; set; }
        public byte[] Photo { get; set; }
    }
}
