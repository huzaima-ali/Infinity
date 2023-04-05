using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody PlayerRb;
    public float AirCraft_Speed = 60;
    public float TurningSpeed = 5;
    public float tiltSpeed = 5;
    public ParticleSystem ExplosionEffect;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        PlayerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float HorizontalMovement = Input.GetAxis("Horizontal");
        PlayerRb.AddForce(transform.right * TurningSpeed * HorizontalMovement);
        transform.Translate(Vector3.forward * AirCraft_Speed * Time.deltaTime);

        //transform.Rotate(Vector3.back, tiltSpeed * Time.deltaTime * HorizontalMovement);      

        //  Aircraft leftTilt
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //transform.Rotate(Vector3.back, tiltSpeed * Time.deltaTime * HorizontalMovement);
            //transform.rotation = Quaternion.AngleAxis(30, Vector3.forward);
            float leftTilt = Input.GetAxis("Horizontal") * -15.0f;
            //print(leftTilt);
            Vector3 euler = transform.localEulerAngles;
            print(euler);
            euler.z = Mathf.Lerp(euler.z, leftTilt, 2.0f * Time.deltaTime);
            transform.localEulerAngles = euler;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward, tiltSpeed * Time.deltaTime * HorizontalMovement);
            transform.rotation = Quaternion.AngleAxis(0, Vector3.forward);
        }

        //  Aircraft RightTilt
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //transform.Rotate(Vector3.back, tiltSpeed * Time.deltaTime * HorizontalMovement);
            //transform.rotation = Quaternion.AngleAxis(-30, Vector3.forward);
            float rightTilt = Input.GetAxis("Horizontal") * -15.0f;
            //print(rightTilt);
            Vector3 euler = transform.localEulerAngles;
            print(euler);
            euler.z = Mathf.LerpAngle(euler.z, rightTilt, 2.0f * Time.deltaTime);
            transform.localEulerAngles = euler;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.forward, tiltSpeed * Time.deltaTime * HorizontalMovement);
            transform.rotation = Quaternion.AngleAxis(0, Vector3.forward);
        }

    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Finish"))
        {
            Explosion();
            Destroy(gameObject);
            gameManager.GameOver();
        }
        
    }

    void Explosion()
    {
        Instantiate(ExplosionEffect, transform.position, transform.rotation);
        AudioSource Explosionsound = GameObject.FindGameObjectWithTag("ExplosionSound").GetComponent<AudioSource>();
        GetComponent<AudioSource>().clip = Explosionsound.clip;
        Destroy(gameObject);
    }

    public void IncreaseSpeed(float modifier)
    {
        AirCraft_Speed = 60 + modifier;
    }

}