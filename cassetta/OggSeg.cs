using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cassetta
{
    internal class OggSeg
    {
        private float valDic;

        public float ValDic
        {
            get { return valDic; }
            set { valDic = value; }
        }

        virtual public float CalcValAss()
        {
            return ValDic;
        }
    }
}
