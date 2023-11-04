using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController myCharacterController;
    private Vector3 playerVelocity;
    [SerializeField] private float playerSpeed = 2.0f;



    // Start is called before the first frame update
    private void Start()
    {
        myCharacterController = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    private void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        myCharacterController.Move(move * Time.deltaTime * playerSpeed);
    }
}
