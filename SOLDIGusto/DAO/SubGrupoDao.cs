using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using visualSysWeb.dao;

class SubGrupoDao
{
    public string Codigo_SubGrupo { get; set; }
    public string Filial { get; set; }
    public Decimal Codigo_Grupo { get; set; }
    public string Descricao_SubGrupo { get; set; }


    public SubGrupoDao BuscarSubGrupo(string Cod)
    {
        SqlDataReader rs = null;

        try
        {
            StringBuilder Sql = new StringBuilder();
            Sql.Append("Select * from subgrupo where Codigo_SubGrupo =" + Cod);


            //Executando o comando
            rs = Conexao.consulta(Sql.ToString(), null, false);

            SubGrupoDao Obj = new SubGrupoDao();

            //Verificando os resultado da busca
            if (rs.Read())
            {
                Obj.Codigo_SubGrupo = rs["Codigo_SubGrupo"].ToString();
                Obj.Filial = rs["Filial"].ToString();
                Obj.Descricao_SubGrupo = rs["Descricao_SubGrupo"].ToString();
                Obj.Codigo_Grupo = Funcoes.ConvertstrToDecimal(rs["Codigo_Grupo"].ToString());
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

