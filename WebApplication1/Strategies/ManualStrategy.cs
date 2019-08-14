using System;

namespace WebApplication1
{
    public class ManualStrategy : IGenericStrategy
    {
        public Type Type => typeof(string);



        public string Executa(object obj)
        {
            return (string)obj;
        }
    }
}
