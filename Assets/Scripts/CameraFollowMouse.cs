using UnityEngine;

public class CameraFollowMouse : MonoBehaviour
{
    [SerializeField] private float _panSpeed = 25f;
    [SerializeField] private float _panBorderThickness = 10f;
    [SerializeField] private GameObject _leftBorder;
    [SerializeField] private GameObject _rightBorder;

    private void Update()
    {
        Vector3 pos = transform.position;

        if (Input.mousePosition.x >= Screen.width - _panBorderThickness)
            pos.x += _panSpeed * Time.deltaTime;

        if (Input.mousePosition.x <= _panBorderThickness)
            pos.x -= _panSpeed * Time.deltaTime;

        pos.x = Mathf.Clamp(pos.x, _leftBorder.transform.position.x, _rightBorder.transform.position.x);
        transform.position = pos;
    }
}
