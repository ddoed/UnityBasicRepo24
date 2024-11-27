using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityBasic.Prototype2
{
    public interface IitemCollectable
    {
        public void Interact();
    }

    public class Banana : Item
    {
        public override void Interact()
        {
            base.Interact();
            Debug.Log("�ٳ��� ������ ȹ��");
        }
    }
}
