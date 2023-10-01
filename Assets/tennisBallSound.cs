using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tennisBallSound : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }





    public AudioClip collisionSound; // Assign your sound clip in the Inspector

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("CollisionTag")) // Adjust the tag as needed
        {
            AudioSource.PlayClipAtPoint(collisionSound, transform.position);
        }
    }







}
