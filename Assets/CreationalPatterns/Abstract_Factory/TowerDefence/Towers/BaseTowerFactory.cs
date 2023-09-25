namespace TowerDefenceExample
{
    public abstract class BaseTowerFactory
    {

        protected abstract BaseTower SelectTower(ETowerTypes towerType);

        public BaseTower GetTower(ETowerTypes towerType)
        {
            BaseTower tower = SelectTower(towerType);
            tower.CreateTower();

            return tower;
        }

    }
}
