using UnityEngine;

public class Robot : MonoBehaviour
{
    public Ability ability;

    private void Awake()
    {
        // Awake : ��ü�� ������ �� ȣ��Ǹ�, ��ü�� ��Ȱ��ȭ�Ǿ� ���� ������
        //         ȣ��ǰ�, �� �� ���� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
        Debug.Log("Awake");      

        ability = new Ability();
    }

    private void OnEnable()
    {
        // OnEnable : ��ü�� Ȱ��ȭ�Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
        Debug.Log("OnEnable");
    }

    void Start()
    {
        // Start : ��ü�� �����Ǿ��� �� ȣ��Ǹ�, �� �� ���� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
        Debug.Log("Start");
    }

    private void FixedUpdate()
    {
        // FixedUpdate : Time Step�� ������ ���� ���� ������ �������� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
        Debug.Log("Fixed Update");
    }

    void Update()
    {
        // Update : ��ü�� Ȱ��ȭ�Ǵ� ����, �� �����Ӹ��� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
        Debug.Log("Update");
    }

    private void LateUpdate()
    {
        // LateUpdate : �� �������� ������ �ܰ迡�� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
        Debug.Log("Late Update");
    }
}
