﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_12_09
{
    internal class Clients
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Adress { get; set; }

        public string Email { get; set; }

        public List<Orders> Orders { get; set; } = new();

    }
}
