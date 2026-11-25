using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Text;
using System.Transactions;
using Task.Entities;
using Task.Entities.Enumerators;
using Tesk.Persistencia.Interfaces;

namespace Tesk.Persistencia.DataBase
{
    public class CuentaDB : ICuenta
    {
        const string CONNECTION_STRING = "Data Source=WIN-UD8I8C01092\\SQLEXPRESS;Initial Catalog=TaskManager;Integrated Security=True;Trust Server Certificate=True";

        public Cuenta? BuscarCuentaPorOwner(string correo)
        {
            var cuentas = LeerCuentas();
            foreach (var cuenta in cuentas)
            {
                if (cuenta.Owner.Email.Equals(correo))
                    return cuenta;
            }
            return null;
        }

        public int GuardarCuenta(Cuenta cuenta)
        {
            var sqlConnection = new SqlConnection(CONNECTION_STRING);
            try
            {
                sqlConnection.Open();

                var transaction= sqlConnection.BeginTransaction();
                string consultaSql = "INSERT INTO Users (Nombre, Email, Password) VALUES (@Nombre, @Email, @Password); SELECT CAST (SCOPE_IDENTITY() AS INT);";
                var sqlCommand = new SqlCommand(consultaSql, sqlConnection, transaction);
                sqlCommand.Parameters.AddWithValue("@Nombre", cuenta.Owner.Nombre);
                sqlCommand.Parameters.AddWithValue("@Email", cuenta.Owner.Email);
                sqlCommand.Parameters.AddWithValue("@Password", cuenta.Owner.Password);

                //Guardamos info en las dos tablas, Users y Accounts.
                int ownerId = 0;
                var dataReader = sqlCommand.ExecuteReader();
                
                if(dataReader.Read())
                {
                    ownerId = Convert.ToInt32(dataReader[0]);
                }
                dataReader.Close();

                string consultarAccounts = "INSERT INTO Accounts (Id, OwnerId, AccountType) VALUES (@Id, @OwnerId, @AccountType);";
                var commandAccount = new SqlCommand(consultarAccounts, sqlConnection, transaction);
                commandAccount.Parameters.AddWithValue("@Id", Guid.NewGuid());
                commandAccount.Parameters.AddWithValue("@OwnerId", ownerId);
                commandAccount.Parameters.AddWithValue("@accountType", (short)cuenta.TipoCuenta);
                int filasAfectadas = commandAccount.ExecuteNonQuery();
                transaction.Commit();
                return filasAfectadas;
            }

            catch (Exception ex)
            {
                throw;
            }
        }
            
        

        private List<Cuenta> LeerCuentas()
        {
            List<Cuenta> cuentas = [];
            var sqlConnection = new SqlConnection(CONNECTION_STRING);
            try
            {
                sqlConnection.Open();
                string sqlQuery = "SELECT * FROM Accounts A INNER JOIN Users U ON A.OwnerId = U.Id";
                var sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
                var dataReader = sqlCommand.ExecuteReader();
                while(dataReader.Read())
                {
                    var cuenta = new Cuenta()
                    {
                        Id = new Guid(dataReader["Id"].ToString()),
                        Owner = new Administrador()
                        {
                            Id = Convert.ToInt32(dataReader["OwnerId"].ToString()),
                            Nombre = dataReader["Nombre"].ToString(),
                            Email = dataReader["Email"].ToString(),
                            Password = dataReader["Password"].ToString()
                        },
                        TipoCuenta = (TipoCuenta)Convert.ToInt16(dataReader["AccountType"].ToString())
                    };
                    cuentas.Add(cuenta);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if(sqlConnection.State == System.Data.ConnectionState.Open)
                    sqlConnection.Close();
            }
            return cuentas;
        }
    }
}
