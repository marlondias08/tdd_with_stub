using Boliche.Api;
using System.Threading.Tasks;

namespace BolicheTestes
{
    public class StubPontuacaoDeUmSpare : IBolicheApi
    {
        public Task<ArremessosResponse> ObterArremessos()
        {
            ArremessosResponse resposta = new ArremessosResponse()
            {
                Arremessos = new int[] { 3, 7, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };
            return Task.FromResult<ArremessosResponse>(resposta);
        }
    }
}