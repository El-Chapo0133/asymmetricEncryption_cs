using System;

namespace asymmetricEncryption.message
{
    class Message
    {
        private string message = "Hello World!";
        string MessageContent
        {
            get { return message;  }
        }
        public void print()
        {
            Console.WriteLine("===========================");
            Console.WriteLine("= The message is : ========");
            Console.WriteLine("= " + message);
        }
    }
}
