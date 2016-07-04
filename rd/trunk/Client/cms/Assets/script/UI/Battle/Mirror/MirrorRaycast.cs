using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MirrorRaycast : MonoBehaviour 
{

	// Use this for initialization
	void Start () {
	
	}


	public List<MirrorTarget> WeakpointRayCast(Vector2 startPos)
	{
		List<MirrorTarget> returnList = new List<MirrorTarget> ();
		List<GameUnit> listEnemy = BattleController.Instance.BattleGroup.EnemyFieldList;

		GameUnit subUnit = null;
		for (int i =0; i< listEnemy.Count; ++i)
		{
			subUnit = listEnemy [i];
			if (null == subUnit) 
			{
				continue;
			}
			MirrorTarget bestTarget = null;
			List<MirrorTarget> listFind  = RaycastFromAllWeakpoint(subUnit,startPos,GameConfig.Instance.MirrorRadius, out bestTarget);
			returnList.AddRange(listFind);
		}
		return returnList;
	}

	public static	MirrorTarget RaycastCanAttackWeakpoint( GameUnit gameUnit,Vector2 uiPos,float maxDistance)
	{
		Dictionary<string,GameObject> weakpointDumpDic = new Dictionary<string, GameObject> ();
		List<string> attackWpList = WeakPointController.Instance.GetCanAttackWeakpointList (gameUnit);
		if (null != attackWpList)
		{
			foreach(string subWp in attackWpList)
			{
				weakpointDumpDic.Add(subWp, gameUnit.weakPointDumpDic[subWp]);
			}
		}
		MirrorTarget bestTarget = null;
		RaycastWeakPoint (gameUnit, uiPos, maxDistance, weakpointDumpDic,out bestTarget);
		return bestTarget;
	}

	public static	List<MirrorTarget> RaycastFromAllWeakpoint(GameUnit gameUnit, Vector2 uiPos, float maxDistance,out MirrorTarget bestTarget)
	{
		Dictionary<string,GameObject> weakpointDumpDic = gameUnit.weakPointDumpDic;

		return RaycastWeakPoint (gameUnit, uiPos, maxDistance, weakpointDumpDic,out bestTarget);
	}

	private  static	List<MirrorTarget> RaycastWeakPoint(GameUnit gameUnit,Vector2 uiPos,float maxDistance,Dictionary<string,GameObject> weakpointDumpDic,out MirrorTarget bestTarget)
	{
		List<MirrorTarget> allFindTarget  = new List<MirrorTarget>();
		bestTarget = null;
		GameObject subWeakpointObj = null;
		foreach(KeyValuePair<string,GameObject> subWeak in weakpointDumpDic)
		{
			WeakPointRuntimeData wpHp = null;
			if(gameUnit.wpHpList.TryGetValue(subWeak.Key, out wpHp))
			{
				if(wpHp.hp < 1)
				{
					continue;
				}
			}

			subWeakpointObj = subWeak.Value;
			Vector2	dumpPos = RectTransformUtility.WorldToScreenPoint(BattleCamera.Instance.CameraAttr,subWeakpointObj.transform.position);
			float distane = Vector2.Distance(uiPos,dumpPos);
			if(distane < maxDistance)
			{
				MirrorTarget mTarget = subWeakpointObj.GetComponent<MirrorTarget>();
				mTarget.DistanceToMirror = distane;
				if(bestTarget == null)
				{
					bestTarget = mTarget;
				}
				else
				{
					if(mTarget.DistanceToMirror < bestTarget.DistanceToMirror)
					{
						bestTarget = mTarget;
					}
				}
				allFindTarget.Add(mTarget);
			}
		}
		 
		return allFindTarget;
	}
}
