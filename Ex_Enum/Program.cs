/*
 * Décrivez une structure permettant de construire une voiture sur base de valeurs 
présentes dans des énumérations. 
Ensuite, ajoutez lui des méthodes utiles. 
Une fois construite, faites la rouler et affichez son état dans la console
*/

using Ex_Enum.Enums;
using Ex_Enum.Structures;

Voiture voiture = new Voiture(Marques.Renault,"rouge",80,Carburants.Diesel);
voiture.Roule();
Console.WriteLine($"La {voiture.Marque} a {voiture.Kilometrage} km au compteur et roule au {voiture.Carburant}");

Voiture voiture2 = new Voiture(Marques.VW, "bleu", 100, Carburants.Essence);
voiture2.Roule();
Console.WriteLine($"La {voiture2.Marque} a {voiture2.Kilometrage} km au compteur et roule au {voiture2.Carburant}");







