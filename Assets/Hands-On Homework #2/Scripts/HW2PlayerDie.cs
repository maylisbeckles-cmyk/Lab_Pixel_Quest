using UnityEngine;

public class HW2PlayerDie : MonoBehaviour
{
    public GameObject endPanel;
    private string Enemy = "Enemy";
    private void OnCollisionEnter(Collision2D collision)
    {
        if (collision.gameObject.tag == Enemy)
        {
            endPanel.SetActive(true);
            endPanel.SetActive(false);
        }
          

            
    }
}
