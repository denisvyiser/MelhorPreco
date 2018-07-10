
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using MelhorPreco.UTILITIES;
using MelhorPreco.BUSINESS.Interfaces;


namespace MelhorPreco.BUSINESS.Repositories
{
    public class RepositoryBase<C, TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class where C : DbContext, new() 
    {
         private C _entities = new C();
    public C ContextDB {

        get { return _entities; }
        set { _entities = value; }
    }


        Utilities util;

        
        public Utilities Cadastrar(TEntity obj)
        {
            
            try
            {
                util = new Utilities();

                _entities.Set<TEntity>().Add(obj);

                _entities.SaveChanges();
               
                util.CodigoErro = 0;
                util.Objeto = new object[] { "Dados Cadastrados" };
            }
            catch (Exception ex)
            {
                util.CodigoErro = -1;
                util.Objeto = new object[] { "Erro ao Cadastradar Dados" + ex.Message };
            }
            return util;
        }

        public virtual Utilities ProducarPeloId(int id)
        {
            try
            {
                 util = new Utilities();

                util.Objeto = new object[] { _entities.Set<TEntity>().Find(id) };
                
                util.CodigoErro = 0;

            }
            catch (Exception ex)
            {
                util.CodigoErro = -1;
                util.Objeto = new object[] { "Não foi possível obter o ID" + ex.Message };
            }
            return util;


        }

        public virtual Utilities ListarTodos()
        {
            try
            {
                util = new Utilities();

                IQueryable<TEntity> query = _entities.Set<TEntity>().AsNoTracking();

                util.Objeto = new object[] { query };
                

                util.CodigoErro = 0;

            }
            catch (Exception ex)
            {
                util.CodigoErro = -1;
                util.Objeto = new object[] { "Erro ao Listar Dados" + ex.Message };
            }
            return util;
        }

        public Utilities Atualizar(TEntity obj)
        {
            try
            {

                _entities.Entry(obj).State = EntityState.Modified;

                _entities.SaveChanges();

                util.Objeto = new object[] { "Dados Atualizados" };
                util.CodigoErro = 0;

            }
            catch (Exception ex)
            {
                util.CodigoErro = -1;
                util.Objeto = new object[] { "Erro ao Atualizar Dados" + ex.Message };
            }
            return util;

        }

        public Utilities Remover(TEntity obj)
        {
            try
            {
                util = new Utilities();

                _entities.Set<TEntity>().Attach(obj);
                _entities.Set<TEntity>().Remove(obj);



                _entities.SaveChanges();
                

                util.Objeto = new object[] { "Dados Removidos" };
                util.CodigoErro = 0;

            }
            catch (Exception ex)
            {
                util.CodigoErro = -1;
                util.Objeto = new object[] { "Erro ao Remover Dados" + ex.Message };
            }
            return util;

        }

       

        public virtual void Dispose()
        {

            
        }


        public Utilities ProcurarPor(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            util = new Utilities();
            try
            {
                IQueryable<TEntity> query = _entities.Set<TEntity>().Where(predicate);

                util.Objeto = new object[] { query };

                util.CodigoErro = 0;

            }
            catch (Exception e)
            {

            }
            return util;
        }

        public Utilities RemoverVarios(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {

            try
            {
                util = new Utilities();

              
                _entities.Set<TEntity>()
              .Where(predicate).ToList()
              .ForEach(del => _entities.Set<TEntity>().Remove(del));
                
                _entities.SaveChanges();


                util.Objeto = new object[] { "Dados Removidos" };
                util.CodigoErro = 0;

            }
            catch (Exception ex)
            {
                util.CodigoErro = -1;
                util.Objeto = new object[] { "Erro ao Remover Dados" + ex.Message };
            }
            return util;
           
        }
       
    }
}
