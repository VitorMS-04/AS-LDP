public class FornecedorRepository : IFornecedorRepository
{
    private readonly AppDbContext _context;

    // setando contexto a partir do AppDbContext
    public FornecedorRepository(AppDbContext context)
    {
        _context = context;
    }

    // inejção de dependência do método Delete
    public Fornecedor Delete(int id)
    {
        var fornecedor = _context.Fornecedores.Find(id);

        if(fornecedor == null)
        {
            return fornecedor;
        }

        _context.Fornecedores.Remove(fornecedor);
        _context.SaveChanges();
        return fornecedor;
    }

    // inejção de dependência do método GetAll
    public List<Fornecedor> GetAll()
    {
        return _context.Fornecedores.ToList();
    }

    // inejção de dependência do método GetById
    public Fornecedor GetById(int id)
    {
        return _context.Fornecedores.Find(id);
    }

    // inejção de dependência do método Post
    public void Post(Fornecedor fornecedor)
    {
        _context.Fornecedores.Add(fornecedor);
        _context.SaveChanges();
    }

    // inejção de dependência do método Put
    public Fornecedor Put(int id, Fornecedor fornecedorAtualizado)
    {
        var fornecedor = _context.Fornecedores.Find(id);
        if(fornecedor == null)
        {
            return fornecedor;
        }
        fornecedor.Nome = fornecedorAtualizado.Nome;
        fornecedor.Cnpj = fornecedorAtualizado.Cnpj;
        fornecedor.Telefone = fornecedorAtualizado.Telefone;
        fornecedor.Email = fornecedorAtualizado.Email;
        fornecedor.Endereco = fornecedorAtualizado.Endereco;

        _context.SaveChanges();
        return fornecedor;
    }
}