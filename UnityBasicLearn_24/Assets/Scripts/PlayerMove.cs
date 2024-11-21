using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityBasic
{
    public class PlayerMove : MonoBehaviour
    {
        public float Speed = 10f; // 초기 속도
        public float acceleration = 5f; // 가속도
        public int turnSpeed = 45;
        // Start is called before the first frame update
        void Start()
        {
            //.Rotate(0,90,0);
        }

        // Update is called once per frame
        void Update()
        {
            // 수평(horizontal)과 수직(vertical) 입력값
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            // 이동: 현재 속도와 수직 방향 입력을 기반으로 이동
            transform.Translate(Speed * vertical * Time.deltaTime * Vector3.forward);
            // 회전: 수평 입력에 따라 회전
            transform.Rotate(Vector3.up, turnSpeed * horizontal * Time.deltaTime);

        }
    }
}
