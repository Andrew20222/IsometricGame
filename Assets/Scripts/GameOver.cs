using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private PlayerAttack _player;
    private Monster _monster;
    [SerializeField] private GameObject gameOver;

    private void Start()
    {
        _player = FindObjectOfType<PlayerAttack>();
        _monster = FindObjectOfType<Monster>();
    }
    private void Update()
    {
        if(_player.CountPoint > 0 || _monster.CountPoint > 0)
        {
            gameOver.SetActive(true);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
