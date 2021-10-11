using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> EnVoieDeDisparition = new List<Animal>();
            EnVoieDeDisparition = CreerListeDanimaux("Tigre Blanc", 100).Concat(CreerListeDanimaux("Tortue albinos", 15)).Concat(CreerListeDanimaux("Bonobo tacheté", 3)).ToList();


            int nombreDeTigre = EnVoieDeDisparition.Where(x => x.Species.Name == "Tigre Blanc").Count();
            int nombreDeTortue = EnVoieDeDisparition.Where(x => x.Species.Name == "Tortue albinos").Count();
            int nombreDeBonobo = EnVoieDeDisparition.Where(x => x.Species.Name == "Bonobo tacheté").Count();


            string message1 = $"Nombre de Tigre Blanc : {nombreDeTigre} \n";
            string message2 = $"Nombre de Tortue albinos : {nombreDeTortue} \n";
            string message3 = $"Nombre de Bonobo tacheté : {nombreDeBonobo} \n";

            string caption = "Recensement des espèces en Voie de disparition";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            result = MessageBox.Show(message1 + message2 + message3, caption, buttons);

        }

        private static List<Animal> CreerListeDanimaux(string nom, int nombre)
        {
            List<Animal> liste = new List<Animal>(); 
            for (int i =0; i < nombre; i++ )
            {
                //Animal animal = new Animal(nom);
                liste.Add(new Animal(nom));
            }
            return liste;
        }
    }
}
