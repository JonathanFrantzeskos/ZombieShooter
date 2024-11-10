using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;


public class Bullet : MonoBehaviour
{
    private float bulletSpeed;
    private float baseSpeed = 15f;
    public GameObject obj;

   
    void Start()
    {
        bulletSpeed = baseSpeed; //* (1 + Random.Range(-0.3f, 0.3f));
        //Scoretext = GameObject.Find("/HealthSystem/Scoretext").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * bulletSpeed * Time.deltaTime);
        
    }

   private void OnTriggerEnter2D(Collider2D other) {
       
       
       if (other.tag == "Decorations"){
            Destroy(obj);
            
       }
       else{
        Destroy(other.gameObject);
       Destroy(obj);
       ScoreKeeper.Score+=1;
       }
    }
}
