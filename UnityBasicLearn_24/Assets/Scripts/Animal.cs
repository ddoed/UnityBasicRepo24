using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace UnityBasic.Prototype2
{
    public class Animal : MonoBehaviour
    {
        public float speed = 3f;
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            transform.position += Vector3.back * Time.deltaTime * speed;
        }
    }
}
