public interface IFornecedorRepository
{
    // criação dos métodos seguindo as operações CRUD
    public List<Fornecedor> GetAll();
    public Fornecedor GetById(int id);
    public void Post(Fornecedor fornecedor);
    public Fornecedor Put(int id, Fornecedor fornecedorAtualizado);
    public Fornecedor Delete(int id);
}