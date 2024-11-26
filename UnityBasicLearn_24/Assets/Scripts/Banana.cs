using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityBasic.Prototype2
{
    public interface IitemCollectable
    {
        public void Interact();
    }

    public class Banana : MonoBehaviour, IitemCollectable
    {
        public void Interact()
        {
            Debug.Log("Banana »πµÊ º”µµ ¡ı∞°");
        }
    }
}
