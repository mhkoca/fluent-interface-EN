using System;

namespace FluentInterfaceConsole
{
    public class CowMilkerNew :  IAfterTakeBucket, IAfterImmobilize, IAfterGiveFood, IMilk
    {
        public IAfterImmobilize Immobilize()
        {
            Console.WriteLine("Cow binded");
            return this;
        }

        public IAfterGiveFood GiveFood()
        {
            Console.WriteLine("Weed was gave");
            return this;
        }

        public IAfterTakeBucket TakeBucket()
        {
            Console.WriteLine("Bucket was taken");
            return this;
        }       

        public void Milk()
        {
            Console.WriteLine("Cow milked");
        }
    }
}
