using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collision : MonoBehaviour
{
    static public bool stand = false;
     void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Horizontal")
        {
            stand = true;
            fixedroll.turn = true;
        }
        if (coll.gameObject.tag == "Vertical")
        {
            stand = true;
            fixedroll.turn = false;
        }
        if (coll.gameObject.tag == "Respawn")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +0);
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        stand = false;
        if (fixedroll.turn == true)
        {
            fixedroll.turn= false;
        }
        else
        {
            fixedroll.turn = true;
        }
    }
}
