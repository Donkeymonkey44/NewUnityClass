using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float ShotSpeed = 1;
    public bool IsOrigin = true;
    float delta = 0;
    public float deleteTime = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.y += ShotSpeed * Time.deltaTime;
        transform.position = pos;

        delta += Time.deltaTime;
        if (delta > deleteTime && !IsOrigin)
        {
            delta = 0;
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"충돌 : {collision}");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"충돌 : {other.gameObject}");
        Destroy(gameObject);
        Destroy(other.gameObject);
    }

}
