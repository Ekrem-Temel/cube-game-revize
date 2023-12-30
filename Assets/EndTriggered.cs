using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTriggered : MonoBehaviour
{



    public GameObject levelCompletePanel; // Level complete panelinizi buraya s�r�kleyin

    private void Start()
    {
        // Ba�lang��ta paneli gizle
        levelCompletePanel.SetActive(false);
    }
  
        void OnCollisionEnter(Collision collisioninfo)
        {
            if (collisioninfo.collider.tag == "END")
            {
            
                levelCompletePanel.SetActive(true); // Level complete panelini g�ster
            }
        }

    }

