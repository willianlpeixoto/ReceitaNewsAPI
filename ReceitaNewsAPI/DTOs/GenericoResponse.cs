using System.Dynamic;
using System.Net;

namespace ReceitaNewsAPI.DTOs
{
    public class GenericoResponse<T> where T : class
    {

        public HttpStatusCode CodHttp { get; set; }
        public T DadosRetorno { get; set; }
        public ExpandoObject ErroRetorno {  get; set; } 

    }

}
