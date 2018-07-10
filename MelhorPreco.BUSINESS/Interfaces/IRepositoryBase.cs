using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using MelhorPreco.UTILITIES;

namespace MelhorPreco.BUSINESS.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class 
    {
        Utilities Cadastrar(TEntity obj);
        Utilities ProducarPeloId(int id);

        //IEnumerable<TEntity> GetAll();
        Utilities ListarTodos();

        Utilities Atualizar(TEntity obj);
        Utilities Remover(TEntity obj);

        Utilities ProcurarPor(Expression<Func<TEntity, bool>> predicate);
        void Dispose();
    }
}
