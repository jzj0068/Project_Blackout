using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{
    public int selectWeapon = 0;
    // Start is called before the first frame update
    void Start()
    {
        SelectWeapon();
    }

    // Update is called once per frame
    void Update()
    {
        int previousWeapon = selectWeapon;
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            
            Debug.Log("GUN SELECTED");
            selectWeapon = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) && transform.childCount >= 2)
        {
            Debug.Log("KNIFE SELECTED");
            selectWeapon = 1;
        }
        if (previousWeapon != selectWeapon)
        {
            SelectWeapon();
        }

    }
    void SelectWeapon()
    {
        int i = 0;
        foreach (Transform weapon in transform)
        {
            if (i == selectWeapon)
            {
                weapon.gameObject.SetActive(true);
            }
            else
            {
                weapon.gameObject.SetActive(false);
            }
            i++;
        }
    }
}
