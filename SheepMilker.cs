using System;

namespace FluentInterfaceConsole
{
    public class SheepMilker : IMilker
    {
        public IMilker Immobilize()
        {
            Console.WriteLine("Sheep, taken to milking area");
            return this;
        }

        public IMilker GiveFood()
        {
            Console.WriteLine("Weed was gave");
            return this;
        }

        public IMilker TakeBucket()
        {
            Console.WriteLine("Bucket was taken");
            return this;
        }

        public IMilker Milk()
        {
            Console.WriteLine("Sheep milked");
            return this;
        }
    }
}
