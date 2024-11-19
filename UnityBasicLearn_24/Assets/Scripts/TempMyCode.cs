using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityBasic
{

    public class TempMyCode : MonoBehaviour
    {
        [System.Serializable]
        public class Dog
        {
            public string DogName;
            public int Age;

            public void Bark()
            {
                Debug.Log("왈왈!");
            }
        }

        public Dog myDog;

        #region unity Event Method

        // Start is called before the first frame update
        void Start()
        {
            ShowStatus();
        }
        private void ShowStatus()
        {
            Debug.Log($"나의 반려 동물의 이름 : {myDog.DogName}, 반려 동물의 나이 : {myDog.Age}");
            myDog.Bark();
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                ChangeDogName();
                ShowStatus();
            }
            else if (Input.GetKeyDown(KeyCode.G))
            {
                ChangeDogAge();
                ShowStatus();
            }
        }

        public string ModifyName;
        public int ModifyAge;

        private void ChangeDogName()
        {
            myDog.DogName = ModifyName;
        }
        private void ChangeDogAge()
        {
            myDog.Age = ModifyAge;
        }
        #endregion
    } 
}

