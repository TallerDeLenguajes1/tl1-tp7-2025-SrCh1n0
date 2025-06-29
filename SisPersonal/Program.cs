Empleado Mario = new Empleado("Mario", "Luis", new DateTime(1990, 7, 31), 'c', new DateTime(2020, 3, 24), 600000.00, Cargos.Ingeniero);
Empleado Jorge = new Empleado("Jorge", "Borges", new DateTime(1995, 6, 25), 's', new DateTime(2019, 4, 30), 650000.00, Cargos.Administrativo);
Empleado Miguel = new Empleado("Miguel", "Cano", new DateTime(1988, 4, 20), 'c', new DateTime(2021, 7, 15), 550000.00, Cargos.Especialista);

Empleado[] Empleados = [Mario, Jorge, Miguel];

void MostrarEmpleado(Empleado persona)
{
    Console.WriteLine($"\n{persona.Apellido}, {persona.Nombre}\nNacimieto: {persona.FechaDeNacimiento.ToString("d")}");
    if (persona.EstadoCivil == 'c')
    {
        Console.WriteLine("Estado Civil: Casado");
    }
    else
    {
        Console.WriteLine("Estado Civil: Soltero");
    }
    Console.WriteLine($"Sueldo Basico: ${persona.SueldoBasico:N2}\nCargo: {persona.Cargo}");
    Console.WriteLine($"Antigüedad: {persona.Antiguedad(DateTime.Today)} años\nEdad: {persona.Edad(DateTime.Today)}\nAños para jubilarse: {persona.AniosParaJubilarse()}");
    Console.WriteLine($"Salario: ${persona.Salario():N2}");
}
double totalAPagar = 0;
foreach (Empleado persona in Empleados)
{
    totalAPagar += persona.Salario();
    MostrarEmpleado(persona);
}

Console.WriteLine($"\nTotal a pagar: ${totalAPagar:N2}");

Empleado masProximo = Empleados[0];

foreach (Empleado persona in Empleados)
{
    if (persona.AniosParaJubilarse() < masProximo.AniosParaJubilarse())
    {
        masProximo = persona;
    }
}

Console.WriteLine("\nEmpleado mas proximo a jubilarse: ");
MostrarEmpleado(masProximo);