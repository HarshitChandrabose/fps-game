using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            this.transform.position = Vector3.zero;

            this.transform.GetChild(0).gameObject.SetActive(true);
            Destroy(this.gameObject, 0.5f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.position += Vector3.forward * Bullet_container.bulletSpeed * Time.deltaTime;
        this.transform.position += new Vector3(0, 0, Bullet_container.bulletContainer.initialPosition.position.z * Bullet_container.bulletSpeed * Time.deltaTime);
        
    }
}
