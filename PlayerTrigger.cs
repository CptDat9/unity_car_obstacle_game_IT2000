using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
    private bool gameIsOver = false;

    private void Update()
    {
        if (!gameIsOver)
        {
            // Di chuyển Player bằng chuột
            this.transform.position += new Vector3(Input.GetAxis("Mouse X"), 0, 0.3f);
            Camera.main.transform.position += new Vector3(0, 0, 0.3f);

            // Kiểm tra kết thúc trò chơi khi Player đạt đích
            if (transform.position.z >= 1000f)
            {
                WinGame();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!gameIsOver)
        {
            if (other.CompareTag("Enemy"))
            {
                LoseGame();
            }
        }
    }

    private void WinGame()
    {
        gameIsOver = true;
        Debug.Log("Thắng cuộc!"); // In ra console thông báo thắng cuộc
    }

    private void LoseGame()
    {
        gameIsOver = true;
        Debug.Log("Thua cuộc!"); // In ra console thông báo thua cuộc
    }
}