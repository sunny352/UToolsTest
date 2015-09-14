using UnityEngine;
using System.Collections;

public class TestBounceMono : MonoBehaviour
{
	public Transform Source;
	public Transform Target;
	public float Value = 5.0f;
	public float MaxSpeed = 10.0f;
	public float MinSpeed = 2.0f;
	// Use this for initialization
	void Start()
	{
		BounceMono mono = Source.gameObject.AddComponent<BounceMono>();
		mono.Target = Target;
		mono.Value = Value;
		mono.MaxSpeed = MaxSpeed;
		mono.MinSpeed = MinSpeed;
	}
}
