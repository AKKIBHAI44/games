using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class eenemy : MonoBehaviour
{
    public NavMeshAgent enemy;
    public GameObject dest;
    public Transform enloc;
    public GameObject newen;
    public Text gameover;
    public float health;
    public float maxhealth;
    public GameObject healthBarui;
    public Slider slider;
    public ParticleSystem death;



    void Start()
    {
        health = maxhealth;
        slider.value =calculatehealth() ;

    }

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(dest.transform.position);

        slider.value = calculatehealth();
        if(health<=0)
        {
            Destroy(gameObject);
        }
        if(health<maxhealth)
        {
            health = maxhealth;
        }
    }
    void OnDestroy()
    {
        //GameObject enemy2;
        //enemy2 = Instantiate(newen, enloc.position, enloc.rotation);

        //enemy2.active = true;
        //enemy2.GetComponent<NavMeshAgent>().enabled = true;
        //enemy2.GetComponent<eenemy>().enabled = true;
        //print("SPAWNIG");
        Instantiate(death, transform.position, Quaternion.identity);
    }
    public void spawnn()
    {
        Instantiate(newen, enloc.position, enloc.rotation);

    }
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "box")
        {


            Time.timeScale = 0;
            gameover.enabled = true;


        }
    }
    float calculatehealth()

    {
        return health / maxhealth;

    }
 
}