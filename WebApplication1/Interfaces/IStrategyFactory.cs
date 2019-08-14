namespace WebApplication1
{
    public interface IStrategyFactory
    {

        IGenericStrategy GetStrategy(object T);
    }
}