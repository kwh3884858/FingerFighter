using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockableEvent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (m_isBlocked)
        {
            m_master.GetComponent<Animator>().SetBool("IsBlocked", true);
            m_isBlocked = false;
        }
        else
        {
            m_master.GetComponent<Animator>().SetBool("IsBlocked", false);
        }
    }

    public void OnBlocked()
    {
        if (m_damagableEvent.enabled)
        {
            m_isBlocked = true;
        }
        else
        {
            Debug.Log("Miss!");
        }
    }

    public GameObject m_master;
    public DamagableEvent m_damagableEvent;
    private bool m_isBlocked =false;
}
