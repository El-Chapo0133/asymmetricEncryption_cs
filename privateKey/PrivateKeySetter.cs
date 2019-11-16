using System;

namespace asymmetricEncryption.privateKey
{
    class PrivateKeySetter
    {
        public string askPrivateKey()
        {
            printMessageStart();
            string privateKey = Console.ReadLine();
            printMessageEnd();
            return privateKey;
        }
        private void printMessageStart()
        {
            Console.WriteLine("===========================");
            Console.WriteLine("= What is you private key ?");
            Console.Write("= : ");
        }
        private void printMessageEnd()
        {
            Console.WriteLine("= Your private key has been setted");
            Console.WriteLine("===========================");
        }
    }
}
