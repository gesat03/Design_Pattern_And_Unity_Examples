using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public interface  ITDetectability
    {
        public bool Ground();
        public bool Air();
        public bool Water();
    }
}
