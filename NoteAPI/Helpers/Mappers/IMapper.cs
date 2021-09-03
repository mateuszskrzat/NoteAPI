namespace NoteAPI.Helpers.Mappers
{
    public interface IMapper<TSource, TResult> where TResult : new()
    {
        TResult Map(TSource source);
    }
}