using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class madeiraBuild : baseBuilds
{
    public override void Construir(builDefault prefab)
    {
        base.Construir(prefab);
    }

    public override void GastarRecursos(builDefault prefab)
    {
        base.GastarRecursos(prefab);
    }
    public void Start(float tempo, int indice)
    {
        StartCoroutine(GastaeGeraRecursos(tempo, indice));
    }
    public IEnumerator GastaeGeraRecursos(float tempo, int indice)
    {

        while (true)
        {
            base.GastarRecursos(ResourceManager.RManager.Builds[indice]);
            base.GerarRecursos(ResourceManager.RManager.Builds[indice]);
            yield return new WaitForSeconds(tempo);
        }
    }
}
