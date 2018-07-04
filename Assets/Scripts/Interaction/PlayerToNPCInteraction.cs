using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerToNPCInteraction : MonoBehaviour
{
	[SerializeField]
	private DialogueManager playerDialogueManager;

	void Start ()
	{
		InitializeScripts();	
	}
	
	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.E))
			// Player input to interact with an NPC
			DialogueInteraction();
	}

	/// <summary>
	/// Initialize the dialogue manager and quest handler on the player
	/// </summary>
	void InitializeScripts()
	{
		if (!playerDialogueManager)
			playerDialogueManager = GetComponent<DialogueManager>();

		if (!playerDialogueManager)
			Debug.LogError("ERROR: Player must contain DialogueManager script");
	}

	/// <summary>
	/// Will attempt to perform a dialogue interaction with an NPC
	/// </summary>
	private void DialogueInteraction()
	{
		playerDialogueManager.CheckForAndActivateConversation();
	}
}
