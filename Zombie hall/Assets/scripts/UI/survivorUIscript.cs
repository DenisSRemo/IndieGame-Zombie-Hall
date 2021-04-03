using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class survivorUIscript : MonoBehaviour
{

    [SerializeField] private GameObject panel,panel2;
    private bool active;
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        active = false;
        panel.SetActive(false);
        panel2.SetActive(false);
        // time = Time.time;
    }

    // Update is called once per frame
    void Update()
    {


    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (active == false)
            {
                panel.SetActive(true);
                panel2.SetActive(true);
                active = true;
                time = Time.time;
                Time.timeScale = 0;
            }
        }

    }


    public void NextPanel(GameObject panel)
    {
        panel.SetActive(false);
        
    }



    public void LastPanel(GameObject panel)
    {
        panel.SetActive(false);
        Time.timeScale =1;
    }

}
