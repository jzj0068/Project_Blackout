using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    public int weaponSelect = 0;
    public WeaponSwitch wSwitch;
    private Transform aimTransform;
    private Animator aimAnimator;
    public AudioSource gunAudio;
    public Transform fire_point;
    public GameObject bulletPrefab;
    public string weaponChange;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void Awake()
    {
        aimTransform = transform.Find(weaponChange);
        aimAnimator = aimTransform.GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        Aiming();
        Shooting();
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            weaponChange = "AimG";
            weaponSelect = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            weaponChange = "AimK";
            weaponSelect = 1;
        }
    }
    private void Aiming()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 aimDirection = (mousePos - transform.position).normalized;
        float angle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg;
        aimTransform.eulerAngles = new Vector3(0, 0, angle);
        if ((angle > 90) || (angle < -90) )
        {
            aimTransform.localScale = new Vector3(.5f, -.5f, 1f);
        }
        else
        {
            aimTransform.localScale = new Vector3(.5f, .5f, 1f);
        }
        //Debug.Log(angle);
    }
    private void Shooting()
    {
        if (weaponSelect == 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(bulletPrefab, fire_point.position, fire_point.rotation);
                gunAudio.Play();
            }
        }
    }
}
