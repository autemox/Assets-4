using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;

#if UNITY_EDITOR
using UnityEditor;
#endif

[ExecuteAlways]
public class BillboardEffect : MonoBehaviour
{
    [NonSerialized] public Camera targetCamera;
    [SerializeField] private Vector3 offsetAlongPlane = Vector3.zero;

    void OnEnable()
    {
        SetTargetCamera();
    }

    void Update()
    {
        SetTargetCamera();
        ApplyBillboard();
    }

    void OnValidate()
    {
        ApplyBillboard();
    }

    private void SetTargetCamera()
    {
        if (targetCamera != null) return;

        if (Application.isPlaying)
        {
            targetCamera = Camera.main;
        }
#if UNITY_EDITOR
        else if (SceneView.lastActiveSceneView != null)
        {
            targetCamera = SceneView.lastActiveSceneView.camera;
        }
#endif
    }

    private void ApplyBillboard()
    {
        if (targetCamera == null) return;

        // Face camera
        transform.forward = -targetCamera.transform.forward;

        // Apply local offset
        transform.localPosition = offsetAlongPlane;
    }
}