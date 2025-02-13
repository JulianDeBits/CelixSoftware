using System;
using System.Data.SqlClient;

public class ConexionDB
{
    private string cadenaConexion;

    public ConexionDB(string conexionString)
    {
        cadenaConexion = conexionString;
    }

    public SqlConnection AbrirConexion()
    {

        try
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.open();
            return conexion;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}");
            return null;
        }
    }

    public void CerrarConexion(SqlConnection conexion)
    {
        try
        {
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
            {

                conexion.Close();

            } catch (Exception ex)
        {

            MessageBox.Show($"Error al cerrar la conexion: {ex.Message}");

        }
        }
    }

}