using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCreater : MonoBehaviour
{
    public GameObject copy = null;
    GameObject clone = null;
    float delta = 0;
    public float shotDelay = 1f;
    public Transform pos = null;
    public float shotSpeed = 3f;

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if (Input.GetKey(KeyCode.Space) && delta > shotDelay || Input.GetKeyDown(KeyCode.Space))
        {
            delta = 0;
            clone = GameObject.Instantiate(copy);
            clone.transform.position = pos.position;
            clone.SetActive(true);

            Bullet bullet = clone.GetComponent<Bullet>();
            bullet.shotSpeed = shotSpeed;
            
        }
    }
}
