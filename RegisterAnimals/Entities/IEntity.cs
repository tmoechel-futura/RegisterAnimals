﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterAnimals.Entities
{
    internal interface IEntity
    {
        public Guid Id { get; set; }
    }
}
