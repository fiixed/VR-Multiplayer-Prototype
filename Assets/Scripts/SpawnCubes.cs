using UnityEngine;
using System.Collections;

public class SpawnCubes : MonoBehaviour {

    public GameObject cubePrefab;
	
	// Update is called once per frame
	void Update () {
        var lDevice = SteamVR_Controller.Input((int)ViveManager.Instance.lefthand.GetComponent<SteamVR_TrackedObject>().index);
        var rDevice = SteamVR_Controller.Input((int)ViveManager.Instance.righthand.GetComponent<SteamVR_TrackedObject>().index);

        if (lDevice.GetTouchDown(SteamVR_Controller.ButtonMask.Trigger)) {
            PhotonNetwork.Instantiate(cubePrefab.name, ViveManager.Instance.lefthand.transform.position, ViveManager.Instance.lefthand.transform.rotation, 0);
        }

        if (rDevice.GetTouchDown(SteamVR_Controller.ButtonMask.Trigger)) {
            PhotonNetwork.Instantiate(cubePrefab.name, ViveManager.Instance.righthand.transform.position, ViveManager.Instance.righthand.transform.rotation, 0);
        }
    }
}
