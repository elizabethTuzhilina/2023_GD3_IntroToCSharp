namespace GD
{
    public class Player : GameObject
    {
        private string name;
        private int health;
        private int ammo;
        private PlayerType type;  //scout, mage, thief, priest

        public string Name
        {
            get => name; //EBMs - expresion bodied member
            set
            {
                if (value == null)
                    name = "default player name";
                else
                {
                    value = value.Trim();
                    name = (value.Length == 0) ? "default player name" : value;
                }
            }
        }

        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                health = (value >= 0 && value <= 100) ? value : 100;
            }
        }

        public int Ammo { get => ammo; set => ammo = value; }
        public PlayerType Type { get => type; set => type = value; }

        //NMCG - remove magic literals
        public Player() : this("default player", 100, 100, PlayerType.Scout)
        {
        }

        public Player(string name, int health, int ammo, PlayerType type)
        {
            this.name = name;
            this.health = health;
            this.ammo = ammo;
            this.type = type;
        }
    }
}