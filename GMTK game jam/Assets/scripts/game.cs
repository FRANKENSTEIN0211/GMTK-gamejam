using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game : MonoBehaviour
{
    public Image panel;
    static public int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        Time.timeScale = 1;
        panel.gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (count == 10)
        {
            Time.timeScale = 0;
            panel.gameObject.SetActive(true);
        }
        
    }
}
