using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SOLDIGusto;


class Funcoes
{

    /// <summary>
    /// Grava um log de erros do sistema
    /// </summary>
    /// <param name="ValorRecebido"></param>
    public static void GravarLog(string ValorRecebido)
    {
        string strCurDir = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory.ToString());
        string strArquivo = "";
        strCurDir += "\\LOG";
        if (!Directory.Exists(strCurDir))
        {
            Directory.CreateDirectory(strCurDir);
        }
        strArquivo = strCurDir + "\\LOG" + DateTime.Now.ToString("yyyyMMdd") + ".TXT";
        StreamWriter log = new StreamWriter(strArquivo, true);
        log.WriteLine(DateTime.Today.ToString("dd-MM-yyyy") + " " + DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00"));
        log.WriteLine(ValorRecebido);
        log.Close();
    }

    /// <summary>
    /// Metoda para validar se a data final é maior que a inicial
    /// </summary>
    /// <param name="DataInicio">Data Inicial</param>
    /// <param name="DataFim">Data final</param>
    /// <returns>Retorna um obj do tipo bool</returns>
    public static bool ValidarData(DateTime DataInicio, DateTime DataFim)
    {
        try
        {
            // dividindo os valores das datas
            int diaInicio = DataInicio.Day;
            int diaFim = DataFim.Day;

            int MesInicio = DataInicio.Month;
            int MesFim = DataFim.Month;

            int AnoInicio = DataInicio.Year;
            int AnoFim = DataFim.Year;

            //verificando o ano
            if (AnoFim == AnoInicio)
            {
                //verificando o mes
                if (MesFim == MesInicio)
                {
                    //verificando o dia
                    if (diaFim < diaInicio)
                        return false;
                }
                else if (MesFim > MesInicio)
                    return true;
                else
                    return false;
            }
            else if (AnoFim > AnoInicio)
                return true;
            else
                return false;

            return true;
        }
        catch (Exception err)
        {

            throw err;
        }
    }

    /// <summary>
    /// Metodo para arredondar as bordas de um objeto
    /// </summary>
    /// <param name="Width">Largura do objeto a ser arredondado</param>
    /// <param name="Height">Altura do objeto a ser arredondado</param>
    /// /// <param name="Topo">Se será arredondado o topo do obj</param>
    /// /// <param name="Inferior">Se será arredondado o inferior do obj</param>
    /// <returns>Retorna um obj do tipo GraphicsPath</returns>
    public static GraphicsPath BorderRadius(int Width, int Height, bool Topo, bool Inferior)
    {

        GraphicsPath PastaGrafica = new GraphicsPath();
        PastaGrafica.AddRectangle(new Rectangle(1, 1, Width, Height));

        if (Topo == true)
        {
            //Arredondar canto superior esquerdo        
            PastaGrafica.AddRectangle(new Rectangle(1, 1, 10, 10));
            PastaGrafica.AddPie(1, 1, 20, 20, 180, 90);

            //Arredondar canto superior direito
            PastaGrafica.AddRectangle(new Rectangle(Width - 12, 1, 12, 13));
            PastaGrafica.AddPie(Width - 24, 1, 24, 26, 270, 90);
        }

        if (Inferior == true)
        {
            //Arredondar canto inferior esquerdo
            PastaGrafica.AddRectangle(new Rectangle(1, Height - 10, 10, 10));
            PastaGrafica.AddPie(1, Height - 20, 20, 20, 90, 90);

            //Arredondar canto inferior direito
            PastaGrafica.AddRectangle(new Rectangle(Width - 12, Height - 13, 13, 13));
            PastaGrafica.AddPie(Width - 24, Height - 26, 24, 26, 0, 90);
        }

        PastaGrafica.SetMarkers();


        return PastaGrafica;
    }

    /// <summary>
    /// Valida os caracteres permitidos de acordo com o tipo do campo
    /// </summary>
    /// <param name="tipo">Tipo do campo</param>
    /// <returns>Retorna uma string com os caracteres permitidos</returns>
    public static string ValidarCaracteres(int tipo)
    {
        string caracteresPermitido = "";

        if (tipo == 1)//texto
        {
            caracteresPermitido = "qwertyuiopasdfghjklzxcvbnm QWERTYUIOPASDFGHJKLZXCVBNM-.,1234567890";
        }
        else if (tipo == 2)//numero
        {
            caracteresPermitido = "0123456789";
        }
        else if (tipo == 3)//DINHEIRO
        {
            caracteresPermitido = "0123456789,";
        }
        else if (tipo == 4)//TEXTO SIMPLES
        {
            caracteresPermitido = "qwertyuiopasdfghjklzxcvbnm QWERTYUIOPASDFGHJKLZXCVBNM";
        }
        else if (tipo == 5)//TEXTO S caracter especial
        {
            caracteresPermitido = "qwertyuiopasdfghjklzxcvbnm QWERTYUIOPASDFGHJKLZXCVBNM1234567890";
        }

        return caracteresPermitido;

    }

    /// <summary>
    /// Metodo para converter string em int
    /// </summary>
    /// <param name="valor"></param>
    /// <returns>Retorna um obj do tipo int</returns>
    public static int ConvertstrToInt(string valor)
    {

        if (int.TryParse(valor, out int nnumero))
        {
            return nnumero;
        }
        else
        {
            return 0;
        }
    }

    /// <summary>
    /// Metodo para converter string em int64
    /// </summary>
    /// <param name="valor"></param>
    /// <returns>Retorna um obj do tipo Int64</returns>
    public static Int64 ConvertstrToLong(string valor)
    {

        if (Int64.TryParse(valor, out long nnumero))
        {
            return nnumero;
        }
        else
        {
            return 0;
        }
    }

    /// <summary>
    /// Metodo para converter string em decimal
    /// </summary>
    /// <param name="valor"></param>
    /// <returns>Retorna um obj do tipo Decimal, sendo 0 no caso de falha da conversão</returns>
    public static Decimal ConvertstrToDecimal(string valor)
    {

        if (Decimal.TryParse(valor, out decimal nnumero))
        {
            return nnumero;
        }
        else
        {
            return 0;
        }
    }

    /// <summary>
    /// Metodo para converter uma string em DateTime
    /// </summary>
    /// <param name="valor"></param>
    /// <returns>Retona um obj do tipo DateTime, sendo a data atual para caso de falha na conversão</returns>
    public static DateTime ConvertstrToDateTime(string valor)
    {
        DateTime nnumero = DateTime.Now;

        if (DateTime.TryParse(valor, out nnumero))
        {
            return nnumero;
        }
        else
        {
            return DateTime.Now;
        }
    }

    /// <summary>
    /// Metodo para converter uma string em bool
    /// </summary>
    /// <param name="valor"></param>
    /// <returns>retorna um obj do tipo bool</returns>
    public static bool ConvertstrToBoolean(string valor)
    {
        bool resultado = false;

        if (valor != "")
        {
            if (valor == "False" || valor == "false" || valor == "0")
            {
                return resultado;
            }
            else if (valor == "true" || valor == "True" || valor == "1")
            {
                resultado = true;
                return resultado;
            }
            else
            {
                return resultado;
            }
        }
        else
        {
            return resultado;
        }
    }

    /// <summary>
    /// Metodo para converter Bool em int (0 ou 1)
    /// </summary>
    /// <param name="valor"></param>
    /// <returns>
    /// 0 ou 1
    /// </returns>
    public static int ConvertBoolToBit(bool valor)
    {
        int numero = 0;

        if (valor == true)
        {
            numero = 1;
        }

        return numero;
    }

    public static bool IsNumeric(string value)
    {
        if (value.Equals(""))
        {
            return false;
        }
        return value.All(char.IsNumber);
    }
}

