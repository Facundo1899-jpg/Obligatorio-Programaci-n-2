using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Entities;
using Microsoft.Data.SqlClient;
using System.Windows.Markup;
using System.Security.Cryptography.X509Certificates;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Datos
{
    public class DatosGestion
    {
        public int GuardarCliente(Cliente clientes)
        {
            SqlConnection conexion = new SqlConnection(Constantes.CONNECTION_STRING);
            conexion.Open();
            string consulta = "INSERT INTO Clientes (Tipo, Documento, Nombre, Telefono, Email, Direccion, Empresa) " +
                "VALUES (@Tipo, @Documento, @Nombre, @Telefono, @Email, @Direccion, @Empresa)";

            SqlCommand comando = new SqlCommand(consulta, conexion);
            
            comando.Parameters.AddWithValue("@Tipo", clientes.Tipo);
            
            comando.Parameters.AddWithValue("@Documento", clientes.Documento);
            
            comando.Parameters.AddWithValue("@Nombre", clientes.Nombre);
            
            comando.Parameters.AddWithValue("@Telefono", clientes.Telefono);
            
            comando.Parameters.AddWithValue("@Email", clientes.Email);
            
            comando.Parameters.AddWithValue("@Direccion", clientes.Direccion);
            
            comando.Parameters.AddWithValue("@Empresa", clientes.Empresa);

            int resultado = comando.ExecuteNonQuery();

            conexion.Close();
            return resultado;
        }

        public int GuradarDeposito(Deposito deposito)
        {
            SqlConnection conexion = new SqlConnection(Constantes.CONNECTION_STRING);
            conexion.Open();
            string consulta = "INSERT INTO Depositos (Nombre, Ubicacion, Observaciones)" +
                "VALUES (@Nombre, @Ubicacion, @Observaciones)";
           
            SqlCommand comando = new SqlCommand(consulta, conexion);
            
            comando.Parameters.AddWithValue("@Nombre", deposito.Nombre);
            
            comando.Parameters.AddWithValue("@Ubicacion", deposito.Ubicacion);
            
            comando.Parameters.AddWithValue("@Observaciones", deposito.Observaciones);

            int resultado = comando.ExecuteNonQuery();

            conexion.Close();
            return resultado;
        }

        public int GuardarEquipo(Equipo equipo)
        {
            SqlConnection conexion = new SqlConnection(Constantes.CONNECTION_STRING);
            conexion.Open();
            string consulta = "INSERT INTO Equipos (Nombre, Tipo, Estado, IdDeposito, Observaciones) VALUES (@Nombre, @Tipo, @Estado, @IdDeposito, @Observaciones)";

            SqlCommand comando = new SqlCommand(consulta, conexion);

            comando.Parameters.AddWithValue("@Nombre", equipo.Nombre);
            comando.Parameters.AddWithValue("@Tipo", equipo.Tipo);
            comando.Parameters.AddWithValue("@Estado", equipo.Estado);
            comando.Parameters.AddWithValue("@IdDeposito", equipo.IdDeposito);
            comando.Parameters.AddWithValue("@Observaciones", equipo.Observaciones);

            int resultado = comando.ExecuteNonQuery();

            conexion.Close();

            return resultado;
        }
        public DataTable ListarClientes()
        {
            SqlConnection conexion = new SqlConnection(Constantes.CONNECTION_STRING);
            
            String consulta= "SELECT*FROM  Clientes";

            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);

            DataTable tabla = new DataTable();

            adaptador.Fill(tabla);

            return tabla;

        }
    

    }
}
