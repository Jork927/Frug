using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lateralPlatformScript : MonoBehaviour
{

    public float Speed = 5f;

    public Transform child;

    public Transform parent;

    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.CompareTag("returnPlatform")){
            Speed = -Speed;
        }
        {

        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.transform.CompareTag("Player")){
            child.transform.SetParent(parent);
        }
    }

    private void  OnCollisionExit2D(Collision2D collision){
        if (collision.transform.CompareTag("Player")){ 
        }
    }

    void Update(){
      transform.Translate ( Speed * Time.deltaTime, 0, 0); 
    }
}
