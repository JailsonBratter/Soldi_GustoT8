using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using visualSysWeb.dao;

class ComandaAbertaDAO
{
    public int Terminal { get; set; }
    public int Comanda { get; set; }

    /// <summary>
    /// Metodo para inserir uma nova linha na tabela comanda aberta
    /// </summary>
    /// <param name="obj">Obj do tipo ComandaAbertaDAO preenchido</param>
    /// <returns></returns>
    public bool InserirComandaAberta(ComandaAbertaDAO obj)
    {
        try
        {
            //Armazenando o comando em uma string
            StringBuilder Sql = new StringBuilder();
            Sql.Append("Insert into Comanda_Aberta (Comanda,Terminal) values (");
            Sql.Append( obj.Comanda );
            Sql.Append("," + Parametros.Terminal + ")");

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
    /// Metodo para excluir uma linha na tabela comanda aberta
    /// </summary>
    /// <param name="obj">Obj do tipo ComandaAbertaDAO preenchido</param>
    /// <returns></returns>
    public bool ExcluirComandaAberta(ComandaAbertaDAO obj)
    {
        try
        {
            //Armazenando o comando em uma string
            StringBuilder Sql = new StringBuilder();
            Sql.Append("delete Comanda_Aberta ");
            Sql.Append(" where comanda=" + obj.Comanda);
            Sql.Append(" and Terminal ='" + Parametros.Terminal + "'");

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

