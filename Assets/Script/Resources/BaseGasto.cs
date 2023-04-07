using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseGasto : MonoBehaviour
{
    protected int CustoMadeira, CustoPedra;
    public virtual void Pagar()
    {
        ResourceManager.RManager.Madeira -= CustoMadeira;
        ResourceManager.RManager.Pedra -= CustoPedra;

    }
 
}
