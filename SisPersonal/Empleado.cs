using System.Runtime.CompilerServices;

public enum Cargos
{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
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

    public int Antiguedad(DateTime today)
    {
        return today.Subtract(FechaDeIngreso).Days / 365;
    }
    public int Edad(DateTime today)
    {
        return today.Subtract(FechaDeNacimiento).Days / 365;
    }
    public int AniosParaJubilarse()
    {
        return 65 - Edad(DateTime.Today);
    }
    public double Salario()
    {
        double monto;
        if (Antiguedad(DateTime.Today) <= 20)
        {
            double antiguedad = Antiguedad(DateTime.Today);
            monto = SueldoBasico * antiguedad / 100;
        }
        else
        {
            monto = sueldoBasico * 0.25;
        }
        if (Cargo == Cargos.Ingeniero || Cargo == Cargos.Especialista)
        {
            monto *= 1.5;
        }
        if (EstadoCivil == 'c')
        {
            monto += 150000;
        }
        monto += SueldoBasico;
        return monto;
    }
}