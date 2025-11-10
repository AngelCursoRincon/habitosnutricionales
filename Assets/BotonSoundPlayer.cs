using UnityEngine;

public class BotonSoundPlayer : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

    private void OnMouseDown()
    {
        
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.gameObject == gameObject)
                    {
                        OnTouchDown();
                    }
                }
            }
        }
    }

    void OnTouchDown()
    {
        source.PlayOneShot(clip);
    }
}
