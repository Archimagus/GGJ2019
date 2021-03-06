﻿using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public static Player Instance { get; private set; }
	public List<int> FoundPickups { get; } = new List<int>();
	public int CurrentPickup = -1;

	private void Awake()
	{
		if(Instance != null)
		{
			Destroy(gameObject);
			return;
		}
		Instance = this;
		DontDestroyOnLoad(gameObject);
	}
	private void OnLevelWasLoaded(int level)
	{
		if (level == 0)
			Destroy(gameObject);
	}
}
