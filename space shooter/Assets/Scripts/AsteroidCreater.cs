using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidCreater : MonoBehaviour
{
    public GameObject copy1 = null;
    public GameObject copy2 = null;
    public GameObject copy3 = null;
    GameObject clone = null;
    public Transform setPos = null;
    float posX = 0f;

    int makechoice = 0;
    float delta = 0;
    public float spawnDelay = 1f;

    // Update is called once per frame
    void Update()
    {
        makechoice = Random.Range(1, 4);
        delta += Time.deltaTime;
        posX = UnityEngine.Random.Range(-3.5f, 3.7f);

        if (delta > spawnDelay)
        {
            delta = 0;
            if (makechoice == 1)
            {
                clone = GameObject.Instantiate(copy1);
                Vector3 pos = clone.transform.position;
                pos = setPos.position;
                pos.x = posX;
                clone.transform.position = pos;
                clone.SetActive(true);
            }
            else if (makechoice == 2)
            {
                clone = GameObject.Instantiate(copy2);
                Vector3 pos = clone.transform.position;
                pos = setPos.position;
                pos.x = posX;
                clone.transform.position = pos;
                clone.SetActive(true);
            }
            else if (makechoice == 3)
            {
                clone = GameObject.Instantiate(copy3);
                Vector3 pos = clone.transform.position;
                pos = setPos.position;
                pos.x = posX;
                clone.transform.position = pos;
                clone.SetActive(true);
            }
        }
    }
}
