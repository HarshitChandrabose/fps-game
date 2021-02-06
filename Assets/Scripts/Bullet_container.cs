using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_container : MonoBehaviour
{    
    public static Bullet_container bulletContainer;

    public Transform initialPosition;

    public GameObject bulletToPool;
    //public List<GameObject> bulletPool = new List<GameObject>();
   // public int numberOfBullets;

    public static float bulletSpeed =5;
    // Start is called before the first frame update
    void Start()
    {
        bulletContainer = this;

        //for object pooling
       /* for (int i = 0; i < numberOfBullets; i++)
        {
            GameObject obj = (GameObject)Instantiate(bulletToPool);
            obj.transform.parent = this.transform;

            obj.SetActive(false);

            bulletPool.Add(obj);
        }*/
    }

    public void InstantiateBullets()
    {
        GameObject bullet = Instantiate(bulletToPool) as GameObject;
        bullet.transform.parent = this.transform;
        bullet.transform.position = initialPosition.position;
    }
    
}
