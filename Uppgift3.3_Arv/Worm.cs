using System.Threading.Channels;

namespace Uppgift3._3_Arv
{
    internal class Worm : Animal
    {
        public override void DoSound()
        {
            Console.WriteLine("Plopp.. plopp, plopp.");
        }
        public double Bendiness { get; set; }
    }    
}