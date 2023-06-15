using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Clicker
{
    public class Upgrades : MonoBehaviour
    {
        public Stats stats;

        public int cpPrice = 100;
        public TMP_Text cpPriceText;

        public int acuPrice = 5000;
        public TMP_Text acuPriceText;


        private void Update()
        {
            cpPriceText.SetText(cpPrice+"c");
            acuPriceText.SetText(acuPrice + "c");
        }


        public void ClickPower()
        {
            if(stats.clicks >= cpPrice)
            {
                stats.clickPower *= 2;
                stats.clicks -= cpPrice;
                cpPrice *= 3;
            }
            else
            {
                Debug.Log("You dont have enough Clicks!");
            }
        }

        public void ACPower()
        {
            if (stats.clicks >= acuPrice)
            {
                stats.autoclickerPower *= 4;
                stats.clicks -= acuPrice;
                acuPrice *= 9;
            }
            else
            {
                Debug.Log("You dont have enough Clicks!");
            }
        }
    }
}
