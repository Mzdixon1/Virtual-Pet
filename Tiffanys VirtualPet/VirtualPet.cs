using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiffanys_VirtualPet
{
    public class VirtualPet
    {
        //Called methods ints
        private int petfood;
        private int petthirst;
        private int petplay;


        public int petFood

        {
            get { return petfood; }
            set { this.petfood = value; }
        }

        public int petThirst

        {
            get { return petthirst; }
            set { this.petthirst = value; }
        }
        public int petPlay
        {
            get { return petplay; }
            set { this.petplay = value; }
        }



        public VirtualPet()

        {
            petfood = 7;
            petthirst = 7;
            petplay = 7;
        }
        public void status()
        {

            Console.WriteLine("hunger: " + petFood + "\nthirst: " + petThirst + "\nboredom: " + petPlay);
            Console.WriteLine("\nWhat would like to do?");
            Console.WriteLine("to feed your gremlin type 1 ");
            Console.WriteLine("to hydrate your gremline type 2 ");
            Console.WriteLine("to play with your gremlin type 3, remember he does not like lights so only bring him out to play at night");

        }
        public void feed()
        {
            if (petfood == 0)
            {
                Console.WriteLine("not very hungry");
            }
            else
            {
                petfood = (petfood - 1);
                
            }
              }
        public void thirst()
        {
            if (petthirst == 0)
            {
                Console.WriteLine("not very thirsty");
                
            }
            else
            {
                petthirst = (petthirst - 1);
            }
        }
        public void play()
        {
            if (petplay == 0) 
            {
                Console.WriteLine("not in a playful mood");
                
            }
            else
            {
                petplay = (petplay - 1);

            }
        }
       
    }

}
