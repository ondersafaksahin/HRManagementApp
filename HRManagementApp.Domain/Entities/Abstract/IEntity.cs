﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Domain.Entities.Abstract
{
    public interface IEntity<T>
    {
        public T ID { get; set; }
    }
}
