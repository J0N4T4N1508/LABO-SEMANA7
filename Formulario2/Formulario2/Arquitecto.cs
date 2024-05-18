using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;

public class Arquitecto
{
    // Atributos
    public int Codigo { get; set; }
    public string Nombres { get; set; }
    public string CondicionContrato { get; set; }
    public string Especialidad { get; set; }
    public string TipoActividad { get; set; }
    public string TipoAfiliacion { get; set; }

    // Constructor
    public Arquitecto(int codigo, string nombres, string condicionContrato, string especialidad, string tipoActividad, string tipoAfiliacion)
    {
        Codigo = codigo;
        Nombres = nombres;
        CondicionContrato = condicionContrato;
        Especialidad = especialidad;
        TipoActividad = tipoActividad;
        TipoAfiliacion = tipoAfiliacion;
    }

    // Método para mostrar la información del arquitecto
    public void MostrarInformacion()
    {
        Console.WriteLine($"Código: {Codigo}");
        Console.WriteLine($"Nombres: {Nombres}");
        Console.WriteLine($"Condición de Contrato: {CondicionContrato}");
        Console.WriteLine($"Especialidad: {Especialidad}");
        Console.WriteLine($"Tipo de Actividad: {TipoActividad}");
        Console.WriteLine($"Tipo de Afiliación: {TipoAfiliacion}");
    }

    public double SueldoBase()
    {
        if (CondicionContrato == "Estable" && TipoActividad == "Supervision de Obras")
        {
            return 4000;
        }
        else if (CondicionContrato == "Estable" && TipoActividad == "Supervision de Vias")
        {
            return 6000;
        }
        else if (CondicionContrato == "Contratado" && TipoActividad == "Supervision de Obras")
        {
            return 2000;
        }
        else if (CondicionContrato == "Contratado" && TipoActividad == "Supervision de Vias")
        {
            return 4500;
        }
        {
            // Manejo de caso donde no se cumple ninguna condición
            return 0;
        }
    }

    public double Bonificacion()
    {
        if (Especialidad == "Estructuras")
        {
            return SueldoBase() * 0.16;
        }
        else if (Especialidad == "Recursos Hidricos")
        {
            return SueldoBase() * 0.18;
        }
        {
            // Manejo de caso donde no se cumple ninguna condición
            return 0;
        }
    }

    public double Descuento()
    {
        if (TipoAfiliacion == "AFP")
        {
            return SueldoBase() * 0.15;
        }
        else if (TipoAfiliacion == "SNP")
        {
            return SueldoBase() * 0.08;
        }
        else
        {
            // Manejo de caso donde no se cumple ninguna condición
            return 0;
        }
    }

    public double SueldoBruto()
    {
        return SueldoBase() + Bonificacion();
    }

    public double SueldoNeto()
    {
        return SueldoBruto() - Descuento();
    }
}

