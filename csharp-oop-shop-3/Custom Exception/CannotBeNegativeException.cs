using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_3.Custom_Exception
{
    public class CannotBeNegativeException:ArgumentOutOfRangeException
    {
        public CannotBeNegativeException(string paramName, string Message) : base(paramName, Message)
        { }
    }
}
