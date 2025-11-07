using UnityEngine;

public class BotonSoundPlayer : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

    private void OnMouseDown()
    {
        source.PlayOneShot(clip);
    }
}
