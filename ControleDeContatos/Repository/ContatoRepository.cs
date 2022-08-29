using ControleDeContatos.Data;
using ControleDeContatos.Models;

namespace ControleDeContatos.Repository
{
    public class ContatoRepository : IContatoRepository
    {
        private readonly BancoContext _bancoContext;//para acessar dentro do meu metodo
                                                    //(Uma curiosidade como o metodo é privado começo o nome da minha variavél com(_))
        //Porém que vai gravar é o contexto então eu vou injetar o construtor
        public ContatoRepository(BancoContext bancoContext)
        {
            //porém se eu quiser usar dentro do meu método eu não irei conseguir usar pq ela existe apens dentro do construtor
            _bancoContext = bancoContext;
        }
        public List<ContatoModel> BuscarTodos()
        {
            return _bancoContext.Contatos.ToList();
        }
        public ContatoModel Adcionar(ContatoModel contato)
        {
            //Aqui eu irei gravar no banco de dados
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();//para confirmar as ações acima para o meu banco
            return contato;
        }

    }
}
