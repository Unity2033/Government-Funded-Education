using UnityEngine;

public class ItemManager : MonoBehaviour
{
    [SerializeField] int count;
    [SerializeField] Item [ ] gameObjects;  

    void Start()
    {
        for(int i = 0; i < gameObjects.Length; i++)
        {
            gameObjects[i].transform.gameObject.SetActive(false);
        }

        count = gameObjects.Length - 1;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Swap();
        }

        if(Input.GetMouseButtonDown(0))
        {
            gameObjects[count].Activate();
        }
    }

    void Swap()
    {
        gameObjects[count].transform.gameObject.SetActive(false);

        count = (count + 1) % gameObjects.Length;

        gameObjects[count].transform.gameObject.SetActive(true);
    }
}
