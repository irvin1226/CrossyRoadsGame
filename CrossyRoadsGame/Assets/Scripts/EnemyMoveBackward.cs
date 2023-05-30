using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveBackward : MonoBehaviour
{
    [SerializeField] public float moveSpeed;
    public Transform enemy;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move(moveSpeed);
    }

    private void Move(float speed)
    {
        transform.position -= transform.forward * speed;
    }
}