using UnityEngine;
using System.Collections;

public class TestBounce : MonoBehaviour
{
	public Transform Source;
	public Transform Target;
	public float Value = 5.0f;
	public float MaxSpeed = 10.0f;
	public float MinSpeed = 2.0f;
	public bool IsEnable = true;
	private Bounce m_bounce;
	// Use this for initialization
	void Start()
	{
		m_bounce = new Bounce();
		m_bounce.Init(Source);
		m_bounce.Target = Target;
		m_bounce.Value = Value;
		m_bounce.MaxSpeed = MaxSpeed;
		m_bounce.MinSpeed = MinSpeed;
	}
	void FixedUpdate()
	{
		if (IsEnable)
		{
			m_bounce.Enable();
		}
		else
		{
			m_bounce.Disable();
		}
	}
	void LateUpdate()
	{
		m_bounce.LateUpdate();
	}
}
