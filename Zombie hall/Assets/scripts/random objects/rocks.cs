using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocks : MonoBehaviour
{

    [SerializeField] private lever Lever;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.E)&&Lever.pulled==true)
        {
            Destroy(gameObject, 5);
        }

        
    }
  
    // chips away the health of a zombie with every rock

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Zombie")
        {
            var enemy = collision.collider.GetComponent<Zombie>();
            enemy.TakeHit(90);
        }
    }
}
