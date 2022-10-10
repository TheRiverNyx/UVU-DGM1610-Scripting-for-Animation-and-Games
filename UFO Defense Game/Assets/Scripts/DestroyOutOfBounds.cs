using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour

{
    public float topBounds = 30.00f;//how far up ojects can go before they get deleted
    
    public float lowerBounds = -10.00f;//how far down ojects can go before they get deleted

    private ScoreManager scoreManager;//reference the Score manager

    private DetectCollision detectCollision;//reference detectCollsion script
    
    
    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        detectCollision = GetComponent<DetectCollision>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }else if (transform.position.z<lowerBounds){
            if (gameObject.CompareTag("Enemy"))//only decrease score if enemy goes beyond bottom bound
            {
                scoreManager.DecreaseScore(detectCollision.scoreToGive);
            }
            Destroy(gameObject);
        }
    }
}
