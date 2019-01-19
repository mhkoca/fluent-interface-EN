namespace FluentInterfaceConsole
{
    public interface IMilker
    {
        IMilker Immobilize();

        IMilker GiveFood();

        IMilker TakeBucket();

        IMilker Milk();
    }
}
