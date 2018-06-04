using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Game_Manager;

public class mouse_image : MonoBehaviour {

	// Use this for initialization
	private Game_Scene_Manager gsm;
	private Image Mouse_image;
	private int mouse_type = 0;
	public Sprite none;
	public Sprite head;
	public Sprite arm;
	public Sprite shoes;
	public Color None;
	public Color NotNone;
	public Camera cam;

	void Awake() {
		gsm = Game_Scene_Manager.GetInstance();
		gsm.SetMouse(this);
		Mouse_image = GetComponent<Image>();
	}

	public int GetMouseType() {
		return mouse_type;
	}

	public void SetMouseType(int Mouse_type) {
		mouse_type = Mouse_type;
	}


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (mouse_type == 0) {
			Mouse_image.sprite = none;
			Mouse_image.color = None;
		} else {
			Mouse_image.color = NotNone;
			if (mouse_type == 1)
				Mouse_image.sprite = head;
			else if (mouse_type == 2)
				Mouse_image.sprite = arm;
			else if (mouse_type == 3)
				Mouse_image.sprite = shoes;
			Vector3 mp = Input.mousePosition;
			Vector3 mmp = cam.ScreenToWorldPoint(mp + new Vector3(0, 0, 350));
			transform.position = new Vector3(mmp.x, mmp.y, 0);
		}

	}
}
