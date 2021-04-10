using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public GameObject bulletObject;
    public Transform bulletSpawningpos;
    public float rotspeed;
    public Text coin;
    public int score1 = 0;
    public float yaw;
    public float pitch;
    public float speedh;
    public float speedv;
    public Camera Camera;
    private AudioSource maudio;

    // Use this for initialization
    void Start()
    {
        maudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))

        {
            maudio.Play();
            Instantiate(bulletObject, bulletSpawningpos.position, bulletSpawningpos.rotation);


        }
        yaw += speedh * Input.GetAxis("Mouse X");
        pitch += speedv * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(-pitch, yaw, 0.0f);
        Camera.transform.eulerAngles = new Vector3(-pitch, yaw, 0.0f);


    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, 0.1f));
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-0.1f, 0, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(0.1f, 0, 0));
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 0, -0.1f));
        }
        float x = Input.GetAxis("Mouse X") * rotspeed * Time.deltaTime;
        transform.Rotate(transform.up * x);


    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "coin")
        {

            Destroy(collision.gameObject);
            score1++;
            coin.text = score1.ToString();
        }
    }
    public void togglegame()
    {
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
        else
            Time.timeScale = 0;
    }
    private void Awake()
    {
        Time.timeScale = 0;

    }
}