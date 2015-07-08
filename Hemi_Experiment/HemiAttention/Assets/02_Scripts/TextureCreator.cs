using UnityEngine;
using System.Collections;

public class TextureCreator : MonoBehaviour {

	public int resolution = 256;
	private Texture2D texture;

	SerializePrivateVariables void Awake (){
		texture = new Texture2D (resolution, resolution, TextureFormat.RGB24, true);
		Texture.name = "Procedural Texture";
		GetComponent<Mesh>

	}