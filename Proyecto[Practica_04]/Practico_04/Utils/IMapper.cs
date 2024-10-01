namespace Practico_04.Utils
{
    public interface IMapper<Input, Output>
    {
        Output Set(Input entity);
        List<Output> Set(List<Input> entity);
        Input Get(Output entity);
        List<Input> Get(List<Output> entity);
    }
}
