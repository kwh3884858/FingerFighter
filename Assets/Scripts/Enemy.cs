using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    void Start()
    {
        m_anim = GetComponent<Animator>();
    }

    void Update()
    {
        m_anim.SetBool("IsAttack", false);
        if (Time.time > m_lastAttack)
        {
            m_anim.SetBool("IsAttack", true);
            m_lastAttack = Time.time + m_attackInterval;
        }
    }

    float m_lastAttack = 0.0f;
    public float m_attackInterval = 3.0f;
    Animator m_anim;
}
