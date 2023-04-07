using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubHudActiveandDesactive : MonoBehaviour
{
    public GameObject hud;
    bool ativo = false;
    public void click()
    {
        GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag("BtnHud");
        foreach (GameObject go in gameObjectArray)
        {
            go.SetActive(false);
        }
        ativo = !ativo;
        hud.SetActive(ativo);
    }
}
