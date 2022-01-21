using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardView : MonoBehaviour
{
    public Text title;
    public Text description;
    public Text exhibit;
    public Image animalImg;

    public CardModel[] cardsArray;

    private void OnEnable()
    {
        
    }

    public void DisplayCard(int card)
    {
        title.text = cardsArray[card].title;
        description.text = cardsArray[card].description;
        exhibit.text = cardsArray[card].exhibit;
        animalImg.sprite = cardsArray[card].animalImg;
    }
}
