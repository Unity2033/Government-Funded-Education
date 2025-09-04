using UnityEngine;

public class ItemManager : MonoBehaviour
{
    [SerializeField] GameObject [] gameObjects;  

    void Start()
    {
        for(int i = 0; i < gameObjects.Length; i++)
        {
            gameObjects[i].SetActive(false);
        }
    }
}
