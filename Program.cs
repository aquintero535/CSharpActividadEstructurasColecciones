using System;
using System.Collections;

namespace ActividadEstructuras
{
    class Program
    {

        public struct Estudiante{
            public string nombre;
            public string apellido;
            public int edad;
            public string materia;

            public Estudiante(string nombre, string apellido, int edad, string materia){
                this.nombre = nombre;
                this.apellido = apellido;
                this.edad = edad;
                this.materia = materia;
            }
        }

        public enum Meses {Enero, Febrero, Marzo, Abril, Mayo, Junio, Julio, Agosto, Septiembre, Octubre, Noviembre, Diciembre};

        static void Main(string[] args)
        {
            while (true)
            {
                System.Console.WriteLine("\n\n[1] Ejemplo de arreglos.\n[2] Ejemplo de colecciones.\n[3] Ejemplo de estructuras\n[4] Ejemplo de enumeraciones\n[5] Salir");
                System.Console.Write("Opción elegida: ");
                int op = Int32.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1: arreglos(); break;
                    case 2: colecciones(); break;
                    case 3: estructuras(); break;
                    case 4: enumeraciones(); break;
                    case 5: return;
                    default: System.Console.WriteLine("Opción inválida"); break;
                }    
            }
        }

        static void arreglos() {
            System.Console.WriteLine("Arreglo con números pares comprendidos entre 1 y 20.");
            int[] arreglo = new int[10];
            int p=2;
            for (int i=0; i<10; i++) {
                arreglo[i] = p;
                p = p + 2;
            }
            System.Console.Write("[");
            foreach (var numero in arreglo)
            {
                System.Console.Write($"{numero}, ");
            }
            System.Console.Write("]");
        }

        static void colecciones() {
            Queue cola = new Queue();
            cola.Enqueue("Probando");
            cola.Enqueue("la");
            cola.Enqueue("estructura");
            cola.Enqueue("de");
            cola.Enqueue("las");
            cola.Enqueue("colas");
            while(cola.Count > 0){
                System.Console.WriteLine(cola.Dequeue());
            }

            Stack pila = new Stack();
            System.Console.WriteLine("Insertando elementos en la pila...");
            for (int i=1; i<=5; i++) {
                pila.Push($"Elemento {i}");
                System.Console.WriteLine($"Elemento {i} insertado.");
            }
            System.Console.WriteLine("Extrayendo elementos de la pila...");
            while(pila.Count > 0) {
                System.Console.WriteLine($"{pila.Pop()} extraído.");
            }

        }

        static void estructuras() {
            Estudiante estudiante1 = new Estudiante("Pedro", "Ramos", 21, "Programación 5");
            Estudiante estudiante2 = new Estudiante("Erika", "Saiz", 22, "Base de Datos 1");
            System.Console.WriteLine($"| Nombre: {estudiante1.nombre} | Apellido: {estudiante1.apellido} | Edad: {estudiante1.edad} | Materia: {estudiante1.materia} |");
            System.Console.WriteLine($"| Nombre: {estudiante2.nombre} | Apellido: {estudiante2.apellido} | Edad: {estudiante2.edad} | Materia: {estudiante2.materia} |");
        }

        static void enumeraciones() {
            System.Console.WriteLine("Introduzca un numero para encontrar el mes: ");
            int num = Int32.Parse(Console.ReadLine())-1;
            if (num >= 0 && num < 12) {
                Meses mes = (Meses)num;
                System.Console.WriteLine($"El número introducido corresponde al mes {mes.ToString()}");
            } else {
                System.Console.WriteLine("Número inválido.");
            }
        }
    }
}
