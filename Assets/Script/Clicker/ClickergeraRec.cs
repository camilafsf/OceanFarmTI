using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickergeraRec : BaseGeradordeRecurso
{
    public new int GanhoVeg1, GanhoAnim1;
    
    public override void Gerar()
    {
        ResourceManager.RManager.Vegetal += GanhoVeg1;
        ResourceManager.RManager.Animal += GanhoAnim1;
    }
}
