// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using CodLaboratorio1JosueBryanHernandezZelaya.Entidades;
using CodLaboratorio1JosueBryanHernandezZelaya.Negocio;

Console.Write("======== ");
Console.Write("Bienvenido usuario inteligente");
Console.WriteLine("======== ");
Console.WriteLine("");
Console.WriteLine("Porfavor escriba su nombre: ");
String? nombre = Console.ReadLine();
Console.WriteLine("");
Console.WriteLine($"{nombre} por favor escriba su apellido: ");
String? apellido = Console.ReadLine();
Console.WriteLine("");
Console.WriteLine($"{nombre} {apellido} por favor ingrese su edad: ");
int edad = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine($"{nombre} {apellido} por favor escriba su sexo: ");
String? sexo = Console.ReadLine();
Console.WriteLine("");
Console.WriteLine($"{nombre} {apellido} por favor ingrese su peso: ");
Double peso = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine($"{nombre} {apellido} por favor ingrese su altura: ");
Double altura = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("");

Console.WriteLine("===========================================================================================================");
Persona persona = new Persona();
persona.nombre = nombre;
persona.apellido = apellido;
persona.edad = edad;
persona.sexo = sexo;
persona.peso = peso;
persona.altura = altura;
ClsPersona clsPersona = new ClsPersona();

Console.WriteLine(clsPersona.calcularIMC(persona));
Console.WriteLine("");
Console.WriteLine(clsPersona.esMayorDeEdad(persona));
Console.WriteLine("===========================================================================================================");
Console.WriteLine("");
Console.Write("Muchas gracias por ingresar sus datos");





