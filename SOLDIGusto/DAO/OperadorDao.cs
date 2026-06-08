using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using visualSysWeb.dao;

class OperadorDao
{
    public int ID_Operador { get; set; }
    public string Senha { get; set; }
    public int ID_NivelAcesso { get; set; }
    public string Cargo { get; set; }
    public string Nome { get; set; }
    public bool OpCaixa { get; set; }
    public string Filial { get; set; }
    public int inativo { get; set; }

    public OperadorDao LogarOp(int senha)
    {
        SqlDataReader rs = null;

        try
        {
            StringBuilder Sql = new StringBuilder();

           // Sql.Append("Select * from Operadores where senha =" + senha);
            Sql.Append("SELECT Codigo, Nome, Senha, Cancela_Item,usa_terminal FROM Funcionario ");
            Sql.Append("WHERE RTRIM(LTRIM(senha)) = " + senha);
            Sql.Append(" ");


            //Executando o comando
            rs = Conexao.consulta(Sql.ToString(), null, false);

            OperadorDao Obj = new OperadorDao();

            //Verificando os resultado da busca
            if (rs.Read())
            {
                //Obj.ID_Operador = Funcoes.ConvertstrToInt(rs["ID_Operador"].ToString());
                //Obj.Senha = rs["Senha"].ToString();
                //Obj.Nome = rs["Nome"].ToString();
                //Obj.ID_NivelAcesso = Funcoes.ConvertstrToInt(rs["ID_NivelAcesso"].ToString());
                //Obj.Cargo = rs["Cargo"].ToString();
                //Obj.Filial = rs["Filial"].ToString();
                //Obj.OpCaixa = Funcoes.ConvertstrToBoolean(rs["OpCaixa"].ToString());
                //Obj.inativo = Funcoes.ConvertstrToInt(rs["inativo"].ToString());

                Obj.ID_Operador = Funcoes.ConvertstrToInt(rs["Codigo"].ToString());
                Obj.Senha = rs["Senha"].ToString();
                Obj.Nome = rs["Nome"].ToString();
                Obj.ID_NivelAcesso = Funcoes.ConvertstrToInt(rs["Cancela_Item"].ToString());
                if (Obj.ID_NivelAcesso == 1)
                    Obj.ID_NivelAcesso = 3;
                Obj.inativo = Funcoes.ConvertstrToInt(rs["usa_terminal"].ToString());
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

