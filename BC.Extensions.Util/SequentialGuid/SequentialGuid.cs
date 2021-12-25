using System;

namespace BC.Extensions.SequentialGuid
{
    public static class SequentialGuid
    {
        public static SequentialGuidType sequentialGuidType = SequentialGuidType.SequentialAtEnd;
        public static Guid NewSequentialGuid(this Guid guid)
        {
            return new SequentialGuidGenerator().Create(sequentialGuidType);
        }
    }
}
