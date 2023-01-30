using UnityEngine;

public class GestionCoins : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
        Counter.Instance.CollectMoney(other.gameObject);
    }
    
    void Update () 
    {
        transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
    }
}
