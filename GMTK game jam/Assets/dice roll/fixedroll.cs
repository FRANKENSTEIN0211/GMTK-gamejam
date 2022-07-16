using System.Collections;
using UnityEngine;

public class fixedroll : MonoBehaviour
{
    static public int diceside = 0;
    static public bool turn = false;
    private Sprite[] diceSides;
    private SpriteRenderer rend;

    // Use this for initialization
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        diceSides = Resources.LoadAll<Sprite>("DiceSides/");
        rend.sprite = diceSides[diceside];
    }
    private void OnMouseDown()
    {
        if (collision.stand == true)
        {
            StartCoroutine("RollTheDice");
        }
    }
    private IEnumerator RollTheDice()
    {
        int randomDiceSide = 0;
        for (int i = 0; i <= 20; i++)
        {
            // Pick up random value from 0 to 5 (All inclusive)
            randomDiceSide = Random.Range(0, 6);

            // Set sprite to upper face of dice from array according to random value
            rend.sprite = diceSides[randomDiceSide];

            // Pause before next itteration
            yield return new WaitForSeconds(0.05f);
        }
        if (turn == false)
        {
            rend.sprite = diceSides[Mathf.Abs(5-diceside)];
            diceside = Mathf.Abs(5 - diceside);
        }
        if (turn == true)
        {
            if((diceside==0)|| (diceside == 1) || (diceside == 3) || (diceside == 4))
            {
                rend.sprite = diceSides[diceside+1];
                diceside = diceside + 1;
            }
            else
            {
                rend.sprite = diceSides[diceside - 1];
                diceside = diceside - 1;
            }
        }
    }
}
