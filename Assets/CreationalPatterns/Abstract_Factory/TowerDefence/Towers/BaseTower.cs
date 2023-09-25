using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public abstract class BaseTower
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
        protected ITSpecialities _TowerSpecialities;

        public abstract void CreateTower();

        public void MakeFireAnimation()
        {
            _TowerAnimations.FiringAnimation().MakeAnimation();
        }


    }
}
