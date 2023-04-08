using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceManager : MonoBehaviour
{
    public static ResourceManager RManager;
    public int Vegetal, Animal, Pedra, Madeira, Marvita, Pessoas, estrelas;
    public builDefault[] Builds;
    public Button[] construir;
    public int constAtual;
    public GameObject atual;
    public baseBuilds build;
    
    void Awake()
    {
        RManager = this;
    }

    private void Start()
    {
      
        for (int i = 0; i < construir.Length; i++)
        {
            int Index = i;
            construir[i].onClick.AddListener(() => ReconheceConstrucao(Index));
            construir[i].image.sprite = Builds[i].Image;
        }
  
    }
    public void ReconheceConstrucao(int indice)
    {
       
        build = new madeiraBuild();
        build.Construir(Builds[indice]);
        
        //build.StartCoroutine(GastaeGeraRecursos(Builds[indice].tempo, indice));
       // Builds[indice].prefabBuild.AddComponent<recursosTempo>().Start(Builds[indice]);
        

    }

 
}
