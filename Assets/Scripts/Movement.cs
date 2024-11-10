using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 20f;

    void Start()
    {
        Application.targetFrameRate = 60;
    }
    // Update is called once per frame
    void Update()
    {
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(0,moveAmount,0);
    }

    void OnCollisionEnter2D(Collision2D collision){
    if(collision.collider.tag =="ob"){
       //Debug.Log("Finish");
        }
    }
}
