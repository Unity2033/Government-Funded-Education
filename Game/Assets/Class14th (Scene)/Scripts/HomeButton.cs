using UnityEngine;

public class HomeButton : MonoBehaviour
{
    [SerializeField] GameObject sceneryManager;

    void Awake()
    {
        sceneryManager = GameObject.Find("Scenery Manager");
    }

    public void Return()
    {
        sceneryManager.GetComponent<SceneryManager>().LoadScene(0);
    }

}
