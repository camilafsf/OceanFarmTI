using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToBtn : MonoBehaviour
{
    [SerializeField]private string scn;
    public void Goto()
    {
        SceneManager.LoadScene(scn);
    }
}
