using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    Animation animation;

    //dmg variables
    public float damage = 10.0f;
    public float fireRate = 0.15f;
    private float fireTime;

    //Spawn Effects
    public GameObject muzzleFlash;
    public GameObject bulletHit;
    public GameObject muzzle;
    public GameObject target;

    //Audio
    public GameObject fireSound;


    // Start is called before the first frame update
    void Start()
    {
        animation = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        Weaponfiring();
    }

    private void Weaponfiring()
    {
        if(Input.GetMouseButton(0) && Time.time > fireTime)
        {

            //fire effects
            Instantiate(fireSound, transform.position, transform.rotation);
            Instantiate(muzzleFlash, muzzle.transform.position, muzzle.transform.rotation);
            animation.Play("fire");

            //Raycast projectile
            RaycastHit hit;
            if (Physics.Raycast(muzzle.transform.position, -(muzzle.transform.position - target.transform.position).normalized, out hit, 50.0f))
            {
                if(hit.transform.tag == "Enemy")
                {
                    hit.transform.GetComponent<Enemy>().takeDamage(damage);

                    Instantiate(bulletHit, hit.transform.position, hit.transform.rotation);
                }
            }

            


            //Setup next firetime
            fireTime = Time.time + fireRate;

        }
    }
}
