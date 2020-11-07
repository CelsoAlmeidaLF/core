using ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAL
{
    public class dFuncionarios : IFuncionarios
    {

        IEnumerable<eFuncionarios> _funcionarios;

        public IEnumerable<eFuncionarios> GetFuncionarios()
        {
            eFuncionarios item;
            var func = new List<eFuncionarios>();

            string cmmd = "SELECT * FROM TB_FUNCIONARIOS";
            var conn = new DAL();

            try
            {
                DataTable dt = DAL.dtaGet(cmmd);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    item = new eFuncionarios()
                    {
                        eIdFunc = Int32.Parse(dt.Rows[i]["IDFUNC"].ToString()),
                        eNome = dt.Rows[i]["NOME"].ToString(),
                        eDepto = Int32.Parse(dt.Rows[i]["DEPTO"].ToString()),
                        eFuncao = dt.Rows[i]["FUNCAO"].ToString(),
                        eSalario = Double.Parse(dt.Rows[i]["SALARIO"].ToString()),
                    };
                    func.Add(item);
                }
                _funcionarios = func;
                return _funcionarios;
            }
            catch (SqlException e)
            {
                var er = e;
                conn.Close();
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public void InsertFuncionarios(eFuncionarios func)
        {

            string cmmd = $"INSERT INTO TB_FUNCIONARIOS VALUES ('{func.eNome}', '{func.eDepto}', '{func.eFuncao}', {func.eSalario});";
            var conn = new DAL();

            try
            {
                conn.Set(cmmd);
            }
            catch (SqlException e)
            {
                var er = e; conn.Close();
            }
            finally
            {
                conn.Close();
            }
        }

        public void UpdateFuncionarios(eFuncionarios func)
        {
            string cmmd = $"UPDATE TB_FUNCIONARIOS SET ('{func.eNome}', '{func.eDepto}', '{func.eFuncao}', {func.eSalario}) WHERE IDFUNC = {func.eIdFunc};";
            var conn = new DAL();

            try
            {
                conn.Set(cmmd);
            }
            catch (SqlException e)
            {
                var er = e; conn.Close();
            }
            finally
            {
                conn.Close();
            }
        }

        public void DeleteFuncionarios(eFuncionarios func)
        {
            string cmmd = $"DELETE FROM TB_FUNCIONARIOS WHERE IDFUNC = {func.eIdFunc}";
            var conn = new DAL();

            try
            {
                conn.Set(cmmd);
            }
            catch (SqlException e)
            {
                var er = e; conn.Close();
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
