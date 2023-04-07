using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstruturaTeste : BaseGasto
{
    public new int CustoMadeira, CustoPedra;
    public override void Pagar()
    {
        ResourceManager.RManager.Madeira -= CustoMadeira;
        ResourceManager.RManager.Pedra -= CustoPedra;
    }
}
