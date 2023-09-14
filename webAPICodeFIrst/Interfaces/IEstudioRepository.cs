using webAPICodeFIrst.Domains;

namespace webAPICodeFIrst.Interfaces
{
    public interface IEstudioRepository
    {
        void Cadastrar(Estudio novoEstudio);

        List<Estudio> ListarTodos();

    }
}
