using System;
using System.Security.Cryptography;
using System.Text;

public class Encriptacion
{

    private string usuario, clave;
    public Encriptacion (string usuario, string clave)
    {
        this.usuario = usuario;
        this.clave = clave;

        var resultado = EncriptarClave(clave);
    }

    private static (string Hash, string Salt) EncriptarClave(string clave)
    {
        var salt = GenerarSalt();
        var hash = ObtenerHash(clave, salt);
        return (hash, salt);
    }

    private static string GenerarSalt()
    {
        using (var rng = new RNGCryptoServiceProvider())
        {
            byte[] saltBytes = new byte[16];
            rng.GetBytes(saltBytes);
            return Convert.ToBase64String(saltBytes);
        }
    }

    private static string ObtenerHash(string clave, string salt)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            var claveConSalt = clave + salt;
            byte[] bytes = Encoding.UTF8.GetBytes(claveConSalt);
            byte[] hashBytes = sha256.ComputeHash(bytes);
            return Convert.ToBase64String(hashBytes);
        }
    }
}