using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float RotationSpeed = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * RotationSpeed * Time.deltaTime);
    }

    private void OnTriggerExit(Collider other)      // check point to destroy after leaving collider
    {
        if (gameObject.CompareTag("Checks"))
        {
            Destroy(gameObject);
        }
    }

}
