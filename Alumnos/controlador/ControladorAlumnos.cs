using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumnos.controlador
{
    public class ControladorAlumnos
    {
        //Base de datos temporal
        //private ArrayList alumnos;
        
        private alumnosEntities baseDeDatos;

        //Vista
        private Form1 vista;

        public ControladorAlumnos()
        {
            baseDeDatos = new alumnosEntities();
            vista = new Form1();
            vista.setControlador(this);
            vista.mostrarAlumnos(baseDeDatos.alumno.ToList());
            vista.ShowDialog();
            
        }

        public void guardarAlumno(alumno alumno)
        {
            baseDeDatos.alumno.Add(alumno);
            baseDeDatos.SaveChanges();
            vista.mostrarAlumnos(baseDeDatos.alumno.ToList());
        }

        public void eliminarAlumno(alumno alumno)
        {
            baseDeDatos.alumno.Remove(alumno);
            baseDeDatos.SaveChanges();
            vista.mostrarAlumnos(baseDeDatos.alumno.ToList());
        }
    }
}
