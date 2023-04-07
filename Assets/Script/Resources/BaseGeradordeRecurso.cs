using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseGeradordeRecurso : MonoBehaviour
{
    protected int GanhoVeg, GanhoAnim;
    public virtual void Gerar()
    {
        ResourceManager.RManager.Vegetal += GanhoVeg;
        ResourceManager.RManager.Animal += GanhoAnim;

    }
}
