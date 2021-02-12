using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ohnoscript : MonoBehaviour
{

    [SerializeField] private GameObject tutorial_panel;
    private bool active;
    private float time;
  [SerializeField]  private lever aaaaa;
    private bool bbbb;
    // Start is called before the first frame update
    void Start()
    {
        active = false;
        tutorial_panel.SetActive(false);
        //time = Time.time;
        bbbb = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (aaaaa.pulled&& bbbb==false)
        {
            time = Time.time;
            bbbb = true;
        }

        
            if (active == false&&bbbb&&Time.time-time>5)
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
