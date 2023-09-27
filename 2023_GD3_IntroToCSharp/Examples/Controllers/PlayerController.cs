using System.Collections.Generic;

namespace GD.Controller
{
    public class GameObject
    {
        //id, transform(position, rotation, scale)
    }

    public interface IUpgradeGameObject
    {
        bool Upgrade(GameObject gameObj);
    }

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

    public class GameObjectUpgradeController
    {
        private List<IUpgradeGameObject> listOfUpgrades;

        public void Add(IUpgradeGameObject upgrader)
        {
            listOfUpgrades.Add(upgrader);
        }

        public void Apply(GameObject gameObj)
        {
            foreach (IUpgradeGameObject upgrader in listOfUpgrades)
            {
                upgrader.Upgrade(gameObj);
            }
        }
    }
}