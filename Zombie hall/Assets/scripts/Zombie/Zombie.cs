using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
   [SerializeField] public Transform target;
    public GameObject player;
    public float speed;
    public int health;
    public Transform door;
    [SerializeField]private List<Transform> positions;
    private float timing;
    public bool exiting;
    
    // Start is called before the first frame update
    void Start()
    {
       
        health = 100;
        exiting = false;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (target == door)
            exiting = true;
        else
            exiting = false;


    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
            health = health - 20;
        if (health <= 0)
            Destroy(gameObject);
        
    }
}
