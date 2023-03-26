using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float shotSpeed = 3f;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.z += shotSpeed * Time.deltaTime;
        transform.position = pos;

        if (this.transform.position.z > 9)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name != "vehicle_playerShip")
        {
            Debug.Log("Ãæµ¹");
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
    }

}
