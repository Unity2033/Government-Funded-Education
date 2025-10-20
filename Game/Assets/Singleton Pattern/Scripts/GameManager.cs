using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] bool state;

    [SerializeField] static GameManager instance;

    private void Awake()
    {
        instance = this;
    }

    public void Pause()
    {
        state = !state;
    }

}
