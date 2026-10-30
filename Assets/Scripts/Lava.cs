using UnityEngine;

public class Lava : MonoBehaviour
{
    [SerializeField] string shaderToggle = "_LightToggle";
    public Material mat;

    private void Start()
    {
        mat.SetFloat(shaderToggle, 0.0f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            mat.SetFloat(shaderToggle, 1.0f);
            Debug.Log(shaderToggle);
        }
    }
}
