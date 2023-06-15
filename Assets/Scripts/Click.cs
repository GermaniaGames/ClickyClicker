using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Clicker
{
    
    public class Click : MonoBehaviour
    {
        public Stats stats;

        public AudioSource clickSound;
        public AudioClip ClickSound;

        public void OnClick()
        {
            stats.clicks += stats.clickPower;
            clickSound.PlayOneShot(ClickSound);
        }
    }
}
