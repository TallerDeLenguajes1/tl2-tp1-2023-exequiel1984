namespace Practico1
{
    public class CargarDatos
    {
        public Cadeteria CargarDatosCadeteria(){
            string ArchivoCSV = "DatosCadeteria.csv";
            var LeerArchivoCSV = File.ReadAllLines(ArchivoCSV);
            var LineaCSV = (LeerArchivoCSV[0]).Split(",");
            Cadeteria NuevaCadeteria = new Cadeteria(LineaCSV[0], LineaCSV[1]);
            return NuevaCadeteria;
        }

        public void CargarDatosCadete(List<Cadete> ListadoCadetes){
            string ArchivoCSV = "DatosCadetes.csv";
            var LeerArchivoCSV = File.ReadAllLines(ArchivoCSV);

            for (int i = 0; i < LeerArchivoCSV.Length; i++)
            {
                var LineaCSV = (LeerArchivoCSV[i].Split(","));
                Cadete NuevoCadete = new Cadete(LineaCSV);
                ListadoCadetes.Add(NuevoCadete);
            }
        }
    }
}