﻿using UnityEngine;
using System.Collections;

public class CannonProjectile : MonoBehaviour {
	public float m_speed = 0.2f;
	public int m_damage = 10;

	void Update () {
		var translation = transform.forward * m_speed;
		transform.Translate (translation);
	}

	void OnTriggerEnter(Collider other) {
		var monster = other.gameObject.GetComponent<Monster> ();
		if (monster == null)
			return;

        //TODO Закомментировал, чтобы скомпилилось
		//monster._currentHealth -= m_damage;
		//if (monster._currentHealth <= 0) {
		//	Destroy (monster.gameObject);
		//}
		Destroy (gameObject);
	}
}
