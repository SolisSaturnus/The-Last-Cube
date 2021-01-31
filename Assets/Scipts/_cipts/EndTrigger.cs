
using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public GameManager1 gameManager1;
    private void OnTriggerEnter()
    {
        gameManager1.Completelevel();
    }
}
