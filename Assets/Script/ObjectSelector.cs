using System.Collections;
using UnityEngine;
using UnityEngine.VR;
using VRStandardAssets.Utils;

namespace Common.Selector
{
	public class ObjectSelector : MonoBehaviour {

		[SerializeField] private VREyeRaycaster m_EyeRaycaster;                         // Used to detect if the raycaster is on something
		[SerializeField] private VRInput m_VRInput;                                     // Used to tell if the user triggered the button
		[SerializeField] private GameObject m_SelectedGameObject;                               // Store selected object

		// OnEnable
		private void OnEnable ()
		{
			m_VRInput.OnDown += HandleDown;
		}

		// OnDisable
		private void OnDisable ()
		{
			m_VRInput.OnDown -= HandleDown;
		}

		private void HandleDown ()
		{

			m_SelectedGameObject = m_EyeRaycaster.GetCurrentlySelected;
			if (m_SelectedGameObject != null) 
			{
				Debug.Log (m_SelectedGameObject);
				Destroy (m_SelectedGameObject);
			} 
			else 
			{
				// TODO : Print a message on UI to warn user to aim a gameobject 
			}

		}

	}
}
