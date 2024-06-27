﻿using HospitalManagementSystem.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Entity
{
    public class NameType
    {
        public int Id { get; set; }
        public string Type { get; set; }
    }

    public class ResNameType
    {
        public MessageEntity msgEntity { get; set; }
        public List<ResNameType> lstNameType { get; set; }
    }
}
