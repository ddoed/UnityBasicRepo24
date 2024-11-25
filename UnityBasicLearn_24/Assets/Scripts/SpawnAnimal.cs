using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityBasic.Prototype2
{
    public class SpawnAnimal : MonoBehaviour
    {
        [Header("Spawn Monster Setting")]
        public GameObject animalPrefab;
        public float spawnTime = 3f;
        private float checkTime = 0f;

        public int limitx = 20;


        // Start is called before the first frame update
        void Start()
        {
            Instantiate(animalPrefab);
        }

        // Update is called once per frame
        void Update()
        {
            SpawnAnimals();
        }

        private void SpawnAnimals()
        {
            checkTime += Time.deltaTime;
            if (checkTime >= spawnTime)
            {
                checkTime = 0f;

                int randomX = Random.Range(-limitx, limitx);

                Vector3 spawnPos = new Vector3(randomX, 0, 19);
                Instantiate(animalPrefab, spawnPos, animalPrefab.transform.rotation);
            }
        }
    }
}