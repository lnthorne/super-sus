using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource[] speakers;
    public void Play()
    {
        double startTime = AudioSettings.dspTime + 0.1;
        foreach (AudioSource speaker in speakers)
        {
            speaker.PlayScheduled(startTime);
        }
    }

    public void Stop() 
    {
         foreach (AudioSource speaker in speakers)
        {
            speaker.Stop();
        }
    }
}
