using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Core
{
    public class PersistentObjectSpawner : MonoBehaviour
    {
        [SerializeField] GameObject persistentObjectPrefab;

        static bool hasSpawner = false;

        private void Awake()
        {
            if (hasSpawner) return;

            SpawnPersistentObjects();

            hasSpawner = true;
        }

        private void SpawnPersistentObjects()
        {
            GameObject persistentObject = Instantiate(persistentObjectPrefab);

            DontDestroyOnLoad(persistentObject);
        }
    }
}
