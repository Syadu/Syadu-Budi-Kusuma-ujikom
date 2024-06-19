using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 350f;
    public Transform shootPoint;
    public float shootSpeed = 300f;
    public GameObject bulletPrefab;

    private CharacterController characterController;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Shoot();
    }

    public void Movement()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        characterController.Move(move * Time.deltaTime * speed);
        float moveValue = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetBool("Left", true);
            animator.SetBool("Right", false);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetBool("Right", true);
            animator.SetBool("Left", false);
        }
    }

    public void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var bullet = Instantiate(bulletPrefab, shootPoint.position, shootPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = shootPoint.forward * shootSpeed;

        }
    }
}
