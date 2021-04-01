using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie2 : MonoBehaviour
{



    [SerializeField] public Transform target;
    public GameObject player;
    public float speed;
    public float health;
    public List<Transform> doors;
    public Transform door;
    [SerializeField] private List<Transform> positions;
    private float timing;
    public bool exiting;
    // Start is called before the first frame update
    void Start()
    {
        speed = 2f;
        health = 100;
        timing = Time.time;
        exiting = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y - gameObject.transform.position.y <= 5)
            target = player.transform;

        else
        {
            target = doors[0];
            exiting = true;
        }

        if (target == doors[0] && Vector2.Distance(transform.position, target.position) <= 0.5)
            doors.Remove(doors[0]);
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
            health = health - 60;
        if (health <= 0)
            Destroy(gameObject);
        if (collision.tag == "ExitDoor")
            exiting = true;
    }


    public void TakeHit(float damage)
    {
        health = health - damage;
    }
}

