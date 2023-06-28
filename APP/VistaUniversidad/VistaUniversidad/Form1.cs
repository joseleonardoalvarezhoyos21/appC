using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace VistaUniversidad
{
    public partial class Form1 : Form
    {
        public void guardarEstudiante()
        {
            Estudiante objE = new Estudiante();
            try
            {
                objE.Identificacion = TXTId.Text;
                objE.Nombre =TXTnombre.Text;
                objE.Apellido = TXTapellido.Text;
                objE.Telefono = TXTtelefono.Text;
                objE.Edad = Convert.ToInt32(TXTedad.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            if (!objE.ingresarEstudiante())
            {
                MessageBox.Show(objE.Error);
                return;
            }
            else
            {
                MessageBox.Show("Grabado Exitosamente");
            }
        }

        private void consultarEstudiante(string identificacion)
        {
            Estudiante objE = new Estudiante();
           
            try
            {
                objE.Identificacion = TXTId.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;

            }

            if (!objE.consultarEstudiante())
            {
                MessageBox.Show(objE.Error);
                objE = null;
                return;

            }
            SqlDataReader readerE;
            readerE = objE.ObjReader;

            if (readerE.HasRows)
            {
                readerE.Read();
                TXTnombre.Text = readerE.GetString(1);
                TXTapellido.Text = readerE.GetString(2);
                TXTtelefono.Text = readerE.GetString(3);
                TXTedad.Text = readerE.GetInt32(4).ToString();
                readerE.Close();

            }


        }

        public void actualizarEstudiante(string identificacion)
        {
            Estudiante objE = new Estudiante();
            try
            {
                objE.Identificacion = TXTId.Text;
                objE.Nombre = TXTnombre.Text;
                objE.Apellido = TXTapellido.Text;
                objE.Telefono = TXTtelefono.Text;
                objE.Edad = Convert.ToInt32(TXTedad.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            if (!objE.actualizarEstudiante())
            {
                MessageBox.Show(objE.Error);
                return;
            }
            else
            {
                MessageBox.Show("Actualizado Exitosamente");
            }

        }

        private void llenarEstudiante()
        {
            Estudiante objE = new Estudiante();

            if (!objE.lsitarEstudiante(dgwdatos))
            {
                MessageBox.Show(objE.Error);
                return;
            }
        }

        public void eliminarEstudiante(string identificacion)
        {
            Estudiante objE = new Estudiante();

            if (!objE.eliminarEstudiante())
            {
                MessageBox.Show(objE.Error);
                return;
            }
            else
            {
                MessageBox.Show("Registro Eliminado");
            }


        } 

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            guardarEstudiante();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            eliminarEstudiante(TXTId.Text);
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            actualizarEstudiante(TXTId.Text);
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            consultarEstudiante(TXTId.Text);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            llenarEstudiante();
        }

        
    }

    
}
