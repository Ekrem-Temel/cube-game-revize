
using UnityEngine;

public class obstcle : MonoBehaviour
{
    public Rigidbody rb;
    public PlayerMovement movement;
    public Vector3 startpoint;


    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "obstcle") {

            transform.position =startpoint ;
            ResetVelocity();
        }
    }
    void FixedUpdate()
    {

        if (rb.position.y < -1f)
        {

            transform.position = startpoint;

            ResetVelocity();
        }


    }

    void ResetVelocity()
    {

        rb.velocity = Vector3.zero;
    }
}

