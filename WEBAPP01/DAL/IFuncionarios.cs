using System;
using System.Collections.Generic;
using System.Text;
using ENT;

namespace DAL
{
    public interface IFuncionarios
    {
        IEnumerable<eFuncionarios> GetFuncionarios();
        void InsertFuncionarios(eFuncionarios funcionarios);
        void UpdateFuncionarios(eFuncionarios funcionarios);
        void DeleteFuncionarios(eFuncionarios funcionarios);
    }
}
