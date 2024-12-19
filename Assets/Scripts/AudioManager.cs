using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource[] speakers;
    void Start()
    {
        double startTime = AudioSettings.dspTime + 0.1;
        foreach (AudioSource speaker in speakers)
        {
            speaker.PlayScheduled(startTime);
        }
    }
}
