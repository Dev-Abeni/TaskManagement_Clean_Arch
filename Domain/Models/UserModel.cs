﻿using Domain.Seeds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public  class UserModel : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName  { get; set; }
        public string Email { get; set; }
    }
}
