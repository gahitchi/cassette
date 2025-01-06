using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cassetta
{
    internal class Doc : OggSeg
    {
        override public float CalcValAss()
        {
            if (ValDic >= 100)
                return ValDic;
            else
                return 50;
        }
    }
}
