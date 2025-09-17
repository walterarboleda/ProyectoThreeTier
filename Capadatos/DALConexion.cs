using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capadatos
{
    public class DALConexion
    {
        /*Fuente:
        http://blog.hadsonpar.com/2021/12/windows-forms-crud-con-visual-studio-y.html
        http://blog.hadsonpar.com/2020/08/crud-base-de-datos-con-microsoft-sql.html#google_vignette

        CREATE DATABASE BD_TEST;

        CREATE TABLE USUARIO (
        id int IDENTITY(1,1) PRIMARY KEY  NOT NULL,
        usuario varchar(50) NOT NULL,
        contrasena varchar(50)  NOT NULL,
        intentos int NOT NULL,
        nivelSeg decimal(18,0) NOT NULL,
        fechaReg date
        );

        */
        /// <summary>
        /// Cadena de conexión para el acceso a la base de datos SQL Server
        /// </summary>
        private SqlConnection Conexion = new
            SqlConnection("Data Source= DESKTOP-GJDFMRJ\\SQLEXPRESS01;Initial Catalog=BD_TEST;Integrated Security=True;Encrypt=False;");

        /// <summary>
        /// Abrir la conexión hacia la base de datos
        /// </summary>
        /// <returns></returns>
        public SqlConnection OpenConnection()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        /// <summary>
        /// Cerrar la conexión hacia la base de datos
        /// </summary>
        /// <returns></returns>
        public SqlConnection CloseConnection()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
