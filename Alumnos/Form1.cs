using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alumnos.controlador;

namespace Alumnos
{
    public partial class Form1 : Form
    {
        private ControladorAlumnos controlador;

        public Form1()
        {
            InitializeComponent();
        }

        public void setControlador(ControladorAlumnos c)
        {
            controlador = c;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if((txtApellido.Text!="")&&(txtNombre.Text!=""))
            {
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                alumno al = new alumno();
                al.nombre = nombre;
                al.apellido = apellido;
                
                controlador.guardarAlumno(al);
            }
        }

        public void mostrarAlumnos(IList alumnos)
        {
            dgvAlumnos.DataSource = alumnos;
        }

        public void eliminarAlumno(object sender, DataGridViewCellEventArgs e)
        {
            alumno alumEliminar = (alumno)dgvAlumnos.CurrentRow.DataBoundItem;
            controlador.eliminarAlumno(alumEliminar);
        }
    }
}
