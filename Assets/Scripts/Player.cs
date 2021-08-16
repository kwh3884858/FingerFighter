using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        m_anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        m_anim.SetBool("IsAttack", false);

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            m_anim.SetBool("IsAttack", true);
        }
    }


    Animator m_anim;
}
