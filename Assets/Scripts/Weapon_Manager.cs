using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Weapon_Manager : MonoBehaviour
{
    public GameObject[] weaponList;
    public Text weaponSelected;

    public void Start()
    {
        foreach (GameObject weapon in weaponList)
        {
            weapon.SetActive(false);
        }
        weaponList[0].SetActive(true);
        weaponSelected.text = "Weapon 1" + Input.inputString;
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Bullet_container.bulletContainer.InstantiateBullets();

            foreach (GameObject weapon in weaponList)
            {
                weapon.transform.GetChild(0).gameObject.SetActive(true);
            }
        }
        else if (Input.GetMouseButtonUp(0))
        {
            foreach (GameObject weapon in weaponList)
            {
                weapon.transform.GetChild(0).gameObject.SetActive(false);
            }
        }

        switch (Input.inputString)
        {
            case "1":
                ActiveDeactiveWeapon();
                break;

            case "2":
                ActiveDeactiveWeapon();
                break;
        }        
       
    }

    public void ActiveDeactiveWeapon()
    {
        weaponSelected.text = "Weapon " + Input.inputString;

        foreach (GameObject weapon in weaponList)
        {
            weapon.SetActive(false);
        }
        weaponList[int.Parse(Input.inputString) - 1].SetActive(true);
    }
}
