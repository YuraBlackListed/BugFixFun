﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ZelenskiyGame
{
    internal static class MathHelper
    {
        public static bool IsBetween(this float value, float min, float max)
        {
            return min <= value && value <= max;
        }
    }
}
