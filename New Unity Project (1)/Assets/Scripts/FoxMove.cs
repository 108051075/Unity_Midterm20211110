using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxMove : MonoBehaviour
{
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 foxMove = transform.position;
        foxMove.x = foxMove.x + Input.GetAxis("Horizontal") * moveSpeed;
       
        transform.position = foxMove;
    }
}
