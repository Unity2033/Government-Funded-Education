using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneryManager : MonoBehaviour
{
    [SerializeField] Slider progress;
    [SerializeField] GameObject screen;
    [SerializeField] float displayProgress;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void Coroutine()
    {
        StartCoroutine(TransitionScene(1));
    }

    public IEnumerator TransitionScene(int index)
    {
        progress.value = 0;
        displayProgress = 0;

        screen.SetActive(true);

        // <AsyncOperation>
        // - allowSceneActivation
        // ����� �غ�� ��� ����� Ȱ��ȭ�Ǵ� ���� ����ϴ� �����Դϴ�.

        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(index);

        asyncOperation.allowSceneActivation = false;

        // <AsyncOperation> 
        // - isDone
        // �ش� ������ �Ϸ�Ǿ��� �� ��Ÿ���� �����Դϴ�. (�б� ����)
        while(asyncOperation.isDone == false)
        {
            displayProgress = Mathf.Lerp(displayProgress, asyncOperation.progress, Time.deltaTime);

            // <AsyncOperation>
            // - progress
            // �۾��� ���� ���¸� ��Ÿ���� �����Դϴ�. (�б� ����)
            if(asyncOperation.progress >= 0.9f)
            {
                displayProgress = Mathf.Lerp(displayProgress, 1.0f, Time.deltaTime);

                if(displayProgress >= 0.99f)
                {
                    asyncOperation.allowSceneActivation = true;
                }
            }

            progress.value = displayProgress;

            yield return null;  
        }

        screen.SetActive(false);
    }
}
