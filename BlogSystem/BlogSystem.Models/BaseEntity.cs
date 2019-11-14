﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSystem.Models
{
    public class BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime CreateTime { get; set; } = DateTime.Now;
        /// <summary>
        /// fake delete
        /// </summary>
        public bool IsRemoved { get; set; }
    }
}
