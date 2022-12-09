using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour{

    [SerializeField] float speed = 5;

    float h, v;

    Vector3 movementDirection;
    //Vector2 facingDirection;

    //Animator playerAnimator;

    void Start(){

        //playerAnimator = GetComponent<Animator>();
    }

    void Update(){

        ReadInput();
        this.transform.position += movementDirection * Time.deltaTime * speed;
    }

    void ReadInput(){

        h = Input.GetAxis("Player2Horizontal");
        v = Input.GetAxis("Player2Vertical");
        movementDirection.x = h;
        movementDirection.y = v;
    }
}