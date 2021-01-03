using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class safe_room : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {

            var player = collision.GetComponent<player>();
            if(player.objectivePicked)
            {
                Debug.Log("WINNER WINNER ZOMBIE KILLER");
            }
        }

    }
}
