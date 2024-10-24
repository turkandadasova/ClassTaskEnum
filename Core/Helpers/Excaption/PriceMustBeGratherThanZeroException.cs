using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Helpers
{
    internal class PriceMustBeGratherThanZeroException:Exception
    {
        public PriceMustBeGratherThanZeroException()
        {
            
        }
        public PriceMustBeGratherThanZeroException(string mesage):base(mesage)
        {
            
        }
    }
}
