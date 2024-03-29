namespace kitties
{
    class Kitty
        //the class in which the object variables and method is contained.
    {
        public string name;
        public int age;
        public string mood;
        public string sex;
        //defining the variables for creating objects
        public void KittyTraits()
        {
            Console.WriteLine($"This kitty's name is {name}. They are a {age} year old {sex}. Currently, this kitty is in a {mood} mood.");
            //a command for each object to execute from the method "KittyTraits()" when an object is created.
        }
    }

    class Kittystatus
        //the class in which the objects are contained.
    {
        static void Main(string[] args)
            //the main method for the objects.
        {
            Kitty kitty1 = new Kitty();
            //the first object created in the Class Kitty, named kitty1, with the executing code syntax defining it as an object. (new Kitty();)
            kitty1.name = "Amber";
            kitty1.age = 5;
            kitty1.mood = "Happy";
            kitty1.sex = "Boy";
            //assigning traits to the object defined by the variables in the class Kitty().
            kitty1.KittyTraits();
            //executing the KittyTraits() method using the variables defined with the object kitty1, printing the message into the console.

            Kitty kitty2 = new Kitty();
            kitty2.name = "Ginger";
            kitty2.age = 2;
            kitty2.mood = "Sassy";
            kitty2.sex = "Boy";
            kitty2.KittyTraits();
            //same as kitty 1, just with different variables.

            Kitty kitty3 = new Kitty();
            kitty3.name = "Aqua";
            kitty3.age = kitty1.age + 2;
            //this takes kitty1's age and adds 2 to it, defining kitty 3's age with the result.
            kitty3.mood = "Sleepy";
            kitty3.sex = "Girl";
            kitty3.KittyTraits();
            //same as kitty 1 and 2, with different variables.

            int agechange = 3;
            int agetotal = kitty1.age + agechange;
            //this int takes kitty 1's age and adds agechange to it.
            kitty1.age = agetotal;
            //kitty1 does not need to be redefined as an object, as it is already in the system's memory. changing a variable down here will alter its present variables.
            Console.WriteLine($"{kitty1.name} would be {kitty1.age} if we added {agechange} years to thier current age.");
            //this reprints kitty1's name and gives it its new age defined above, using the variable agechange to tell how much it has changed by.

            Console.WriteLine($"Just kidding. {kitty1.name} is actually named Maurice.");
            //This line uses kitty1's name and renames them maurice, but only superficially, kitty1's name is still the same as its variable.
        }
    }
}