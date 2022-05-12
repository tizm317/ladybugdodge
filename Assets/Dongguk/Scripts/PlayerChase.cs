using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChase : MonoBehaviour
{
    public Transform target;
    public Vector3 direction;
    public float velocity;
    public float acceleration;
    public float distance;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        MoveToTarget();
    }
    public void MoveToTarget()
    {
        target = GameObject.Find("Character").transform;

        direction = (target.position - transform.position).normalized;

        acceleration = 0.1f;

        velocity = (velocity + acceleration * Time.deltaTime);

        distance = Vector3.Distance(target.position, transform.position);

        if (distance <= 10.0f)
        {
            transform.Translate(direction * 3f * Time.deltaTime);


            //this.transform.position = new Vector3(transform.position.x + (direction.x * velocity),
            //                                      transform.position.y + (direction.y * velocity),
            //                                      transform.position.z);
        }
    }
}
