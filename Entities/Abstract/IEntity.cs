﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{

    public  interface IEntity
    {
        public int ID { get; set; } 
        public bool IsDeleted { get; set; } 


    }
}
