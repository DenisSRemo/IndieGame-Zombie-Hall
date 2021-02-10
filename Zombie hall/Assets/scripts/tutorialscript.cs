using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialscript : MonoBehaviour
{


    [SerializeField] private GameObject tutorial_panel;
    private bool active;
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        active = false;
        tutorial_panel.SetActive(false);
        time = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (active && Time.time - time >= 10)
        {
            tutorial_panel.SetActive(false);
            Time.timeScale = 1;
        }
            
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="player")
        {
            if(active==false)
            {
                tutorial_panel.SetActive(true);
                active = true;
                time = Time.time;
                Time.timeScale = 0;
            }
        }

    }

}
