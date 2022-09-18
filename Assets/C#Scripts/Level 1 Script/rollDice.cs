using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rollDice : MonoBehaviour
{

  // Array of dice sides sprites to load from Resources folder
    public Sprite[] diceSides;

    // Reference to sprite renderer to change sprites
    public Image rend;
 

    // Start is called before the first frame update
    void Start()
    {
        // rend = GetComponent<Image>();
        int randomDiceSide = 0;
        // Load dice sides sprites to array from DiceSides subfolder of Resources folder
        //for(int x = 0; x<diceSides.Length;x++){
        //   diceSides[x] =  GetComponent<Sprite>();
        //}

          randomDiceSide = Random.Range(0, 5);

            // Set sprite to upper face of dice from array according to random value
            rend.GetComponent<Image>().sprite = diceSides[randomDiceSide];
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void RollDice()
    {
      StartCoroutine("RollTheDice");
    }

      public IEnumerator RollTheDice()
    {
        // Variable to contain random dice side number.
        // It needs to be assigned. Let it be 0 initially
        int randomDiceSide = 0;

        // Final side or value that dice reads in the end of coroutine
        int finalSide = 0;

        // Loop to switch dice sides ramdomly
        // before final side appears. 20 itterations here.
        for (int i = 0; i <= 20; i++)
        {
            // Pick up random value from 0 to 5 (All inclusive)
            randomDiceSide = Random.Range(0, 5);

            // Set sprite to upper face of dice from array according to random value
            rend.GetComponent<Image>().sprite = diceSides[randomDiceSide];

            // Pause before next itteration
            yield return new WaitForSeconds(0.1f);
        }

        // Assigning final side so you can use this value later in your game
        // for player movement for example
        finalSide = randomDiceSide + 1;

        // Show final dice value in Console
        Debug.Log(finalSide);
    }

}
////