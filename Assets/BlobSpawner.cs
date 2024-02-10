using UnityEngine;

public class BlobSpawner : MonoBehaviour
{
    public GameObject blobPrefab; // Arraste seu prefab de Blob aqui através do Inspector da Unity

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 10.0f; // Exemplo de profundidade de 10 unidades à frente da câmera

            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePos);
            Instantiate(blobPrefab, worldPosition, Quaternion.identity);
        }
    }
}
