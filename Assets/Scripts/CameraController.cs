
using UnityEngine;

public class CameraController : MonoBehaviour 
{
    [SerializeField] private float speed;
    private Vector3 velocity = Vector3.zero;

    private void Update()
    {
        transform.position = Vector3.SmoothDamp()
    }


}