using System;

namespace FluentInterfaceConsole
{
    public class CowMilker : IMilker
    {
        public IMilker Immobilize()
        {
            Console.WriteLine("Cow binded");
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
            Console.WriteLine("Cow milked");
            return this;
        }
    }
}
