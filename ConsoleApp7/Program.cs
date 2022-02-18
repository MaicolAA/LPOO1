using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, caso;
            int diasLaborados;
            double bonoProfesionalizacion, bonoAlimentacionTotal, ganaciasTotales, sueldoTotal, deducciones;
            double sueldoQuincenal = 1050000;
            double bonoTransporte = 120000;
            double seguroColectivo = (sueldoQuincenal / 100) * 2;
            double eps = (sueldoQuincenal / 100) * 2;
            double paroForzoso = (sueldoQuincenal / 100) * 1;
            double cajaDeCompensacion = (sueldoQuincenal / 100) * 2;

            Console.WriteLine("Ingrese su nombre");
            name = Console.ReadLine();
            Console.WriteLine(name + " si tienes un titulo universitario escribe 1, de lo contrario escribe 2.");
            caso = Console.ReadLine();
            switch (caso)
            {
                case "1":

                    Console.WriteLine(name + " durante esta quincena, ¿Cuantos dias laboraste?");
                    diasLaborados = Convert.ToInt32(Console.ReadLine());
                    bonoAlimentacionTotal = diasLaborados * 25000;
                    bonoProfesionalizacion = (sueldoQuincenal / 100) * 10;
                    ganaciasTotales = sueldoQuincenal + bonoProfesionalizacion + bonoAlimentacionTotal;
                    deducciones = seguroColectivo + eps + paroForzoso + cajaDeCompensacion;
                    sueldoTotal = ganaciasTotales - deducciones;


                    Console.WriteLine(name + " su sueldo fijo quincenal es " + sueldoQuincenal);
                    Console.WriteLine(name + " su bono de transporte quincenal es " + bonoTransporte);
                    Console.WriteLine(name + " su bono de alimentacion quincenal es " + bonoAlimentacionTotal);
                    Console.WriteLine(name + " su bono por profesionalización es " + bonoProfesionalizacion);
                    Console.WriteLine("");
                    Console.WriteLine(name + " sus ganancias totales durante esta quincena son " + ganaciasTotales);
                    Console.WriteLine("");
                    Console.WriteLine(name + " su descuento por EPS es de " + eps);
                    Console.WriteLine(name + " su descuento por seguro colectivo es de " + seguroColectivo);
                    Console.WriteLine(name + " su descuento por paro forzoso es de " + paroForzoso);
                    Console.WriteLine(name + " su descuento por caja de compensación es de " + cajaDeCompensacion);
                    Console.WriteLine("");
                    Console.WriteLine(name + " el total de sus deducciones son de " + deducciones);
                    Console.WriteLine("");
                    Console.WriteLine(name + " su sueldo total durante esta quincena es de  " + sueldoTotal);


                    break;


                case "2":

                    Console.WriteLine(name + " durante esta quincena, ¿Cuantos dias laboraste?");
                    diasLaborados = Convert.ToInt32(Console.ReadLine());
                    bonoAlimentacionTotal = diasLaborados * 25000;
                    ganaciasTotales = sueldoQuincenal + bonoAlimentacionTotal;
                    deducciones = seguroColectivo + eps + paroForzoso + cajaDeCompensacion;
                    sueldoTotal = ganaciasTotales - deducciones;


                    Console.WriteLine(name + " su sueldo fijo quincenal es " + sueldoQuincenal);
                    Console.WriteLine(name + " su bono de transporte quincenal es " + bonoTransporte);
                    Console.WriteLine(name + " su bono de alimentacion quincenal es " + bonoAlimentacionTotal);
                    Console.WriteLine(name + " usted no cuenta con derechos a bono de profesionalización");
                    Console.WriteLine("");
                    Console.WriteLine(name + " sus ganancias totales durante esta quincena son " + ganaciasTotales);
                    Console.WriteLine("");
                    Console.WriteLine(name + " su descuento por EPS es de " + eps);
                    Console.WriteLine(name + " su descuento por seguro colectivo es de " + seguroColectivo);
                    Console.WriteLine(name + " su descuento por paro forzoso es de " + paroForzoso);
                    Console.WriteLine(name + " su descuento por caja de compensación es de " + cajaDeCompensacion);
                    Console.WriteLine("");
                    Console.WriteLine(name + " el total de sus deducciones son de " + deducciones);
                    Console.WriteLine("");
                    Console.WriteLine(name + "su sueldo total durante esta quincena es de  " + sueldoTotal);


                    break;

            }


            Console.ReadKey();











        }
    }
}
