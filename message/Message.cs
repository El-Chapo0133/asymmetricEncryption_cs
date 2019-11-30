using System;

namespace asymmetricEncryption.message
{
    class Message
    {
        private string oldMessage;
        public string OldMessage
        {
            get { return oldMessage; }
        }
        public void print(string message, string title)
        {
            this.oldMessage = message;
            Console.WriteLine("===========================");
            Console.WriteLine("=" + generateTitle(title) + "=");
            Console.WriteLine("= " + message);
        }
        private string generateTitle(string title)
        {
            string return_title;
            string defaultTitle = "                         ";
            int titleLength = title.Length, maxLength = defaultTitle.Length;
            if (titleLength < maxLength)
                return_title = title + defaultTitle.Substring(0, Math.Abs(titleLength - maxLength));
            else
                return_title = title;
            return return_title;
        }
    }
}
