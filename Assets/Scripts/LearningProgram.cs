using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningProgram : MonoBehaviour
{
    private Rigidbody2D myBody;
    private BoxCollider2D myCollider;
    private AudioSource myAudioSource;
    private Animator anim;

    private Transform myTransform;

    // En la siguiente linea es Player pero no lo tengo aun
    //PlayerMovement p = new PlayerMovement();

    // 3rd function called
    private void Start()
    {   
        myBody = GetComponent<Rigidbody2D>();
      
        myTransform = GetComponent<Transform>();
        myTransform = transform;

        myTransform.position = new Vector3(10,10,0);
        
    }


} // class
