using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class ImagePair
{
    public Sprite correctImage;
    public Sprite incorrectImage;
}

public class GameController : MonoBehaviour
{
    public static GameController instance;

    [SerializeField] List<ImagePair> images = new List<ImagePair>();
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] List<Button> buttons = new List<Button>();

    private int currentImagePairIndex;
    private int playerScore;

    private void Start()
    {
        if (instance == null)
        {
            instance = this;
            
            currentImagePairIndex = 0;
            playerScore = 0;

            PlayNextTurn();
        } else
        {
            Destroy(gameObject);
        }

    }

    private void PlayNextTurn()
    {
        if (currentImagePairIndex >= images.Count)
        {
            EndGame();
            return;
        } else
        {
            UpdateScoreText();
            DisplayImages();

            currentImagePairIndex++;
        }
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Puntuación: " + playerScore.ToString() + " / 3";
    }

    private void DisplayImages()
    {
        buttons[0].GetComponent<GameFoodButton>().SetImage(images[currentImagePairIndex].correctImage);
        buttons[1].GetComponent<GameFoodButton>().SetImage(images[currentImagePairIndex].incorrectImage);
    }

    public void ImageWasSelected(Sprite image)
    {
        if (images[currentImagePairIndex - 1].correctImage == image) playerScore++;

        PlayNextTurn();
    }

    private void EndGame()
    {
        foreach (Button button in buttons) Destroy(button.gameObject);
        scoreText.text = "Juego terminado. Puntuación: " + playerScore.ToString() + " / 3";
    }
}
