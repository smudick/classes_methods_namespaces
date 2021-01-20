using System;
using System.Collections.Generic;
using System.Text;

namespace ThePetStore.Pets
{
    class Turtle
    {
        //Properties - externally consumable things
        public string Name {get; set;}
        public string Size { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }

        //Fields - internal private things
        private bool _isHungry = true;

        //Constructor
        public Turtle(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine($"This turtle's name is {Name} and its age is {age}.");
        }

        //Method
        public void Eat(string foodType)
        {
            if (_isHungry)
            {
                Console.WriteLine($"The turtle takes a bite of the {foodType}");
                _isHungry = false;
            }
            else
            {
                Console.WriteLine("The turtle sticks its nose up at the food.");
            }
        }
        public void ShowTime(string occasion)
        {
            if (occasion != null)
            {
                Console.WriteLine($"It is a {occasion}!");
            }
            else
            {
                Console.WriteLine("No occasion...");
            }
            DressUp("tie");
        }
        //method overloading
        public void Eat()
        {
            Eat("pellets");
        }

        private void DressUp(string clothing)
        {
            Console.WriteLine($"The turtle is wearing a {clothing}");
        }

    }

}
