using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float speed;//how fast the enemy moves

    public float rayDistance;// how far the ray extends

    private bool isMovingRight = true;//is the enemy moving right

    public Transform groundDetection;//is the enemy touching the ground
    
    // Update is called once per frame
    void Update()
    {
        //move the enemy to the right
        transform.Translate(Vector2.right * (speed * Time.deltaTime));
        //Raycasting produces a ray from an origin point in a certain direction with a set distance
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, rayDistance);

        if (groundInfo.collider == false)
        {
            if (isMovingRight)
            {
                //flip enemy at edge to move left
                transform.eulerAngles = new Vector3(0, -180, 0);
                isMovingRight = false;
            }
            else
            {
                //flip enemy at edge to move right
                transform.eulerAngles = new Vector3(0, 0, 0);
                isMovingRight = true;
            }
        }
    }
}
