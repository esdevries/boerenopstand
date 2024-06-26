using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AkshayDhotre.GraphicSettingsMenu
{
    public class MenuToggler : MonoBehaviour
    {
        public Canvas menuCanvasComponent;

        public KeyCode toggleKey = KeyCode.P;

        private void Update()
        {
            if (true)
            {
              
                    SetMenuActive(true);
                    
                
            }
        }

        /// <summary>
        /// Sets the menu canvas component enabled value equal to active.
        /// </summary>
        /// <param name="active"></param>
        private void SetMenuActive(bool active)
        {
            menuCanvasComponent.enabled = active;
        }
    }
}

