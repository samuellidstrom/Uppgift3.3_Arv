using System.Threading.Channels;

namespace Uppgift3._3_Arv
{
    internal class Bird : Animal
    {
        public override void DoSound()
        {
            Console.WriteLine("Kvitt! ... Kvitt kvitt, kvidderitt!");
        }
        public double WingSpan { get; set; }
    }



}