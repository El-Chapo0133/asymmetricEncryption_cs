using asymmetricEncryption.message;
using asymmetricEncryption.privateKey;
using asymmetricEncryption.publickey;
using asymmetricEncryption.engines.hash;
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
            Hash hashEngine = new Hash();

            /** set the private key */
            privateKey.PrivateKeyContent = privateKeySetter.askPrivateKey();
            Debug.WriteLine("|- private key:" + privateKey.PrivateKeyContent);

            Hash_Return hash = hashEngine.getHash(privateKey.PrivateKeyContent);

            Debug.WriteLine("hash private key:" + hash.Hash);
            message.print(hash.Hash, "private key hash");

            /** generate the public key */
            publicKey.PublicKeyContent = publicKeyGenerator.generate();
        }
    }
}
