using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTriggered : MonoBehaviour
{



    public GameObject levelCompletePanel; // Level complete panelinizi buraya sürükleyin

    private void Start()
    {
        // Baþlangýçta paneli gizle
        levelCompletePanel.SetActive(false);
    }
  
        void OnCollisionEnter(Collision collisioninfo)
        {
            if (collisioninfo.collider.tag == "END")
            {
            
                levelCompletePanel.SetActive(true); // Level complete panelini göster
            }
        }

    }

