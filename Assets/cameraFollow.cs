
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    [Range(1, 10)]
    public float smoothFactor;
    // Start is called before the first frame update
    private void FixedUpdate()
    {
        if (!target)   //MissingReferenceException: The object of type 'Transform' has been destroyed but you are still trying to access it.
        {                   //Your script should either check if it is null or you should not destroy the object.
            return;
            //GameOver();
        }

        Follow();
    }
    public void Follow()
    {
        Vector3 targetPosition = target.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, targetPosition, smoothFactor * Time.fixedDeltaTime);
        transform.position = targetPosition;
    }

    /*void GameOver()
    {

    }*/

}
