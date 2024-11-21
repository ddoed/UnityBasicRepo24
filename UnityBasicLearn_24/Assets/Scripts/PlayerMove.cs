using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityBasic
{
    public class PlayerMove : MonoBehaviour
    {
        public float Speed = 10f; // �ʱ� �ӵ�
        public float acceleration = 5f; // ���ӵ�
        public int turnSpeed = 45;
        // Start is called before the first frame update
        void Start()
        {
            //.Rotate(0,90,0);
        }

        // Update is called once per frame
        void Update()
        {
            // ����(horizontal)�� ����(vertical) �Է°�
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            // �̵�: ���� �ӵ��� ���� ���� �Է��� ������� �̵�
            transform.Translate(Speed * vertical * Time.deltaTime * Vector3.forward);
            // ȸ��: ���� �Է¿� ���� ȸ��
            transform.Rotate(Vector3.up, turnSpeed * horizontal * Time.deltaTime);

        }
    }
}
