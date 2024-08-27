
using UnityEngine;

public class CameraController : MonoBehaviour
{
   [SerializeField] private float speed; 
   private float currenrtPosX;
   private Vector3 velocity = Vector3.zero;
   
   private void Update Start()
   {
    transform.positon = Vector3.SmoothDamp(transform.position, new Vector3(currenrtPosX, transform.position.y, transform position.z), 
    ref velocity, speed * Time.deltaTime);
   }
   public void MoveToNewRoom(Transform_newRoom)
   {
    currenrtPosX = _MoveToNewRoom.positionx;

   }
}
