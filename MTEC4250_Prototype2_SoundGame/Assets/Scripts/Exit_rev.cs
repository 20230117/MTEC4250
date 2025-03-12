using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Exit_rev : MonoBehaviour
{
    [SerializeField] string tagFilter;

    [SerializeField] UnityEvent onTriggerEnter;

    public AudioSource source_sceneSwitch;
    public AudioClip sceneSwitch;
    void Start()
    {
        source_sceneSwitch.volume = 0.65f;
    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (!string.IsNullOrEmpty(tagFilter) && !other.gameObject.CompareTag(tagFilter)) return;
        source_sceneSwitch.PlayOneShot(sceneSwitch);

        int currentSceneBuildIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneBuildIndex + 1);
    }
}