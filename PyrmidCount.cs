﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public static class PyramidCount
    {
        public static int Count(int n)
        {
            return (((n * n + 1 * n + 2) / 6));
        }
    }
}
