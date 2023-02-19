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
        foreach(byte b in byteArray) {

            block[n, i] = b;

            if(i < 3) {
                i ++;
            } else if (n <3) {
                n ++;
                i = 0;
            } else {
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
        }
        return result;
    }
}
