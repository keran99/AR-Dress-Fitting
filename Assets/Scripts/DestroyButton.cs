using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyButton : MonoBehaviour
{
    public GameObject startButton;
    public void Destroy(){
        Destroy(startButton);
    }
}
