using LabT2Dependency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabT2Dependency.Controllers
{
   public interface IApiRequestSend<T>
    {
        IEnumerable<T> GetAllData();

        void AddEntity(T entity);

        void ModifyEntity(int id, T entity);

        void DeleteEntity(T entity);

    }
}
