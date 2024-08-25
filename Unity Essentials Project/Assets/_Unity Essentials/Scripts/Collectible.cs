using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float rotationSpeed=0.5f;
    public GameObject onCollectEffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed, 0);
    }
    private void OnTriggerEnter(Collider other) {
        // Instantiate the particle effect
        Instantiate(onCollectEffect, transform.position, transform.rotation);

        if (other.CompareTag("Player")) {
            Destroy(gameObject);
        }
    }
         
}
