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
            Debug.Log("���ڸ� �Ծ���");
        }

        private void AddScore()
        {
            
        }
    }
}
