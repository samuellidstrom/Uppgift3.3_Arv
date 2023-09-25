using System.Threading.Channels;

namespace Uppgift3._3_Arv
{
    internal class Pelican : Bird
    {
        public override void DoSound()
        {
            Console.WriteLine("POP! POPPP! POP!!");
        }
        public double BeakPouchSize { get; set; }
    }



}