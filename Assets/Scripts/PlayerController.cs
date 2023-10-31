using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;
    private float verticalInput;

    public float turnSpeed;
    private float horizontalInput;

    public Animator animator;

    private Rigidbody playerRb;

    private GameObject focalPoint;

    // Start is called before the first frame update
    void Start()
    {

        animator = GetComponent<Animator>();playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");

    }

    // Update is called once per frame
    void Update()
    {
        // Rotate Camera

        float forwardInput = Input.GetAxis("Vertical");
        playerRb.AddForce(focalPoint.transform.forward * moveSpeed * forwardInput);

        //Move Forward
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * verticalInput);
        animator.SetFloat("verticalInput", Mathf.Abs(verticalInput));

        //Rotate
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);

        
    }
}
