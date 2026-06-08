using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using visualSysWeb.dao;

class ObsDAO
{
    #region Propriedades
    public string filial { get; set; }
    public string plu { get; set; }
    public string obs { get; set; }
    public string plu_item_adc { get; set; }
    public DateTime IndisponivelAte { get; set; }
    public bool Obrigatorio { get; set; }
    public Decimal Preco { get; set; }
    #endregion

    /// <summary>
    /// Executa a procedure sp_m_obs
    /// (Busca as observaçoes disponiveis)
    /// </summary>
    /// <param name="Plu">Numero da produto</param>
    /// <returns></returns>
    public List<ObsDAO> BuscarObs(int Plu)
    {

        SqlConnection cn = Conexao.novaConexao();

        try
        {
            if (cn.State != ConnectionState.Open)
                cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_m_obs";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            SqlParameter[] data =
            {
                new SqlParameter() {ParameterName = "@filial", Value= "MATRIZ"},
                new SqlParameter() {ParameterName = "@plu",Value= Plu}
            };

            cmd.Parameters.AddRange(data);

            SqlDataReader rs = cmd.ExecuteReader();

            List<ObsDAO> Lista = new List<ObsDAO>();

            //Verificando os resultado da busca
            while (rs.Read())
            {
                ObsDAO Obj = new ObsDAO();
                Obj.obs = rs["observacao"].ToString();
                Obj.plu_item_adc = rs["codigoCobranca"].ToString();
                Obj.Preco = Funcoes.ConvertstrToDecimal(rs["PrcAd"].ToString());
                Lista.Add(Obj);
            }

            return Lista;
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




}

