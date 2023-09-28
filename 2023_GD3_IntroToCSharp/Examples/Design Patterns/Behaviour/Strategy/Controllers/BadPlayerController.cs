using System.Collections.Generic;

namespace GD.Controller
{
    /// <summary>
    /// A bad implementation of controller that promotes and resets players
    /// </summary>
    public class BadPlayerController
    {
        private List<Player> list;

        public BadPlayerController(List<Player> pList)
        {
            this.list = pList;
        }

        public void Execute()
        {
            foreach (Player p in list)
            {
                UpgradePlayerType(p);
                ResetPlayerType(p);
            }
        }

        public bool UpgradePlayerType(Player p)
        {
            //find the type and increment by 1
            return false;
        }

        public bool ResetPlayerType(Player p)
        {
            return false;
        }
    }
}