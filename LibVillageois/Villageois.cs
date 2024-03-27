namespace LibVillageois
{
    public class Villageois
    {
        private bool _malade;
        private string _nom;
        private double _poids;
        private Potions maPotions;


        public Villageois(string nom)
        {
            this._nom = nom;
            this._malade = false;
            this.maPotions = new Potions(0);
        }

        public Villageois(String nom,int poids, bool malade)
        {
            this._nom = nom;
            this._malade = malade;
            this._poids = poids;
        }
       
        public Villageois(string nom, int poids, bool malade, int nbPotions)
        {
            this._nom = nom;
            this._malade = malade;
            this._poids = poids;
            this.maPotions = new Potions(nbPotions);
        }
        
        public string get_nom()
        { return this._nom; }

        public bool get_malade()
        { return this._malade; }

        public double get_poids()
        { return this._poids; }

        public override string ToString()
        {
            string malade = "malade";
            if (!this._malade)
            {
                malade = "pas malade";
            }
            return $"le villageois se nomme {this._nom} peut soulever {this._poids} et est {malade}";

        }

        public double poidsSouleve()
        {
            return (this._poids / 5);
        }

        public string getNom()
        {
            return _nom;
        }

        public bool getmalade()
        {
            return this._malade;
        }

        public void setPoids(int poids)
        {
            this._poids = poids;
        }

        public bool soulevememepoids(Villageois goulois) 
        {

            bool flag = false;
            if (this._poids == goulois .get_poids())
            {
                flag = true;

            }   
            return flag;
        
        
        }


    }
}