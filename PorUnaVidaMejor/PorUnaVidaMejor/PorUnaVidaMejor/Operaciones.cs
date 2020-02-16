using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace PorUnaVidaMejor
{
    class Operaciones
    {
        string conexion = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ../../../Base_De_Datos_Por_Una_Mejor_Vida.accdb";
        string SQL;
        Form1 mensajes = new Form1();
        OleDbDataAdapter Adaptador = new OleDbDataAdapter();
        DataTable tabla = new DataTable();
        public Boolean MatricularEstudiante(string id, string nombres, string apellidos, string nacimiento, string direccion, string celular, string email)
        {
            try
            {
                tabla.Clear();
                SQL = "insert into Estudiantes values ('" + id + "','" + nombres + "','" + apellidos + "','" + nacimiento + "','" + direccion + "','" + celular + "','" + email + "')";
                Adaptador = new OleDbDataAdapter(SQL, conexion);
                Adaptador.Fill(tabla);
                return true;
            }
            catch (System.Data.OleDb.OleDbException)
            {
                mensajes.Mensaje(3);
                return false;
            }
            catch
            {
                mensajes.Mensaje(1);
                return false;
            }
        }
        public Boolean InscribirEstudiante(string ide, string idc)
        {
            try
            {
                tabla.Clear();
                SQL = "insert into Relacion values ('" + ide + "','" + idc + "')";
                Adaptador = new OleDbDataAdapter(SQL, conexion);
                Adaptador.Fill(tabla);
                return true;
            }
            catch (System.Data.OleDb.OleDbException)
            {
                mensajes.Mensaje(2);
                return false;
            }
            catch
            {
                mensajes.Mensaje(1);
                return false;
            }
        }
        public Boolean InscribirCurso(string id, string nombre, string instructor, string costo)
        {
            try
            {
                tabla.Clear();
                SQL = "insert into Cursos values ('" + id + "','" + nombre + "','" + instructor + "','" + costo + "')";
                Adaptador = new OleDbDataAdapter(SQL, conexion);
                Adaptador.Fill(tabla);
                return true;
            }
            catch(System.Data.OleDb.OleDbException)
            {
                mensajes.Mensaje(3);
                return false;
            }
            catch
            {
                mensajes.Mensaje(1);
                return false;
            }
        }
        public DataTable VerTodosLosCursos()
        {
            try
            {
                tabla.Clear();
                SQL = "select * from Cursos";
                Adaptador = new OleDbDataAdapter(SQL, conexion);
                Adaptador.Fill(tabla);
                return tabla;
            }
            catch
            {
                mensajes.Mensaje(1);
                return tabla;
            }
        }
        public DataTable buscarEstudiantes(string buscador, string dato)
        {
            try
            {
                tabla.Clear();
                SQL = "select * from Estudiantes where " + buscador + "='" + dato + "' ";
                Adaptador = new OleDbDataAdapter(SQL, conexion);
                Adaptador.Fill(tabla);
                return tabla;
            }
            catch
            {
                mensajes.Mensaje(1);
                return tabla;
            }
        }
        public void eliminarEstudiante(string id)
        {
            try
            {
                tabla.Clear();
                SQL = "delete from Relacion where identificacion='" + id + "' ";
                Adaptador = new OleDbDataAdapter(SQL, conexion);
                Adaptador.Fill(tabla);
                SQL = "delete from Estudiantes where identificacion='" + id + "' ";
                Adaptador = new OleDbDataAdapter(SQL, conexion);
                Adaptador.Fill(tabla);
            }
            catch
            {
                mensajes.Mensaje(1);
            }
        }
        public void ActualizarCosto(string costo,string id)
        {
            try
            {
                tabla.Clear();
                SQL = "UPDATE Cursos SET ValorAPagar = '" + costo + "' WHERE idCurso = '" + id + "'";
                Adaptador = new OleDbDataAdapter(SQL, conexion);
                Adaptador.Fill(tabla);
            }
            catch
            {
                mensajes.Mensaje(1);
            }
        }
        public void ActualizarInstructor(string instructor, string id)
        {
            try
            {
                tabla.Clear();
                SQL = "UPDATE Cursos SET Instructor = '" + instructor + "' WHERE idCurso = '" + id + "'";
                Adaptador = new OleDbDataAdapter(SQL, conexion);
                Adaptador.Fill(tabla);
            }
            catch
            {
                mensajes.Mensaje(1);
            }
        }
        public void ActualizarNombre(string Nombre, string id)
        {
            try
            {
                tabla.Clear();
                SQL = "UPDATE Cursos SET NombreCurso = '" + Nombre + "' WHERE idCurso = '" + id + "'";
                Adaptador = new OleDbDataAdapter(SQL, conexion);
                Adaptador.Fill(tabla);
            }
            catch
            {
                mensajes.Mensaje(1);
            }
        }
        public void ActualizarEstudiante(string campo, string contenido, string id)
        {
            try
            {
                tabla.Clear();
                SQL = "UPDATE Estudiantes SET " + campo + " = '" + contenido + "' WHERE Identificacion = '" + id + "';";
                Adaptador = new OleDbDataAdapter(SQL, conexion);
                Adaptador.Fill(tabla);
            }
            catch
            {
                mensajes.Mensaje(1);
            }
        }
        public DataTable VerTodosLosEstudiante()
        {
            try
            {
                tabla.Clear();
                SQL = "select * from Estudiantes";
                Adaptador = new OleDbDataAdapter(SQL, conexion);
                Adaptador.Fill(tabla);
                return tabla;
            }
            catch
            {
                mensajes.Mensaje(1);
                return tabla;
            }
        }
        public DataTable verRelaciones()
        {
            try
            {
                tabla.Clear();
                SQL = "select * from Relacion";
                Adaptador = new OleDbDataAdapter(SQL, conexion);
                Adaptador.Fill(tabla);
                return tabla;
            }
            catch
            {
                mensajes.Mensaje(1);
                return tabla;
            }
        }
    }
}

