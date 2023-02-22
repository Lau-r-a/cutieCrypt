using System;
using Crypt;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Laura ist süß");
        Console.WriteLine("Nikki ist süß <3");

        AES aes = new AES();
        List<byte[,]> blocks = aes.toByteBlock("Nikki ist giga süß <3");
        aes.printByteBlock(blocks);
        Console.WriteLine(aes.byteBlocktoString(blocks));
    }
}
