using UnityEngine;
using UnityEngine.Video;

public class Television : MonoBehaviour
{
    [SerializeField] VideoClip [ ] videoClip;
    [SerializeField] VideoPlayer videoPlayer;

    [SerializeField] int channel;

    private void Awake()
    {
        channel = PlayerPrefs.GetInt("Channel"); 
        
        videoPlayer.clip = videoClip[channel];
    }

    public void Increase()
    {
        channel = (channel + 1) % videoClip.Length;

        videoPlayer.clip = videoClip[channel];

        PlayerPrefs.SetInt("Channel", channel);
    }
    
}
