using System;
using System.IO;

namespace WebApplication1
{
    public class UploadStrategy : IGenericStrategy
    {
        public Type Type => typeof(double);

        public string Executa(object obj)
        {
            var file = (double)obj;

            return "foi upload";
        }
    }
}
