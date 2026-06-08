using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using visualSysWeb.dao;

class ComandaControleDAO
{
    #region Proriedades
    public int comanda { get; set; }
    public string status { get; set; }
    public string funcionario { get; set; }
    public string obs { get; set; }
    public decimal Total { get; set; }
    
    #endregion

    /// <summary>
    /// Metodo para buscar uma comanda existente
    /// </summary>
    /// <param name="Com">Numero da comanda</param>
    /// <returns></returns>
    public ComandaControleDAO BuscarComanda(int Com)
    {
        SqlDataReader rs = null;

        try
        {
            StringBuilder Sql = new StringBuilder();

            Sql.Append("SELECT Comanda_Controle.Comanda, Comanda_Controle.Status, ");
            Sql.Append("Comanda.Status AS StatusComanda ");
            Sql.Append("FROM Comanda_Controle LEFT OUTER JOIN Comanda ON ");
            Sql.Append("Comanda.Comanda = Comanda_Controle.Comanda ");
            Sql.Append("AND Comanda.PDV = 0 WHERE Comanda_Controle.Comanda = " + Com);

            //Executando o comando
            rs = Conexao.consulta(Sql.ToString(), null, false);

            ComandaControleDAO Obj = new ComandaControleDAO();

            //Verificando os resultado da busca
            if (rs.Read())
            {
                Obj.comanda = Funcoes.ConvertstrToInt(rs["comanda"].ToString());
                Obj.status = rs["status"].ToString();
            }

            P_Comanda(Com.ToString());

            return Obj;
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

    /// <summary>
    /// Metodo para executar a procedure sp_m_comanda
    /// </summary>
    /// <param name="Com">Numero da comanda</param>
    public void P_Comanda(string Com)
    {
        SqlConnection cn = Conexao.novaConexao();

        try
        {
            if (cn.State != ConnectionState.Open)
                cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_m_comanda";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            SqlParameter[] data =
            {
                new SqlParameter() {ParameterName = "@filial", Value= "MATRIZ"},
                new SqlParameter() {ParameterName = "@numeroComanda",Value= Com}
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

    /// <summary>
    /// Metodo para buscar todas comandas existentes
    /// </summary>
    /// <returns></returns>
    public List<ComandaControleDAO> BuscarComanda()
    {
        SqlDataReader rs = null;

        try
        {
            StringBuilder Sql = new StringBuilder();

            Sql.Append("Select * from Comanda_controle ");

            //Executando o comando
            rs = Conexao.consulta(Sql.ToString(), null, false);

            List<ComandaControleDAO> ListaCom = new List<ComandaControleDAO>();

            //Verificando os resultado da busca
            while (rs.Read())
            {
                ComandaControleDAO Obj = new ComandaControleDAO();
                Obj.comanda = Funcoes.ConvertstrToInt(rs["comanda"].ToString());
                Obj.status = rs["status"].ToString();
                Obj.funcionario = rs["funcionario"].ToString();
                Obj.obs = rs["obs"].ToString();
                ListaCom.Add(Obj);
            }

            return ListaCom;
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

    /// <summary>
    /// Metodo para buscar as comandas em uso dentro de um intervalo definido
    /// </summary>
    /// <param name="Inicio">Numero inicial do intervalo</param>
    /// <param name="fim">Numero  final do intervalo</param>
    /// <returns>Retorna um obj do tipo List<ComandaControleDAO></returns>
    public List<ComandaControleDAO> BuscarComanda(int Inicio, int fim, int Ordem)
    {
        SqlDataReader rs = null;

        try
        {
            StringBuilder Sql = new StringBuilder();

            Sql.Append("with Com as(SELECT COMANDA_CONTROLE.COMANDA,COMANDA_CONTROLE.STATUS");
            Sql.Append(",Sum(COMANDA_ITEM.TOTAL) as TOTAL, ");
            Sql.Append(" row_number() over(order by ");

            if (Ordem == 1)
            {
                Sql.Append("COMANDA_CONTROLE.COMANDA");
            }
            else if (Ordem == 10)
            {
                Sql.Append("COMANDA_CONTROLE.COMANDA desc");
            }
            else if (Ordem == 2)
            {
                Sql.Append("MAX(COMANDA_ITEM.data) desc");
            }
            else if (Ordem == 20)
            {
                Sql.Append("MAX(COMANDA_ITEM.data) ");
            }
            else
                Sql.Append("Sum(COMANDA_ITEM.TOTAL) desc");

            Sql.Append(") as NumLinha  ");

            Sql.Append("FROM COMANDA_CONTROLE INNER JOIN COMANDA_ITEM ON COMANDA_CONTROLE.COMANDA = ");
            Sql.Append("COMANDA_ITEM.COMANDA WHERE COMANDA_ITEM.DATA_CANCELAMENTO IS NULL ");
            Sql.Append("and COMANDA_ITEM.CUPOM = 0 AND ORIGEM = 'MBL' GROUP BY ");
            Sql.Append("COMANDA_CONTROLE.COMANDA, COMANDA_CONTROLE.STATUS)");
            Sql.Append(" select* from Com where NumLinha between '" + Inicio);
            Sql.Append("'  and '" + fim + "'");


            //Executando o comando
            rs = Conexao.consulta(Sql.ToString(), null, false);

            List<ComandaControleDAO> ListaCom = new List<ComandaControleDAO>();

            //Verificando os resultado da busca
            while (rs.Read())
            {
                ComandaControleDAO Obj = new ComandaControleDAO();
                Obj.comanda = Funcoes.ConvertstrToInt(rs["comanda"].ToString());
                Obj.status = rs["status"].ToString();
                Obj.Total = Funcoes.ConvertstrToDecimal(rs["Total"].ToString());


                ListaCom.Add(Obj);
            }

            return ListaCom;
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

    /// <summary>
    /// Metodo para atualizar o status da comanda
    /// </summary>
    /// <param name="obj">Obj do tipo ComandaControleDAO preenchido</param>
    /// <returns></returns>
    public bool AtualizarComandaControle(ComandaControleDAO obj)
    {
        try
        {
            //Armazenando o comando em uma string
            StringBuilder Sql = new StringBuilder();
            Sql.Append("Update Comanda_controle set  ");
            Sql.Append("status ='" + obj.status + "'");
            Sql.Append(" where comanda=" + obj.comanda);

            //Executando o comando
            bool retorno = Conexao.executarSql(Sql.ToString());

            return retorno;
        }
        catch (Exception err)
        {

            throw err;
        }

    }
}

