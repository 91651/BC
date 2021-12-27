using BC.Extensions.Encode;
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
            var id = new SequentialIdGenerator().Create().ToString("X"); ;
            return id;
        }

        public static string NewId(bool isReadable = false)
        {
            var id = new SequentialIdGenerator().Create().ToBase32String(isReadable);
            return id;
        }
    }
}
