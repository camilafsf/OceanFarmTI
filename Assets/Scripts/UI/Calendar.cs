using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Calendar : MonoBehaviour
{
    public int day=1, month=1, year=1221;
    [SerializeField] private float dayTime;
    [SerializeField] private Text textComponent;

    void Start()
    {
        InvokeRepeating("dayUp",dayTime,dayTime);
    }

    // Update is called once per frame
    void Update()
    {
        textComponent.text = ((int)day+"/"+(int)month+"/"+(int)year).ToString();

        if (month == 1|| month==3||month==5||month==6||month==7||month==9||month==12)
        {
            if(day== 32)
            {
                Invoke("monthUp", 0);
                day = 1;
            }

        }
        else if (month ==2)
        {
            if (day == 30)
            {
                Invoke("monthUp", 0);
                day = 1;
            }
        }
        else
        {
            if (day == 31)
            {
                Invoke("monthUp", 0);
                day = 1;
            }
        }
        if(month==13)
        {
            Invoke("yearUp", 0);
            month = 1;
        }
        
    }
    void dayUp()
    {
        day += 1;
    }
    void monthUp()
    {
        month += 1;
    }
    void yearUp()
    {
        year += 1;
    }
}
