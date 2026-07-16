using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController Control;
	public float X;
	public float Z;
	public int i;
	[SerializeField] int Speedmod;
	//public GameObject Player;
	
	// Awake	
    void Awake()
    {
		//what needs to be called at load
    }
	
	// Start is called before the first frame update
	void Start()
    {
		//what needs to be called at start
    }

    // Update is called once per frame
    void Update()
    {
		X = Input.GetAxisRaw("Horizontal");
		Z = Input.GetAxisRaw("Vertical");				
		if(X==0 && Z==0)
		{
			//Do nothing
		}
		else
		{
			Movement();
		}
    }
	
	void Movement()
	{
		Vector3 move = new Vector3(X*Speedmod*Time.deltaTime,0,Z*Speedmod*Time.deltaTime);
		float Angle = Mathf.Atan2(move.x, move.z)*Mathf.Rad2Deg;
		//transform.rotation = Quaternion.Euler(0,Angle,0);
		Control.Move(move);
	}
	
	void Jump()
	{
		//jumping action
	}
	
}