﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initializer : MonoBehaviour
{
    [SerializeField] RuntimeData _runtimeData;
    void Start()
    {
        _runtimeData._activeCubes.Clear();
    }

}
