using System;

class Program
{
    static void Main()
    {
        SByte a = 0;
        Byte b = 0;
        Int16 c = 0;
        Int32 d = 0;
        Int64 e = 0;
        string s = "";
        Exception ex = new Exception();

        object[] types = { a, b, c, d, e, s, ex };

        foreach (object item in types)
        {
            string str;
            if (item.GetType().IsValueType) str = "value type";
            else str = "reference Type";
            Console.WriteLine($"{item.GetType()} {str}");
        }
    }
}