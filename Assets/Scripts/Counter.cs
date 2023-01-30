using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class Counter : MonoBehaviour
{
    public TextMeshProUGUI tet;
    public GameObject winDisplay;
    public GameObject coin;
    
    public static Counter Instance;

    private int _totalmoney;
    private int _count = 0;

    private void Awake()
    {
        if (Instance != null && Instance != this)
            Destroy(this); 
        
        else
            Instance = this;
    }
    
    private void Start()
    {
        _totalmoney = coin.transform.childCount;
        UpdateText();
    }


    private void OnWin(GameObject player)
    {
        winDisplay.SetActive(true);
        player.GetComponent<PlayerInput>().DeactivateInput();
        
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        GetComponent<Rigidbody>().angularVelocity = Vector3.zero; 
    }
    
    public void CollectMoney(GameObject player)
    {
        _count++;
        UpdateText();

        if (_count == _totalmoney)
            OnWin(player);
    }
    
    private void UpdateText()
    {
        tet.text = _count + " / " + _totalmoney;
    }
}
