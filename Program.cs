using asymmetricEncryption.message;
using asymmetricEncryption.privateKey;
using asymmetricEncryption.publickey;
using System;
using System.Diagnostics;

namespace asymmetricEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            PrivateKey privateKey = new PrivateKey();
            PrivateKeySetter privateKeySetter = new PrivateKeySetter();
            PublicKey publicKey = new PublicKey();
            PublicKeyGenerator publicKeyGenerator = new PublicKeyGenerator();
            Message message = new Message();

            message.print();

            /** set the private key */
            privateKey.PrivateKeyContent = privateKeySetter.askPrivateKey();
            Debug.WriteLine("|- private key:" + privateKey.PrivateKeyContent);

            /** generate the public key */
            publicKey.PublicKeyContent = publicKeyGenerator.generate();
        }
    }
}
