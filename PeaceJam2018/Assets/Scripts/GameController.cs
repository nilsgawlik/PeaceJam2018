﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	public GameObject player;
	public Color[] colorWheel;

	public static GameController instance;

	private void Start() {
		instance = this;
	}
}
