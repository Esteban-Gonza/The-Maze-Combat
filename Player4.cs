using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player4 : MonoBehaviour{

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

        h = Input.GetAxis("Player4Horizontal");
        v = Input.GetAxis("Player4Vertical");
        movementDirection.x = h;
        movementDirection.y = v;
    }
}