using UnityEngine;
using System.Collections;

public class CopyScript : Photon.MonoBehaviour {

    public int index  = 1;
	
	// Update is called once per frame
	void Update () {
        if (photonView.isMine) {
            switch (index) {
                case 1: //head
                    transform.position = ViveManager.Instance.head.transform.position;
                    transform.rotation = ViveManager.Instance.head.transform.rotation;
                    break;
                case 2: //left
                    transform.position = ViveManager.Instance.lefthand.transform.position;
                    transform.rotation = ViveManager.Instance.lefthand.transform.rotation;
                    break;
                case 3: //right
                    transform.position = ViveManager.Instance.righthand.transform.position;
                    transform.rotation = ViveManager.Instance.righthand.transform.rotation;
                    break;
                default:
                    break;
            }
        }
	}
}
