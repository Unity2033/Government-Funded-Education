using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] int count;
    [SerializeField] int index;

    [SerializeField] GameObject prefab;
    [SerializeField] List<GameObject> unitList;

    void Start()
    {
        Initialize();

        StartCoroutine(Coroutine());
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

    bool ExamineActive()
    {
        for(int i = 0; i < unitList.Count; i++)
        {
            if (unitList[i].activeSelf == false)
            {
                return false;
            }
        }

        return true;
    }

    IEnumerator Coroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(5.0f);

            index = Random.Range(0, unitList.Count);

            while(unitList[index].activeSelf)
            {
                index = (index +1) % unitList.Count; 
            }

            unitList[index].SetActive(true);

            Debug.Log(index);

            if(ExamineActive())
            {
                yield break;
            }
        }
    }



}
