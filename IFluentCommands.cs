namespace FluentInterfaceConsole
{
    public interface IAfterImmobilize : IGiveFood, ITakeBucket
    {
    }
    public interface IAfterGiveFood : ITakeBucket
    {
    }
    public interface IAfterTakeBucket : IMilk
    {
    }
    public interface ICommands
    {
        IAfterImmobilize Immobilize();
    }
    public interface IGiveFood 
    {
        IAfterGiveFood GiveFood();
    }
    public interface ITakeBucket 
    {
        IAfterTakeBucket TakeBucket();
    }
    public interface IMilk
    {
        void Milk();
    }
}
