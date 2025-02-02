using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pb503MiniProject.Models;
using Pb503MiniProject.Repostory.I;

namespace Pb503MiniProject.Repostory.Implementation
{
    public class GenericRepostory<T> : IGenericRepostory<T> where T : BaseEntity, new()
    {
        private readonly AppDbContext _appDbContext;

        public GenericRepostory()
        {
            _appDbContext = new AppDbContext();
        }

        public void Create(T Entity)
        {
            _appDbContext.Set <T>().Add(Entity);
            _appDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var model = _appDbContext.Set<T>().FirstOrDefault(x => x.Id == id);
            _appDbContext.Set<T>().Remove(model);
            _appDbContext.SaveChanges();
        }

        public T GetbyId(int id)
        {
            return _appDbContext.Set<T>().FirstOrDefault(x => x.Id == id);
        }
        public List<T> GetAll()
        {
            return _appDbContext.Set<T>().ToList();
        }
        public void Commit()
        {
            _appDbContext.SaveChanges();
        }
    }
}
