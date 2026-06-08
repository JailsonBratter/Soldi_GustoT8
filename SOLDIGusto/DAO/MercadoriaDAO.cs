using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using visualSysWeb.dao;

class MercadoriaDAO
{
    #region Propriedades
    public int PLU { get; set; }
    public string DESCRICAO { get; set; }
    public string EAN { get; set; }
    public Decimal PRECO { get; set; }
    public string Peso_Variavel { get; set; }
    public decimal SaldoAtual { get; set; }
    public decimal PrecoPromo { get; set; }
    public bool Promocao { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
    public int Inativo { get; set; }
    #endregion

    /// <summary>
    /// Busca varias mercadorias por aproximação
    /// </summary>
    /// <param name="Busca">Texto de busca (Para DESCRICAO,PLU e PRECO)</param>
    /// <param name="Ordem">Ordem do resultado (Para PLU(1),DESCRICAO(2) e PRECO(3))
    /// (Para ordem desc acrescente (*10))</param>
    /// <param name="Ctg">Codigo da categoria do produto 
    /// (se esse campo estiver nulo, será buscado todas as categorias)</param>
    /// <returns></returns>
    public List<MercadoriaDAO> BuscarMercadoriaLike(string Busca,int Ordem, string Ctg)
    {
        SqlDataReader rs = null;

        try
        {
            StringBuilder Sql = new StringBuilder();
            Sql.Append("SELECT DISTINCT top 100 MERCADORIA.PLU, MERCADORIA.DESCRICAO, ");
            Sql.Append("MERCADORIA_LOJA.PRECO FROM MERCADORIA INNER JOIN MERCADORIA_LOJA ");
            Sql.Append("ON MERCADORIA_LOJA.PLU = MERCADORIA.PLU INNER JOIN TIPO ");
            Sql.Append("ON Mercadoria.Tipo = Tipo.Tipo INNER JOIN W_BR_CADASTRO_DEPARTAMENTO ");
            
            Sql.Append("ON MERCADORIA.CODIGO_DEPARTAMENTO = W_BR_CADASTRO_DEPARTAMENTO.CODIGO_DEPARTAMENTO ");
            Sql.Append("LEFT OUTER join EAN on EAN.PLU = Mercadoria.plu ");
            Sql.Append("WHERE ISNULL(Mercadoria.Inativo, 0) = 0 AND  Tipo.Gera_Carga = 1  AND MERCADORIA.DESCRICAO <> '' ");
            if (Ctg != null && Ctg.Length > 0)
            {
                if(Ctg.Length == 1)
                Sql.Append(" AND RTRIM(LTRIM(W_BR_CADASTRO_DEPARTAMENTO.Codigo_Grupo)) = " + Ctg);
                else if(Ctg.Length == 6 )
                Sql.Append( " AND RTRIM(LTRIM(W_BR_CADASTRO_DEPARTAMENTO.Codigo_SubGrupo)) = '" + Ctg + "'");
                else if (Ctg.Length == 9)
                Sql.Append(" AND RTRIM(LTRIM(W_BR_CADASTRO_DEPARTAMENTO.Codigo_Departamento)) = '" + Ctg + "'");
            }
            //Rotinas para melhorar a pesquisa
            //Checa se trata de números apenas
            if (Funcoes.IsNumeric(Busca))
            {
                //Checa se a pesquisa é por PLU ou EAN
                if (Funcoes.ConvertstrToLong(Busca) > 999999)
                {
                    Sql.Append("AND EAN.EAN like '%" + Busca + "%' ");
                }
                else
                {
                    Sql.Append("AND Mercadoria.PLU = '" + Busca + "'");
                }
            }
            //Se não trata de número e não está vazio, o sistema efetuará a consulta a partir do terceiro caracter digitado.
            else 
            {
                if (Busca.Trim().Length > 3)
                {
                    Sql.Append("AND MERCADORIA.DESCRICAO like '%" + Busca.Replace(" ", "%") + "%' ");
                }
                else
                {
                    return null;
                }
            }

            //Sql.Append("or MERCADORIA_LOJA.PRECO like '%" + Busca.Replace(",",".") + "%' )");

            if (Ordem == 1)
                Sql.Append("order by MERCADORIA.PLU" );
            else if (Ordem == 2)
                Sql.Append("order by MERCADORIA.DESCRICAO");
            else if (Ordem == 3)
                Sql.Append("order by MERCADORIA_LOJA.PRECO");
            else if(Ordem == 10)
                Sql.Append("order by MERCADORIA.PLU desc");
            else if (Ordem == 20)
                Sql.Append("order by MERCADORIA.DESCRICAO desc");
            else if (Ordem == 30)
                Sql.Append("order by MERCADORIA_LOJA.PRECO desc");

            

            //Executando o comando
            rs = Conexao.consulta(Sql.ToString(), null, false);

            List<MercadoriaDAO> ListaItens = new List<MercadoriaDAO>();


            //Verificando os resultado da busca
            while (rs.Read())
            {
                MercadoriaDAO Obj = new MercadoriaDAO();
                Obj.PLU = Funcoes.ConvertstrToInt(rs["PLU"].ToString());
                Obj.PRECO = Funcoes.ConvertstrToDecimal(rs["PRECO"].ToString());
                Obj.DESCRICAO = rs["DESCRICAO"].ToString();

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
    /// Busca uma mercadoria por PLU ou EAN
    /// </summary>
    /// <param name="Plu">Plu ou EAN </param>
    /// <returns></returns>
    public MercadoriaDAO BuscarMercadoria(string Plu)
    {
        SqlDataReader rs = null;

        try
        {
            StringBuilder Sql = new StringBuilder();

            Sql.Append("SELECT TOP 1 MERCADORIA.PLU, MERCADORIA.DESCRICAO,ISNULL(EAN.EAN,' ') AS EAN,");
            if (Parametros.Delivery)
                Sql.Append("(CASE WHEN ISNULL(Mercadoria.Preco_Referencia, 0) > 0 THEN Mercadoria.Preco_Referencia ELSE Mercadoria_Loja.PRECO END) AS PRECO,");
            else
                Sql.Append("Mercadoria_Loja.PRECO,");
            Sql.Append("Mercadoria_Loja.Preco_promocao, Mercadoria_Loja.Promocao, Mercadoria_Loja.data_inicio, ");
            Sql.Append("Mercadoria_Loja.data_fim,Peso_variavel, Mercadoria_Loja.saldo_atual, PV = '', ISNULL(Mercadoria.Inativo, 0) AS Inativo ");
            Sql.Append("FROM MERCADORIA LEFT OUTER JOIN EAN ON  MERCADORIA.PLU = EAN.PLU ");
            Sql.Append("inner join Mercadoria_Loja on Mercadoria_Loja.PLU = Mercadoria.PLU ");
            Sql.Append("WHERE Mercadoria_Loja.Filial = 'MATRIZ' ");
            Sql.Append("and (CONVERT(FLOAT, MERCADORIA.PLU) = " + Plu);
            Sql.Append(" or CONVERT(FLOAT, EAN.EAN) = " + Plu +")");

            
            //Executando o comando
            rs = Conexao.consulta(Sql.ToString(), null, false);

            MercadoriaDAO Obj = new MercadoriaDAO();

            //Verificando os resultado da busca
            if (rs.Read())
            {
                Obj.PLU = Funcoes.ConvertstrToInt(rs["PLU"].ToString());
                Obj.DESCRICAO = rs["DESCRICAO"].ToString();
                Obj.EAN = rs["EAN"].ToString();
                Obj.PRECO = Funcoes.ConvertstrToDecimal(rs["PRECO"].ToString());
                Obj.Peso_Variavel = rs["Peso_Variavel"].ToString();
                Obj.SaldoAtual = Funcoes.ConvertstrToDecimal(rs["saldo_atual"].ToString());
                Obj.PrecoPromo = Funcoes.ConvertstrToDecimal(rs["Preco_promocao"].ToString());
                Obj.Promocao = Funcoes.ConvertstrToBoolean(rs["Promocao"].ToString());
                Obj.DataInicio = Funcoes.ConvertstrToDateTime(rs["data_inicio"].ToString());
                Obj.DataFim = Funcoes.ConvertstrToDateTime(rs["data_fim"].ToString());
                Obj.Inativo = Funcoes.ConvertstrToInt(rs["Inativo"].ToString());
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
}


