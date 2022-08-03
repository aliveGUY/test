using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Stats {
    public class statHandler : MonoBehaviour
    {
        public Player_Storage storage;
        void Start()
        {
            Hunger hunger = new Hunger(storage.hunger);
            InvokeRepeating("hunger.DecreaseBar()", 0f, 2.0f);
        }
    }

}
