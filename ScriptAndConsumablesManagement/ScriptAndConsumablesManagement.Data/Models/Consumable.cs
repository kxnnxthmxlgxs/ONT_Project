﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptAndConsumablesManagement.Data.Models
{
    public class Consumable
    {
        [Key]
        public int ConsumableID { get; set; }
        public string ConsumableName { get; set; }
    }
}
