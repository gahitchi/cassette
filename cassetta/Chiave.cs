using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cassetta
{
    internal class Chiave : OggSeg
    {
        override public float CalcValAss()
        {
            return ValDic * 1000;
        }
    }
}
