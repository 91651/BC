using System;
using System.Security.Cryptography;

namespace BC.Extensions.SequentialGuid
{
    public class SequentialGuidGenerator
    {
        public Guid Create(SequentialGuidType guidType)
        {
            var randomBytes = new byte[8];
            RandomNumberGenerator.Create().GetBytes(randomBytes);
            long timestamp = DateTime.UtcNow.Ticks;
            byte[] timestampBytes = BitConverter.GetBytes(timestamp);
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(timestampBytes);
            }
            byte[] guidBytes = new byte[16];

            switch (guidType)
            {
                case SequentialGuidType.SequentialAsString:
                case SequentialGuidType.SequentialAsBinary:
                    Buffer.BlockCopy(timestampBytes, 0, guidBytes, 0, 8);
                    Buffer.BlockCopy(randomBytes, 0, guidBytes, 8, 8);

                    if (guidType == SequentialGuidType.SequentialAsString && BitConverter.IsLittleEndian)
                    {
                        Array.Reverse(guidBytes, 0, 4);
                        Array.Reverse(guidBytes, 4, 2);
                        Array.Reverse(guidBytes, 6, 2);
                    }

                    break;

                case SequentialGuidType.SequentialAtEnd:
                    Buffer.BlockCopy(randomBytes, 0, guidBytes, 0, 8);
                    Buffer.BlockCopy(timestampBytes, 6, guidBytes, 8, 2);
                    Buffer.BlockCopy(timestampBytes, 0, guidBytes, 10, 6);
                    break;
            }

            return new Guid(guidBytes);
        }
    }
}
