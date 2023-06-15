using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Clicker
{
    public class Items : MonoBehaviour
    {
        public Stats stats;
        public int acPrice = 50;
        public TMP_Text acPriceText;

        // Update is called once per frame
        void Update()
        {
            acPriceText.SetText(acPrice + "c");
        }

        public void AutoClickerBuy()
        {
            if (stats.clicks >= acPrice)
            {
                stats.clicks -= acPrice;
                stats.autoclickerNumber += 10;
                acPrice += 70;
            }

        }
    }

}