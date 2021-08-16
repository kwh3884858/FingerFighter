using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagableEvent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (name == "Sword" && other.gameObject.name == "Blockable")
        {
            BlockableEvent blockEvent = other.gameObject.GetComponent<BlockableEvent>();
            if (blockEvent)
            {
                blockEvent.OnBlocked();
            }
            if (m_audio)
            {
                m_audio.Play();
            }
        }
    }
    public AudioSource m_audio = null;
}
