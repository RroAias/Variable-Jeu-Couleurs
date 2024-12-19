using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var game = new ColorSet();

            while (true)
            {
                Console.WriteLine("Sur quelle couleur voulez-vous courir ? (yellow, red, blue) ou tapez 'exit' pour quitter :");
                string color = Console.ReadLine();
                if (color.ToLower() == "exit")
                { break; }
                Console.WriteLine("Combien de secondes voulez-vous courir sur cette couleur ?");
                if (float.TryParse(Console.ReadLine(), out float seconds)) {
                    game.RunOnColor(color, seconds);
                    var status = game.GetStatus();
                    Console.WriteLine($"Jaune: {status.Yellow}, Rouge: {status.Red}, Bleu: {status.Blue}, Temps total: {status.Time} secondes");
                    Console.WriteLine($"Couleur actuelle : {game.GetColor()}"); }
                else
                {
                    Console.WriteLine("Veuillez entrer un nombre valide de secondes.");

                }
            }

        }
    }
}
