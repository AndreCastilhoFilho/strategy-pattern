using System;

namespace WebApplication1
{
    public interface IGenericStrategy
    {
        Type Type { get; }
        string Executa(object obj);
    }
}
