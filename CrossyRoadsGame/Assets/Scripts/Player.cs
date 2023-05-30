using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] public float movementSpeed = 5f;
    public CharacterController controller;
    public Camera camera;
    public bool wasHit = false;
    public GameObject restart;
    //private float cameraFOV = 15f;

    float velocityY = -9.8f;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        camera.fieldOfView = 15f;
    }

    // Update is called once per frame
    void Update()
    {
        if(camera.fieldOfView < 55f)
        {
            camera.fieldOfView++;
        }
        if(wasHit == true)
        {
            restart.SetActive(true);
        }
        UpdateMovement();

    }

    private void UpdateMovement()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));


        controller.Move((move * Time.deltaTime * movementSpeed) + (Vector3.up * velocityY));
    }
}