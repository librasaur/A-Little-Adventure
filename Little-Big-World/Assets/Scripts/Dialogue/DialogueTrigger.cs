﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    [SerializeField] private DialogueManager dialogueManager;
    [SerializeField] private CharacterController characterController;

    //public DialogueObject dialogue;
    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        //dialogueManager.StartDialogue(dialogue);
    }

    private void OnTriggerStay(Collider other)
    {
        DialogueTrigger interactable = other.GetComponent<DialogueTrigger>();

        if (Input.GetKeyDown(KeyCode.Return) && characterController.isCurrentCharacter &&
            interactable && !dialogueManager.playingDialogue)
        {
            Debug.Log(dialogue.name + " interacted with " + interactable.name);

            if(dialogue.name == "Raine")
            {
                if (interactable.name == "Lance")
                    dialogueManager.StartDialogue(interactable.dialogue.messages[0]);

                else if (interactable.name == "Connie")
                    dialogueManager.StartDialogue(interactable.dialogue.messages[0]);
            }

            else if (dialogue.name == "Lance")
            {
                if (interactable.name == "Raine")
                    dialogueManager.StartDialogue(interactable.dialogue.messages[0]);

                else if (interactable.name == "Connie")
                    dialogueManager.StartDialogue(interactable.dialogue.messages[1]);
            }

            else if (dialogue.name == "Connie")
            {
                if (interactable.name == "Raine")
                    dialogueManager.StartDialogue(interactable.dialogue.messages[1]);

                else if (interactable.name == "Lance")
                    dialogueManager.StartDialogue(interactable.dialogue.messages[1]);
            }
        }
    }
}
