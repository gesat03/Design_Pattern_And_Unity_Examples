using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public abstract class BaseTower
    {

        protected string _Name;

        protected ITStates _TowerState;
        protected ITAnimations _TowerAnimations;
        protected ITLevels _TowerLevels;
        protected ITDynamicSpecialities _TowerDynamicSpecialities;

        public abstract void CreateTower();

        public void MakeFireAnimation()
        {
            _TowerAnimations.FiringAnimation().MakeAnimation();
        }

        public void EnemyDetected()
        {
            _TowerState.TowerDetectState().GetState();
        }

        public void NoEnemyDetection()
        {
            _TowerState.TowerIdleState().GetState();
        }

        public void ApplyingDamage()
        {
            Debug.Log(_Name + " " + _TowerDynamicSpecialities.TowerDamage().Damage() + " damage to enemy vehicle");
        }

        public void GetRadarRange()
        {
            Debug.Log(_Name + " has " + _TowerDynamicSpecialities.TowerDetectRange().DetectRange() + " m2 range...");
        }

        public void GetFireRate()
        {
            Debug.Log(_Name + " has " + 1 / _TowerDynamicSpecialities.TowerFireRate().FireRate() + " shots per second...");
        }

    }
}
