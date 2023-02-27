using TMPro;
using UnityEngine;

// Zenject를 사용하지 않고 종속성을 주입
public class Injector : MonoBehaviour
{
    public MyPhone myPhone;
    public EmailService emailService;
    public DMService dmService;

    private void Start()
    {
        myPhone.SetMessageService(dmService);
    }
}