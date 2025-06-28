public enum Cargos
{
    Auxiliar = 0,
    Administrativo = 1,
    Ingeniero = 2,
    Espcialista = 3,
    Investigador = 4
}
public class Empleado
{
    private string nombre;
    private string apellido;
    private DateTime fechaDeNacimiento;
    private char estadoCivil;
    private DateTime fechaDeIngreso;
    private double sueldoBasico;
    private Cargos cargo;

    public Empleado(string nombre, string apellido, DateTime fechaDeNacimiento, char estadoCivil, DateTime fechaDeIngreso, double sueldoBasico, Cargos cargo)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.fechaDeNacimiento = fechaDeNacimiento;
        this.estadoCivil = estadoCivil;
        this.fechaDeIngreso = fechaDeIngreso;
        this.sueldoBasico = sueldoBasico;
        this.cargo = cargo;
    }

    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public DateTime FechaDeIngreso { get => fechaDeIngreso; set => fechaDeIngreso = value; }
    public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
    public Cargos Cargo { get => cargo; set => cargo = value; }
}