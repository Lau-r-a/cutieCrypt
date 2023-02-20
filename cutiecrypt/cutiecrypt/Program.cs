using System;
using Crypt;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Laura ist süß");
        Console.WriteLine("Nikki ist süß <3");

        AES aes = new AES();
        aes.toByteBlock("Laura ist süß");
        aes.printByteBlock(aes.toByteBlock("Laura ist süß"));
    }
}
