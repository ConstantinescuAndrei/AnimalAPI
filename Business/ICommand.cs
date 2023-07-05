namespace Business;

public interface ICommand<in TInput, out TOutput>
{
    public TOutput Execute(TInput input);
}

public interface ICommand<out TOutput>
{
    public TOutput Execute();
}