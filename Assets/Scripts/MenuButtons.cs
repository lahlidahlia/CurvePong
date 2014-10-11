using UnityEngine;
using System.Collections;

public class MenuButtons : MonoBehaviour {

    public Sprite defaultSprite;
    public Sprite onHoverSprite;
    public string switch_to_room; //The room name to switch to
    private SpriteRenderer spriteRenderer;
    // Use this for initialization
    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = defaultSprite;
    }

    // Update is called once per frame
    void Update() {

    }

    void OnMouseOver() {
        spriteRenderer.sprite = onHoverSprite;
    }
    void OnMouseExit() {
        spriteRenderer.sprite = defaultSprite;
    }
    void OnMouseDown() {
        Application.LoadLevel(switch_to_room);  
    }
}
