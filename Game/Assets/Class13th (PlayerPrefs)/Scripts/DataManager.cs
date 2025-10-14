using UnityEngine;

public class DataManager : MonoBehaviour
{
    [SerializeField] int channel;

    void Start()
    {
        PlayerPrefs.SetInt("Channel", channel);
    }

    public void Save()
    {
        PlayerPrefs.Save();
    }

    public void Delete()
    {
        PlayerPrefs.DeleteAll();
    }
}
