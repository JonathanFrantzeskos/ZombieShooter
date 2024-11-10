using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int damage;
    public GameObject zombiePrefab;
    [SerializeField] private Healthcontroller healthcontrols;

   void Start(){
    zombiePrefab = GameObject.Find("HealthController");
   }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other) {
        
       if(other.tag == "Zombie"){
        Damag();
        //Destroy(zombiePrefab);
       }
    }
    

    void Damag(){
        healthcontrols.Health = healthcontrols.Health - damage;
        healthcontrols.UpdateHealth();
        
    }
}
