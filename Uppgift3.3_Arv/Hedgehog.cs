using System.Threading.Channels;

namespace Uppgift3._3_Arv
{
    internal class Hedgehog : Animal
    {
        public override void DoSound()
        {
            Console.WriteLine("Gruff... Gruff... Sniff, sniff.");
        }
        public double NrOfSpikes { get; set; }
    }

}