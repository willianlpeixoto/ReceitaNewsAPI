using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ReceitaNewsAPI.DTOs;
using ReceitaNewsAPI.Models;

namespace ReceitaNewsAPI
{
    public class ReceitaNewsRest
    {

        public async Task<GenericoResponse<CNPJModel>> BuscarCNPJ(string sCNPJ)
        {

            var request = new HttpRequestMessage(HttpMethod.Get, "https://receitaws.com.br/v1/cnpj/" + sCNPJ );
            var response = new GenericoResponse<CNPJModel>();

            using (var cliente = new HttpClient())
            {

                var resposta = await cliente.SendAsync(request);
                var ConteudoResposta = await resposta.Content.ReadAsStringAsync();
                var objResposta = JsonSerializer.Deserialize<CNPJModel>(ConteudoResposta);

                if (resposta.IsSuccessStatusCode)
                {

                    response.CodHttp = resposta.StatusCode;
                    response.DadosRetorno = objResposta;

                }
                else
                {

                    response.CodHttp = resposta.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(ConteudoResposta);

                }

            }

            return response;

        }


    }
}
