using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCreate : MonoBehaviour
{
    public GameObject copyobj = null;
    GameObject cloneobj = null;
    float delta = 0;
    public float spawnTime = 1;
    
    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if (delta > spawnTime)
        {
            delta = 0;
            cloneobj = GameObject.Instantiate(copyobj);
            Vector3 randompos = new Vector3(0, 5f, 0);
            float randposX = UnityEngine.Random.Range(-17f, 17f);
            randompos.x = randposX;
            cloneobj.transform.position = randompos;
            cloneobj.SetActive(true);
        }
    }
}
