using System.Threading.Channels;

namespace Uppgift3._3_Arv
{
    internal class Flamingo : Bird
    {
        public override void DoSound()
        {
            Console.WriteLine("HOONK! HONK-GRUNT, GROWL!");
        }
        public double AmountOfPinkness { get; set; }
    }

}