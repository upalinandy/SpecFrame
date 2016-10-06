using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFrame.CustomExceptions
{
    public class NoDriverFound : Exception
    {
        public NoDriverFound(string msg) : base(msg)
        {

        }
    }
}
