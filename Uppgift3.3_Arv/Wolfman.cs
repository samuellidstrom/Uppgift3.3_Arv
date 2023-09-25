using System.Threading.Channels;

namespace Uppgift3._3_Arv
{
    internal class Wolfman : Wolf, IPerson
    {
        public override void DoSound()
        {
            Console.WriteLine("Hello, there.. Oh! I'ts a full mooooOOOOON-AHwooooooo!");
        }
        public void Talk()
        {
            Console.WriteLine("Nice moon out today..!");
        }
        public int PeopleEaten { get; set; }
    }
}