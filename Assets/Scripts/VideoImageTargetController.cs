using UnityEngine;
using UnityEngine.Video;

public class VideoImageTargetController : MonoBehaviour
{
    [SerializeField] VideoPlayer videoPlayer;
    [SerializeField] AudioSource backgroundMusicAudioSource;

    public void StartVideo()
    {
        if(videoPlayer != null)
            videoPlayer.Play();
        if(backgroundMusicAudioSource != null)
            backgroundMusicAudioSource.Stop();
    }

    public void StopVideo()
    {
        if(videoPlayer != null)
            videoPlayer.Stop();
        if(backgroundMusicAudioSource != null)
            backgroundMusicAudioSource.Play();
    }
}
