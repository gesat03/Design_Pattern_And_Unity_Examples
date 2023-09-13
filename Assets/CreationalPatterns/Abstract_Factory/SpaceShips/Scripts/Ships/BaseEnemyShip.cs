using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceShipExample
{
    public abstract class BaseEnemyShip
    {

        private string _name;

        // Newly defined objects that represent weapon & engine
        // These can be changed easily by assigning new parts
        // in UFOEnemyShipFactory or UFOBossEnemyShipFactory
        protected IESWeapon weapon;
        protected IESEngine engine;
        protected IESForceField forceField;

        public string GetName
        {
            get => _name;
        }

        public string SetName
        {
            set => value = _name;
        }

        public abstract void MakeShip();

        // Because I defined the toString method in engine
        // when it is printed the String defined in toString goes
        // on the screen
        public void FollowHeroShip()
        {
            Debug.Log(GetName + " is following the hero at " + engine.ShowMessage());
        }

        public void ActivateForceField()
        {
            Debug.Log(GetName + forceField.ShowMessage() + " force field activated");
        }

        public void DisplayEnemyShip()
        {
            Debug.Log(GetName + " enemy ship is on the screen");
        }

        public void EnemyShipShoots()
        {
            Debug.Log(GetName + " attacks and does " + weapon.ShowMessage());
        }

        // If any EnemyShip object is printed to screen this shows up
        public void ShowMessage()
        {
            Debug.Log("The " + _name
                + " has a top speed of " + engine.ShowMessage()
                + " and an attack power of " + weapon.ShowMessage()
                + " force field is " + forceField.ShowMessage()); ;
        }
    }
}
