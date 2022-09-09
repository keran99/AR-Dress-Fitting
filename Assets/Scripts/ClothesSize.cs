using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothesSize : MonoBehaviour
{
    public GameObject Object; // Cloth

    public void OnPressSDress(){   
        Object.transform.localScale = new Vector3(0.65f, 0.75f, 1f);
        Object.SetActive(!Object.activeSelf);
        Object.SetActive(!Object.activeSelf);
    }

    public void OnPressMDress(){
        Object.transform.localScale = new Vector3(0.7f, 0.8f, 1f);
        Object.SetActive(!Object.activeSelf);
        Object.SetActive(!Object.activeSelf);
    }

    public void OnPressLDress(){
        Object.transform.localScale = new Vector3(0.75f, 0.85f, 1f);
        Object.SetActive(!Object.activeSelf);
        Object.SetActive(!Object.activeSelf);
    }

    public void OnPressXLDress(){
        Object.transform.localScale = new Vector3(0.8f, 0.9f, 1.05f);
        Object.SetActive(!Object.activeSelf);
        Object.SetActive(!Object.activeSelf);
    }

    public void OnPressXXLDress(){
        Object.transform.localScale = new Vector3(0.85f, 0.95f, 1.05f);
        Object.SetActive(!Object.activeSelf);
        Object.SetActive(!Object.activeSelf);
    }

    public void OnPressSTop(){
        Object.transform.localScale = new Vector3(1.5f, 1.5f, 1.8f);
        Object.SetActive(!Object.activeSelf);
        Object.SetActive(!Object.activeSelf);
    }

    public void OnPressMTop(){
        Object.transform.localScale = new Vector3(1.6f, 1.5f, 2.2f);
        Object.SetActive(!Object.activeSelf);
        Object.SetActive(!Object.activeSelf);
    }

    public void OnPressLTop(){
        Object.transform.localScale = new Vector3(1.7f, 1.5f, 2.4f);
        Object.SetActive(!Object.activeSelf);
        Object.SetActive(!Object.activeSelf);
    }

    public void OnPressXLTop(){
        Object.transform.localScale = new Vector3(1.8f, 1.5f, 2.6f);
        Object.SetActive(!Object.activeSelf);
        Object.SetActive(!Object.activeSelf);
    }

    public void OnPressXXLTop(){
        Object.transform.localScale = new Vector3(1.9f, 1.5f, 2.8f);
        Object.SetActive(!Object.activeSelf);
        Object.SetActive(!Object.activeSelf);
    }

    public void OnPressSSkirt(){
        Object.transform.localScale = new Vector3(3.4f, 4.9f, 2.9f);
        Object.SetActive(!Object.activeSelf);
        Object.SetActive(!Object.activeSelf);
    }

    public void OnPressMSkirt(){
        Object.transform.localScale = new Vector3(3.5f, 5f, 3f);
        Object.SetActive(!Object.activeSelf);
        Object.SetActive(!Object.activeSelf);
    }

    public void OnPressLSkirt(){
        Object.transform.localScale = new Vector3(3.6f, 5.1f, 3.1f);
        Object.SetActive(!Object.activeSelf);
        Object.SetActive(!Object.activeSelf);
    }

    public void OnPressXLSkirt(){
        Object.transform.localScale = new Vector3(3.7f, 5.2f, 3.2f);
        Object.SetActive(!Object.activeSelf);
        Object.SetActive(!Object.activeSelf);
    }

    public void OnPressXXLSkirt(){
        Object.transform.localScale = new Vector3(3.8f, 5.3f, 3.3f);
        Object.SetActive(!Object.activeSelf);
        Object.SetActive(!Object.activeSelf);
    }
}
