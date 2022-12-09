using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinZone : MonoBehaviour{

    void Start(){}

    void Update(){}

    void OnTriggerEnter2D(Collider2D collision){
    
        if(collision.gameObject.tag.Equals("Player1")){

            GameManager.sharedInstance.Win1Game();
        }

        if (collision.gameObject.tag.Equals("Player2")){

            GameManager.sharedInstance.Win2Game();
        }
    }
}
