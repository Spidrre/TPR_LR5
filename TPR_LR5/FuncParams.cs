using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPR_LR5
{
    public class FuncParams
    {
        public int name;
        public double q;
        public double s;
        public bool rev = false;

        public FuncParams(string _s, string _name,  string _q, bool _f)
        {
            this.name = Convert.ToInt32(_name);
            if (String.IsNullOrEmpty(_s))
                this.s = 0.0;
            else
                this.s = Convert.ToDouble(_s);
            if (String.IsNullOrEmpty(_q))
                this.q = 0.0;
            else
                this.q = Convert.ToDouble(_q);
            rev = _f;

        }
    }
}
