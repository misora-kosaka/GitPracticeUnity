using UnityEngine;

namespace GitPracticeUnity
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private float moveSpeed = 5.0f;
        [SerializeField] private float jumpPower = 4.0f;

        public float MoveSpeed => moveSpeed;
        public float JumpPower => jumpPower;

        public void Move(Vector3 direction)
        {
            transform.position += direction * moveSpeed * Time.deltaTime;
        }

        public void Jump()
        {
            Debug.Log($"Jump! power={jumpPower}");
        }
    }
}
