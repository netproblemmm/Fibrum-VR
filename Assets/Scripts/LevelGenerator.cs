﻿using UnityEngine;
using System.Collections.Generic;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private List<Transform> _segments;
    [SerializeField] private float _minDistance;
    [SerializeField] private Transform _player;

    void Update()
    {
        Transform lastobj = _segments[_segments.Count - 1];
        float dis = Vector3.Distance(lastobj.position, _player.position);

        if (dis < _minDistance)
        {
            Transform firstObj = _segments[0];
            firstObj.position = lastobj.position;

            Vector3 offset = lastobj.GetComponent<Collider>().bounds.extents + firstObj.GetComponent<Collider>().bounds.extents;
            firstObj.position += Vector3.forward * offset.z;

            _segments.Remove(firstObj);
            _segments.Add(firstObj);
        }
    }
}
