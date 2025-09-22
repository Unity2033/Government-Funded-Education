using UnityEngine;

public class Soundable : MonoBehaviour
{
    [SerializeField] AudioClip audioClip;

    void Start()
    {
        AudioManager.Emit(audioClip);
    }
}
