using UnityEngine;
using System.Collections.Generic;

namespace Stats {
    public class TaskScheduler
    {
        public float barLength { get; set; }

        public TaskScheduler(float _barLength){
            this.barLength = _barLength;
        }

        void DecreaseBar()
        {
            barLength--;
        }
    }

}

