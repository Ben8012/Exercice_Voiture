using Ex_Enum.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Enum.Structures
{
    internal struct Voiture
    {
        private int _kilometrage;
        public int Kilometrage
        {
            get
            {
                return _kilometrage;
            }
        }



        public string Couleur { get; set; }
        public int Puissance { get; set; }

        private Carburants _carburant;
        public Carburants Carburant { get { return _carburant; } }

        private Marques _marque;
        public Marques Marque { get { return _marque; } }

        public Voiture(Marques marque, string couleur, int puissance, Carburants carburant) : this()
        {
            Couleur = couleur;
            Puissance = puissance;
            _carburant = carburant;
            _marque = marque;
        }

        /// <summary>
        /// ajoute des km la voiture
        /// </summary>
        public void Roule()
        {
            if (_marque == Marques.Renault)
                _kilometrage += 50;
            if (_marque.ToString() is "VW")
                _kilometrage += 100;
        }


    }
}
