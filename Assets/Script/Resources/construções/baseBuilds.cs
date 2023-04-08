using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class baseBuilds : MonoBehaviour
{


    public virtual void Construir(builDefault prefab)
    {
        int Gastamadeira = prefab.MadeiraGastoC;
        int Gastapedra = prefab.PedraGastoC;
        int Gastapessoas = prefab.PessoaGastoC;
        int GastaMarvita = prefab.ManaGastoC;
        int restoMadeira, restoPessoas, restoPedra, restoMarvita;

        restoMadeira = ResourceManager.RManager.Madeira - prefab.MadeiraGastoC;
        restoPessoas = ResourceManager.RManager.Pedra - prefab.PedraGastoC;
        restoPedra = ResourceManager.RManager.Pessoas - prefab.PessoaGastoC;
        restoMarvita = ResourceManager.RManager.Marvita - prefab.ManaGastoC;

        if (restoMadeira >= 0 && restoPessoas >= 0 && restoPedra >= 0 && restoMarvita >= 0)
        {
            
            ResourceManager.RManager.Madeira -= Gastamadeira;
            ResourceManager.RManager.Pedra -= Gastapedra;
            ResourceManager.RManager.Pessoas -= Gastapessoas;

            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = Camera.main.nearClipPlane;
            Vector3 pos = Camera.main.ScreenToViewportPoint(mousePosition);
            Instantiate(prefab.prefabBuild, pos, Quaternion.identity);
        }

        else
        {
            Debug.Log("não pode construir");
            //fazer algo aqui para dar um feedback q não é possível construir
        }
           
    }

    public virtual void GastarRecursos(builDefault prefab)
    {
        int madeira = prefab.MadeiraGasta;
        int pedra = prefab.PedraGasta;
        int pessoas = prefab.PessoasGastas;
        int marvita = prefab.marvitaGastas;
        int vegetal = prefab.vegetalGastos;
        int animal = prefab.animal;
        float tempo = prefab.tempo;
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
