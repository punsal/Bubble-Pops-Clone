using System;
using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{

	
}

public class InputEventArgs
{
	private Vector3 _position;

	public InputEventArgs(Vector3 position)
	{
		_position = position;
	}
}

public class InputManager : MonoBehaviour
{
	private InputEventArgs _inputEventArgs;

	private void Awake()
	{
		_inputEventArgs = new InputEventArgs(Vector3.zero);
	}

	private IEnumerator Handle()
	{
		yield break;
	}
}