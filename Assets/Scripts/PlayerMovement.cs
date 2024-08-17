using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController characterContr;
    public float velocidad = 8f;

    private void Start()
    {
        characterContr = GetComponent<CharacterController>();
    }

    void Update()
    {
        Movimiento();
    }

    void Movimiento()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        characterContr.Move(move * velocidad * Time.deltaTime);
    }
}
