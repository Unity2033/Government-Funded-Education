using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    [SerializeField] Button button;
    [SerializeField] GameObject sceneryManager;

    private void Awake()
    {
        sceneryManager = GameObject.Find("Scenery Manager");
    }

    private void Start()
    {
        button.onClick.AddListener(() => sceneryManager.GetComponent<SceneryManager>().LoadScene(1));
    }
}
