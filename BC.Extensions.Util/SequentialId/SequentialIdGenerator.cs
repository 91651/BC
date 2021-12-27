using BC.Extensions.Encode;
using System;

namespace BC.Extensions.SequentialId
{
    public class SequentialIdGenerator
    {
        public string Create()
        {
            var now = DateTime.UtcNow;
            var ticks = now.AddYears(-(now.Year - now.Year % 100)).Ticks / 100;
            return ticks.ToBase32String();
        }
    }
}
