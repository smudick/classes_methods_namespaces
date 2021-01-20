using System;
using ThePetStore.Pets;

namespace ThePetStore
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Turtle turtle1 = new Turtle("Mertle", 72);

            //turtle1.Eat("Lettuce");
            //turtle1.Eat("Lettuce");
            //turtle1.ShowTime("werewolf bar mitzvah");

            Scorpion scorpion = new Scorpion("Steven");
            scorpion.Attack();

        }
    }
}
