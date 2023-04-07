using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Text anim,agro,pop,mana,rock,wood;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        anim.text = ResourceManager.RManager.Animal.ToString();
        agro.text = ResourceManager.RManager.Vegetal.ToString();
        pop.text = ResourceManager.RManager.Pessoas.ToString();
        mana.text = ResourceManager.RManager.Marvita.ToString();
        rock.text = ResourceManager.RManager.Pedra.ToString();
        wood.text = ResourceManager.RManager.Madeira.ToString();
    }
}
