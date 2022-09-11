using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenderManager : MonoBehaviour
{
    public Renderer rend;

    public void renderSwitch(){
        rend = GetComponent<Renderer>();
        rend.enabled = !rend.enabled;
    }

    public void renderColor(){
        Color newColor = new Color( Random.value, Random.value, Random.value, 1.0f );
        rend = GetComponent<Renderer>();
        rend.material.color = newColor;
    }
}
