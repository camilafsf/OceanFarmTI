using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridController : MonoBehaviour
{
  /*  public void Start()
    {

        for (int i = 0; i < ResourceManager.RManager.construir.Length; i++)
        {
            int Index = i;
            ResourceManager.RManager.construir[i].onClick.AddListener(() => ReconheceConstrucao(Index));
            ResourceManager.RManager.construir[i].image.sprite = ResourceManager.RManager.Builds[i].Image;
        }

    }


    public void ReconheceConstrucao(int indice)
    {
        ResourceManager.RManager.constAtual = indice;
        ResourceManager.RManager.atual = ResourceManager.RManager.Builds[ResourceManager.RManager.constAtual].prefabBuild;
        Debug.Log("tá aqui" + indice);
      /*  foreach (builDefault build in ResourceManager.RManager.Builds)
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = Camera.main.nearClipPlane;
            Vector3 pos = Camera.main.ScreenToViewportPoint(mousePosition);
            Instantiate(ResourceManager.RManager.atual, pos, Quaternion.identity);
        }
    }*/


    
    /* public GameObject objectPrefab; 
     public Button instantiateButton; 
     public GridLayoutGroup grid;

     private GameObject currentObject; 
     private bool isDragging = false; 

     void Start()
     {
         foreach (Button button in ResourceManager.RManager.construir)
         {
             button.onClick.AddListener(() => SetCurrentObject(buttons.IndexOf(button)));
         }
     }


     void Update()
     {
         if (isDragging)
         {
             // Atualiza a posição do objeto para seguir o mouse
             Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
             currentObject.transform.position = mousePosition;
         }

         if (Input.GetMouseButtonDown(0) && isDragging)
         {
             // Verifica se o mouse está sobre um espaço do grid e posiciona o objeto lá
             Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
             int index = GetGridIndex(mousePosition);
             if (index >= 0)
             {
                 Vector3 newPosition = grid.transform.GetChild(index).position;
                 currentObject.transform.position = newPosition;
                 isDragging = false;
             }
         }
     }

     void SetCurrentObject(int index)
     {
         if (index >= 0 && index < ResourceManager.RManager.Builds.Length)
         {
             currentObject = Instantiate(Builds[index].prefabBuild);
         }
     }

     void InstantiateObject()
     {
         // Instancia o objeto na posição do mouse e o torna arrastável
         Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
         currentObject = Instantiate(objectPrefab, mousePosition, Quaternion.identity);
         isDragging = true;
     }

     int GetGridIndex(Vector2 position)
     {
         // Retorna o índice do espaço do grid sob a posição especificada
         for (int i = 0; i < grid.transform.childCount; i++)
         {
             if (RectTransformUtility.RectangleContainsScreenPoint(grid.transform.GetChild(i).GetComponent<RectTransform>(), position))
             {
                 return i;
             }
         }
         return -1;
     }*/
}
