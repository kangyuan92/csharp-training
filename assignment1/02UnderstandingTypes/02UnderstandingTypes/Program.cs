// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace _02UnderstandingTypes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(String.Format("Number of Bytes for sbyte: {0}, max value: {1}, min value: {2}", 1, 255, 0));
            Console.WriteLine(String.Format("Number of Bytes for byte: {0}, max value: {1}, min value: {2}", 1, 127, -128));
            Console.WriteLine(String.Format("Number of Bytes for short: {0}, max value: {1}, min value: {2}", 2, 32767, -32768));
            Console.WriteLine(String.Format("Number of Bytes for ushort: {0}, max value: {1}, min value: {2}", 2, 65525, 0));
            Console.WriteLine(String.Format("Number of Bytes for int: {0}, max value: {1}, min value: {2}", 4, 2147483647, -2147483648));
            Console.WriteLine(String.Format("Number of Bytes for unint: {0}, max value: {1}, min value: {2}", 4, "4,294,967,295", "0"));
            Console.WriteLine(String.Format("Number of Bytes for long: {0}, max value: {1}, min value: {2}", 8, "9,223,372,036,854,775,807", "-9,223,372,036,854,775,808"));
            Console.WriteLine(String.Format("Number of Bytes for ulong: {0}, max value: {1}, min value: {2}", 8, "18,446,744,073,709,551,615", "0"));
            Console.WriteLine(String.Format("Number of Bytes for float: {0}, max value: {1}, min value: {2}", 4, "3.402823e38", "-3.402823e38"));
            Console.WriteLine(String.Format("Number of Bytes for double: {0}, max value: {1}, min value: {2}", 8, "1.79769313486232e308", "-1.79769313486232e308"));
            Console.WriteLine(String.Format("Number of Bytes for decimal: {0}, max value: {1}, min value: {2}", 16, "7.9 x 10e28", "(+ or -)1.0 x 10e-28"));

            ConvertNumber convertNumber = new ConvertNumber();
            Console.WriteLine(convertNumber.convert(1));
            Console.WriteLine(convertNumber.convert(5));
        }

    }
}
