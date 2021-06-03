using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public const int gridRows = 2;// amount of rows
    public const int gridCols = 4;//amount of columns
    public const float offSetX = 4.0f;// distance between columns
    public const float offSetY = 4.2f;// distance between rows

    [SerializeField] private MemoryCard motherCard; // main card or mother card of other cards
    [SerializeField] private Sprite[] images;// array of images
    [SerializeField] private TMP_Text scoreCounter;// counter for scores output

    private MemoryCard firstRevealed;// first revealed card
    private MemoryCard secondRevealed;// second revealed card
    private int score = 0; // counter of scores

   public bool canReveal { //function of reading, that helps to find to find the second pair of opened card
        get {
           return secondRevealed == null;
        }
    }

    void Start() { //initialization function
        Vector3 startPos = motherCard.transform.position; //taking  coordination of mother card

        for (int i = 0; i < gridCols; i++) {// running by columns=4
            for (int j = 0; j < gridRows; j++) { //running by rows=2

                MemoryCard card;// to create the link to the motherCard and its copies

                if (i == 0 && j == 0)
                {
                    card = motherCard;
                }
                else
                {
                    card = Instantiate(motherCard) as MemoryCard;// creating the copies of motherCard
                }
                //setting id and image to the cards
                int id = Random.Range(0, images.Length);//randomly giving an id numbers starting from 0 till to the last index of array images
                card.SetCard(id, images[id]);//setting this randomly gotten id and image by the id inplace of index

                float posX = (offSetX*i) + startPos.x;//position of card in horizontal
                float posY = -(offSetY*j) + startPos.y;// position of card in vertical
                card.transform.position = new Vector3(posX, posY, startPos.z);// putting the card in the position we found

            }
        }
    } 

}
