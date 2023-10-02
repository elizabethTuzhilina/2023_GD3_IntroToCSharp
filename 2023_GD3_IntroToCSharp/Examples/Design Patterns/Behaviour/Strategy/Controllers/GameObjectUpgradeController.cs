using System;
using System.Collections.Generic;

namespace GD.Controller
{
    public class GameObjectUpgradeController
    {
        private List<IUpgradeGameObject> upgrades;

        public GameObjectUpgradeController()
        {
            upgrades = new List<IUpgradeGameObject>();
        }

        public void Add(IUpgradeGameObject upgrader)
        {
            upgrades.Add(upgrader);
        }

        public void Upgrade(GameObject gameObj)
        {
            foreach (IUpgradeGameObject upgrader in upgrades)
            {
                upgrader.Upgrade(gameObj);
            }
        }
    }
}