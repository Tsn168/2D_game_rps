using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
public void OnButtonClick(GameObject buttonObject)
{
Debug.Log(buttonObject.name + " clicked " );
}
}