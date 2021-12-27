using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.Extensions.SequentialId
{
    public class SequentialId
    {
        public static string NewId() {
            return new SequentialIdGenerator().Create();
        }
    }
}
