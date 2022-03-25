﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.Entities
{
    public class UserRole
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public User User { get; set; }

    }
}
