using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Clicker
{

    public class Stats : MonoBehaviour
    {
        public int clicks = 0;
        public int clickPower = 0;

        public int autoclickerNumber = 0;
        public int autoclickerPower = 1;
        public int autoclickerFinal = 0;
        public float acCountdown = 0f;

        private void Start()
        {
            clickPower = 1;
            autoclickerNumber = 0;
        }
        private void Update()
        {
            AutoClicker();


        }
        public void AutoClicker()
        {
            autoclickerFinal = autoclickerNumber * autoclickerPower;
            acCountdown -= Time.deltaTime;
            if (acCountdown <= 0f)
            {
                acCountdown = 10f;
                clicks += autoclickerFinal;
            }
        }
    }
}
