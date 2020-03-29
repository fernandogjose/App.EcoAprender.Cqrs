using App.EcoAprender.Cqrs.Domain.Commands;
using App.EcoAprender.Cqrs.Domain.FakeRepositories;
using App.EcoAprender.Cqrs.Domain.Handles;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace App.EcoAprender.Cqrs.UnitTest.HandlerTests
{
    [TestClass]
    public class AnuncioAdicionarHandlerTest
    {
        private readonly AnuncioAdicionarCommand _anuncioAdicionarCommand = new AnuncioAdicionarCommand
        {
            Marca = 1,
            Modelo = 1,
            Versao = 1,
            Ano = 2022,
            Quilometragem = 10,
            Observacao = "Meu Teste de unidade"
        };
        private readonly AnuncioHandler _anuncioHandler = new AnuncioHandler(new AnuncioFakeRepository());

        [TestMethod]
        public void Deve_Retornar_Mensagem_Erro_Quando_Marca_Invalida()
        {
            _anuncioAdicionarCommand.Marca = 0;

            ResponseCommand responseCommand = _anuncioHandler.Handle(_anuncioAdicionarCommand);

            List<string> erros = responseCommand.Objeto as List<string>;
            Assert.IsTrue(erros.Any(x => x == "Marca é obrigatório"));
            Assert.AreEqual(responseCommand.Sucesso, false);
            Assert.AreEqual(responseCommand.Mensagem, "Falha ao adicionar o anuncio");
        }

        [TestMethod]
        public void Deve_Retornar_Mensagem_Sucesso()
        {
            ResponseCommand responseCommand = _anuncioHandler.Handle(_anuncioAdicionarCommand);

            Assert.IsTrue(Convert.ToInt32(responseCommand.Objeto) > 0);
            Assert.AreEqual(responseCommand.Sucesso, true);
            Assert.AreEqual(responseCommand.Mensagem, "Anuncio adicionado com sucesso");
        }
    }
}
