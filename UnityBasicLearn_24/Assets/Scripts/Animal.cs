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

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.CompareTag("End"))
            {
                Debug.Log("게임 오버");
                GameManager.instance.GameOver();
            }
        }

        private void OnCollisionExit(Collision collision)
        {
            if (collision.collider.CompareTag("End"))
            {
                //Debug.Log("충돌 종료");
            }
        }

        private void OnCollisionStay(Collision collision)
        {
            if (collision.collider.CompareTag("End"))
            {
                //Debug.Log("충돌 진행 중");
            }
        }
    }
}
