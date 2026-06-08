using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using visualSysWeb.dao;

class ComandaDAO
{
    #region Proriedades
    public decimal comanda { get; set; }
    public string cupom { get; set; }
    public bool pdv { get; set; }
    public string filial { get; set; }
    public bool status { get; set; }
    public string usuario { get; set; }
    public DateTime data_alteracao { get; set; }
    public DateTime data_chave { get; set; }
    #endregion

    /// <summary>
    /// Metodo para buscar uma comanda existente
    /// </summary>
    /// <param name="Com">Numero da comanda</param>
    /// <returns>Retorna um objeto do tipo ComandaDAO preenchido</returns>
    public ComandaDAO BuscarComanda(int Com)
    {
        SqlDataReader rs = null;

        try
        {
            StringBuilder Sql = new StringBuilder();

            Sql.Append("Select * from Comanda where comanda =" + Com);
            Sql.Append(" and cupom =0");

            //Executando o comando
            rs = Conexao.consulta(Sql.ToString(), null, false);

            ComandaDAO Obj = new ComandaDAO();

            //Verificando os resultado da busca
            if (rs.Read())
            {
                Obj.comanda = Funcoes.ConvertstrToInt(rs["comanda"].ToString());
                Obj.cupom = rs["cupom"].ToString();
                Obj.usuario = rs["usuario"].ToString();
                Obj.filial = rs["filial"].ToString();
                Obj.data_chave = Funcoes.ConvertstrToDateTime(rs["data_chave"].ToString());
            }

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
    ///  Metodo para inserir as informaçoes da comanda
    /// </summary>
    /// <param name="obj">Objeto do tipo ComandaDAO preenchido</param>
    /// <returns></returns>
    public bool InserirComanda(ComandaDAO obj)
    {
        try
        {
            //Armazenando o comando em uma string
            StringBuilder Sql = new StringBuilder();
            Sql.Clear();
            Sql.Append("Insert into Comanda  ");
            Sql.Append("(comanda,cupom,pdv,status,usuario,data_alteracao,data_chave,filial)");
            Sql.Append(" values (");
            Sql.Append(obj.comanda.ToString().Replace(",", "."));
            Sql.Append(",'" + obj.cupom + "'");
            Sql.Append("," + Funcoes.ConvertBoolToBit(obj.pdv));
            Sql.Append("," + Funcoes.ConvertBoolToBit(obj.status));
            Sql.Append(",'SA'");
            Sql.Append(",'" + obj.data_alteracao.ToString("yyyy-MM-dd HH:mm:ss:fff") + "'");
            Sql.Append(",'" + obj.data_chave.ToString("yyyy-MM-dd HH:mm:ss:fff") + "'");
            Sql.Append(",'" + obj.filial + "'");
            Sql.Append(")");

            //Executando o comando
            bool retorno = Conexao.executarSql(Sql.ToString());

            return retorno;
        }
        catch (Exception err)
        {

            throw err;
        }

    }

    /// <summary>
    /// Metodo para atualizar as informaçoes da comanda
    /// </summary>
    /// <param name="obj">Objeto do tipo ComandaDAO preenchido</param>
    /// <returns></returns>
    public bool AtualizarComanda(ComandaDAO obj)
    {
        try
        {
            //Armazenando o comando em uma string
            StringBuilder Sql = new StringBuilder();
            Sql.Append("Set Language 'us_english'; ");
            Sql.Append("update Comanda set ");
            Sql.Append("data_alteracao='" + obj.data_alteracao.ToString("yyyy-MM-dd HH:mm:ss:fff") + "'");
            Sql.Append(" where comanda=" + obj.comanda.ToString().Replace(",", "."));
            Sql.Append(" and cupom= 0 and pdv = 0");
            Sql.Append(" AND filial='" + obj.filial + "'");

            //Executando o comando
            bool retorno = Conexao.executarSql(Sql.ToString());

            return retorno;
        }
        catch (Exception err)
        {

            throw err;
        }

    }

    /// <summary>
    /// Metodo executar a procedure sp_m_Transfere_Comanda
    /// (transfere itens de uma comanda para outra)
    /// </summary>
    /// <param name="ComOrigem">Numero da comanda de origem</param>
    /// <param name="ComDestino">Numero da comanda de destino</param>
    public void TransfereComanda(string ComOrigem, string ComDestino)
    {
        SqlConnection cn = Conexao.novaConexao();
        SqlTransaction transaciton = null;
        try
        {
            if (cn.State != ConnectionState.Open)
                cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_m_Transfere_Comanda";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;
            transaciton = cn.BeginTransaction(IsolationLevel.ReadUncommitted);
            cmd.Transaction = transaciton;

            SqlParameter[] data =
            {
                new SqlParameter() {ParameterName = "@ComandaOrig",SqlDbType = SqlDbType.BigInt, Value= ComOrigem},
                new SqlParameter() {ParameterName = "@ComandaDest",SqlDbType = SqlDbType.BigInt,Value= ComDestino}
            };

            cmd.Parameters.AddRange(data);

            cmd.ExecuteNonQuery();
            transaciton.Commit();
        }
        catch (Exception err)
        {
            transaciton.Rollback();
            throw err;
        }
        finally
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
        }
    }
}

