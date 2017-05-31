﻿using SecondExercise.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondExercise.Prototype
{
    public class GramophonePlayerPrototype : GramophonePlayer, ICloneable
    {
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
