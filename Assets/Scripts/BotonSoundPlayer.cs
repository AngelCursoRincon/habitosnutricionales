using UnityEngine;
using UnityEngine.Audio;

public class BotonSoundPlayer : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

    public void OnTouchDown()
    {
        source.PlayOneShot(clip);
    }
}
