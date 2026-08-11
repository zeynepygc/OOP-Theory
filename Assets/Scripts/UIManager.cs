using UnityEngine;
using TMPro; 
using System.Collections;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    
    [SerializeField] private TextMeshProUGUI blessingText;
    
    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }
    
    void Start()
    {
        blessingText.text = "";
    }
    
    public void ShowBlessingSequence(string[] messages, float delayBetween)
    {
        StartCoroutine(DisplaySequence(messages, delayBetween));
    }
    
    private IEnumerator DisplaySequence(string[] messages, float delay)
    {
        foreach (string message in messages)
        {
            blessingText.text = message;
            yield return new WaitForSeconds(delay);
        }
        
        // Clear after last message
        yield return new WaitForSeconds(delay);
        blessingText.text = "";
    }
}