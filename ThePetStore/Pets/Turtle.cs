using System;
using System.Collections.Generic;
using System.Text;

namespace ThePetStore.Pets
{
    class Turtle
    {
        //Properties - externally consumable things

        //read only property  --  they can only be set once and in the constuctor/instantiaion process and no where else
        public string Name { get; } = "Yertle";  //instantiation
        public string Size { get; set; }

        //public property with a private setter
        public int Age { get; private set; }
        public string Color { get; set; }

        //read only property, but can only be calculated/derived, can't be set
        public string Description => $"{Age} year old {Size}, {Color} turtle.";

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
            if (occasion == "birthday")
            {
                Console.WriteLine($"{Name} is now {++Age} years old!");
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
