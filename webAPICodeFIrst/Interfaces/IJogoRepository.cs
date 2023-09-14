using webAPICodeFIrst.Domains;

namespace webAPICodeFIrst.Interfaces
{
    public interface IJogoRepository
    {
        void Cadastrar(Jogo jogoNovo);

        List<Jogo> ListarTodos();

        Jogo BuscarPorId(Guid id);
    }
}
