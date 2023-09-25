using System.Threading.Channels;

namespace Uppgift3._3_Arv
{
    internal class Horse : Animal
    {
        public override void DoSound()
        {
            Console.WriteLine("Hei-he-he-he-hou-hou-hu-huu-huuu! ...Pfrrrrrrr....");
        }
        public double HoofHardness { get; set; }

    }
}