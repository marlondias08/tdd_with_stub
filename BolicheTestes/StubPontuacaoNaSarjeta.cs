using Boliche.Api;
using System.Threading.Tasks;

namespace BolicheTestes
{
    internal class StubPontuacaoNaSarjeta : IBolicheApi
    {
        public Task<ArremessosResponse> ObterArremessos()
        {
            ArremessosResponse resposta = new ArremessosResponse()
            {
                Arremessos = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };
            return Task.FromResult<ArremessosResponse>(resposta);
        }
    }
}