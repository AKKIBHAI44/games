using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class apawm : MonoBehaviour
{
    public GameObject enemy;
    public Transform enloc;
    private GameObject newen;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
    
       private void spawn()
    {
        if (Input.GetMouseButtonDown(1))
           newen = Instantiate(enemy, enloc.position, enloc.rotation);

    }
    
}
