using Boliche;
using Boliche.Api;
using Refit;
using Xunit;

namespace BolicheTestes
{
    public class JogoDeBolicheNaoDeterministicoTeste
    {
        private JogoDeBolicheNaoDeterministico jogoDeBoliche;

        [Fact]
        public void calculaAPontuacaoDeUmJogoInteiroNaSarjeta()
        {
            IBolicheApi bolicheApi = new StubPontuacaoNaSarjeta();
            this.jogoDeBoliche = new JogoDeBolicheNaoDeterministico(bolicheApi);
            Assert.Equal(0, jogoDeBoliche.CalcularPontuacao());
        }

        [Fact]
        public void calculaAPontuaDeUmJogoSimples()
        {
            IBolicheApi bolicheApi = new StubPontuaDeUmJogoSimples();
            this.jogoDeBoliche = new JogoDeBolicheNaoDeterministico(bolicheApi);
            Assert.Equal(12, jogoDeBoliche.CalcularPontuacao());
        }

        [Fact]
        public void calculaAPontuacaoDeUmSpare()
        {
            IBolicheApi bolicheApi = new StubPontuacaoDeUmSpare();
            this.jogoDeBoliche = new JogoDeBolicheNaoDeterministico(bolicheApi);
            Assert.Equal(16, jogoDeBoliche.CalcularPontuacao());
        }

        [Fact]
        public void calculaAPontuacaoDeUmStrike()
        {
            IBolicheApi bolicheApi = new StubPontuacaoDeUmStrike();
            this.jogoDeBoliche = new JogoDeBolicheNaoDeterministico(bolicheApi);
            Assert.Equal(24, jogoDeBoliche.CalcularPontuacao());
        }

        [Fact]
        public void calculaAPontuacaoDeUmJogoPerfeito()
        {
            IBolicheApi bolicheApi = new StubPontuacaoDeUmJogoPerfeito();
            this.jogoDeBoliche = new JogoDeBolicheNaoDeterministico(bolicheApi);
            Assert.Equal(300, jogoDeBoliche.CalcularPontuacao());
        }

    }

}
