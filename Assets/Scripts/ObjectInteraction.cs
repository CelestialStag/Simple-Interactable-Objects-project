using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    [SerializeField] GameObject InteractionMessage;
	private Animator ObjectAnimator;
	bool isPlayerInteracting;
	public int isOpen;
	
	// Awake
	void Awake()
	{
		ObjectAnimator = this.gameObject.transform.parent.gameObject.GetComponent<Animator>();
	}
	
	// Start is called before the first frame update
    void Start()
    {
		isPlayerInteracting = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isPlayerInteracting == true)
		{
			TriggerAnimation();
		}
    }
	
	void OnTriggerEnter(Collider other)
	{
		InteractionMessage.SetActive(true);
		isPlayerInteracting = true;
	}
	
	void OnTriggerExit(Collider other)
	{
		InteractionMessage.SetActive(false);
		isPlayerInteracting = false;
	}
	
	void TriggerAnimation()
	{
		if(ObjectAnimator != null)
		{
			if(Input.GetKeyDown(KeyCode.F))
			{
				if(isOpen == 1)
				{
					isOpen = 0;
					ObjectAnimator.SetTrigger("TriggerClose");
				}
				
				else if(isOpen == 0)
				{
					isOpen = 1;
					ObjectAnimator.SetTrigger("TriggerOpen");
				}
				else
				{
					ObjectAnimator.SetTrigger("TriggerActivate");
				}
			}
		}
	}
}
