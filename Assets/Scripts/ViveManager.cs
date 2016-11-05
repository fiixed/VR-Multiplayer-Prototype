using UnityEngine;
using System.Collections;

public class ViveManager : MonoBehaviour {

    public GameObject head;
    public GameObject lefthand;
    public GameObject righthand;

    public static ViveManager Instance;

    void Awake() {
        if (Instance == null) {
            Instance = this;
        }
    }

    void OnDestroy() {
        if (Instance == this) {
            Instance = null;
        }
    }

}
