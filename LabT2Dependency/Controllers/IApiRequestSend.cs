using LabT2Dependency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabT2Dependency.Controllers
{
    interface IApiRequestSend<T>
    {
        IEnumerable<T> GetAllData();

        void AddEntity(T journey);

        void ModifyEntity(int id, T journey);

        void DeleteEntity(T journey);

    }
}
