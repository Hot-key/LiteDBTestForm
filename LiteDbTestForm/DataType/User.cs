﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace LiteDbTestForm.DataType
{
    public class User
    {
        [BsonId]
        public string Id { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }
    }
}
