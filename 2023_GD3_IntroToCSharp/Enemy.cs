namespace GD
{
    internal class Enemy
    {
        private string v1;
        private int v2;
        private int v3;
        private EnemyType airborn;

        public Enemy(string v1, int v2, int v3, EnemyType airborn)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.airborn = airborn;
        }
    }
}