using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GameFoodButton : MonoBehaviour
{
    Sprite image;

    public void SetImage(Sprite newImage)
    {
        image = newImage;

        GetComponent<Image>().sprite = image;
    }

    public void WasSelected()
    {
        GameController.instance.ImageWasSelected(image);
    }

    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            if (EventSystem.current.IsPointerOverGameObject(Input.touches[0].fingerId))
                WasSelected();
        }
    }
}
