using Data.Model;

namespace Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseModel
    {
        public List<T> Objects { get; set; }

        public BaseRepository()
        {
            Objects = new List<T>();
        }

        public string Create(T model)
        {
            return "Criado";
        }

        public string Delete(int id)
        {
            return "Deletado";    
        }

        public T Get(int id)
        {
            var model = Objects[id];
            return model;
        }

        public List<T> GetAll()
        {
            return Objects;
        }

        public string Update(T model)
        {
            throw new NotImplementedException();
        }
    }
}
