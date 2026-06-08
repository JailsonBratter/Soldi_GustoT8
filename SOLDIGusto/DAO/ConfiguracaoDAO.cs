using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using visualSysWeb.dao;

class ConfiguracaoDAO
{
    #region Prop
    public int ID { get; set; }
    public int Qtde_maxItem { get; set; }
    public string Filial { get; set; }
    public Decimal Valor_maxItem { get; set; }
    public bool Trata_Comanda { get; set; }
    public int Com_RetiraCluna { get; set; }
    public bool Divide_conta { get; set; }
    public bool Solicita_ImpConta { get; set; }
    public bool Com_ApenasLeitura { get; set; }
    public bool Fixa_User { get; set; }
    public bool Solicita_Motivo { get; set; }
    public bool Integra_Balanca { get; set; }
    public string Balanca_porta { get; set; }
    public int Balanca_CodInicio { get; set; }
    public int Balanca_CodFim { get; set; }
    public int Balanca_ItemInicio { get; set; }
    public int Balanca_ItemFim { get; set; }
    public bool Manda_preco { get; set; }
    public int Balanca_Etiqueta { get; set; }
    public int Cod_BtnAtalho1 { get; set; }
    public string Desc_ProdAtalho1 { get; set; }
    public string Leg_BtnAtalho1 { get; set; }
    public int Cod_BtnAtalho2 { get; set; }
    public string Desc_ProdAtalho2 { get; set; }
    public string Leg_BtnAtalho2 { get; set; }
    public int Cod_BtnAtalho3 { get; set; }
    public string Desc_ProdAtalho3 { get; set; }
    public string Leg_BtnAtalho3 { get; set; }
    public int Cod_BtnAtalho4 { get; set; }
    public string Desc_ProdAtalho4 { get; set; }
    public string Leg_BtnAtalho4 { get; set; }
    public int Cod_BtnAtalho5 { get; set; }
    public string Desc_ProdAtalho5 { get; set; }
    public string Leg_BtnAtalho5 { get; set; }
    public int Cod_BtnAtalho6 { get; set; }
    public string Desc_ProdAtalho6 { get; set; }
    public string Leg_BtnAtalho6 { get; set; }
    public int Cod_BtnAtalho7 { get; set; }
    public string Desc_ProdAtalho7 { get; set; }
    public string Leg_BtnAtalho7 { get; set; }
    public int Cod_BtnAtalho8 { get; set; }
    public string Desc_ProdAtalho8 { get; set; }
    public string Leg_BtnAtalho8 { get; set; }
    public int Cod_BtnAtalho9 { get; set; }
    public string Desc_ProdAtalho9 { get; set; }
    public string Leg_BtnAtalho9 { get; set; }
    public int Cod_BtnAtalho10 { get; set; }
    public string Desc_ProdAtalho10 { get; set; }
    public string Leg_BtnAtalho10 { get; set; }
    public int Cod_BtnAtalho11 { get; set; }
    public string Desc_ProdAtalho11 { get; set; }
    public string Leg_BtnAtalho11 { get; set; }
    public int Cod_BtnAtalho12 { get; set; }
    public string Desc_ProdAtalho12 { get; set; }
    public string Leg_BtnAtalho12 { get; set; }
    public string Cod_BtnCtg1 { get; set; }
    public string Cod_BtnCtg2 { get; set; }
    public string Cod_BtnCtg3 { get; set; }
    public string Cod_BtnCtg4 { get; set; }
    public string Cod_BtnCtg5 { get; set; }
    public int Terminal { get; set; }
    public int Velocidade { get; set; }
    public int Pct_calculo { get; set; }

    public bool Altera_local { get; set; }
    public bool Insere_Local { get; set; }

    public string IP_Terminal { get; set; }
    public bool Delivery { get; set; }

    public bool CodigoBarrasDuplicado { get; set; }
    public int CodigoBarrasDuplicadoDigitos { get; set; }

    public bool BloqueiaImpressao { get; set; }
    public string CaractereComanda { get; set; } = "W";

    #endregion

    /// <summary>
    /// Busca a configuração existente (de acordo com o parametro ID_Config)
    /// </summary>
    /// <returns>Retorna um objeto do tipo ConfiguracaoDAO preenchido</returns>
    public ConfiguracaoDAO BuscarConfig()
    {
        SqlDataReader rs = null;
        try
        {
            StringBuilder Sql = new StringBuilder();

            Sql.Append("Select * from Configuracao where Terminal = " + Parametros.Terminal);
            Sql.Append("AND Filial = '" + Parametros.Filial + "'");

            //Executando o comando
            rs = Conexao.consulta(Sql.ToString(), null, false);

            ConfiguracaoDAO Obj = new ConfiguracaoDAO();
            if (rs.Read())
            {
                Obj.ID = Funcoes.ConvertstrToInt(rs["ID"].ToString());
                Obj.Qtde_maxItem = Funcoes.ConvertstrToInt(rs["Qtde_maxItem"].ToString());
                Obj.Valor_maxItem = Funcoes.ConvertstrToDecimal(rs["Valor_maxItem"].ToString());
                Obj.Trata_Comanda = Funcoes.ConvertstrToBoolean(rs["Trata_Comanda"].ToString());
                Obj.Com_RetiraCluna = Funcoes.ConvertstrToInt(rs["Com_RetiraCluna"].ToString());
                Obj.Divide_conta = Funcoes.ConvertstrToBoolean(rs["Divide_conta"].ToString());
                Obj.Solicita_ImpConta = Funcoes.ConvertstrToBoolean(rs["Solicita_ImpConta"].ToString());
                Obj.Com_ApenasLeitura = Funcoes.ConvertstrToBoolean(rs["Com_ApenasLeitura"].ToString());
                Obj.Fixa_User = Funcoes.ConvertstrToBoolean(rs["Fixa_User"].ToString());
                Obj.Integra_Balanca = Funcoes.ConvertstrToBoolean(rs["Integra_Balanca"].ToString());
                Obj.Velocidade = Funcoes.ConvertstrToInt(rs["Velocidade"].ToString());
                Obj.Pct_calculo = Funcoes.ConvertstrToInt(rs["Pct_calculo"].ToString());
                Obj.Solicita_Motivo = Funcoes.ConvertstrToBoolean(rs["Solicita_Motivo"].ToString());
                Obj.Balanca_porta = rs["Balanca_porta"].ToString();
                Obj.Filial = rs["Filial"].ToString();
                Obj.Balanca_CodInicio = Funcoes.ConvertstrToInt(rs["Balanca_CodInicio"].ToString());
                Obj.Balanca_CodFim = Funcoes.ConvertstrToInt(rs["Balanca_CodFim"].ToString());
                Obj.Balanca_ItemInicio = Funcoes.ConvertstrToInt(rs["Balanca_ItemInicio"].ToString());
                Obj.Balanca_ItemFim = Funcoes.ConvertstrToInt(rs["Balanca_ItemFim"].ToString());
                Obj.Balanca_Etiqueta = Funcoes.ConvertstrToInt(rs["Balanca_Etiqueta"].ToString());
                Obj.Cod_BtnAtalho1 = Funcoes.ConvertstrToInt(rs["Cod_BtnAtalho1"].ToString());
                Obj.Desc_ProdAtalho1 = rs["Desc_ProdAtalho1"].ToString();
                Obj.Leg_BtnAtalho1 = rs["Leg_BtnAtalho1"].ToString();
                Obj.Cod_BtnAtalho2 = Funcoes.ConvertstrToInt(rs["Cod_BtnAtalho2"].ToString());
                Obj.Desc_ProdAtalho2 = rs["Desc_ProdAtalho2"].ToString();
                Obj.Leg_BtnAtalho2 = rs["Leg_BtnAtalho2"].ToString();
                Obj.Cod_BtnAtalho3 = Funcoes.ConvertstrToInt(rs["Cod_BtnAtalho3"].ToString());
                Obj.Desc_ProdAtalho3 = rs["Desc_ProdAtalho3"].ToString();
                Obj.Leg_BtnAtalho3 = rs["Leg_BtnAtalho3"].ToString();
                Obj.Cod_BtnAtalho4 = Funcoes.ConvertstrToInt(rs["Cod_BtnAtalho4"].ToString());
                Obj.Desc_ProdAtalho4 = rs["Desc_ProdAtalho4"].ToString();
                Obj.Leg_BtnAtalho4 = rs["Leg_BtnAtalho4"].ToString();
                Obj.Cod_BtnAtalho5 = Funcoes.ConvertstrToInt(rs["Cod_BtnAtalho5"].ToString());
                Obj.Desc_ProdAtalho5 = rs["Desc_ProdAtalho5"].ToString();
                Obj.Leg_BtnAtalho5 = rs["Leg_BtnAtalho5"].ToString();
                Obj.Cod_BtnAtalho6 = Funcoes.ConvertstrToInt(rs["Cod_BtnAtalho6"].ToString());
                Obj.Desc_ProdAtalho6 = rs["Desc_ProdAtalho6"].ToString();
                Obj.Leg_BtnAtalho6 = rs["Leg_BtnAtalho6"].ToString();
                Obj.Cod_BtnAtalho7 = Funcoes.ConvertstrToInt(rs["Cod_BtnAtalho7"].ToString());
                Obj.Desc_ProdAtalho7 = rs["Desc_ProdAtalho7"].ToString();
                Obj.Leg_BtnAtalho7 = rs["Leg_BtnAtalho7"].ToString();
                Obj.Cod_BtnAtalho8 = Funcoes.ConvertstrToInt(rs["Cod_BtnAtalho8"].ToString());
                Obj.Desc_ProdAtalho8 = rs["Desc_ProdAtalho8"].ToString();
                Obj.Leg_BtnAtalho8 = rs["Leg_BtnAtalho8"].ToString();
                Obj.Cod_BtnAtalho9 = Funcoes.ConvertstrToInt(rs["Cod_BtnAtalho9"].ToString());
                Obj.Desc_ProdAtalho9 = rs["Desc_ProdAtalho9"].ToString();
                Obj.Leg_BtnAtalho9 = rs["Leg_BtnAtalho9"].ToString();
                Obj.Cod_BtnAtalho10 = Funcoes.ConvertstrToInt(rs["Cod_BtnAtalho10"].ToString());
                Obj.Desc_ProdAtalho10 = rs["Desc_ProdAtalho10"].ToString();
                Obj.Leg_BtnAtalho10 = rs["Leg_BtnAtalho10"].ToString();
                Obj.Cod_BtnAtalho11 = Funcoes.ConvertstrToInt(rs["Cod_BtnAtalho11"].ToString());
                Obj.Desc_ProdAtalho11 = rs["Desc_ProdAtalho11"].ToString();
                Obj.Leg_BtnAtalho11 = rs["Leg_BtnAtalho11"].ToString();
                Obj.Cod_BtnAtalho12 = Funcoes.ConvertstrToInt(rs["Cod_BtnAtalho12"].ToString());
                Obj.Desc_ProdAtalho12 = rs["Desc_ProdAtalho12"].ToString();
                Obj.Leg_BtnAtalho12 = rs["Leg_BtnAtalho12"].ToString();
                Obj.Cod_BtnCtg1 = rs["Cod_BtnCtg1"].ToString();
                Obj.Cod_BtnCtg2 = rs["Cod_BtnCtg2"].ToString();
                Obj.Cod_BtnCtg3 = rs["Cod_BtnCtg3"].ToString();
                Obj.Cod_BtnCtg4 = rs["Cod_BtnCtg4"].ToString();
                Obj.Cod_BtnCtg5 = rs["Cod_BtnCtg5"].ToString();
                Obj.Terminal = Funcoes.ConvertstrToInt(rs["Terminal"].ToString());
                Obj.Manda_preco = Funcoes.ConvertstrToBoolean(rs["Manda_preco"].ToString());
                Obj.Altera_local = Funcoes.ConvertstrToBoolean(rs["Altera_local"].ToString());
                Obj.Insere_Local = Funcoes.ConvertstrToBoolean(rs["Insere_Local"].ToString());
                Obj.Delivery = Funcoes.ConvertstrToBoolean(rs["Delivery"].ToString());
                Obj.CodigoBarrasDuplicado = Funcoes.ConvertstrToBoolean(rs["Codigo_Barras_Duplicado"].ToString());
                Obj.CodigoBarrasDuplicadoDigitos = Funcoes.ConvertstrToInt(rs["Codigo_Barras_Duplicado_Digitos"].ToString());
                Obj.BloqueiaImpressao = Funcoes.ConvertstrToBoolean(rs["Bloqueia_Impressao"].ToString());
                Obj.CaractereComanda = rs["Caractere_Comanda"].ToString();

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

    public ConfiguracaoDAO BuscarConfig(int NumTerminal)
    {
        SqlDataReader rs = null;
        try
        {
            StringBuilder Sql = new StringBuilder();

            Sql.Append("Select * from Configuracao where Terminal = " + NumTerminal);
            Sql.Append("AND Filial = '" + Parametros.Filial + "'");

            //Executando o comando
            rs = Conexao.consulta(Sql.ToString(), null, false);

            ConfiguracaoDAO Obj = new ConfiguracaoDAO();
            if (rs.Read())
            {
                Obj.ID = Funcoes.ConvertstrToInt(rs["ID"].ToString());
                Obj.Terminal = Funcoes.ConvertstrToInt(rs["Terminal"].ToString());
                Obj.IP_Terminal = rs["IP_Terminal"].ToString();
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

    /// <summary>
    /// Salva uma nova configuração no banco
    /// </summary>
    /// <param name="Obj">Objeto do tipo ConfiguracaoDAO preenchido</param>
    /// <returns></returns>
    public bool SalvarConfig(ConfiguracaoDAO Obj)
    {
        try
        {
            try
            {
                //Armazenando o comando em uma string
                StringBuilder Sql = new StringBuilder();
                Sql.Append("Insert into Configuracao  ");
                Sql.Append("(ID,Filial,Qtde_maxItem,Valor_maxItem,Trata_Comanda,Com_RetiraCluna,Divide_conta," +
                    "Solicita_ImpConta,Com_ApenasLeitura,Fixa_User,Integra_Balanca,Velocidade,Balanca_porta," +
                    "Balanca_CodInicio,Balanca_CodFim,Balanca_ItemInicio,Balanca_ItemFim,Balanca_Etiqueta," +
                    "Cod_BtnAtalho1,Desc_ProdAtalho1,Leg_BtnAtalho1,Cod_BtnAtalho2," +
                    "Desc_ProdAtalho2,Leg_BtnAtalho2,Cod_BtnAtalho3,Desc_ProdAtalho3,Leg_BtnAtalho3," +
                    "Cod_BtnAtalho4,Desc_ProdAtalho4,Leg_BtnAtalho4,Cod_BtnAtalho5," +
                    "Desc_ProdAtalho5,Leg_BtnAtalho5,Cod_BtnAtalho6,Desc_ProdAtalho6,Leg_BtnAtalho6," +
                    "Cod_BtnAtalho7,Desc_ProdAtalho7,Leg_BtnAtalho7,Cod_BtnAtalho8," +
                    "Desc_ProdAtalho8,Leg_BtnAtalho8,Cod_BtnAtalho9,Desc_ProdAtalho9,Leg_BtnAtalho9," +
                    "Cod_BtnAtalho10,Desc_ProdAtalho10,Leg_BtnAtalho10,Cod_BtnAtalho11," +
                    "Desc_ProdAtalho11,Leg_BtnAtalho11,Cod_BtnAtalho12,Desc_ProdAtalho12,Leg_BtnAtalho12," +
                    "Cod_BtnCtg1,Cod_BtnCtg2,Cod_BtnCtg3,Cod_BtnCtg4,Cod_BtnCtg5,Terminal,Solicita_Motivo," +
                    "Pct_calculo,Altera_local,Insere_Local,Manda_preco,IP_Terminal,Delivery, Codigo_Barras_Duplicado, Codigo_Barras_Duplicado_Digitos, Bloqueia_Impressao"+
                    ", Caractere_Comanda)");
                Sql.Append("values (");
                Sql.Append("(SELECT ISNULL(MAX(ID),0) +1 FROM Configuracao)");
                Sql.Append(",'" + Obj.Filial + "'");
                Sql.Append("," + Obj.Qtde_maxItem);
                Sql.Append("," + Obj.Valor_maxItem.ToString().Replace(",", "."));
                Sql.Append("," + Funcoes.ConvertBoolToBit(Obj.Trata_Comanda));
                Sql.Append("," + Obj.Com_RetiraCluna);
                Sql.Append("," + Funcoes.ConvertBoolToBit(Obj.Divide_conta));
                Sql.Append("," + Funcoes.ConvertBoolToBit(Obj.Solicita_ImpConta));
                Sql.Append("," + Funcoes.ConvertBoolToBit(Obj.Com_ApenasLeitura));
                Sql.Append("," + Funcoes.ConvertBoolToBit(Obj.Fixa_User));
                Sql.Append("," + Funcoes.ConvertBoolToBit(Obj.Integra_Balanca));
                Sql.Append("," + Obj.Velocidade);
                Sql.Append(",'" + Obj.Balanca_porta + "'");
                Sql.Append("," + Obj.Balanca_CodInicio);
                Sql.Append("," + Obj.Balanca_CodFim);
                Sql.Append("," + Obj.Balanca_ItemInicio);
                Sql.Append("," + Obj.Balanca_ItemFim);
                Sql.Append("," + Obj.Balanca_Etiqueta);

                Sql.Append("," + Obj.Cod_BtnAtalho1);
                Sql.Append(",'" + Obj.Desc_ProdAtalho1 + "'");
                Sql.Append(",'" + Obj.Leg_BtnAtalho1 + "'");

                Sql.Append("," + Obj.Cod_BtnAtalho2);
                Sql.Append(",'" + Obj.Desc_ProdAtalho2 + "'");
                Sql.Append(",'" + Obj.Leg_BtnAtalho2 + "'");

                Sql.Append("," + Obj.Cod_BtnAtalho3);
                Sql.Append(",'" + Obj.Desc_ProdAtalho3 + "'");
                Sql.Append(",'" + Obj.Leg_BtnAtalho3 + "'");

                Sql.Append("," + Obj.Cod_BtnAtalho4);
                Sql.Append(",'" + Obj.Desc_ProdAtalho4 + "'");
                Sql.Append(",'" + Obj.Leg_BtnAtalho4 + "'");

                Sql.Append("," + Obj.Cod_BtnAtalho5);
                Sql.Append(",'" + Obj.Desc_ProdAtalho5 + "'");
                Sql.Append(",'" + Obj.Leg_BtnAtalho5 + "'");

                Sql.Append("," + Obj.Cod_BtnAtalho6);
                Sql.Append(",'" + Obj.Desc_ProdAtalho6 + "'");
                Sql.Append(",'" + Obj.Leg_BtnAtalho6 + "'");

                Sql.Append("," + Obj.Cod_BtnAtalho7);
                Sql.Append(",'" + Obj.Desc_ProdAtalho7 + "'");
                Sql.Append(",'" + Obj.Leg_BtnAtalho7 + "'");

                Sql.Append("," + Obj.Cod_BtnAtalho8);
                Sql.Append(",'" + Obj.Desc_ProdAtalho8 + "'");
                Sql.Append(",'" + Obj.Leg_BtnAtalho8 + "'");

                Sql.Append("," + Obj.Cod_BtnAtalho9);
                Sql.Append(",'" + Obj.Desc_ProdAtalho9 + "'");
                Sql.Append(",'" + Obj.Leg_BtnAtalho9 + "'");

                Sql.Append("," + Obj.Cod_BtnAtalho10);
                Sql.Append(",'" + Obj.Desc_ProdAtalho10 + "'");
                Sql.Append(",'" + Obj.Leg_BtnAtalho10 + "'");

                Sql.Append("," + Obj.Cod_BtnAtalho11);
                Sql.Append(",'" + Obj.Desc_ProdAtalho11 + "'");
                Sql.Append(",'" + Obj.Leg_BtnAtalho11 + "'");

                Sql.Append("," + Obj.Cod_BtnAtalho12);
                Sql.Append(",'" + Obj.Desc_ProdAtalho12 + "'");
                Sql.Append(",'" + Obj.Leg_BtnAtalho12 + "'");

                Sql.Append(",'" + Obj.Cod_BtnCtg1 + "'");
                Sql.Append(",'" + Obj.Cod_BtnCtg2 + "'");
                Sql.Append(",'" + Obj.Cod_BtnCtg3 + "'");
                Sql.Append(",'" + Obj.Cod_BtnCtg4 + "'");
                Sql.Append(",'" + Obj.Cod_BtnCtg5 + "'");

                Sql.Append("," + Obj.Terminal);
                Sql.Append("," + Funcoes.ConvertBoolToBit(Obj.Solicita_Motivo));
                Sql.Append("," + Obj.Pct_calculo);

                Sql.Append("," + Funcoes.ConvertBoolToBit(Obj.Altera_local));
                Sql.Append("," + Funcoes.ConvertBoolToBit(Obj.Insere_Local));
                Sql.Append("," + Funcoes.ConvertBoolToBit(Obj.Manda_preco));

                Sql.Append(",'" + Obj.IP_Terminal + "'");
                Sql.Append("," + Funcoes.ConvertBoolToBit(Obj.Delivery));

                Sql.Append(", " + Funcoes.ConvertBoolToBit(Obj.CodigoBarrasDuplicado));
                Sql.Append(", " + Obj.CodigoBarrasDuplicadoDigitos);

                Sql.Append(", " + Funcoes.ConvertBoolToBit(Obj.BloqueiaImpressao));
                Sql.Append(", '" + Obj.CaractereComanda + "'");
                Sql.Append(")");
                //Executando o comando
                bool retorno = Conexao.executarSql(Sql.ToString());

                return retorno;
            }
            catch (Exception err)
            {

                throw err;
            }
        }
        catch (Exception err)
        {

            throw err;
        }
    }

    /// <summary>
    /// Atualiza uma configuração ao banco
    /// </summary>
    /// <param name="Obj">Objeto do tipo ConfiguracaoDAO preenchido</param>
    /// <returns></returns>
    public bool EditarConfig(ConfiguracaoDAO Obj)
    {
        try
        {
            try
            {
                //Armazenando o comando em uma string
                StringBuilder Sql = new StringBuilder();
                Sql.Append("Update  Configuracao set ");

                Sql.Append("Qtde_maxItem=" + Obj.Qtde_maxItem);
                Sql.Append(",Valor_maxItem=" + Obj.Valor_maxItem.ToString().Replace(",", "."));
                Sql.Append(",Trata_Comanda=" + Funcoes.ConvertBoolToBit(Obj.Trata_Comanda));
                Sql.Append(",Com_RetiraCluna=" + Obj.Com_RetiraCluna);
                Sql.Append(",Divide_conta=" + Funcoes.ConvertBoolToBit(Obj.Divide_conta));
                Sql.Append(",Solicita_ImpConta=" + Funcoes.ConvertBoolToBit(Obj.Solicita_ImpConta));
                Sql.Append(",Com_ApenasLeitura=" + Funcoes.ConvertBoolToBit(Obj.Com_ApenasLeitura));
                Sql.Append(",Fixa_User=" + Funcoes.ConvertBoolToBit(Obj.Fixa_User));
                Sql.Append(",Integra_Balanca=" + Funcoes.ConvertBoolToBit(Obj.Integra_Balanca));
                Sql.Append(",Balanca_porta='" + Obj.Balanca_porta + "'");
                Sql.Append(",Balanca_CodInicio=" + Obj.Balanca_CodInicio);
                Sql.Append(",Balanca_CodFim=" + Obj.Balanca_CodFim);
                Sql.Append(",Balanca_ItemInicio=" + Obj.Balanca_ItemInicio);
                Sql.Append(",Balanca_ItemFim=" + Obj.Balanca_ItemFim);
                Sql.Append(",Balanca_Etiqueta=" + Obj.Balanca_Etiqueta);
                Sql.Append(",Velocidade=" + Obj.Velocidade);
                Sql.Append(",Manda_preco=" + Funcoes.ConvertBoolToBit(Obj.Manda_preco));
                Sql.Append(",Pct_calculo=" + Obj.Pct_calculo);

                Sql.Append(",Cod_BtnAtalho1=" + Obj.Cod_BtnAtalho1);
                Sql.Append(",Desc_ProdAtalho1='" + Obj.Desc_ProdAtalho1 + "'");
                Sql.Append(",Leg_BtnAtalho1='" + Obj.Leg_BtnAtalho1 + "'");

                Sql.Append(",Cod_BtnAtalho2=" + Obj.Cod_BtnAtalho2);
                Sql.Append(",Desc_ProdAtalho2='" + Obj.Desc_ProdAtalho2 + "'");
                Sql.Append(",Leg_BtnAtalho2='" + Obj.Leg_BtnAtalho2 + "'");

                Sql.Append(",Cod_BtnAtalho3=" + Obj.Cod_BtnAtalho3);
                Sql.Append(",Desc_ProdAtalho3='" + Obj.Desc_ProdAtalho3 + "'");
                Sql.Append(",Leg_BtnAtalho3='" + Obj.Leg_BtnAtalho3 + "'");

                Sql.Append(",Cod_BtnAtalho4=" + Obj.Cod_BtnAtalho4);
                Sql.Append(",Desc_ProdAtalho4='" + Obj.Desc_ProdAtalho4 + "'");
                Sql.Append(",Leg_BtnAtalho4='" + Obj.Leg_BtnAtalho4 + "'");

                Sql.Append(",Cod_BtnAtalho5=" + Obj.Cod_BtnAtalho5);
                Sql.Append(",Desc_ProdAtalho5='" + Obj.Desc_ProdAtalho5 + "'");
                Sql.Append(",Leg_BtnAtalho5='" + Obj.Leg_BtnAtalho5 + "'");

                Sql.Append(",Cod_BtnAtalho6=" + Obj.Cod_BtnAtalho6);
                Sql.Append(",Desc_ProdAtalho6='" + Obj.Desc_ProdAtalho6 + "'");
                Sql.Append(",Leg_BtnAtalho6='" + Obj.Leg_BtnAtalho6 + "'");

                Sql.Append(",Cod_BtnAtalho7=" + Obj.Cod_BtnAtalho7);
                Sql.Append(",Desc_ProdAtalho7='" + Obj.Desc_ProdAtalho7 + "'");
                Sql.Append(",Leg_BtnAtalho7='" + Obj.Leg_BtnAtalho7 + "'");

                Sql.Append(",Cod_BtnAtalho8=" + Obj.Cod_BtnAtalho8);
                Sql.Append(",Desc_ProdAtalho8='" + Obj.Desc_ProdAtalho8 + "'");
                Sql.Append(",Leg_BtnAtalho8='" + Obj.Leg_BtnAtalho8 + "'");

                Sql.Append(",Cod_BtnAtalho9=" + Obj.Cod_BtnAtalho9);
                Sql.Append(",Desc_ProdAtalho9='" + Obj.Desc_ProdAtalho9 + "'");
                Sql.Append(",Leg_BtnAtalho9='" + Obj.Leg_BtnAtalho9 + "'");

                Sql.Append(",Cod_BtnAtalho10=" + Obj.Cod_BtnAtalho10);
                Sql.Append(",Desc_ProdAtalho10='" + Obj.Desc_ProdAtalho10 + "'");
                Sql.Append(",Leg_BtnAtalho10='" + Obj.Leg_BtnAtalho10 + "'");

                Sql.Append(",Cod_BtnAtalho11=" + Obj.Cod_BtnAtalho11);
                Sql.Append(",Desc_ProdAtalho11='" + Obj.Desc_ProdAtalho11 + "'");
                Sql.Append(",Leg_BtnAtalho11='" + Obj.Leg_BtnAtalho11 + "'");

                Sql.Append(",Cod_BtnAtalho12=" + Obj.Cod_BtnAtalho12);
                Sql.Append(",Desc_ProdAtalho12='" + Obj.Desc_ProdAtalho12 + "'");
                Sql.Append(",Leg_BtnAtalho12='" + Obj.Leg_BtnAtalho12 + "'");

                Sql.Append(",Cod_BtnCtg1='" + Obj.Cod_BtnCtg1 + "'");
                Sql.Append(",Cod_BtnCtg2='" + Obj.Cod_BtnCtg2 + "'");
                Sql.Append(",Cod_BtnCtg3='" + Obj.Cod_BtnCtg3 + "'");
                Sql.Append(",Cod_BtnCtg4='" + Obj.Cod_BtnCtg4 + "'");
                Sql.Append(",Cod_BtnCtg5='" + Obj.Cod_BtnCtg5 + "'");
                Sql.Append(",Terminal=" + Obj.Terminal);
                Sql.Append(",Solicita_Motivo=" + Funcoes.ConvertBoolToBit(Obj.Solicita_Motivo));


                Sql.Append(",Altera_local=" + Funcoes.ConvertBoolToBit(Obj.Altera_local));
                Sql.Append(",Insere_Local=" + Funcoes.ConvertBoolToBit(Obj.Insere_Local));

                Sql.Append(",IP_Terminal='" + Obj.IP_Terminal + "'");
                Sql.Append(",Delivery=" + Funcoes.ConvertBoolToBit(Obj.Delivery));

                Sql.Append(",Codigo_Barras_Duplicado_Digitos='" + Obj.CodigoBarrasDuplicadoDigitos + "'");
                Sql.Append(",Codigo_Barras_Duplicado=" + Funcoes.ConvertBoolToBit(Obj.CodigoBarrasDuplicado));
                Sql.Append(",Bloqueia_Impressao=" + Funcoes.ConvertBoolToBit(Obj.BloqueiaImpressao));
                Sql.Append(", Caractere_Comanda= '" + Obj.CaractereComanda + "'");

                Sql.Append(" where ID=" + Obj.ID);
                Sql.Append(" AND Filial ='" + Obj.Filial + "'");
                //Executando o comando
                bool retorno = Conexao.executarSql(Sql.ToString());

                return retorno;
            }
            catch (Exception err)
            {

                throw err;
            }
        }
        catch (Exception err)
        {

            throw err;
        }
    }
}

