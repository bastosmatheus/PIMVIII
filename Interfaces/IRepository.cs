namespace PIMVIII.Interfaces;

public interface IRepository<T>
{
    public void Adicionar(T entidade);

    public void Atualizar(T entidade);

    public void Excluir(T entidade);

    public void ObterPorId(int id);

    public List<T> ObterTodos();
}
