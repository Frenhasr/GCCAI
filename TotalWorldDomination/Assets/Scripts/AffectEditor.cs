using UnityEngine;
using System.Collections;
using UnityEditor;


[CustomEditor (typeof(Affects))]
public class AffectEditor : Editor
{


	private SerializedObject affectTarget;

	#region Character Identity

	private SerializedProperty characterName;
	private SerializedProperty characterAge;
	private SerializedProperty characterGender;
	public GENDER gender;

	#endregion

	#region Needs

	private SerializedProperty friendship;
	private SerializedProperty enmity;
	private SerializedProperty competition;
	private SerializedProperty lust;
	private SerializedProperty greed;
	private SerializedProperty mentorship;

	#endregion

	#region Affects

	private SerializedProperty boredomToInterest;
	private SerializedProperty sadToJoy;
	private SerializedProperty supriseToCalm;
	private SerializedProperty distressToAmused;
	private SerializedProperty angerToCheers;
	private SerializedProperty disgustToLove;
	private SerializedProperty shameToPride;
	private SerializedProperty fearToHope;

	#endregion

	#region Affect Multipliers

	private SerializedProperty boredom;
	private SerializedProperty interest;
	private SerializedProperty sadness;
	private SerializedProperty enjoyment;
	private SerializedProperty surprise;
	private SerializedProperty calm;
	private SerializedProperty distress;
	private SerializedProperty amusement;
	private SerializedProperty anger;
	private SerializedProperty cheer;
	private SerializedProperty disgust;
	private SerializedProperty love;
	private SerializedProperty shame;
	private SerializedProperty pride;
	private SerializedProperty fear;
	private SerializedProperty hope;

	#endregion

	#region Editor Bools

	protected static bool showIdentity;
	protected static bool showNeeds;
	protected static bool showAffect;
	protected static bool showMultiplier;
	protected static bool showTraits;

	#endregion

	public void OnEnable ()
	{

		affectTarget = new SerializedObject (target);

		characterName = affectTarget.FindProperty ("characterName");
		characterAge = affectTarget.FindProperty ("characterAge");
		//characterGender = affectTarget.FindProperty ("gender");

		#region Find Need Properties
		friendship = affectTarget.FindProperty ("friendship");
		enmity = affectTarget.FindProperty ("enmity");
		competition = affectTarget.FindProperty ("competition");
		lust = affectTarget.FindProperty ("lust");
		greed = affectTarget.FindProperty ("greed");
		mentorship = affectTarget.FindProperty ("mentorship");
		#endregion

		#region Find Affect Properties
		boredomToInterest = affectTarget.FindProperty ("boredomToInterest");
		sadToJoy = affectTarget.FindProperty ("sadToJoy");
		supriseToCalm = affectTarget.FindProperty ("supriseToCalm");
		distressToAmused = affectTarget.FindProperty ("distressToAmused");
		angerToCheers = affectTarget.FindProperty ("angerToCheers");
		disgustToLove = affectTarget.FindProperty ("disgustToLove");
		shameToPride = affectTarget.FindProperty ("shameToPride");
		fearToHope = affectTarget.FindProperty ("fearToHope");
		#endregion
			
		#region Find Affect Mulitpliers
		boredom = affectTarget.FindProperty ("boredom");
		interest = affectTarget.FindProperty ("interest");
		sadness = affectTarget.FindProperty ("sadness");
		enjoyment = affectTarget.FindProperty ("enjoyment");
		surprise = affectTarget.FindProperty ("surprise"); 
		calm = affectTarget.FindProperty ("calm");
		distress = affectTarget.FindProperty ("distress");
		amusement = affectTarget.FindProperty ("amusement");
		anger = affectTarget.FindProperty ("anger");
		cheer = affectTarget.FindProperty ("cheer");
		disgust = affectTarget.FindProperty ("disgust");
		love = affectTarget.FindProperty ("love");
		shame = affectTarget.FindProperty ("shame");
		pride = affectTarget.FindProperty ("pride");
		fear = affectTarget.FindProperty ("fear");
		hope = affectTarget.FindProperty ("hope");
		#endregion



	}

	public override void OnInspectorGUI ()
	{
		#region Show Identity
		showIdentity = EditorGUILayout.Foldout (showIdentity, "Identity");
		if (showIdentity) {
			EditorGUILayout.PropertyField (characterName);
			EditorGUILayout.PropertyField (characterAge);
			gender = (GENDER)EditorGUILayout.EnumPopup ("Gender", gender);
		}
		#endregion




		#region Show Needs
		showNeeds = EditorGUILayout.Foldout (showNeeds, "Needs");
		if (showNeeds) {
			EditorGUILayout.PropertyField (friendship);
			EditorGUILayout.PropertyField (enmity);
			EditorGUILayout.PropertyField (competition);
			EditorGUILayout.PropertyField (lust);
			EditorGUILayout.PropertyField (greed);
			EditorGUILayout.PropertyField (mentorship);
		}
		#endregion


		#region Show Affect
		showAffect = EditorGUILayout.Foldout (showAffect, "Affects");

		if (showAffect) {
			EditorGUILayout.PropertyField (boredomToInterest);
			EditorGUILayout.PropertyField (sadToJoy);
			EditorGUILayout.PropertyField (supriseToCalm);
			EditorGUILayout.PropertyField (distressToAmused);
			EditorGUILayout.PropertyField (shameToPride);
			EditorGUILayout.PropertyField (fearToHope);
		
		}
		#endregion


		#region Show Affect Multiplier
		showMultiplier = EditorGUILayout.Foldout (showMultiplier, "Affect Multipliers");

		if (showMultiplier) {
			EditorGUILayout.PropertyField (boredom);
			EditorGUILayout.PropertyField (interest);
			EditorGUILayout.PropertyField (sadness);
			EditorGUILayout.PropertyField (enjoyment);
			EditorGUILayout.PropertyField (surprise);
			EditorGUILayout.PropertyField (calm);
			EditorGUILayout.PropertyField (distress);
			EditorGUILayout.PropertyField (amusement);
			EditorGUILayout.PropertyField (anger);
			EditorGUILayout.PropertyField (cheer);
			EditorGUILayout.PropertyField (disgust);
			EditorGUILayout.PropertyField (love);
			EditorGUILayout.PropertyField (shame);
			EditorGUILayout.PropertyField (pride);
			EditorGUILayout.PropertyField (fear);
			EditorGUILayout.PropertyField (hope);


		}
		#endregion


		#region Character Traits
		showTraits = EditorGUILayout.Foldout (showTraits, "Character Traits");

		if (showTraits) {

		}
		#endregion



	}


}

