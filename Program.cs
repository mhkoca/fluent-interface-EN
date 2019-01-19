using System;

namespace FluentInterfaceConsole
{
    public class Program
    {
        static void Main(string[] args) 
        {
            CowMilker cowMilker = new CowMilker();

            SheepMilker sheepMilker= new SheepMilker();
            CowMilkerNew cowMilkerNew = new CowMilkerNew();

            Console.WriteLine("New cow is going to be milking");
            cowMilkerNew.Immobilize().GiveFood().TakeBucket().Milk();

            Console.WriteLine("************");
            Console.WriteLine("Cow is going to be milking");
            cowMilker.Immobilize().GiveFood().TakeBucket().Milk();

            Console.WriteLine("************");
            Console.WriteLine("Sheep is going to be milking");
            sheepMilker.Immobilize().GiveFood().TakeBucket().Milk();

            Console.ReadLine();
        }
    }
}
