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
        constAtual = indice;
        atual = Builds[constAtual].prefabBuild;
        Debug.Log("tá aqui" + indice);

            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = Camera.main.nearClipPlane;
            Vector3 pos = Camera.main.ScreenToViewportPoint(mousePosition);
            Instantiate(atual, pos, Quaternion.identity);
        
    }


}
