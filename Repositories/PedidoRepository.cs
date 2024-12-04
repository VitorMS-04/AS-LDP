public class PedidoRepository : IPedidoRepository
{
    private readonly AppDbContext _context;

    // setando contexto a partir do AppDbContext
    public PedidoRepository(AppDbContext context)
    {
        _context = context;
    }

    // inejção de dependência do método Delete
    public Pedido Delete(int id)
    {
        var pedido = _context.Pedidos.Find(id);

        if(pedido == null)
        {
            return pedido;
        }

        _context.Pedidos.Remove(pedido);
        _context.SaveChanges();
        return pedido;
    }

    // inejção de dependência do método GetAll
    public List<Pedido> GetAll()
    {
        return _context.Pedidos.ToList();
    }

    // inejção de dependência do método GetById
    public Pedido GetById(int id)
    {
        return _context.Pedidos.Find(id);
    }

    // inejção de dependência do método Post
    public void Post(Pedido pedido)
    {
        _context.Pedidos.Add(pedido);
        _context.SaveChanges();
    }

    // inejção de dependência do método Put
    public Pedido Put(int id, Pedido pedidoAtualizado)
    {
        var pedido = _context.Pedidos.Find(id);
        if(pedido == null)
        {
            return pedido;
        }
        pedido.Data = pedidoAtualizado.Data;
        pedido.ValorTotal = pedidoAtualizado.ValorTotal;
        pedido.Status = pedidoAtualizado.Status;
        pedido.Descricao = pedidoAtualizado.Descricao;

        _context.SaveChanges();
        return pedido;
    }
}