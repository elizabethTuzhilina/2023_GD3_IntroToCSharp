using System.Collections.Generic;

namespace GD.Controller
{
    public interface IUpgradePlayer
    {
        public bool Execute(Player p);
    }

    public class UpgradePlayerHealth : IUpgradePlayer
    {
        public bool Execute(Player p)
        {
            //do something to health
        }
    }

    public class PlayerController
    {
        private List<Player> list;
        private IUpgradePlayer upgradePlayer;
        private IResetPlayer resetPlayer;

        public void Execute()
        {
            foreach (Player p in list)
            {
                upgradePlayer.Execute(p);
                resetPlayer.Execute(p);
            }
        }
    }
}