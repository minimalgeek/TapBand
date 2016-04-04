using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class BoosterDraggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

	public int TokenCost;
//	public Transform parentToReturnTo = null;
//	public Transform defaultParent = null;
	private bool BoosterisActive;
	private BoosterDropZone boosterDropzone;
	public Vector3 basePosition;

	public void Awake(){
		boosterDropzone = GameObject.Find ("BoosterDropZone").GetComponent<BoosterDropZone>();
		if (boosterDropzone.tokenNumber > TokenCost) {
			BoosterisActive = true;
		} else {
			BoosterisActive = false;
		}

	}

	public void Start(){
	    basePosition = GetComponent<RectTransform>().localPosition;
		//Debug.Log (basePosition);
		//defaultParent = this.transform.parent;
	}

	public void Update(){
		if (boosterDropzone.tokenNumber >= TokenCost) {
			BoosterisActive = true;
		} else {
			BoosterisActive = false;
		}
	}

	public void OnBeginDrag(PointerEventData eventData){
		//Debug.Log ("onbegindrag");
		Color color = new Vector4(0.5f,0.5f,0.5f,0.6f);
		boosterDropzone.setColor (color);
		if (BoosterisActive){
		//parentToReturnTo = this.transform.parent;
		this.transform.SetParent (this.transform.parent.parent);
		GetComponent<CanvasGroup> ().blocksRaycasts = false;
		}
	}

	public void OnDrag(PointerEventData eventData){
		//Debug.Log (eventData.position);
		if (BoosterisActive) {
			this.transform.position = eventData.position;
		}
	}

	public void OnEndDrag(PointerEventData eventData){
		//Debug.Log ("Onenddrag");
		Color color = new Vector4(0f,0f,0f,0f);
		boosterDropzone.setColor (color);
		if (BoosterisActive) {
			//this.transform.SetParent (parentToReturnTo);
			GetComponent<CanvasGroup> ().blocksRaycasts = true;
		}
	}

	public bool IsActive(){
		return BoosterisActive;
	}
}
