using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocks : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.E))
        {
            Destroy(gameObject, 5);
        }

        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Zombie")
        {
           var enemy= collision.GetComponent<Zombie>();
            enemy.TakeHit(5);
        }
            
    }
}
