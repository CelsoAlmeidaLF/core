using DAL;
using ENT;
using System.Collections.Generic;

namespace NEG
{
    public class nFuncionarios : IFuncionarios
    {
        public void DeleteFuncionarios(eFuncionarios funcionarios)
        {
            dFuncionarios dao = new dFuncionarios();
            dao.DeleteFuncionarios(funcionarios);
        }

        public IEnumerable<eFuncionarios> GetFuncionarios()
        {
            dFuncionarios dao = new dFuncionarios();
            return dao.GetFuncionarios();
        }

        public void InsertFuncionarios(eFuncionarios funcionarios)
        {
            dFuncionarios dao = new dFuncionarios();
            dao.InsertFuncionarios(funcionarios);
        }

        public void UpdateFuncionarios(eFuncionarios funcionarios)
        {
            dFuncionarios dao = new dFuncionarios();
            dao.UpdateFuncionarios(funcionarios);
        }
    }
}
