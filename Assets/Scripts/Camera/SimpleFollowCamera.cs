using UnityEngine;

namespace Camera
{
    public class SimpleFollowCamera : MonoBehaviour
    {
        private Transform target;
        
        public void SetTarget(Transform newTarget)
        {
            target = newTarget;
        }
        
        private void LateUpdate()
        {
            if (target)
            {
                transform.position = target.position;
            }
        }
    }
}