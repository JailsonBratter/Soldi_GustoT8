using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

class Parametros
{

    public static int ID_Config = 0;//SOLDIGusto.Properties.Settings.Default.ID_Config;
    public static bool Atualiza_Home { get; set; }
    public static int Terminal { get; set; }
    public static bool Solicita_Motivo { get; set; }
    public static string Filial = "";//SOLDIGusto.Properties.Settings.Default.FILIAL;
    public static bool Delivery { get; set; }

    //---------------------------------------------------------------------------------
    //----------------------------------Operador---------------------------------------
    //---------------------------------------------------------------------------------
    public static int Id_Operador { get; set; }
    public static string Nome_Operador { get; set; }
    public static int Nivel_Operador { get; set; }
    public static bool Fixa_Op { get; set; }

    //---------------------------------------------------------------------------------
    //-----------------------------------Comanda---------------------------------------
    //---------------------------------------------------------------------------------
    public static string Comanda { get; set; }
    public static bool Insere_local = true;
    public static bool Altera_Local { get; set; }
    public static bool Codigo_Barras_Duplicado {get;set;}
    public static int Codigo_Barras_Duplicado_Digitos { get; set; }
    public static bool Bloqueia_Impressao { get; set; }
    public static string CaractereComanda { get; set; }

    //---------------------------------------------------------------------------------
    //-------------------------------------Busca---------------------------------------
    //---------------------------------------------------------------------------------
    
    #region Categorias
    // Categoria 01
    public static string Cod_Ctg01 { get; set; }
    public static string Img_Ctg01 = Application.StartupPath.ToString() + @"\\Img\Img_ctg01.png";
    // Categoria 02
    public static string Cod_Ctg02 { get; set; }
    public static string Img_Ctg02 = Application.StartupPath.ToString() + @"\\Img\Img_ctg02.png";
    // Categoria 03
    public static string Cod_Ctg03 { get; set; }
    public static string Img_Ctg03 = Application.StartupPath.ToString() + @"\\Img\Img_ctg03.png";
    // Categoria 04
    public static string Cod_Ctg04 { get; set; }
    public static string Img_Ctg04 = Application.StartupPath.ToString() + @"\\Img\Img_ctg04.png";
    // Categoria 05
    public static string Cod_Ctg05 { get; set; }
    public static string Img_Ctg05 = Application.StartupPath.ToString() + @"\\Img\Img_ctg05.png";
    #endregion

    //---------------------------------------------------------------------------------
    //--------------------------------Botões Atalho------------------------------------
    //---------------------------------------------------------------------------------

    #region Botões de atalho
    // Botão 01
    public static int Cod_Btn01 { get; set; }
    public static string Desc_Btn01 { get; set; }
    public static string Texto_Btn01 { get; set; }
    // Botão 02
    public static int Cod_Btn02 { get; set; }
    public static string Desc_Btn02 { get; set; }
    public static string Texto_Btn02 { get; set; }
    // Botão 03
    public static int Cod_Btn03 { get; set; }
    public static string Desc_Btn03 { get; set; }
    public static string Texto_Btn03 { get; set; }
    // Botão 04
    public static int Cod_Btn04 { get; set; }
    public static string Desc_Btn04 { get; set; }
    public static string Texto_Btn04 { get; set; }
    // Botão 05
    public static int Cod_Btn05 { get; set; }
    public static string Desc_Btn05 { get; set; }
    public static string Texto_Btn05 { get; set; }
    // Botão 06
    public static int Cod_Btn06 { get; set; }
    public static string Desc_Btn06 { get; set; }
    public static string Texto_Btn06 { get; set; }
    // Botão 07
    public static int Cod_Btn07 { get; set; }
    public static string Desc_Btn07 { get; set; }
    public static string Texto_Btn07 { get; set; }
    // Botão 08
    public static int Cod_Btn08 { get; set; }
    public static string Desc_Btn08 { get; set; }
    public static string Texto_Btn08 { get; set; }
    // Botão 09
    public static int Cod_Btn09 { get; set; }
    public static string Desc_Btn09 { get; set; }
    public static string Texto_Btn09 { get; set; }
    // Botão 10
    public static int Cod_Btn10 { get; set; }
    public static string Desc_Btn10 { get; set; }
    public static string Texto_Btn10 { get; set; }
    // Botão 11
    public static int Cod_Btn11 { get; set; }
    public static string Desc_Btn11 { get; set; }
    public static string Texto_Btn11 { get; set; }
    // Botão 12
    public static int Cod_Btn12 { get; set; }
    public static string Desc_Btn12 { get; set; }
    public static string Texto_Btn12 { get; set; }
    #endregion

    //---------------------------------------------------------------------------------
    //--------------------------------Configurações------------------------------------
    //---------------------------------------------------------------------------------
    public static int Col_Retira_Comanda { get; set; }
    public static bool Trata_Comanda { get; set; }
    public static bool Divide_Conta { get; set; }
    public static bool Solicita_Imp_Conta { get; set; }
    public static bool Com_apenas_leitura { get; set; }
    public static int Qtde_Max_Item { get; set; }
    public static decimal Valor_Max_Item { get; set; }
    public static int Pct_Calculo = 10;

    //---------------------------------------------------------------------------------
    //-----------------------------------Balança---------------------------------------
    //---------------------------------------------------------------------------------
    public static bool Balanca_Integra { get; set; }
    public static bool Manda_preco_bal { get; set; }
    public static int Cod_Inicio = 1;
    public static int Cod_Fim = 6;
    public static int Item_Incio = 7;
    public static int Item_Fim = 5;
    public static int Tipo_Etiqueta = 1;
    public static string Porta_balanca { get; set; }
    public static int Velocidade_porta = 2400;
    public static bool usa_goomer { get; set; }


}

