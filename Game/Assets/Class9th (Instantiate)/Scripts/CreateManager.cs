using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] int count;
    [SerializeField] float time;
    [SerializeField] GameObject prefab;
    [SerializeField] List<GameObject> unitList;

    void Start()
    {
        Initialize();
    }

    void Initialize()
    {
        unitList.Capacity = 10;

        for (int i = 0; i < count; i++)
        {
            GameObject clone = Instantiate(prefab, gameObject.transform);

            clone.SetActive(false);

            unitList.Add(clone);
        }
    }

    private void Update()
    {
        time += Time.deltaTime;

        if(time >= 5.0f)
        {
            Debug.Log("Call");

            time = 0.0f;
        }
    }


}
