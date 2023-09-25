using System.Threading.Channels;

namespace Uppgift3._3_Arv
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public string Weight { get; set;}
        public string Age { get; set; }

        public abstract void DoSound();
        public Animal()
        {
            
        }

    }

    

}