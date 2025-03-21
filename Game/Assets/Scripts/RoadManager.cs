using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadManager : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float offset = 40;
    [SerializeField] List<GameObject> roads;

    void Update()
    {
        if (GameManager.Instance.State == false) return;

        for (int i = 0; i < roads.Count; i++)
        {
            roads[i].transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
    }

    public void InitializePosition()
    {
        GameObject newRoad = roads[0];

        roads.Remove(newRoad);

        float newZ = roads[roads.Count-1].transform.position.z + offset;

        newRoad.transform.position = new Vector3(0, 0, newZ);

        roads.Add(newRoad);
    }
}
