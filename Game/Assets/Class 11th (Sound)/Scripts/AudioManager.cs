using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] static AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public static void Emit(AudioClip audioClip)
    {
       audioSource.PlayOneShot(audioClip);
    }
}
