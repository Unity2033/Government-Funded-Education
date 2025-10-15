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
        // 장면이 준비된 즉시 장면이 활성화되는 것을 허용하는 변수입니다.

        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(index);

        asyncOperation.allowSceneActivation = false;

        // <AsyncOperation> 
        // - isDone
        // 해당 동작이 완료되었는 지 나타내는 변수입니다. (읽기 전용)
        while(asyncOperation.isDone == false)
        {
            displayProgress = Mathf.Lerp(displayProgress, asyncOperation.progress, Time.deltaTime);

            // <AsyncOperation>
            // - progress
            // 작업의 진행 상태를 나타내는 변수입니다. (읽기 전용)
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
