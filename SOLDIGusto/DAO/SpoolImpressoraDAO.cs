using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using visualSysWeb.dao;

class SpoolImpressoraDAO
{
    public string Descricao { get; set; }
    public string Porta { get; set; }


    public List<SpoolImpressoraDAO> BuscarImpressoras()
    {
        SqlDataReader rs = null;

        try
        {
            StringBuilder Sql = new StringBuilder();
            Sql.Append("SELECT Descricao, Porta FROM Spool_Impressoras");


            //Executando o comando
            rs = Conexao.consulta(Sql.ToString(), null, false);

            List<SpoolImpressoraDAO> Imp = new List<SpoolImpressoraDAO>();

            //Verificando os resultado da busca
            while (rs.Read())
            {
                SpoolImpressoraDAO Obj = new SpoolImpressoraDAO();
                Obj.Descricao = rs["Descricao"].ToString();
                Obj.Porta = rs["Porta"].ToString();
                Imp.Add(Obj);
            }

            return Imp;
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

