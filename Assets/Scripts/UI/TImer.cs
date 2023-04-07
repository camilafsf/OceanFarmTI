using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TImer : MonoBehaviour
{
    Image timer;
    public float maxtime = 365f;
    float timeleft;
    void Start()
    {
        timer= GetComponent<Image>();
        timeleft = maxtime;
    }

    // Update is called once per frame
    void Update()
    {
        if(timeleft > 0)
        {
            timeleft -= Time.deltaTime;
            timer.fillAmount = timeleft / maxtime;
        }
        
    }
}
