using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using visualSysWeb.dao;

class MotivoDAO
{
    public string Motivo { get; set; }
    public string Modulo { get; set; }

    public List<MotivoDAO> BuscarMotivos()
    {
        SqlDataReader rs = null;
        try
        {
            StringBuilder Sql = new StringBuilder();

            Sql.Append("SELECT Motivo FROM Motivo_Cancelamento WHERE Modulo = 'COMANDA'");

            //Executando o comando
            rs = Conexao.consulta(Sql.ToString(), null, false);

            List<MotivoDAO> Motivos = new List<MotivoDAO>();
            while (rs.Read())
            {
                MotivoDAO Obj = new MotivoDAO();
                Obj.Motivo = rs["Motivo"].ToString();
                Motivos.Add(Obj);
            }
            return Motivos;
        }
        catch (Exception err)
        {

            throw err;
        }
        finally
        {
            if (rs != null)
            {
                rs.Close();
            }
        }
    }
}

