using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineDrawer : MonoBehaviour
{
    private LineRenderer _lineRenderer;
    private Vector2 _mousePosition;
    private Vector2 _startMousePosition;
    private float _distance;

    public Text distanceText;

    void Start()
    {
        _lineRenderer = GetComponent<LineRenderer>();
        _lineRenderer.positionCount = 2;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _startMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        if (Input.GetMouseButton(0))
        {
            _mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            _lineRenderer.SetPosition(0, new Vector3(_startMousePosition.x, _startMousePosition.y, 0f));
            _lineRenderer.SetPosition(1, new Vector3(_mousePosition.x, _mousePosition.y, 0f));
            _distance = (_mousePosition - _startMousePosition).magnitude;
            distanceText.text = _distance.ToString("F2") + "meters";
        }
    }
}
