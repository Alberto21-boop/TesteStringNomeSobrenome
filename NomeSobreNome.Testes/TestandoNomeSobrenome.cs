using NomeSobrenome;
using System.Collections.Generic;
using Xunit;


namespace NomeSobreNome.Testes
{
    public class TestandoNomeSobrenome
    {
        string nome1 = "Alberto";
        string nome2 = "Barbosa";

        [Fact]
        public void DeveConcatenaNomeESobrenomeRetornandoNomeESobrenome()
        {
            var result = new NomeCompleto();
            Assert.Equal(nome1 + nome2, result.DeveConcatenaNomeESobrenomeRetornandoNomeESobrenome(nome1, nome2));
        }
    }
}