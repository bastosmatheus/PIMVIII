namespace PIMVIII.Interfaces;

public interface IRepository<T>
{
    public void Adicionar(T entidade);

    public void Atualizar(T entidade);

    public void Excluir(T entidade);

    public T ObterPorId(int id);

    public List<T> ObterTodos();
}
