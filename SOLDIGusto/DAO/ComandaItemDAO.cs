using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using visualSysWeb.dao;

class ComandaItemDAO
{
    #region Propriedades
    public decimal comanda { get; set; }
    public string cupom { get; set; }
    public int pdv { get; set; }
    public string filial { get; set; }
    public string plu { get; set; }
    public int id { get; set; }
    public string origem { get; set; }
    public string usuario { get; set; }
    public DateTime data { get; set; }
    public decimal localizacao { get; set; }
    public decimal qtde { get; set; }
    public decimal unitario { get; set; }
    public decimal total { get; set; }
    public int status { get; set; }
    public string obs { get; set; }
    public DateTime data_cancelamento { get; set; }
    public string integridade { get; set; }
    public DateTime hora { get; set; }
    public DateTime hora_evento { get; set; }
    public int tip_id { get; set; }
    public string datac { get; set; }
    public int fechada { get; set; }
    public string Usuario_Cancelamento { get; set; }
    public string motivo { get; set; }
    public int Loja { get; set; }
    public string OBs_Orig_PLU { get; set; }
    public int Obs_Orig_ID { get; set; }
    public string Motivo_Cancelamento { get; set; }
    public decimal Estoque { get; set; }
    public string Descrição { get; set; }
    public int Terminal { get; set; }
    public string Idseq { get; set; }

    #endregion

    /// <summary>
    /// Busca os itens da comanda
    /// </summary>
    /// <param name="Com">Numero da comanda</param>
    /// <returns></returns>
    public List<ComandaItemDAO> BuscarItensComanda(int Com)
    {
        SqlDataReader rs = null;

        try
        {
            StringBuilder Sql = new StringBuilder();

            Sql.Append("Select Comanda_item.*,MERCADORIA.DESCRICAO from Comanda_item ");
            Sql.Append("INNER JOIN MERCADORIA on MERCADORIA.PLU = Comanda_item.plu ");
            Sql.Append("where cupom = 0 and comanda =" + Com);
            //Sql.Append(" AND Comanda_item.ORIGEM = 'MBL'");
            Sql.Append(" AND DATA_CANCELAMENTO IS NULL ");

            //Executando o comando
            rs = Conexao.consulta(Sql.ToString(), null, false);

            List<ComandaItemDAO> ListaItens = new List<ComandaItemDAO>();


            //Verificando os resultado da busca
            while (rs.Read())
            {
                ComandaItemDAO Obj = new ComandaItemDAO();
                Obj.comanda = Funcoes.ConvertstrToInt(rs["comanda"].ToString());
                Obj.status = Funcoes.ConvertstrToInt(rs["status"].ToString());
                Obj.plu = rs["plu"].ToString();
                Obj.obs = rs["obs"].ToString();
                Obj.qtde = Funcoes.ConvertstrToDecimal(rs["qtde"].ToString());
                Obj.total = Funcoes.ConvertstrToDecimal(rs["total"].ToString());
                Obj.unitario = Funcoes.ConvertstrToDecimal(rs["unitario"].ToString());
                Obj.usuario = rs["usuario"].ToString();
                Obj.origem = rs["ORIGEM"].ToString();
                Obj.data = Funcoes.ConvertstrToDateTime(rs["data"].ToString());
                Obj.hora = Funcoes.ConvertstrToDateTime(rs["hora"].ToString());
                Obj.id = Funcoes.ConvertstrToInt(rs["id"].ToString());
                Obj.Descrição = rs["DESCRICAO"].ToString();
                Obj.Terminal = Funcoes.ConvertstrToInt(rs["Terminal"].ToString());
                Obj.Idseq = rs["Idseq"].ToString();


                ListaItens.Add(Obj);
            }

            return ListaItens;

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

    public List<ComandaItemDAO> BuscarItensPendentesComanda(int Com)
    {
        SqlDataReader rs = null;

        try
        {
            StringBuilder Sql = new StringBuilder();

            Sql.Append("Select Comanda_item.*,MERCADORIA.DESCRICAO from Comanda_item ");
            Sql.Append("INNER JOIN MERCADORIA on MERCADORIA.PLU = Comanda_item.plu ");
            Sql.Append("where cupom = 0 and comanda =" + Com);
            Sql.Append(" AND Comanda_item.ORIGEM != 'MBL'");
            Sql.Append(" AND DATA_CANCELAMENTO IS NULL ");

            //Executando o comando
            rs = Conexao.consulta(Sql.ToString(), null, false);

            List<ComandaItemDAO> ListaItens = new List<ComandaItemDAO>();


            //Verificando os resultado da busca
            while (rs.Read())
            {
                ComandaItemDAO Obj = new ComandaItemDAO();
                Obj.comanda = Funcoes.ConvertstrToInt(rs["comanda"].ToString());
                Obj.status = Funcoes.ConvertstrToInt(rs["status"].ToString());
                Obj.plu = rs["plu"].ToString();
                Obj.obs = rs["obs"].ToString();
                Obj.qtde = Funcoes.ConvertstrToDecimal(rs["qtde"].ToString());
                Obj.total = Funcoes.ConvertstrToDecimal(rs["total"].ToString());
                Obj.unitario = Funcoes.ConvertstrToDecimal(rs["unitario"].ToString());
                Obj.usuario = rs["usuario"].ToString();
                Obj.origem = rs["ORIGEM"].ToString();
                Obj.data = Funcoes.ConvertstrToDateTime(rs["data"].ToString());
                Obj.hora = Funcoes.ConvertstrToDateTime(rs["hora"].ToString());
                Obj.id = Funcoes.ConvertstrToInt(rs["id"].ToString());
                Obj.Descrição = rs["DESCRICAO"].ToString();
                Obj.Terminal = Funcoes.ConvertstrToInt(rs["Terminal"].ToString());
                Obj.Idseq = rs["Idseq"].ToString();
                ListaItens.Add(Obj);
            }

            return ListaItens;

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
    /// Executa a procedure sp_m_insere_item_comanda
    /// (Insere um item a comanda)
    /// </summary>
    /// <param name="obj">Objeto do tipo ComandaItemDAO preenchido</param>
    /// <returns></returns>
    public bool InserirItemComanda(ComandaItemDAO obj)
    {
        SqlConnection cn = Conexao.novaConexao();

        try
        {
            if (cn.State != ConnectionState.Open)
                cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_m_insere_item_comanda";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            SqlParameter[] data =
            {
                new SqlParameter() {ParameterName = "@comanda", Value= obj.comanda},
                new SqlParameter() {ParameterName = "@filial",Value= obj.filial},
                new SqlParameter() {ParameterName = "@plu", Value= obj.plu},
                new SqlParameter() {ParameterName = "@usuario", Value= obj.usuario},
                new SqlParameter() {ParameterName = "@data", SqlDbType = SqlDbType.DateTime,Value= obj.data},
                new SqlParameter() {ParameterName = "@localizacao", SqlDbType = SqlDbType.Decimal,Value= (Parametros.Bloqueia_Impressao ? 999 :  obj.localizacao)},
                new SqlParameter() {ParameterName = "@qtde",SqlDbType = SqlDbType.Decimal, Value= obj.qtde},
                new SqlParameter() {ParameterName = "@unitario",SqlDbType = SqlDbType.Decimal, Value= obj.unitario},
                new SqlParameter() {ParameterName = "@total",SqlDbType = SqlDbType.Decimal, Value= obj.total},
                new SqlParameter() {ParameterName = "@status", SqlDbType = SqlDbType.TinyInt,Value= obj.status},
                new SqlParameter() {ParameterName = "@cData", SqlDbType = SqlDbType.VarChar,Value= obj.data},
                new SqlParameter() {ParameterName = "@Loja",SqlDbType = SqlDbType.TinyInt, Value= obj.Loja},
                new SqlParameter() {ParameterName = "@Tip_id", SqlDbType = SqlDbType.Int,Value= obj.Terminal}
            };

            cmd.Parameters.AddRange(data);

            cmd.ExecuteNonQuery();
            return true;
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
    /// Cancela um item da comanda
    /// </summary>
    /// <param name="obj">Objeto do tipo ComandaItemDAO preenchido</param>
    /// <returns></returns>
    public bool CancelarItemComanda(ComandaItemDAO obj)
    {
        try
        {
            //Armazenando o comando em uma string
            StringBuilder Sql = new StringBuilder();
            Sql.Append("Set Language 'us_english'; ");
            Sql.Append("Update Comanda_item set ");
            Sql.Append("Motivo_Cancelamento='" + obj.Motivo_Cancelamento + "'");
            Sql.Append(",Usuario_Cancelamento='" + obj.Usuario_Cancelamento + "'");
            Sql.Append(",data_cancelamento ='" + obj.data_cancelamento.ToString("yyyy-MM-dd HH:mm:ss:fff") + "'");
            Sql.Append(" where comanda =" + obj.comanda.ToString().Replace(",", "."));
            Sql.Append(" and id=" + obj.id);
            Sql.Append(" and plu=" + obj.plu);
            Sql.Append(" and cupom= 0");
            Sql.Append(" and Data_Cancelamento IS NULL");
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
    /// Pega o maior ID (Sequencia de Item) da comanda atual
    /// </summary>
    /// <param name="Com">Numero da comanda</param>
    /// <returns></returns>
    public int PegarIdProd(int Com)
    {
        SqlDataReader rs = null;

        try
        {
            StringBuilder Sql = new StringBuilder();

            Sql.Append("Select Max(id) as ID from Comanda_item ");
            Sql.Append("where cupom = 0 and comanda =" + Com);
            //Sql.Append(" AND Comanda_item.ORIGEM = 'MBL'");

            //Executando o comando
            rs = Conexao.consulta(Sql.ToString(), null, false);

            int ID = 0;

            //Verificando os resultado da busca
            if (rs.Read())
            {
                ID = Funcoes.ConvertstrToInt(rs["ID"].ToString());
            }

            return ID;
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
    /// Executa a procedure sp_m_comanda_finaliza_ok
    /// </summary>
    /// <param name="obj">Objeto do tipo ComandaItemDAO preenchido</param>
    public void Com_Finaliza_ok(ComandaItemDAO obj)
    {
        SqlConnection cn = Conexao.novaConexao();

        try
        {
            if (cn.State != ConnectionState.Open)
                cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_m_comanda_finaliza_ok";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            SqlParameter[] data =
            {
                new SqlParameter() {ParameterName = "@filial", Value= obj.filial},
                new SqlParameter() {ParameterName = "@numeroComanda",SqlDbType = SqlDbType.Int,Value= obj.comanda},
                new SqlParameter() {ParameterName = "@tip_id",SqlDbType = SqlDbType.Int, Value= Parametros.Terminal},
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

    /// <summary>
    /// Executa a procedure sp_m_comanda_finaliza
    /// </summary>
    /// <param name="obj">Objeto do tipo ComandaItemDAO preenchido</param>
    /// <returns></returns>
    public void Com_Finaliza(ComandaItemDAO obj)
    {
        SqlConnection cn = Conexao.novaConexao();

        try
        {
            if (cn.State != ConnectionState.Open)
                cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_m_comanda_finaliza";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            SqlParameter[] data =
            {
                new SqlParameter() {ParameterName = "@filial", Value= obj.filial},
                new SqlParameter() {ParameterName = "@numeroComanda",Value= obj.comanda}
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
    /// Busca o local da comanda atual
    /// </summary>
    /// <param name="Com">Numero da comanda</param>
    /// <returns></returns>
    public int BuscarLocalComanda(string Com)
    {
        SqlDataReader rs = null;

        try
        {
            StringBuilder Sql = new StringBuilder();

            Sql.Append("SELECT TOP 1 ISNULL(Comanda_Item.Localizacao, 0) as local FROM Comanda_Item ");
            Sql.Append("where cupom = 0 and comanda =" + Com);
            Sql.Append(" AND Comanda_item.ORIGEM = 'MBL'");
            Sql.Append(" AND DATA_CANCELAMENTO IS NULL ");
            Sql.Append("ORDER BY Comanda_Item.Data DESC");

            //Executando o comando
            rs = Conexao.consulta(Sql.ToString(), null, false);


            int Local = 0;
            //Verificando os resultado da busca
            if (rs.Read())
            {
                Local = Funcoes.ConvertstrToInt(rs["local"].ToString());
            }

            return Local;

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
    /// Deleta as linhas das tabelas Comanda_Item e a Comanda_Item_Obs que estejam ligadas 
    /// e não tenham sido finalizadas
    /// </summary>
    /// <param name="obj">Objeto do tipo ComandaItemDAO preenchido</param>
    /// <returns></returns>
    public bool DeletarItemComandaComOBS(ComandaItemDAO obj)
    {
        try
        {
            //Armazenando o comando em uma string
            StringBuilder Sql = new StringBuilder();
            Sql.Append("DELETE Comanda_Item_Obs FROM Comanda_Item ");
            Sql.Append("WHERE Comanda_Item_Obs.Comanda = Comanda_Item.Comanda ");
            Sql.Append("AND Comanda_Item_obs.Comanda = " + obj.comanda + " AND ");
            Sql.Append("Comanda_Item_Obs.PLU = Comanda_Item.PLU ");
            Sql.Append("AND Comanda_Item_Obs.PLU = '" + obj.plu + "'");
            Sql.Append(" AND Comanda_Item_Obs.ID = Comanda_Item.ID ");
            Sql.Append("AND Comanda_Item_Obs.ID = " + obj.id);
            Sql.Append(" AND Comanda_Item.Origem = 'TM1'");

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
    /// Deleta as linhas das tabelas Comanda_Item 
    /// que não tenham sido finalizadas
    /// </summary>
    /// <param name="obj">Objeto do tipo ComandaItemDAO preenchido</param>
    /// <returns></returns>
    public bool DeletarItemComanda(ComandaItemDAO obj)
    {
        try
        {
            //Armazenando o comando em uma string
            StringBuilder Sql = new StringBuilder();
            Sql.Append("DELETE FROM Comanda_Item WHERE Comanda_Item.Comanda = " + obj.comanda);
            Sql.Append("AND PLU = '" + obj.plu + "'");
            Sql.Append("AND Comanda_Item.ID = " + obj.id);
            Sql.Append("AND Comanda_Item.Origem = 'TM1'");


            //Executando o comando
            bool retorno = Conexao.executarSql(Sql.ToString());

            return retorno;
        }
        catch (Exception err)
        {

            throw err;
        }

    }

    public bool CancelarPedidoComanda(int Com)
    {
        SqlDataReader rs = null;

        try
        {
            StringBuilder Sql = new StringBuilder();

            Sql.Append("Select Comanda_item.*,MERCADORIA.DESCRICAO from Comanda_item ");
            Sql.Append("INNER JOIN MERCADORIA on MERCADORIA.PLU = Comanda_item.plu ");
            Sql.Append("where cupom = 0 and comanda =" + Com);
            Sql.Append(" AND Comanda_item.ORIGEM like 'TM%'");
            //Sql.Append(" AND Terminal = " + Parametros.Terminal);



            //Executando o comando
            rs = Conexao.consulta(Sql.ToString(), null, false);

            //Verificando os resultado da busca
            while (rs.Read())
            {
                ComandaItemDAO Obj = new ComandaItemDAO();
                Obj.comanda = Funcoes.ConvertstrToInt(rs["comanda"].ToString());
                Obj.status = Funcoes.ConvertstrToInt(rs["status"].ToString());
                Obj.plu = rs["plu"].ToString();
                Obj.obs = rs["obs"].ToString();
                Obj.qtde = Funcoes.ConvertstrToDecimal(rs["qtde"].ToString());
                Obj.total = Funcoes.ConvertstrToDecimal(rs["total"].ToString());
                Obj.unitario = Funcoes.ConvertstrToDecimal(rs["unitario"].ToString());
                Obj.usuario = rs["usuario"].ToString();
                Obj.data = Funcoes.ConvertstrToDateTime(rs["data"].ToString());
                Obj.hora = Funcoes.ConvertstrToDateTime(rs["hora"].ToString());
                Obj.id = Funcoes.ConvertstrToInt(rs["id"].ToString());
                Obj.Descrição = rs["DESCRICAO"].ToString();
                Obj.Terminal = Funcoes.ConvertstrToInt(rs["Terminal"].ToString());
                Obj.Idseq = rs["Idseq"].ToString();

                DeletarItemComandaComOBS(Obj);
                DeletarItemComanda(Obj);
            }

            return true;

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

