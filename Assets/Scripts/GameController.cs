using System.Collections;
using System.Collections.Generic;
using Mono.CompilerServices.SymbolWriter;
using UnityEngine;


namespace Golf
{

    public class GameController : MonoBehaviour
    {
        public MainMenuState mainMenuState;

            private void Start()
        {
            mainMenuState.gameObject.SetActive(true);

        }

    }
}
