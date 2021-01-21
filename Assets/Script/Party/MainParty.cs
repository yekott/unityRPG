using RPG.Combat;
using RPG.Saving;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Party
{
    public class MainParty : MonoBehaviour , ISaveable
    {
        List<Fighter> fighters = null;

        public object CaptureState()
        {
            return fighters;
        }

        public void RestoreState(object state)
        {
            fighters = (List<Fighter>)state;
        }
    }
}
