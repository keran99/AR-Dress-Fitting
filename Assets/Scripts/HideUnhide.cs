using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideUnhide : MonoBehaviour
{
    public GameObject Object;

    public void Hide(){
        Object.SetActive(false);
    }

    public void Unhide(){
        Object.SetActive(true);
    }
}
