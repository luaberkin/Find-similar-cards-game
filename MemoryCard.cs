using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryCard : MonoBehaviour
{


    [SerializeField] private GameObject cardBack; //card's shirt
    private int id;//unique number of card
    [SerializeField] private GameController controller; //object of GameController class, which helps to control the logic of the game    


    //getter 
    public int GetId
    {
        get
        {
            return id;
        }
    }

    //setter card
    public void SetCard(int id_, Sprite image)
    {
        id = id_;
        GetComponent<SpriteRenderer>().sprite = image;
    }

    public void OnMouseDown()//this function will help to cards to react on clicks of mouse
    {
        if (cardBack.activeSelf && controller.canReveal)// when we will click on the back of the  card, the card will activate and will open the front of card
        {
            cardBack.SetActive(false);// then we will close the card
        }
    } 

}
