using Data.Context;
using Data.Model;

namespace Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseModel
    {
      
        public virtual List<T> GetAll()
        {
            List<T> list = new List<T>();
            using (WarrenContext context = new WarrenContext())
            {
                list = context.Set<T>().ToList();
            }

            return list;
        }

        public virtual T GetById(int id)
        {
            T model = null;
            using(WarrenContext context = new WarrenContext())
            {
                model = context.Set<T>().Find(id);
            }
            return model;
        }

        public virtual string Create(T model)
        {
            using (WarrenContext context = new WarrenContext())
            {
                context.Set<T>().Add(model);
                context.SaveChanges();
            }
            return "Criado";
        }

        virtual public string Delete(int id)
        {
            var model = this.GetById(id);
            using (WarrenContext context = new WarrenContext())
            {
                context.Entry<T>(model).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                context.SaveChanges();
            }
            return "Deletado";    
        }

        virtual public string Update(T model)
        {
            using (WarrenContext context = new WarrenContext())
            {
                context.Entry<T>(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
            }
            return "Atualizado";
        }
    }
}
