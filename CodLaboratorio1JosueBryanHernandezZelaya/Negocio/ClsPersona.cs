using CodLaboratorio1JosueBryanHernandezZelaya.Entidades;
namespace CodLaboratorio1JosueBryanHernandezZelaya.Negocio
{
     class ClsPersona
    {
        
        public  String calcularIMC (Persona persona){
            Double pro = persona.peso / Math.Pow(persona.altura, 2);

            if (pro > 24 && pro < 25){

                return " Usted tiene un peso ideal felicitaciones ";

            }

            else if (pro <24){

                return "Usted no tiene un peso ideal de 24 sin embargo no tiene sobrepeso esta en buena forma se considera lo ideal";
    
            }

            else if (pro >= 25){

                return "Usted tiene mayor peso de lo ideal, tiene sobre peso cosulte con su doctor de confianza";
            }

            return("");


        }

        public String esMayorDeEdad(Persona persona){

            if(persona.edad >=18){

                return "Usted es mayor de edad";

            }

            else{

                return "Usted es menor de edad";

            }

                
            }

            





        }






    }

