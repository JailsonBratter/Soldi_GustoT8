using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using visualSysWeb.dao;

class DepartamentoDAO
{
    #region Propriedades
    public string Codigo_departamento { get; set; }
    public string Filial { get; set; }
    public string Codigo_Portaria { get; set; }
    public Decimal Codigo_Tributacao { get; set; }
    public string Codigo_SubGrupo { get; set; }
    public string Descricao_departamento { get; set; }
    public Decimal Margem { get; set; }
    public bool tecla { get; set; }
    public bool impressora_remota { get; set; }
    public bool id_trm { get; set; }
    public string descricao_impressora { get; set; }
    public Decimal desconto { get; set; }
    public string dias_semana { get; set; }
    #endregion

    /// <summary>
    /// Busca um departamento existente de acordo com o codigo
    /// </summary>
    /// <param name="Cod">Codigodo depto</param>
    /// <returns></returns>
    public DepartamentoDAO BuscarDepto(string Cod)
    {
        SqlDataReader rs = null;

        try
        {
            StringBuilder Sql = new StringBuilder();
            Sql.Append("Select * from departamento where Codigo_departamento =" + Cod);


            //Executando o comando
            rs = Conexao.consulta(Sql.ToString(), null, false);

            DepartamentoDAO Obj = new DepartamentoDAO();

            //Verificando os resultado da busca
            if (rs.Read())
            {
                Obj.Codigo_departamento = rs["Codigo_departamento"].ToString();
                Obj.Filial = rs["Filial"].ToString();
                Obj.Codigo_Portaria = rs["Codigo_Portaria"].ToString();
                Obj.Codigo_Tributacao = Funcoes.ConvertstrToDecimal(rs["Codigo_Tributacao"].ToString());
                Obj.Codigo_SubGrupo = rs["Codigo_SubGrupo"].ToString();
                Obj.Descricao_departamento = rs["Descricao_departamento"].ToString();
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

