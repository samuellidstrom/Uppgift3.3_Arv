using System.Threading.Channels;

namespace Uppgift3._3_Arv
{
    internal class Wolf : Animal
    {
        public override void DoSound()
        {
            Console.WriteLine("Ahh-wooooooo!");
        }
        public double HowlLoudness { get; set; }
    }
}