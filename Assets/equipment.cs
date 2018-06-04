﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Game_Manager;

public class equipment : MonoBehaviour {

	// Use this for initialization
	private Game_Scene_Manager gsm;
	private Image equip_image;
	public int mouse_type;
	public Sprite weapon;
	public Sprite UIMask;

	void Awake() {
		gsm = Game_Scene_Manager.GetInstance();
		equip_image = GetComponent<Image>();
	}

	public void On_equip_Button() {
		int MouseType = gsm.GetMouse().GetMouseType();
		if (equip_image.sprite == weapon && MouseType == 0) {
			equip_image.sprite = UIMask;
			gsm.GetMouse().SetMouseType(mouse_type);
		} else if (equip_image.sprite == UIMask) {
			if (MouseType == mouse_type) {
				equip_image.sprite = weapon;
				gsm.GetMouse().SetMouseType(0);
			}
		}
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
}
