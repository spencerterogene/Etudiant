using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Etudiant
{
    /// <summary>
    /// Author: Spencer TEROGENE
    /// Devoir: C-Sharp
    /// Cours: C-Sharp
    /// Date: Le 30/09/2022
    /// </summary>

    // Ceation de la classe
    public class Personne
    {
        // Les Attributs de la classe
        string _nom;
        string _prenom1;
        string _prenom2;
        int _age;
        string _nationalite;
        string _adresseRue;
        string _ville;
        string _pays;
        string _telephone;
        string _DateCreer;
        DateTime Now = DateTime.Now;


        // Le constructeur pour associer les attributs avec les proprietes de la classe
        public Personne(string nom, string prenom1, string prenom2,
                   int age)
        {
            this._nom = nom;
            this._prenom1 = prenom1;
            this._prenom2 = prenom2;
            this._age = age;
        }

        public Personne(string nom, string prenom1, string prenom2, int age, string adresseRue, string nationalite, string ville, string pays, string telephone) : this(nom, prenom1, prenom2, age)
        {
        }

        // Le constructeur pour associer les attributs avec les proprietes de la classe
        public Personne(string nom, string prenom1, string prenom2,
                   int age, string nationalite, string adresseRue,
                   string ville, string pays, string telephone, string DateCreer)
        {
            this._nom = nom;
            this._prenom1 = prenom1;
            this._prenom2 = prenom2;
            this._age = age;
            this._nationalite = nationalite;
            this._adresseRue = adresseRue;
            this._ville = ville;
            this._pays = pays;
            this._telephone = telephone;
            this._DateCreer = DateCreer;

        }

        // Les Proprietes de la classe ou les Getters et les setters
        public string Nom
        {

            get => _nom;

            set => _nom = Capitalize(value.Trim());
        }

        public string Prenom1
        {
            get => _prenom1;

            set => _prenom1 = Capitalize(value.Trim());
        }

        public string Prenom2
        {
            get => _prenom2;

            set => _prenom2 = Capitalize(value.Trim());
        }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (_age > 0 && _age < 150)
                {
                    _age = value;
                }
                else
                {
                    _age = -1;
                }
            }
        }

        public string Nationalite
        {
            get => _nationalite;

            set => _nationalite = Capitalize(value.Trim());
        }

        public string AdresseRue
        {
            get => _adresseRue;

            set => _adresseRue = Capitalize(value.Trim());
        }

        public string ville
        {
            get => _ville;

            set => _ville = Capitalize(value.Trim());
        }

        public string Pays
        {
            get => _pays;

            set => _pays = Capitalize(value.Trim());
        }

        public string Telephone
        {

            get => _telephone;

            set => _telephone = value;
        }
        public string Date
        {
            get => _DateCreer;

            set => _DateCreer = value;
        }




        // Methode pour pour formatter quelques attributs de la classe
        public string Capitalize(string N)
        {
            N = N.Substring(0, 1).ToUpper() + N.Substring(1).ToLower();
            return N;
        }
        // Methode pour pour Afficher quelques attributs de la classe

        public string ToString()
        {
            return Prenom1 + " " + Prenom2 + " " + Nom;
        }
    }
}