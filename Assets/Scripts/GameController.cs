using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ImagePair
{
    public Sprite correctImage;
    public Sprite incorrectImage;
}

public class GameController : MonoBehaviour
{
    [SerializeField] List<ImagePair> images = new List<ImagePair>();


}
