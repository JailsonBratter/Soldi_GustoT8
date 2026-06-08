using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using visualSysWeb.dao;

class ImpressaoDao
{
    #region Proriedades
    public ComandaItemDAO Item { get; set; }
    public string NomeFantasia { get; set; }
    public string RazaoSocial { get; set; }
    #endregion

    /// <summary>
    /// Metodo para buscar o conteudo necessario para impressão dos itens da comanda(pedido)
    /// </summary>
    /// <param name="Comanda">Numero da comanda</param>
    /// <returns>Retorna um obj do tipo List<ImpressaoDao></returns>
    public List<ImpressaoDao> BuscaConteudo(int Comanda)
    {
        SqlDataReader rs = null;

        try
        {
            StringBuilder Sql = new StringBuilder();

            Sql.Append("SELECT a.PLU, b.Descricao_resumida, a.Qtde, a.Total, a.Usuario, a.Data, ");
            Sql.Append("Fechada = IsNull(a.Fechada,0), a.Filial, a.Localizacao, a.Unitario,");
            Sql.Append(" a.Status, a.Datac, a.Id, c.Fantasia, c.razao_social ");
            Sql.Append("FROM Comanda_Item a INNER JOIN Mercadoria b ON a.PLU = b.PLU ");
            Sql.Append("inner join filial c on a.filial = c.filial WHERE a.Cupom = 0 ");
            Sql.Append("AND a.Data_Cancelamento IS NULL And Convert(int, Comanda) = " + Comanda);
          

            //Executando o comando
            rs = Conexao.consulta(Sql.ToString(), null, false);

            List<ImpressaoDao> ListaItens = new List<ImpressaoDao>();
            

            //Verificando os resultado da busca
            while (rs.Read())
            {
                ImpressaoDao Obj = new ImpressaoDao();
                ComandaItemDAO objc = new ComandaItemDAO();
                objc.status = Funcoes.ConvertstrToInt(rs["Status"].ToString());
                objc.plu = rs["PLU"].ToString();
                objc.qtde = Funcoes.ConvertstrToDecimal(rs["Qtde"].ToString());
                objc.total = Funcoes.ConvertstrToDecimal(rs["Total"].ToString());
                objc.unitario = Funcoes.ConvertstrToDecimal(rs["Unitario"].ToString());
                objc.usuario = rs["Usuario"].ToString();
                objc.data = Funcoes.ConvertstrToDateTime(rs["Data"].ToString());
                objc.id = Funcoes.ConvertstrToInt(rs["Id"].ToString());
                objc.Descrição = rs["Descricao_resumida"].ToString();
                objc.localizacao = Funcoes.ConvertstrToDecimal(rs["Localizacao"].ToString());
                Obj.Item = objc;
                Obj.NomeFantasia = rs["Fantasia"].ToString();
                Obj.RazaoSocial = rs["razao_social"].ToString();

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
}

