using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoteAPI.Helpers.Mappers
{
    public abstract class Mapper<TSource, TResult> : IMapper<TSource, TResult> where TResult : new()
    {
        public abstract TResult Map(TSource source);
    }
}
