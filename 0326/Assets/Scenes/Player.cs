using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // �̵�ó��
    // �߻�ó��
    void Start()
    {

    }

    public float MoveSpeed = 1;
    public GameObject CopyObj = null;
    GameObject cloneobj = null;
    List<GameObject> cloneobjList = new List<GameObject>();
    public float ShotSpeed = 1;
    float delta = 0;
    public float ShotDelay = 1;

    void Update()
    {
        // �̵�ó��
        if (Input.GetKey(KeyCode.LeftArrow)
            || Input.GetKey(KeyCode.A))
        {
            Vector3 pos = transform.position;
            pos.x -= MoveSpeed * Time.deltaTime;
            this.transform.position = pos;
        }

        if (Input.GetKey(KeyCode.RightArrow)
            || Input.GetKey(KeyCode.D))
        {
            Vector3 pos = transform.position;
            pos.x += MoveSpeed * Time.deltaTime;
            this.transform.position = pos;
        }

        delta += Time.deltaTime;
        // �߻�ü
        if (Input.GetKey(KeyCode.Space) && delta > ShotDelay || Input.GetKeyDown(KeyCode.Space))
        {
            // �߻�ü�� �����ؼ� �����̰� ó��
            //GameObject.Instantiate(  );
            delta = 0;
            cloneobj = GameObject.Instantiate(CopyObj);
            Vector3 pos = cloneobj.transform.position;
            pos = this.transform.position;
            pos.y = 1.2f;
            cloneobj.transform.position = pos;
            cloneobj.SetActive(true);

            Shoot cloneshoot = cloneobj.GetComponent<Shoot>();
            cloneshoot.ShotSpeed = ShotSpeed;
            cloneshoot.IsOrigin = false;

            cloneobjList.Add(cloneobj);
            
        }
    }
}
