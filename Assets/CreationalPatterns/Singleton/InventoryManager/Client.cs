using UnityEngine;
using UnityEngine.SceneManagement;

namespace Pattern.Singleton
{
    public class Client : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                GameManager.Instance.InitializeGame();
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                InventoryManager.Instance.AddItem(001);
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                InventoryManager.Instance.RemoveItem(023);
            }

            if (Input.GetKeyDown(KeyCode.Q))
            {
                SceneManager.LoadScene(0);
            }
        }

        void OnGUI()
        {
            GUI.color = Color.white;
            GUI.Label(new Rect(10, 10, 300, 30), "Press I to initialize the game.");
            GUI.Label(new Rect(10, 30, 300, 30), "Press A to add an item to the inventory.");
            GUI.Label(new Rect(10, 50, 300, 30), "Press R to remove an item to the inventory.");
            GUI.Label(new Rect(10, 70, 300, 30), "Press Q to reload scene.");
            GUI.Label(new Rect(10, 100, 500, 30), "Output of the commands are displayed in the console.");
        }
    }
}