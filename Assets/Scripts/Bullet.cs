using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float lifeTime = 3f;
    public float damage = 100.0f;
    public float moveSpeed = 350f;
    

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(GetComponent<AudioSource>(), transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        
        
    }

    private void Movement()
    {
        transform.position += Time.deltaTime * moveSpeed * transform.forward;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Enemy")
        {
            //other.GetComponent<Enemy>().takeDamage(damage);
            Destroy(this.gameObject);
        }

    }
}
