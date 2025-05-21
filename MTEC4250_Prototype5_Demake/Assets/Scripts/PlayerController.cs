using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public PickupSound PkupSound;
    // TestMovement

    /*

    [Header("References")]
    public Transform orientation;
    public Transform Player;
    public Transform PlayerObj;

    public float RotationSpeed;

    */

    // TestMovement

    public float speed = 0;

    public Rigidbody rb;
    private float movementX;
    private float movementY;

    private int count;
    public TextMeshProUGUI countText;

    public GameObject winTextObject;

    AudioSource BGM;

    void Start()
    {
        // TestMovement

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        // TestMovement

        rb = GetComponent<Rigidbody>();

        count = 0;
        SetCountText();

        winTextObject.SetActive(false);

        BGM = GetComponent<AudioSource>();
        BGM.Play();
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    /*
    void MovePlayerRelativeToCamera ()
    {
        float playerVerticalInput = Input.GetAxis("Vertical");
        float playerHorizontalInput = Input.GetAxis("Horizontal");

        Vector3 forward = Camera.main.transform.forward;
        Vector3 right = Camera.main.transform.right;
        forward.y = 0;
        right.y = 0;
        forward = forward.normalized;
        right = right.normalized;

        Vector3 forwardRelativeVerticalInput = playerVerticalInput * forward;
        Vector3 rightRelativeHorizontalInput = playerHorizontalInput * right;

        Vector3 cameraRelativeMovement = forwardRelativeVerticalInput + rightRelativeHorizontalInput;
        this.transform.Translate(cameraRelativeMovement, Space.World);
    }
    */

    void SetCountText()
    {
        countText.text = "Collectibles: " + count.ToString() + " / 15";

        if (count >= 15)
        {
            winTextObject.SetActive(true);
        }
    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);

        // TestMovement

        /*
        Vector3 viewDir = Player.position - new Vector3(transform.position.x, Player.position.y, transform.position.z);
        orientation.forward = viewDir.normalized;

        float HorizontalInput = Input.GetAxis("Horizontal");
        float VerticalInput = Input.GetAxis("Vertical");
        Vector3 inputDir = orientation.forward * VerticalInput + orientation.right * HorizontalInput;

        if (inputDir != Vector3.zero)
        {
            PlayerObj.forward = Vector3.Slerp(PlayerObj.forward, inputDir.normalized, Time.deltaTime * RotationSpeed);
        }
        */

        // TestMovement
    }

    public void stop()
    {
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup_Main"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
            PkupSound.PlayAud();
        }  
    }
}
