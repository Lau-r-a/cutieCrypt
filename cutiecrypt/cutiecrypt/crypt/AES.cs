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

    private byte[,] emptyBlock() {
        return new byte[,] {
            {0, 0, 0, 0},
            {0, 0, 0, 0},
            {0, 0, 0, 0},
            {0, 0, 0, 0}
        };
    }

    public List<byte[,]> toByteBlock(string plaintext) {

        byte[] byteArray = Encoding.UTF8.GetBytes(plaintext);
        List<byte[,]> result = new List<byte[,]>();

        int k = 0, n = 0;
        byte[,] block = emptyBlock();

        for(int i = 0; i < byteArray.Length; i ++) {

            byte b = byteArray[i];

            block[n, k] = b;
            Console.WriteLine("i: " + i + " n: " + n + " b: " + b);

            if(k < 3) {
                k ++;
            } else if (n <3) {
                n ++;
                k = 0;
            } else {
                //Block finished
                result.Add(block);
                k = 0;
                n = 0;
                block = emptyBlock();
            }

            if (i == byteArray.Length - 1) {
                //add last block
                result.Add(block);
            }
        }
        return result;
    }

    public string byteBlocktoString(List<byte[,]> blocks) {
        byte[] x = new byte[blocks.Count * 16];
        int k = 0;
        foreach(byte[,] block in blocks) {
            for(int i = 0; i < 4; i ++) {
                for(int n = 0; n < 4; n ++) {
                    //ignore zeroes
                    if (block[i, n] != 0) {
                        x[k] = block[i, n];
                        k++;
                    }
                }
            }
        }
        return System.Text.Encoding.UTF8.GetString(x);
    }

    public void printByteBlock(List<byte[,]> blocks) {
        Console.WriteLine("Byte-Blocks in List:");
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
