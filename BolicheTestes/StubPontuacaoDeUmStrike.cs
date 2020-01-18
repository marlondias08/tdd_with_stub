using Boliche.Api;
using System.Threading.Tasks;

namespace BolicheTestes
{
    public class StubPontuacaoDeUmStrike : IBolicheApi
    {
        public Task<ArremessosResponse> ObterArremessos()
        {
            ArremessosResponse resposta = new ArremessosResponse()
            {
                Arremessos = new int[] { 10, 7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };
            return Task.FromResult<ArremessosResponse>(resposta);
        }
    }
}