using System.Threading;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed;
    public float jumpHeight;

    private CharacterController _characterController;
    private Vector3 _movementVector;

    void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        CharacterMove();
    }

    private void CharacterMove()
    {
        float horizontal = Input.GetAxis("Horizontal");

      
            _movementVector = new Vector3(horizontal * playerSpeed, 0f, 0f);

            if (Input.GetButtonDown("Jump"))
            {
                _movementVector.y = jumpHeight;
            }
        
        _characterController.Move(_movementVector * Time.deltaTime);
    }
}