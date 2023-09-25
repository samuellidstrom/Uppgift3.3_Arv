using System.Threading.Channels;

namespace Uppgift3._3_Arv
{
    internal class Swan : Bird
    {
        public override void DoSound()
        {
            Console.WriteLine("TUT! TUUUT!");
        }
        public double NeckBendiness { get; set; }
    }
}