﻿using System.Collections;
using UnityEngine;

namespace Assets
{
    public class Main : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
            GameManager.Instance.a = 5;
        }

        // Update is called once per frame
        void Update()
        {
            Debug.Log( GameManager.Instance.a );
        }
    }
}