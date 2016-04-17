using UnityEngine;
using System.Collections;

public class ACheeseHud : MonoBehaviour {

	public GameObject cheesePac;
	public GameObject cheeseSlice;
	public GameObject cheeseWheel;
	public GameObject cheeseWedge;
	public GameObject cheeseSwiss;
    //public Sprite sprite;
    public int rando;

	// Use this for initialization
	void Start () {
		SwapCheese ("slice");
		//GetComponent(SpriteRenderer).sprite = Slice;
		//GameObject go = new GameObject("CheesePac");
		//SpriteRenderer renderer = go.AddComponent<SpriteRenderer>();
		//renderer.sprite = sprite;
	}

    // Update is called once per frame
    void Update() {
        rando = Random.Range(1, 200);
        //Debug.Log(rando);
        switch (rando) {
            case 1:
                SwapCheese("pac");
                break;
            case 2:
                SwapCheese("slice");
                break;
            case 3:
                SwapCheese("wedge");
                break;
            case 4:
                SwapCheese("swiss");
                break;
            case 5:
                SwapCheese("wheel");
                break;
        }
    }

	void SwapCheese(string cheeseType){
		cheesePac.SetActive(false);
		cheeseSlice.SetActive(false);
		cheeseWheel.SetActive(false);
		cheeseWedge.SetActive(false);
		cheeseSwiss.SetActive(false);

		switch (cheeseType) {
		case "pac":
			cheesePac.SetActive (true);
			break;
		case "slice":
			cheeseSlice.SetActive(true);
			break;
		case "wedge":
			cheeseWedge.SetActive(true);
			break;
		case "wheel":
			cheeseWheel.SetActive(true);
			break;
		case "swiss":
			cheeseSwiss.SetActive(true);
			break;
		default:
			break;
		}
	}
}
