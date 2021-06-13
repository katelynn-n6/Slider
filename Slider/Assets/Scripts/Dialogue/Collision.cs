using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public GameObject npc;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            npc.GetComponent<DialogueTrigger>().TriggerDialogue(npc);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (npc.GetComponent<NPC>().characterName == "Fezziwig")
            {
                //ADD NEW THING HERE
                return;
            }
            npc.GetComponent<DialogueManager>().FadeAwayDialogue();
        }
    }
}
