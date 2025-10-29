using System.Collections;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] GameObject robot;
    [SerializeField] Transform createPosition;
 

    private void Start()
    {
        StartCoroutine(Create());
    }

    IEnumerator Create()
    {
        while(true)
        {
            yield return new WaitForSeconds(Random.Range(1,6));

            Instantiate(robot, createPosition);
        }
    }

}
