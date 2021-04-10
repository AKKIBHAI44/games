using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed;
    public GameObject player1;



    // Use this for initialization
    void Start()
    {

    }
 

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {

            collision.gameObject.GetComponent<eenemy>().spawnn();
            Destroy(collision.gameObject);

           

        }
    }
}

