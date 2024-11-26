using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityBasic.Prototype2
{
    public class Pizza : MonoBehaviour, IitemCollectable
    {
        public GameManager gameManager;
        
        public void Interact()
        {
            AddScore();
            Debug.Log("피자를 먹었다");
        }

        private void AddScore()
        {
            
        }
    }
}
