using HEXConverter.lib;
class Program
{
    static void Main(string[] args) {
        Console.Write("Enter string value: ");
        var input = Console.ReadLine();
        HEX_DCWL.THEX(input);
        Console.WriteLine($"\nConverted to HEXADECIMAL: {HEX_DCWL.SHEX_}");
        Console.ReadKey();
    }
}