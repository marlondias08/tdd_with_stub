using Boliche.Api;
using System.Threading.Tasks;

namespace BolicheTestes
{
    public class StubPontuaDeUmJogoSimples : IBolicheApi
    {
        public Task<ArremessosResponse> ObterArremessos()
        {
            ArremessosResponse resposta = new ArremessosResponse()
            {
                Arremessos = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0 }
            };
            return Task.FromResult<ArremessosResponse>(resposta);
        }
    }
}