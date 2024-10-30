using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View : MonoBehaviour
{
    public void ShowUI(bool ison, GameObject model)
    {
        model.SetActive(ison);
    }
    
}
