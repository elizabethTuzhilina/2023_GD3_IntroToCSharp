namespace GD
{
    public class UpgradePlayerType : IUpgradeGameObject
    {
        public bool Upgrade(GameObject gameObj)
        {
            Player p = gameObj as Player;
            if (p == null) return false;

            int typeAsInt = (int)p.Type;
            typeAsInt++;
            //NMCG - magic numbers. wtf?
            typeAsInt %= 4;
            p.Type = (PlayerType)typeAsInt;

            return true;
        }
    }

    public class UpgradePlayerHealth : IUpgradeGameObject
    {
        private int newHealth;

        public UpgradePlayerHealth(int newHealth)
        { this.newHealth = newHealth; }

        public bool Upgrade(GameObject gameObj)
        {
            Player p = gameObj as Player;
            if (p == null) return false;

            p.Health = newHealth;
            return true;
        }
    }
}