using UnityEngine;
using UnityEngine.UI;

namespace RPG.Stats
{
    public class LevelDisplay : MonoBehaviour
    {
        BaseStats basestats;

        private void Awake()
        {
            basestats = GameObject.FindWithTag("Player").GetComponent<BaseStats>();
        }

        private void Update()
        {
            GetComponent<Text>().text = string.Format("{0:0}", basestats.GetLevel());
        }
    }
}
