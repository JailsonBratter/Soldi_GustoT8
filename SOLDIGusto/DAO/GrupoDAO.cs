using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using visualSysWeb.dao;

class GrupoDAO
{
    #region Propriedades
    public Decimal Codigo_Grupo { get; set; }
    public string Filial { get; set; }
    public string Descricao_Grupo { get; set; }
    public Decimal Codigo_tributacao { get; set; }
    public bool Tecla { get; set; }
    public Decimal comissao { get; set; }
    public bool estado_grupo { get; set; }
    #endregion

    /// <summary>
    /// Busca um grupo de acordo com o codigo
    /// </summary>
    /// <param name="Cod">Codigo do grupo</param>
    /// <returns></returns>
    public GrupoDAO BuscarGrupo(string Cod)
    {
        SqlDataReader rs = null;

        try
        {
            StringBuilder Sql = new StringBuilder();
            Sql.Append("Select * from grupo where Codigo_Grupo =" + Cod);


            //Executando o comando
            rs = Conexao.consulta(Sql.ToString(), null, false);

            GrupoDAO Obj = new GrupoDAO();

            //Verificando os resultado da busca
            if (rs.Read())
            {
                Obj.Codigo_Grupo = Funcoes.ConvertstrToDecimal(rs["Codigo_Grupo"].ToString());
                Obj.Descricao_Grupo = rs["Descricao_Grupo"].ToString();
                Obj.Filial = rs["Filial"].ToString();
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

