using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using visualSysWeb.dao;

namespace SOLDIGusto.DAO
{
    public class ComandaItemintegracao
    {
        public long id_integracao { get; set; }

        public decimal? comanda { get; set; }

        public string PLU { get; set; }

        public int id { get; set; }

        public decimal? qtde { get; set; }

        public decimal? unitario { get; set; }

        public string operacao { get; set; }

        public DateTime data_alteracao { get; set; }

        public string idSeq { get; set; }

        public string usuario { get; set; }

        public bool processado { get; set; }

        public string NomeProduto { get; set; }
        public DateTime data_cancelamento { get; set; }

        public decimal? Comanda_Destino { get; set; }
        public bool InserirTransferenciaComanda(string comandaOrigem,string comandaDestino,string usuario)
        {
            try
            {
                using (SqlConnection conn = Conexao.novaConexao())
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;

                    cmd.CommandText = @"
                INSERT INTO comanda_item_integracao
                (
                    comanda,
                    PLU,
                    id,
                    operacao,
                    data_alteracao,
                    usuario,
                    processado,
                    Comanda_Destino
                )
                VALUES
                (
                    @comanda,
                    '',
                    0,
                    'TC',
                    GETDATE(),
                    @usuario,
                    0,
                    @Comanda_Destino
                )";

                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.Add("@comanda", SqlDbType.Decimal)
                        .Value = Convert.ToDecimal(comandaOrigem);

                    cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 100)
                        .Value = string.IsNullOrEmpty(usuario)
                            ? (object)DBNull.Value
                            : usuario;

                    cmd.Parameters.Add("@Comanda_Destino", SqlDbType.Decimal)
                        .Value = Convert.ToDecimal(comandaDestino);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    "InserirTransferenciaComanda: " + ex.Message);

                return false;
            }
        }

        public bool InserirCancelamentoTotalComanda(string comanda, string usuario)
        {
            try
            {
                using (SqlConnection conn = Conexao.novaConexao())
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;

                    cmd.CommandText = @"
                INSERT INTO comanda_item_integracao
                (
                    comanda,
                    PLU,
                    id,
                    operacao,
                    data_alteracao,
                    usuario,
                    processado,
                    Comanda_Destino
                )
                VALUES
                (
                    @comanda,
                    '',
                    0,
                    'CT',
                    GETDATE(),
                    @usuario,
                    0,
                    NULL
                )";

                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.Add("@comanda", SqlDbType.Decimal)
                        .Value = Convert.ToDecimal(comanda);

                    cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 100)
                        .Value = string.IsNullOrEmpty(usuario)
                            ? (object)DBNull.Value
                            : usuario;

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    "InserirCancelamentoTotalComanda: " + ex.Message);

                return false;
            }
        }
        public bool InserirCancelamentoItem(
     decimal comanda,
     string plu,
     int id,
     decimal qtde,
     string idSeq,
     string usuario)
        {
            try
            {
                using (SqlConnection conn = Conexao.novaConexao())
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;

                    cmd.CommandText = @"
                INSERT INTO comanda_item_integracao
                (
                    comanda,
                    PLU,
                    id,
                    qtde,
                    operacao,
                    data_alteracao,
                    idSeq,
                    usuario,
                    processado,
                    data_cancelamento,
                    Comanda_Destino
                )
                VALUES
                (
                    @comanda,
                    @PLU,
                    @id,
                    @qtde,
                    'CI',
                    GETDATE(),
                    @idSeq,
                    @usuario,
                    0,
                    GETDATE(),
                    NULL
                )";

                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.Add("@comanda", SqlDbType.Decimal)
                        .Value = comanda;

                    cmd.Parameters.Add("@PLU", SqlDbType.VarChar, 17)
                        .Value = string.IsNullOrEmpty(plu)
                            ? (object)DBNull.Value
                            : plu;

                    cmd.Parameters.Add("@id", SqlDbType.Int)
                        .Value = id;

                    cmd.Parameters.Add("@qtde", SqlDbType.Decimal)
                        .Value = qtde;

                    cmd.Parameters.Add("@idSeq", SqlDbType.VarChar, 100)
                        .Value = string.IsNullOrEmpty(idSeq)
                            ? (object)DBNull.Value
                            : idSeq;

                    cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 100)
                        .Value = string.IsNullOrEmpty(usuario)
                            ? (object)DBNull.Value
                            : usuario;

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                Funcoes.GravarLog(
                    "InserirCancelamentoItem: " + ex.Message);

                return false;
            }
        }
    }
   

}
