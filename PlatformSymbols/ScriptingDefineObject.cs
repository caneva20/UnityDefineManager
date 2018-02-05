using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu]
[SuppressMessage("ReSharper", "NotAccessedField.Local")]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public class ScriptingDefineObject : ScriptableObject
{
	[SerializeField]
	BuildTargetGroup m_BuildTarget;

	[SerializeField]
	string[] m_Defines;

	[SerializeField]
	bool m_IsApplied;

}