namespace Examen_3.Data
{
    public class Mysqlconfiguration
    {
        public string CadenaConexion { get; }

        public Mysqlconfiguration(string codenaConexion)
        {
            CadenaConexion = codenaConexion;
        }
    }
}
