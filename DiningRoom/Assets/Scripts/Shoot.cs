using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Shooting
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(bullet, gameObject.transform.TransformPoint(new Vector3(0, -1, 10)), gameObject.transform.rotation);
        }
    }
}
