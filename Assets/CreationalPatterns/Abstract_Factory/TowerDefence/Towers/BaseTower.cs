using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public abstract class BaseTower : ITAttributes
    {

        private string _name;
        public string GetName
        {
            get => _name;
        }
        public string SetName
        {
            set => value = _name;
        }

        protected ITStates _TowerState;
        protected ITAnimations _TowerAnimations;
        protected ITLevel _TowerLevels;
        protected ITSpecialities<int> _TowerDamage;
        protected ITSpecialities<float> _TowerFireRate;
        protected ITSpecialities<Vector2> _TowerDetectRange;

        public abstract void CreateTower();

        public ITStates CurrentState()
        {
            throw new System.NotImplementedException();
        }

        public ITAnimations CurrentAnimation()
        {
            throw new System.NotImplementedException();
        }

        public ITLevel CurrentLevel()
        {
            throw new System.NotImplementedException();
        }

        public ITSpecialities<int> GetDamage()
        {
            throw new System.NotImplementedException();
        }

        public ITSpecialities<float> GetFireRate()
        {
            throw new System.NotImplementedException();
        }

        public ITSpecialities<Vector2> GetRange()
        {
            throw new System.NotImplementedException();
        }
    }
}
