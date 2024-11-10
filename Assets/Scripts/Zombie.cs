using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    private float zombieSpeed;
    private float baseSpeed = 8f;
    public GameObject obj;

    //[SerializeField] private int damage;
    public int damage;
    [SerializeField] private Healthcontroller healthcontrols;

    public 
    void Start()
    {
        zombieSpeed = baseSpeed * (1 + Random.Range(-0.3f, 0.3f));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * zombieSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other) {

        if(other.tag == "House" || other.tag == "Player1"){
            Destroy(obj);
            //Damage();
        }
        
    }

    /*void Damage(){
        healthcontrols.Health = healthcontrols.Health - damage;
        healthcontrols.UpdateHealth();
        
    }*/
    
}

