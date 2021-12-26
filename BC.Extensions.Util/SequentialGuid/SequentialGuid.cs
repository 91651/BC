using System;

namespace BC.Extensions.SequentialGuid
{
    public class Guid
    {
        public static SequentialGuidType sequentialGuidType = SequentialGuidType.SequentialAtEnd;
        public static System.Guid NewSequentialGuid()
        {
            return new SequentialGuidGenerator().Create(sequentialGuidType);
        }
    }
}
