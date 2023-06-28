using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibConexionBD;
using LibLlenarGrid;
using System.Windows.Forms;


public class Estudiante
{


    #region Atributos

    private string identificacion;
    private string nombre;
    private string apellido;
    private string telefono;
    private int edad;
    private string error;
    SqlDataReader objReader;





    #endregion


    #region Propiedades

    public string Identificacion { get => identificacion; set => identificacion = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public string Telefono { get => telefono; set => telefono = value; }
    public int Edad { get => edad; set => edad = value; }
    public string Error { get => error; set => error = value; }
    public SqlDataReader ObjReader { get => objReader; set => objReader = value; }

    #endregion

    #region Metodos Publicos

    public Estudiante()
    {
        identificacion = "";
        nombre = "";
        apellido = "";
        telefono = "";
        edad = 0;
        error = "";
    }

    public bool ingresarEstudiante ()
    {
       
        string sentencia  = $"EXECUTE USP_INSERTAR_EST  '{identificacion}', '{nombre}', '{apellido}', '{telefono}',{edad} ";
        ClsConexion objCon = new ClsConexion();

        if (!objCon.EjecutarSentencia(sentencia, false))
        {

            error = objCon.Error;
            objCon = null;
            return false;
        }
        else
        {
            objCon = null;
            return true;

        }
    }  
    
    public bool consultarEstudiante()
    {
        string sentencia = $"EXECUTE USP_OBTENER_EST '{identificacion}'";
       
        ClsConexion objCon = new ClsConexion();

        if (objCon.Consultar(sentencia, false))
        {

            
            objReader = objCon.Reader;
            objCon = null;
            return true;
        }
        else
        {
            error = objCon.Error;
            objCon = null;
            return false;

        }
    }


    public bool actualizarEstudiante()
    {
        string sentencia = $"EXECUTE USP_ACTUALIZAR_EST'{identificacion}','{nombre}', '{apellido}','{telefono}',{edad}";

        ClsConexion objCon = new ClsConexion();

        if (objCon.EjecutarSentencia(sentencia, false))
        {
            objCon = null;
            return true;
        }
        else
        {
            error = objCon.Error;
            objCon = null;
            return false;

        }
    }


    public bool eliminarEstudiante()
    {
        string sentencia = $"EXECUTE USP_ELIMINAR_EST '{identificacion}'";
        ClsConexion objCon = new ClsConexion();

        if (objCon.EjecutarSentencia(sentencia, false))
        {
            objCon = null;
            return true;
        }
        else
        {
            error = objCon.Error;
            objCon = null;
            return false;

        }
    }
    public bool lsitarEstudiante(DataGridView GRWdato)
    {
        
            ClsLlenarGrid objG = new ClsLlenarGrid();
            objG.NombreTabla = "DATOS";
        objG.SQL = "EXECUTE USP_LISTA_EST;";

        if (objG.LlenarGrid(GRWdato))
        {
            objG = null;
            return true;
        }
        else
        {
            error = objG.Error;
            objG = null;
            return false;

        }
    }


    #endregion



    #region Metodos Privados

    #endregion
}
