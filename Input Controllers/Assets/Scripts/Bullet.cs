using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D rb;
    public float lifeTime;
    public float speed;
    public Vector2 moveDirection;

    private float timeToDie;

    // Start is called before the first frame update
    void Start()
    {
        timeToDie = Time.time + lifeTime;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = moveDirection * speed;

        if (timeToDie < Time.time)
        {
            Destroy(gameObject);
        }
    }
}
