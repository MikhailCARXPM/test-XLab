using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TZ
{
    public class PlayerControler : MonoBehaviour
    {

        public Spawner spawner;
        public CloudControler cloudControler;
        public List<Refresh> villagers;
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                Debug.Log("X key down");
                spawner.Spawn();    
            }
            if (Input.GetKeyDown(KeyCode.Z))
            {
                Debug.Log("Z key down");
                cloudControler.Action();
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Space key down");
                foreach (var villager in villagers)
                {
                    villager.ChangeTool();
                }
            }
        }
    }
}