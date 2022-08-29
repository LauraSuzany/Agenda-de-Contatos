using ControleDeContatos.Models;

namespace ControleDeContatos.Repository
{
    public interface IContatoRepository//basicamente vou criar todos os metodos como contrato 
    {
        List<ContatoModel> BuscarTodos();
        ContatoModel Adcionar(ContatoModel contato);
    }
}
