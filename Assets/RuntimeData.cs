using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "New RuntimeData")]

public class RuntimeData : ScriptableObject
{
    // Materials for cube for easy swapping : )
    [SerializeField] public Material _activeMaterial;
    [SerializeField] public Material _inactiveMaterial;
    [SerializeField] public Material _indicatorMaterial;
    [SerializeField] public List<string> _solveCubes;
    [SerializeField] public List<string> _activeCubes;

    [SerializeField] public string _levelName;

    public bool _solved = false;

    public bool _showingSolution = false;

}