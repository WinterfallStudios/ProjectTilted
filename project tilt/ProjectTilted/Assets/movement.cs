using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed;
    private float moveInputX;
    private Rigidbody rb;
    private float moveInputY;
    public Vector3 moveStuff;
    public float rotation;
    public float sensitivity;
    public float timeBtwJump;
    public float jumpforce;
    public float StartTimeBtwJump = 0.5f;
    public Transform left;
    public Transform right;
    public float StartTimeBtwWalk;
    private float timeBtwWalk;
    private bool iswalking = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBtwJump <= 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Jump();

            }
        }
        else if (timeBtwJump > 0)
        {
            timeBtwJump -= Time.deltaTime;
        }
        moveStuff = new Vector3(moveInputX * speed * Time.deltaTime, 0f, moveInputY * speed * Time.deltaTime);
        moveInputX = Input.GetAxisRaw("Horizontal");
        moveInputY = Input.GetAxisRaw("Vertical");
        transform.Translate(moveStuff);
        if (moveInputX < -0.1 || moveInputX > 0.1 || moveInputY < -0.1 || moveInputY > 0.1)
        {
            iswalking = true;
        }
        else
        {
            iswalking = false;
        }

        if (iswalking == true)
        {
            if (timeBtwWalk <= 1 && timeBtwWalk > 0)
            {
                right.Rotate(-40, 0, 0);
            }
            else if (timeBtwWalk <= 0.5 && timeBtwWalk > 0)
            {
                left.Rotate(-40, 0, 0);
            }
            else if (timeBtwWalk <= 0)
            {
                timeBtwWalk = StartTimeBtwWalk;
            }
            else
            {
                timeBtwWalk -= Time.deltaTime;
            }
        }
    }

    void Jump()
    {
        transform.Translate(Vector3.up * jumpforce * Time.deltaTime);
        timeBtwJump = StartTimeBtwJump;
    }
}

