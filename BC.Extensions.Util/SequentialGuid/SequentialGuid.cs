using System;

namespace BC.Extensions.SequentialGuid
{
    public class SequentialGuid
    {
        public static SequentialGuidType SequentialGuidType = SequentialGuidType.SequentialAtEnd;
        public static System.Guid NewGuid()
        {
            return new SequentialGuidGenerator().Create(SequentialGuidType);
        }
    }
}
