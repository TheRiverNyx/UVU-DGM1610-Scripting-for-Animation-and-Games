using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class DetectCollision : MonoBehaviour
{
    
    private ScoreManager scoreManager;//reference the score manager

    public ParticleSystem explosionParticles;

    private AudioSource explosionSound;
    
    public int scoreToGive;//sets the score that UFOs will give
    // Start is called before the first frame update
    
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        explosionSound = GameObject.Find("ExplosionSound").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        explosionSound.Play();
        Explosion();
        scoreManager.IncreaseScore(scoreToGive);//Increase score amount by scoreToGive
        Destroy(gameObject);//Destroy this game object
        Destroy(other.gameObject);//destroys the object that hits the object
    }

    void Explosion()
    {
        Instantiate(explosionParticles,transform.position,transform.rotation);//creates particles
    }
    
}
