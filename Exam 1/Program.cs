using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ConsoleApplication
{
    public interface IWriter
    {
        void Write(string value);
    }

    public interface ITransform
    {
        string Apply(string value);
    }

    public class Writer : IWriter
    {
        public Writer(IEnumerable<ITransform> transforms)
        {
            Transforms = new List<ITransform>(transforms);
            Console.WriteLine(this);
        }
        
        public virtual void Write(string value)
        {
            foreach (var transform in Transforms)
            {
                value = transform.Apply(value);
            }
            Console.WriteLine(value);
        }

        public override string ToString()
        {
            string text = string.Empty;
            foreach (var transform in Transforms)
            {
                text = text + transform.ToString() + "-";
            }
            return text + "Writer";
        }

        private List<ITransform> Transforms;
    }

    public class EncryptingWriter : Writer
    {
        public EncryptingWriter(IEnumerable<ITransform> transforms)
            : base(transforms)
        {
            Debug.WriteLine(this);
        }
        
        public override void Write(string value)
        {
            base.Write(new string(value.Reverse().ToArray()));
        }

        public override string ToString()
        {
            return base.ToString() + "+Encryption";
        }
    }

    public abstract class Transform : ITransform
    {
        public abstract string Name { get; }
        public abstract string Apply(string value);

        public override string ToString()
        {
            return Name;
        }
    }
    

    public class UppercaseTransform : Transform
    {
        public override string Name { get { return "Upper"; } }

        public override string Apply(string value)
        {
            return value.ToUpper();
        }
    }

    public class CompressTransform : Transform
    {
        public override string Name { get { return "Compress"; } }

        public override string Apply(string value)
        {
            return value.Replace(" ", "");
        }

        public override string ToString()
        {
            return Name;
        }
    }
    
     




    
    

    public class Program
    { 
        public static void Main(string[] args)
        {
            var transforms = new List<ITransform>
            {
                new CompressTransform(),
                new UppercaseTransform(),
            };
            
            Writer writer = new EncryptingWriter(transforms); 
            writer.Write("Hello world");
        }
    }

    
}
