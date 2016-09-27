using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOfBrands.Interfaces
{
    public interface IDatabaseRepository<T>
    {
        void Save(T item);
        List<T> GetAll();
        int NextItemID();
    }
}
