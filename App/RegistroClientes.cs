public class RegistroClientes
{
    private string Nombre, Nacionalidad, Correo, Direccion;
    private int Documento;
    public RegistroClientes (string Nombre, string Nacionalidad, string Correo, string Direccion, int Documento)
    {
        this.Nombre = Nombre;
        this.Nacionalidad = Nacionalidad;
        this.Correo = Correo;
        this.Direccion = Direccion;
        this.Documento = Documento;
    }

    private void EnviarDatos()
    {

    }
}