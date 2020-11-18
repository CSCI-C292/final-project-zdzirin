using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "New RuntimeData")]

public class RuntimeData : ScriptableObject
{
    // Materials for cube for easy swapping : )
    [SerializeField] public Material _activeMaterial;
    [SerializeField] public Material _inactiveMaterial;

}