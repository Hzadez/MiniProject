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
        public void Create(T Entity)
        {
            AppDbContext newDb = new AppDbContext();
            newDb.Set <T>().Add(Entity);
            newDb.SaveChanges();
        }

        public void Delete(int id)
        {
            AppDbContext newDb = new AppDbContext();
            var model = newDb.Set<T>().FirstOrDefault(x => x.Id == id);
            newDb.Set<T>().Remove(model);
            newDb.SaveChanges();
        }

        public T GetbyId(int id)
        {
            AppDbContext newDb = new AppDbContext();
            return newDb.Set<T>().FirstOrDefault(x => x.Id == id);
        }
        public List<T> GetAll()
        {
            AppDbContext newdb = new AppDbContext();
            return newdb.Set<T>().ToList();
        }
        public void Commit()
        {
            AppDbContext newDb = new AppDbContext();
            newDb.SaveChanges();
        }
    }
}
