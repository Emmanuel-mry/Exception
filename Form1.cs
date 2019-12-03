using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exepcion_Especial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ErrorProvider Ep = new ErrorProvider();
            if (txtMatricula.Text == "")
            {
                Ep.SetError(txtMatricula, "No ha ingresado matricula");
            }

            else if (txtNombre.Text == "")
            {
                Ep.SetError(txtNombre, "No ha ingresado Nombre");
            }
            else if (txtSemestre.Text == "")
            {
                Ep.SetError(txtSemestre, "No ha ingresado semestre");
            }
          else if (txtSemestre.Text == "")
            {
                Ep.SetError(txtCarrera, "No ha ingresado Carrera");
            }
         else if (txtTelefono.Text == "")
                Ep.SetError(txtTelefono, "No ha ingresado telefono");
          
            try
            {
                Alumno Al = new Alumno();
                Al.Matricula = txtMatricula.Text;
                Al.Nombre = txtNombre.Text;
                Al.Semestre = Convert.ToInt32(txtSemestre.Text);
                Al.Carrera = txtCarrera.Text;
                Al.Telefono = txtTelefono.Text;

               
                throw new Special_Exeption("su alumno se creo exitosamente");

            }
            catch (FormatException ex)
            {
      
                MessageBox.Show("ERROR DE REGISTRO " + ex.Message);

            }

            catch (Special_Exeption espEx)
            {
                MessageBox.Show(espEx.Message);

            }



        }
    }
    }

