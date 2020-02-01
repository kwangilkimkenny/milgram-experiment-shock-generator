using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BTM : MonoBehaviour
{
    public void ButtonClickedCheck()
    {

            print(EventSystem.current.currentSelectedGameObject.name);

    }
}
