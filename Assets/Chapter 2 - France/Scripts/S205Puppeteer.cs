﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class S205Puppeteer : CutscenePuppeteer {


	private GameObject chefTony;
	
		
	// Use this for initialization
	void Start () {
		// get all the objects we'll need for the cutscene 
		chefTony = GameObject.Find ("Chef Tony Cart");

	}
	
	// Update is called once per frame
	public void FixedUpdate () {

	}

	public override void HandleSceneChange() {
//
//		if(CurrentScene == 3) {
//			chefTony.GetComponent<PlayerFreeze>().UnFreeze();
//		} else if(CurrentScene == 7) {
//			//make CT look backward
//			flipObject(chefTony);
//
//			//make the guard face CT
//			flipObject(police);
//
//			//jump the guard to just off the screen so he can waltz right in
//			Vector3 pos = police.transform.position;
//			pos.x = -6;
//			police.transform.position = pos;
//			police.GetComponent<Animator>().SetFloat("Speed", 3f);
//			police.rigidbody2D.velocity = new Vector2(3f, 0f);
//
//		} else if(CurrentScene == 10) {
//			// chef tony should run off the screen with the cart
//			flipObject(chefTony);
//
//			chefTony.rigidbody2D.isKinematic = true;
//			chefTony.rigidbody2D.velocity = new Vector2(3f, 0f);
//			ctanim.SetFloat("Speed", 3f);
//		} else if(CurrentScene == 12) {
//			StartCoroutine(FadeAndNext(Color.black, 2, "2-05 Cart Race"));
//		}
	}

}
