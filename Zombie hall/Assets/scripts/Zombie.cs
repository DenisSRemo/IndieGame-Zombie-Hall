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
        speed = 2f;
        health = 100;
        timing = Time.time;

    }

    // Update is called once per frame
    void Update()
    {

        if (player.transform.position.y - gameObject.transform.position.y <= 5)
            target = player.transform;
        
        else
            target = door;
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
            health = health - 20;
        if (health <= 0)
            Destroy(gameObject);
        if (collision.tag == "ExitDoor")
            exiting = true;
    }
}
