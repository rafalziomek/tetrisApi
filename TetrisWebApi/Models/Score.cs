﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TetrisWebApi.Models
{
    public class Score
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public int UserId { get; set; }
    }
}
