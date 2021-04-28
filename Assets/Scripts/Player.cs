﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public float health = 100;
    public GameObject youDie;
    private float maxHealth;

    public GameObject mainCamera;

    //UI Elements
    //public Slider healthbar;

	// Use this for initialization
	void Start () {
        maxHealth = health;
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void takeDamage(float dmg) {
        Debug.Log("take damage");
        health -= dmg;

        //healthbar.value = (health / maxHealth);

        if (health <= 0) {
            mainCamera.SetActive(true);
            youDie.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}
