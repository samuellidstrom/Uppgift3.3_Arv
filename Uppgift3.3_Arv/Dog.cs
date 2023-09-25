using System.Threading.Channels;

namespace Uppgift3._3_Arv
{
    internal class Dog : Animal
    {
        public override void DoSound()
        {
            Console.WriteLine("Voff. Vov-vov-voff!");
        }
        public double HatredOfCats { get; set; }

    }



}