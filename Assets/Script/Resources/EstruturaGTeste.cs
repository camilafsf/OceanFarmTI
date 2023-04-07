using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstruturaGTeste : BaseGeradordeRecurso
{
    public new int GanhoVeg, GanhoAnim;
    public float secondstocall;
    private void Start()
    {
        InvokeRepeating("Gerar", secondstocall, secondstocall);
    }
    public override void Gerar()
    {
        ResourceManager.RManager.Madeira += GanhoVeg;
        ResourceManager.RManager.Pedra += GanhoAnim;
    }
}
