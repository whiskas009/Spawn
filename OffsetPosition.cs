using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffsetPosition : MonoBehaviour
{
    [SerializeField] private int _heightAdjustment;

    private void OnEnable()
    {
        transform.Translate(Vector2.up * _heightAdjustment);
    }
}
