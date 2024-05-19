using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Formulario3
public class Jefe
{
    //Atributos
    public string Nombre { get; set; }
    public int DNI { get; set; }
    public string Cargo { get; set; }
    public string Area { get; set; }
    public int  AñosAntiguedad { get; set; }

    //Constructor

    public Jefe(string nombre, int dni, string cargo, string area, int añosAntiguedad)
    {
        Nombre = nombre;
        DNI = dni;
        Cargo = cargo;
        Area = area;
        AñosAntiguedad = añosAntiguedad;

    }

    //Metodos

    public double SueldoBase()
    {
        if (Cargo == "Gerente" && Area =="Contabilidad")
        {
            return 6000;
        }
        else if (Cargo == "Gerente" && Area == "Planificacion")
        {
            return 7000;
        }
        else if (Cargo == "Subgerente" && Area == "Contabilidad")
        {
            return 5000;
        }
        else if (Cargo == "Subgerente" && Area == "Planificacion")
        {
            return 6000;
        }
        {
            // Manejo de caso donde no se cumple ninguna condición
            return 0;
        }
    }

    public double Movilidad()
    {
        if (Cargo == "Gerente")
        {
            return 700;
        }
        else if (Cargo == "Subgerente")
        {
            return 400;
        }
        {
            // Manejo de caso donde no se cumple ninguna condición
            return 0;
        }
    }

    public double Bonificacion()
    {
        if (AñosAntiguedad <= 7)
        {
            return SueldoBase() * 0.05;
        }
        else if (AñosAntiguedad >= 8)
        {
            return SueldoBase() * 0.04;
        }
        {
            // Manejo de caso donde no se cumple ninguna condición
            return 0;
        }
    }

    public double SueldoFinal()
    {
        return SueldoBase() + Bonificacion() + Movilidad();
    }
}

