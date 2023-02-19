namespace Crypt;

interface IAlgorithm {
    public string encrypt(string plaintext, string key);
    public string decrypt(string ciphertext, string key);
}