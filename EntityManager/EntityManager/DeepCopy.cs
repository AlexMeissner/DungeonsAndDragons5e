using System;
using System.IO;
using System.Xml.Serialization;

namespace EntityManager
{
    public static class DeepCopy
    {
        public static T? Create<T>(T original) where T : class
        {
            if (original == null)
            {
                throw new ArgumentNullException(nameof(original));
            }

            using var memoryStream = new MemoryStream();
            XmlSerializer serializer = new(original.GetType());
            serializer.Serialize(memoryStream, original);
            memoryStream.Seek(0, SeekOrigin.Begin);
            return serializer.Deserialize(memoryStream) as T;
        }
    }
}