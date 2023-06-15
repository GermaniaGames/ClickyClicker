using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Clicker
{
    public class ClickCounter : MonoBehaviour
    {
        public Stats stats;

        public TMP_Text playerClicksText;
        public int playerClicks;

        void Start()
        {
            playerClicks = stats.clicks;
        }
        void Update()
        {
            playerClicks = stats.clicks;
            playerClicksText.SetText("Clicks: " + playerClicks);
        }
    }
}
