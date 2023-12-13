namespace assignment_6
{
    public class Program
    {
        interface Strategy //Strategy interface
        {
            public string move();
        }
        class Fly : Strategy
        {
            public Fly() { }          
            public string move() => "*FLIES BY FLAPS WINGS*";
        }
        class Slide: Strategy
        {
            public Slide() { }
            public string move() => "*SLIDES BY ITS BELLY*";     
        }
        class Hide_Head : Strategy
        {
            public Hide_Head() { }
            public string move() => "*HIDES HEAD IN THE SAND AS IT CANNOT FLY*";
        }
        class Float : Strategy
        {
            public Float() { }
            public string move() => "*FLOATS IN WATER*";
        }

        class Bird // Context class
        {
            public string name;
            public Strategy behavior_strategy;
            public Bird(string Name, Strategy strategy) 
            { 
                name = Name;
                behavior_strategy = strategy;
            }
            public string behave() => behavior_strategy.move();
            public void set_strategy(Strategy strategy) => this.behavior_strategy = strategy;      
            
        }

        static void Main(string[] args)
        {
            Strategy fly = new Fly();
            Strategy slide = new Slide();
            Strategy hide_head = new Hide_Head();
            Strategy float_on_water = new Float();

            List<Bird> birds = new List<Bird>() {
                new Bird("Mallard Duck", fly),
                new Bird("Emperor penguin", slide),
                new Bird("Bald Eagle", fly),
                new Bird("Ostrich", hide_head),
                new Bird("Yellow Rubber Duck", float_on_water)
            };
            Console.WriteLine("Number of birds in the simulation: {0}", birds.Count);
            foreach (Bird bird in birds)
            {
                Console.WriteLine("Here is the " + bird.name + "'s movement behavior: " + bird.behave());
            }
        }
    }
}
