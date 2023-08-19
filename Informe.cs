public class Informe{
    // public List<double> EnviosPromedio {get;set;} = new List<double>();
    // public List<double> TotalMontos {get;set;}= new List<double>();
    // public List<string> NombreCadetes {get;set;}= new List<string>();
    public double MontoTotal;
    public List<InformeCadete> InformeCadetes {get;set;}= new List<InformeCadete>();
}
public class InformeCadete{
    public string Nombre;
    public double monto;
}