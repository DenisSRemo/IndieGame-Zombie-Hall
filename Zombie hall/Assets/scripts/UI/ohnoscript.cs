using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ohnoscript : MonoBehaviour
{
    //this class helps explaining to the player the consequences of the trap door trap

    [SerializeField] private GameObject tutorial_panel;
    private bool active;
    private float time;
  [SerializeField]  private lever lever;
    private bool isItTrue;
    // Start is called before the first frame update
    void Start()
    {
        active = false;
        tutorial_panel.SetActive(false);
        //time = Time.time;
        isItTrue = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (lever.pulled&& isItTrue == false)
        {
            time = Time.time;
            isItTrue = true;
        }

        
            if (active == false&& isItTrue && Time.time-time>5)
            {
                tutorial_panel.SetActive(true);
                active = true;
                time = Time.time;
                Time.timeScale = 0;
            }
        

    }


    


    public void functionforbutton()
    {
        tutorial_panel.SetActive(false);
        Time.timeScale = 1;
    }

}
