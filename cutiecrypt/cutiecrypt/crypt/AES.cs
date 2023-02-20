namespace Crypt;

using System.Text;

class AES : IAlgorithm {
    public AES() {
        //todo
    }

    public string encrypt(string plaintext, string key) {
        return "";
    }

    public string decrypt(string ciphertext, string key) {
        return "";
    }

    public List<byte[,]> toByteBlock(string plaintext) {
        byte[] byteArray = Encoding.UTF8.GetBytes(plaintext);
        List<byte[,]> result = new List<byte[,]>();
        int i = 0, n = 0;
        byte[,] block = new byte[,] {
            {0, 0, 0, 0},
            {0, 0, 0, 0},
            {0, 0, 0, 0},
            {0, 0, 0, 0}
        };
        for(int k = 0; k < byteArray.Length; k ++) {

            byte b = byteArray[k];

            block[n, i] = b;
            Console.WriteLine("i: " + i + " n: " + n + " b: " + b);

            if(i < 3) {
                i ++;
            } else if (i == 3 && n <3) {
                n ++;
                i = 0;
            } else {
                Console.WriteLine("Block fertig");
                result.Add(block);
                i = 0;
                n = 0;
                block = new byte[,] {
                    {0, 0, 0, 0},
                    {0, 0, 0, 0},
                    {0, 0, 0, 0},
                    {0, 0, 0, 0}
                };
            }

            if (k == byteArray.Length - 1) {
                Console.WriteLine("Block fertig");
                result.Add(block);
            }
        }
        return result;
    }

    public void printByteBlock(List<byte[,]> blocks) {
        foreach(byte[,] block in blocks) {
            for(int i = 0; i < 4; i ++) {
                for(int n = 0; n < 4; n ++) {
                    Console.Write(block[i, n] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
