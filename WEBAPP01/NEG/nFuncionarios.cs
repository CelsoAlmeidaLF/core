using DAL;
using ENT;
using System.Collections.Generic;

namespace NEG
{
    public class nFuncionarios : IFuncionarios
    {
        public void DeleteFuncionarios(eFuncionarios funcionarios)
        {
            var f = new dFuncionarios();
            f.DeleteFuncionarios(funcionarios);
        }

        public IEnumerable<eFuncionarios> GetFuncionarios()
        {
            var f = new dFuncionarios();
            return f.GetFuncionarios();
        }

        public void InsertFuncionarios(eFuncionarios funcionarios)
        {
            var f = new dFuncionarios();
            f.InsertFuncionarios(funcionarios);
        }

        public void UpdateFuncionarios(eFuncionarios funcionarios)
        {
            var f = new dFuncionarios();
            f.UpdateFuncionarios(funcionarios);
        }
    }
}
