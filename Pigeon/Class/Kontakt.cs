﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pigeon
{
    partial class Kontakt
    {
        public override string ToString()
        {
            return $"{this.Podmiot.Nazwa} - {this.Wartość}";
        }
    }
}
