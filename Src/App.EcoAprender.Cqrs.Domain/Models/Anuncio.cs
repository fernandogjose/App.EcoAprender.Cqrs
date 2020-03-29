namespace App.EcoAprender.Cqrs.Domain.Models
{
    public class Anuncio : Base
    {
        public int Marca { get; private set; }

        public int Modelo { get; private set; }

        public int Versao { get; private set; }

        public int Ano { get; private set; }

        public int Quilometragem { get; private set; }

        public string Observacao { get; private set; }

        public void PreencherAdicionar(int marca, int modelo, int versao, int ano, int quilometragem, string observacao)
        {
            Marca = marca;
            Modelo = modelo;
            Versao = versao;
            Ano = ano;
            Quilometragem = quilometragem;
            Observacao = observacao;
        }

        public void PreencherEditar(int id, int marca, int modelo, int versao, int ano, int quilometragem, string observacao)
        {
            PreencherId(id);
            Marca = marca;
            Modelo = modelo;
            Versao = versao;
            Ano = ano;
            Quilometragem = quilometragem;
            Observacao = observacao;
        }
    }
}
