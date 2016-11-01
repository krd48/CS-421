
using System;
using System.Text;
using System.Collections.Generic;

namespace MyApp
{
    public class JsonFormatter
    {
        private int indent = 0;
        private bool in_def = false; 
        private StringBuilder sb = new StringBuilder();

        public bool Pretty { get; set; }

        internal void Write(JValue obj)
        {
            switch (obj.Type)
            {
                case JType.Null:
                    WriteNull();
                    break;
                case JType.Bool:
                    WriteBool(obj.Bool);
                    break;
                case JType.Number:
                    WriteNumber(obj.Number);
                    break;
                case JType.String:
                    WriteString(obj.String);
                    break;
                case JType.Array:
                    WriteArray(obj.Array);
                    break;
                case JType.Object:
                    WriteObject(obj.Object);
                    break;
                case JType.Blob:
                    WriteBlob(obj.Blob);
                    break;
                default:
                    break;
            }
        }

        internal void WriteNull()
        {
            if (Pretty)
            {
                if (!in_def)
                {
                    Indent();
                }
            }

            sb.Append("null");

            in_def = false;
        }
        
        internal void WriteBool(bool value)
        {
            if (Pretty)
            {
                if (!in_def)
                {
                    Indent();
                }
            }

            sb.Append(value ? "true" : "false");

            in_def = false;
        }

        internal void WriteNumber(double value)
        {
            if (Pretty)
            {
                if (!in_def)
                {
                    Indent();
                }
            }

            sb.Append(value);

            in_def = false;
        }
        
        internal void WriteString(string value)
        {
            if (Pretty)
            {
                if (!in_def)
                {
                    Indent();
                }
            }

            sb.Append('"');
            sb.Append(value);
            sb.Append('"');

            in_def = false;
        }

        internal void WriteArray(List<JValue> values)
        {
            if (Pretty)
            {
                if (!in_def)
                {
                    Indent();
                }
            }

            in_def = false;

            sb.Append('[');
            indent++;
            foreach (var value in values)
            {
                sb.Append(value);
            }
            indent--;
            sb.Append(']');

            in_def = false;
        }

        internal void WriteObject(Dictionary<string, JValue> values)
        {
            if (Pretty)
            {
                if (!in_def)
                {
                    Indent();
                }
            }

            sb.Append('[');
            indent++;
            foreach (var pair in values)
            {
                in_def = false;
                sb.Append('"');
                sb.Append(pair.Key);
                sb.Append("\": ");
                
                in_def = true;
                Write(pair.Value);
            }
            indent--;
            sb.Append(']');
        }

        internal void WriteBlob(byte[] blob)
        {
            if (Pretty)
            {
                if (!in_def)
                {
                    Indent();
                }
            }

            sb.Append('"');
            sb.Append(System.Convert.ToBase64String(blob));
            sb.Append('"');

            in_def = false;
        }

        private void Indent()
        {
            for (int i = 0; i < indent; i++)
            {
                sb.Append("  ");
            }
        }

        public override string ToString()
        {
            return sb.ToString();
        }

    }

}