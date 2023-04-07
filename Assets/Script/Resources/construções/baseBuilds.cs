using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public abstract class baseBuilds: MonoBehaviour
{
    

    public virtual void Construir(int Gastamadeira, int Gastapedra, int Gastapessoas)
    {
        ResourceManager.RManager.Madeira -= Gastamadeira;
        ResourceManager.RManager.Pedra -= Gastapedra;
        ResourceManager.RManager.Pessoas -= Gastapessoas;
    }

    public virtual void GastarRecursos(int madeira, int pedra, int pessoas, int marvita, int vegetal, int animal, float tempo)
    {
        ResourceManager.RManager.Madeira -= madeira;
        ResourceManager.RManager.Pedra -= pedra;
        ResourceManager.RManager.Pessoas -= pessoas;
        ResourceManager.RManager.Marvita -= marvita;
        ResourceManager.RManager.Vegetal -= vegetal;
        ResourceManager.RManager.Animal -= animal;
    }


    public virtual void GerarRecursos(int madeira, int pedra, int pessoas, int marvita, int vegetal, int animal, float tempo)
    {
        ResourceManager.RManager.Madeira += madeira;
        ResourceManager.RManager.Pedra += pedra;
        ResourceManager.RManager.Pessoas += pessoas;
        ResourceManager.RManager.Marvita += marvita;
        ResourceManager.RManager.Vegetal += vegetal;
        ResourceManager.RManager.Animal += animal;

    }

}
