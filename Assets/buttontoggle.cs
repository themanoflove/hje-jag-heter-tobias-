using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttontoggle : MonoBehaviour {
    

	public void ToggleChange(bool state)
    {
        GetComponent<Button>().interactable = state;
    }
}
