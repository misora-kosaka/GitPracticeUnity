using UnityEngine;

namespace GitPracticeUnity
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private int score;

        public int Score => score;

        public void AddScore(int value)
        {
            score += value;
            Debug.Log($"Score: {score}");
        }

        public void RestartGame()
        {
            score = 0;
            Debug.Log("Game restarted.");
        }
    }
}
