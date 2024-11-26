using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityBasic.Prototype2
{
    public class PM_2 : MonoBehaviour
    {
        public float speed = 10f;
        public GameObject food;
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            Move();
            Attack();
        }

        private void Attack()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Vector3 foodPos = new Vector3(transform.position.x, transform.position.y+1, transform.position.z);
                Instantiate(food, foodPos, Quaternion.identity);
            }
        }

        private void Move()
        {
            if (transform.position.x < -20)
            {
                transform.position = new Vector3(-20, transform.position.y, transform.position.z);
            }
            if (transform.position.x > 20)
            {
                transform.position = new Vector3(20, transform.position.y, transform.position.z);
            }


            //Debug.Log($"입력받은 값 : {horizontal}");
            //transform.Translate(speed * horizontal * Time.deltaTime * Vector3.right);
            float horizontal = Input.GetAxis("Horizontal");
            transform.position += speed * Time.deltaTime * Vector3.right * horizontal;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Item"))
            {
                IitemCollectable item = other.GetComponent<IitemCollectable>();
                item.Interact();

                speed *= 2;
                Destroy(other.gameObject);
                
            }
        }
    }
}
