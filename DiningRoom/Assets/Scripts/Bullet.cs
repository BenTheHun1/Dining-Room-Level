using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private PlayerController pl;
    public float timeToDestroy;
    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * speed * 100, ForceMode.Force);
        StartCoroutine(Despawn());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Despawn()
    {
        yield return new WaitForSeconds(timeToDestroy);
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
