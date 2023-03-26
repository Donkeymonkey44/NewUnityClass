using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAsteroid : MonoBehaviour
{
    public float moveSpeed = 2f;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.z -= moveSpeed * Time.deltaTime;
        this.transform.position = pos;

        if (this.transform.position.z < -9)
            Destroy(this.gameObject);
    }
}
