using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakGlass : MonoBehaviour
{

    public GameObject potToBreak;
    public AudioSource source;
    public AudioClip breakSound;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player" && Input.GetKey(KeyCode.F))
        {
            potToBreak.SetActive(false);
        }
    }
}
