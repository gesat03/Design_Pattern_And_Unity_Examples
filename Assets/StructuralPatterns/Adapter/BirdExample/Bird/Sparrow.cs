using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BirdExample
{
    public class Sparrow : IBird
    {
        public string Fly()
        {
           return "fly";
        }

        public string MakeSound()
        {
            return  "cik! cik! cik!";
        }
    }
}
