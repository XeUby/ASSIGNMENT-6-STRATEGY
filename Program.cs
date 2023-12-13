namespace ASSIGNMENT-6-STRATEGY
{
    public class Program
    {
        // This is the interface for the movement strategies
        interface Strategy
        {
            // This method defines the movement behavior for each bird
            string move();
        }

        // This class represents the flying strategy
        class Fly : Strategy
        {
            // Constructor for the Fly class
            public Fly() { }

            // This method returns the movement behavior for flying birds
            public override string move() => "*FLIES BY FLAPS WINGS*";
        }

        // This class represents the sliding strategy
        class Slide : Strategy
        {
            // Constructor for the Slide class
            public Slide() { }

            // This method returns the movement behavior for sliding birds
            public override string move() => "*SLIDES BY ITS BELLY*";
        }

        // This class represents the hiding strategy
        class Hide_Head : Strategy
        {
            // Constructor for the Hide_Head class
            public Hide_Head() { }

            // This method returns the movement behavior for birds that hide in the sand
            public override string move() => "*HIDES HEAD IN THE SAND AS IT CANNOT FLY*";
        }

        // This class represents the floating strategy
        class Float : Strategy
        {
            // Constructor for the Float class
            public Float() { }

            // This method returns the movement behavior for birds that float in water
            public override string move() => "*FLOATS IN WATER*";
        }

        // This class represents the bird object
        class Bird
        {
            // This field stores the bird's name
            public string name;

            // This field stores the bird's movement strategy
            public Strategy behavior_strategy;

            // Constructor for the Bird class
            public Bird(string Name, Strategy strategy)
            {
                // Assign the bird's name
                this.name = Name;

                // Assign the bird's movement strategy
                this.behavior_strategy = strategy;
            }

            // This method returns the behavior of the bird
            public string behave() => behavior_strategy.move();

            // This method sets the bird's movement strategy
            public void set_strategy(Strategy strategy) => this.behavior_strategy = strategy;
        }

        static void Main(string[] args)
        {
            // Create instances of each movement strategy
            Strategy fly = new Fly();
            Strategy slide = new Slide();
            Strategy hide_head = new Hide_Head();
            Strategy float_on_water = new Float();

            // Create a list of birds with different movement strategies
            List<Bird> birds = new List<Bird>()
            {
                new Bird("Mallard Duck", fly),
                new Bird("Emperor penguin", slide),
                new Bird("Bald Eagle", fly),
                new Bird("Ostrich", hide_head),
                new Bird("Yellow Rubber Duck", float_on_water)
            };

            // Print the total number of birds in the simulation
            Console.WriteLine("Number of birds in the simulation: {0}", birds.Count);

            // Iterate through each bird and print its movement behavior
            foreach (Bird bird in birds)
            {
                Console.WriteLine("Here is the " + bird.name + "'s movement behavior: " + bird.behave());
            }
        }
    }
}
