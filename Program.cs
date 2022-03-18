using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu\n1-Send message by email\n2-Send message by sms\n0-Quit");
            string CommandStr = Console.ReadLine();          
            switch (CommandStr)
            {
                case "1":
                    EmailSender emailSender = new EmailSender();
                    emailSender.SendMessage();
                    break; 
                case "2" :
                    SmsSender smsSender = new SmsSender();
                    smsSender.SendMessage();
                    break;
                case "0":
                    Console.WriteLine("Quit");
                    break;
                default:
                    Console.WriteLine("Wrong Command");
                    break; 
            }
        }
    }
}
