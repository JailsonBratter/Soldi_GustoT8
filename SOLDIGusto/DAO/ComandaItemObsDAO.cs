using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using visualSysWeb.dao;

class ComandaItemObsDAO
{
    public decimal comanda { get; set; }
    public string cupom { get; set; }
    public int pdv { get; set; }
    public string filial { get; set; }
    public string plu { get; set; }
    public int id { get; set; }
    public string obs { get; set; }
    public string modificador { get; set; }
    public DateTime DATA { get; set; }
    public DateTime hora { get; set; }
    public int Loja { get; set; }
    public int PDV_Origem { get; set; }
    public int Imp { get; set; }



    public List<ComandaItemObsDAO> BuscarObsExistente(ComandaItemObsDAO obj)
    {
        SqlDataReader rs = null;

        try
        {
            StringBuilder Sql = new StringBuilder();

            Sql.Append("SELECT * FROM Comanda_Item_Obs ");
            Sql.Append("WHERE Comanda = " + obj.comanda + " AND PLU = " + obj.plu);
            Sql.Append(" AND ID = " + obj.id + " AND Cupom = 0");

            //Executando o comando
            rs = Conexao.consulta(Sql.ToString(), null, false);

            List<ComandaItemObsDAO> Lista = new List<ComandaItemObsDAO>();

            //Verificando os resultado da busca
            while (rs.Read())
            {
                ComandaItemObsDAO Obj = new ComandaItemObsDAO();
                Obj.obs = rs["obs"].ToString();
                Obj.modificador = rs["modificador"].ToString();
                Obj.plu = rs["plu"].ToString();
                Lista.Add(Obj);
            }

            return Lista;
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

    public void InsereObs(ComandaItemObsDAO obj, ComandaItemDAO obj2)
    {

        SqlConnection cn = Conexao.novaConexao();
        
        try
        {
            if (cn.State != ConnectionState.Open)
                cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_m_inclui_obs";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;
           

            SqlParameter[] data =
            {
                new SqlParameter() {ParameterName = "@filial", Value= "MATRIZ"},
                new SqlParameter() {ParameterName = "@plu",Value= obj.plu},

                new SqlParameter() {ParameterName = "@id",Value= obj.id},
                new SqlParameter() {ParameterName = "@obs",Value= obj.obs},
                new SqlParameter() {ParameterName = "@comanda",Value= obj.comanda},
                new SqlParameter() {ParameterName = "@usuario",Value= obj2.usuario},
                new SqlParameter() {ParameterName = "@localizacao",Value= obj2.localizacao},
                new SqlParameter() {ParameterName = "@cData",Value= DateTime.Now},
                new SqlParameter() {ParameterName = "@mod",Value= obj.modificador},
                new SqlParameter() {ParameterName = "@qtde",Value= obj2.qtde},
                new SqlParameter() {ParameterName = "@Loja",Value= obj.Loja},
                //new SqlParameter() {ParameterName = "@Terminal", SqlDbType = SqlDbType.Int,Value= Parametros.Terminal}
            };

            cmd.Parameters.AddRange(data);

           cmd.ExecuteNonQuery();
           

        }
        catch (Exception err)
        {
            
            throw err;
        }
        finally
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
        }


    }

    public void ExcluirObs(ComandaItemObsDAO obj)
    {

        try
        {
            StringBuilder Sql = new StringBuilder();

            Sql.Append("DELETE FROM Comanda_Item_Obs ");
            Sql.Append("WHERE Comanda = " + obj.comanda + " AND PLU = " + obj.plu);
            Sql.Append(" AND ID = " + obj.id + " AND Cupom = 0");

            //Executando o comando
            Conexao.executarSql(Sql.ToString());

        }
        catch (Exception err)
        {

            throw err;
        }

    }
}

