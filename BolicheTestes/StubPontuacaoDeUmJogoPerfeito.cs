using Boliche.Api;
using System.Threading.Tasks;

namespace BolicheTestes
{
    public class StubPontuacaoDeUmJogoPerfeito : IBolicheApi
    {
        public Task<ArremessosResponse> ObterArremessos()
        {
            ArremessosResponse resposta = new ArremessosResponse()
            {
                Arremessos = new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 0, 0, 0, 0, 0, 0, 0, 0 }
            };
            return Task.FromResult<ArremessosResponse>(resposta);
        }
    }
}