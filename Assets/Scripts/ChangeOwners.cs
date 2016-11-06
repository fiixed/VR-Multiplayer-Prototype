using UnityEngine;
using System.Collections;
using System;
using VRTK;

public class ChangeOwners : Photon.MonoBehaviour {

    public VRTK.VRTK_InteractableObject toss;

	// Use this for initialization
	void Start () {
        toss.InteractableObjectGrabbed += Toss_InteractableObjectGrabbed;
        StartCoroutine(Pop());
	}

    private IEnumerator Pop() {
        yield return new WaitForSeconds(10f);
        PhotonNetwork.Destroy(this.gameObject);
    }

    private void Toss_InteractableObjectGrabbed(object sender, InteractableObjectEventArgs e) {
        toss.GetComponent<PhotonView>().TransferOwnership(PhotonNetwork.player.ID);
    }

  
}
