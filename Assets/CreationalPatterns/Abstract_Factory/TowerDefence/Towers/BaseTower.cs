using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public abstract class BaseTower
    {

        protected string _Name;

        protected ITStates _TowerStates;
        protected ITAnimations _TowerAnimations;
        protected ITLevels _TowerLevels;
        protected ITDynamicSpecialities _TowerDynamicSpecialities;
        protected ITStaticSpecialities _TowerStaticSpecialities;

        public abstract void CreateTower();

        public void MakeFireAnimation()
        {
            _TowerAnimations.FiringAnimation().MakeAnimation();
        }

        public void EnemyDetected()
        {
            _TowerStates.TowerDetectState().GetState();
        }

        public void NoEnemyDetection()
        {
            _TowerStates.TowerIdleState().GetState();
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
            Debug.Log(_Name + " make 1 shot every " + _TowerDynamicSpecialities.TowerFireRate().FireRate() + " second...");
        }

        public void GetDetection()
        {
            bool air = _TowerStaticSpecialities.Detectablity().Air();
            bool ground = _TowerStaticSpecialities.Detectablity().Ground();
            bool water = _TowerStaticSpecialities.Detectablity().Water();

            string airResult = air ? "-air " : "";
            string groundResult = ground ? "-ground " : "";
            string waterResult = water ? "-water" : "";

            Debug.Log(_Name + " has ability to attack "
                + airResult
                + groundResult
                + waterResult);
        }

    }
}
