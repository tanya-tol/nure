using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatStat_lb1
{
    public class Trebovanie : IComparable<Trebovanie>
    {
        public int kanal;

        public double t_postupleniya;

        public double r;

        public double t_obslugivania;

        public Trebovanie(double _t_postupleniya)
        {
            t_postupleniya = _t_postupleniya;
        }

        public int CompareTo(Trebovanie other)
        {
            if(this.kanal>other.kanal)
            {
                return 1;
            }
            if (this.kanal < other.kanal)
            {
                return -1;
            }
            else 
            {
                return 0;
            }
        }
    }
}
