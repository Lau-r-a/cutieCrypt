using System;
using Crypt;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Laura ist süß");
        Console.WriteLine("Nikki ist süß <3");

        AES aes = new AES();
        aes.toByteBlock("Nikki ist giga süß <3");
        aes.printByteBlock(aes.toByteBlock("Nikki ist giga süß <3"));
    }
}
