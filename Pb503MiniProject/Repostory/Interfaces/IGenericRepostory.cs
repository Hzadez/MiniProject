using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pb503MiniProject.Models;

namespace Pb503MiniProject.Repostory.I
{
    public interface IGenericRepostory< T> where T : BaseEntity , new() 
    {
        void Create(T Entity);
        void Delete(int id);
        T  GetbyId(int id);
        List<T> GetAll();
        void Commit();
    }
}
