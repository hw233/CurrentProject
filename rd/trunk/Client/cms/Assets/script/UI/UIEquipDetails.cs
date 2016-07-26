﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
public enum EquipState
{
    show,
    showGem,
    hide
}
public interface IEquipCallBack
{
    void Reinforced(EquipData data);
    void Inlay(EquipData data);
    void Unload();//卸载
    void Replacement(GameUnit unit,int equipPart);//换装
}

public class UIEquipDetails : MonoBehaviour
{
    //界面
    public Text equipTypeTip;
    public Text equipPowerTip;
    public Text equipLimitTip;
    public Text attributeTextTip;
    public Text gemTextTip;
    public Text gemPromptTip;
    public Text equipUninstallTip;
    public Text equipInstallTip;
    public Text StrengthenTip;
    public Text gemSetTip;


    public IEquipCallBack equipCallBack;
    public Text equipNmae;//装备名称 
    public Text strengthenNum;//装备强化
    public Text equipType;//装备类型
    public Text equipPart;//装备部位
    public Text equipPower;//战斗力
    public Text lvLimit;//装备等级限制
    public GameObject equipOperation;
    public GameObject equipOperation1;
    public GameObject[] basicsAttribute;//基础属性列表
    public Text[] basicsAttributeNum;
    public Text[] basicsAttributePlusNum;
    public GameObject gemPrompt;//宝石提示
    public GameObject[] gemAttribute;//宝石
    GameObject gemName;//宝石名
    GameObject[] gemAttrList = new GameObject[2];
    string[] part = new string[6] { "equip_Weapon", "equip_Waist", "equip_Armor", "equip_Bracelet", "equip_Ring", "equip_Amulet" };
    string[] equipTypeId = new string[4] { "common_type_defence", "common_type_physical", "common_type_magic", "common_type_support" };
    public GameObject reinforcedButton;//强化
    public GameObject inlayButton;//镶嵌
    public GameObject unloadButton;//卸下
    public GameObject reloadButton;//更换
    EquipData equipDate;
    GameUnit unitDate;
    ItemStaticData itemData;
    public static UIEquipDetails CreateEquip()
    {
        GameObject equip = ResourceMgr.Instance.LoadAsset("equipDetails");
        return equip.GetComponent<UIEquipDetails>();
    }
    public void Show(EquipData equip, GameUnit unit, EquipState Type)
    {
        Hide();
        int w = 0;
        if (Type == EquipState.show)
        {
            equipOperation.SetActive(true);
            equipOperation1.SetActive(true);
        }
        else if (Type == EquipState.showGem)
        {
            equipOperation.SetActive(false);
            equipOperation1.SetActive(true);
        }
        else if (Type == EquipState.hide)
        {
            equipOperation.SetActive(false);
            equipOperation1.SetActive(false);
        }
        equipDate = equip;
        unitDate = unit;
        itemData = StaticDataMgr.Instance.GetItemData(equipDate.equipId);
        equipNmae.text = StaticDataMgr.Instance.GetTextByID(itemData.name);
        equipNmae.color = ColorConst.GetStageTextColor(equip.stage);
        lvLimit.text = itemData.minLevel.ToString();
        if (itemData.part > -1 && itemData.part < 6)//装备超出
            equipPart.text = "<" + StaticDataMgr.Instance.GetTextByID(part[itemData.part]) + ">";

        if (itemData.subType > -1 && itemData.subType < 4)//装备类型超出
            equipType.text = StaticDataMgr.Instance.GetTextByID(equipTypeId[itemData.subType]);

        if (equipDate.level > 0) 
        {
            strengthenNum.enabled = true; 
            strengthenNum.text = "+ " + equipDate.level.ToString();
            strengthenNum.color = ColorConst.GetStageTextColor(equip.stage);
        }
        if (equipDate.health > 0)
        {
            basicsAttribute[w].SetActive(true);
            basicsAttribute[w].GetComponent<Text>().text = StaticDataMgr.Instance.GetTextByID("common_attr_health");
            basicsAttributeNum[w].text = equipDate.health.ToString();
            if (equipDate.level > 0)
            {
                basicsAttributePlusNum[w].enabled = true;
                basicsAttributePlusNum[w].text = "+" + equipDate.healthStrengthen.ToString();
            }
            w++;
        }
        if (equipDate.strength > 0)
        {
            basicsAttribute[w].SetActive(true);
            basicsAttribute[w].GetComponent<Text>().text = StaticDataMgr.Instance.GetTextByID("common_attr_strenth");
            basicsAttributeNum[w].text = equipDate.strength.ToString();
            if (equipDate.level > 0)
            {
                basicsAttributePlusNum[w].enabled = true;
                basicsAttributePlusNum[w].text = "+" + equipDate.strengthStrengthen.ToString();
            }
            ++w;
        }
        if (equipDate.intelligence > 0)
        {
            basicsAttribute[w].SetActive(true);
            basicsAttribute[w].GetComponent<Text>().text = StaticDataMgr.Instance.GetTextByID("common_attr_intelligence");
            basicsAttributeNum[w].text = equipDate.intelligence.ToString();
            if (equipDate.level > 0)
            {
                basicsAttributePlusNum[w].enabled = true;
                basicsAttributePlusNum[w].text = "+" + equipDate.intelligenceStrengthen.ToString();
            }
            w++;
        }
        if (equipDate.defense > 0)
        {
            basicsAttribute[w].SetActive(true);
            basicsAttribute[w].GetComponent<Text>().text = StaticDataMgr.Instance.GetTextByID("common_attr_defence");
            basicsAttributeNum[w].text = equipDate.defense.ToString();
            if (equipDate.level > 0)
            {
                basicsAttributePlusNum[w].enabled = true;
                basicsAttributePlusNum[w].text = "+" + equipDate.defenseStrengthen.ToString();
            }
            w++;
        }
        if (equipDate.speed > 0)
        {
            basicsAttribute[w].SetActive(true);
            basicsAttribute[w].GetComponent<Text>().text = StaticDataMgr.Instance.GetTextByID("common_attr_speed");
            basicsAttributeNum[w].text = equipDate.speed.ToString();
            if (equipDate.level > 0)
            {
                basicsAttributePlusNum[w].enabled = true;
                basicsAttributePlusNum[w].text = "+" + equipDate.speedStrengthen.ToString();
            }
            w++;
        }
        if (equip.stage < 3) //装备品级三阶以下不可镶嵌
        {
            gemPrompt.SetActive(true);
            inlayButton.SetActive(false);
        }
        else
        {
            if (equip.gemList != null && equip.gemList.Count > 0)
            {
                gemPrompt.SetActive(false);
                showGem(equip.stage, null, null, false);
                EquipLevelData gemAttr;
                for (int i = 0; i < equip.gemList.Count; i++)
                {
                    if (equip.gemList[i].gemId == "0")
                    {
                        gemAttribute[i].transform.GetComponent<Image>().enabled = true;
                        gemAttribute[i].transform.FindChild("noKong").gameObject.SetActive(false);
                        gemAttribute[i].transform.FindChild("noGem").gameObject.SetActive(true);
                        gemAttribute[i].transform.FindChild("noGem").GetComponent<Text>().text = StaticDataMgr.Instance.GetTextByID("equip_gem_NotSet");
                    }
                    else
                    {
                        itemData = StaticDataMgr.Instance.GetItemData(equip.gemList[i].gemId);
                        gemAttr = StaticDataMgr.Instance.GetEquipLevelData(itemData.gemId);
                        showGem(0, gemAttr, gemAttribute[i], true);
                    }
                }
            }
            else
            {
                gemPrompt.SetActive(false);
                showGem(equip.stage, null, null, false);
            }
        }        
    }
    void Hide()
    {
        for (int i = 0; i < basicsAttribute.Length; i++)
        {
            basicsAttribute[i].SetActive(false);
            basicsAttributePlusNum[i].enabled = false;                
        }
        for (int i = 0; i < gemAttribute.Length; i++)
        {
            gemAttribute[i].transform.GetComponent<Image>().enabled = false;
            gemAttribute[i].transform.FindChild("gem").gameObject.SetActive(false);
            gemAttribute[i].transform.FindChild("noGem").gameObject.SetActive(false);
            gemAttribute[i].transform.FindChild("noKong").gameObject.SetActive(false);
            gemAttribute[i].transform.FindChild("gemName").gameObject.SetActive(false);
            gemAttribute[i].transform.FindChild("gemAttr1").gameObject.SetActive(false);
            gemAttribute[i].transform.FindChild("gemAttr2").gameObject.SetActive(false);            
            gemAttribute[i].SetActive(false);     
        }        
        strengthenNum.enabled = false;
    }
    void showGem(int equipStage, EquipLevelData gemAttr, GameObject gem, bool isLoad)
    {
    	GameObject noKong;
        if (!isLoad)
        {
            int j = 0;
            //判断装备品级3阶有一个孔,4阶有两个孔,5阶有三个孔,6阶有四个孔
            if (equipStage == 3) j = 1;
            else if (equipStage == 4) j = 2;
            else if (equipStage == 5) j = 3;
            else if (equipStage == 6) j = 4;
            for (int i = 0; i < j; i++)
            {
                gemAttribute[i].SetActive(true);
                noKong = gemAttribute[i].transform.FindChild("noKong").gameObject;
                noKong.gameObject.SetActive(true);
                noKong.GetComponent<Text>().text = StaticDataMgr.Instance.GetTextByID("equip_gem_NotKong");
            }
        }
        else
        {
            noKong = gem.transform.FindChild("noKong").gameObject;            
            noKong.gameObject.SetActive(false);
            gemName = gem.transform.FindChild("gemName").gameObject;
            gemName.gameObject.SetActive(true);
            gem.transform.FindChild("noGem").gameObject.SetActive(false);
            gem.transform.GetComponent<Image>().enabled = true;
            gem.transform.FindChild("gem").gameObject.SetActive(true);
            gemName.GetComponent<Text>().text = StaticDataMgr.Instance.GetTextByID(itemData.name);
            gemName.GetComponent<Text>().color = ColorConst.GetStageTextColor(itemData.grade);
            gemAttrList[0] = gem.transform.FindChild("gemAttr1").gameObject;
            gemAttrList[1] = gem.transform.FindChild("gemAttr2").gameObject;
            int gemNum = 0;
            if (gemAttr.health != 0)
            {
                if (gemNum > 1) return;
                gemAttrList[gemNum].SetActive(true);//属性   +99999
                gemAttrList[gemNum].GetComponent<Text>().text = StaticDataMgr.Instance.GetTextByID("common_attr_health") + "   +" + gemAttr.health;
                gemNum++;
            }
            if (gemAttr.strength != 0)
            {
                if (gemNum > 1) return;
                gemAttrList[gemNum].SetActive(true);
                gemAttrList[gemNum].GetComponent<Text>().text = StaticDataMgr.Instance.GetTextByID("common_attr_strenth") + "   +" + gemAttr.strength;
                gemNum++;
            }
            if (gemAttr.intelligence != 0)
            {
                if (gemNum > 1) return;
                gemAttrList[gemNum].SetActive(true);
                gemAttrList[gemNum].GetComponent<Text>().text = StaticDataMgr.Instance.GetTextByID("common_attr_intelligence") + "   +" + gemAttr.intelligence;
                gemNum++;
            }
            if (gemAttr.defense != 0)
            {
                if (gemNum > 1) return;
                gemAttrList[gemNum].SetActive(true);
                gemAttrList[gemNum].GetComponent<Text>().text = StaticDataMgr.Instance.GetTextByID("common_type_defence") + "   +" + gemAttr.defense;
                gemNum++;
            }
            if (gemAttr.speed != 0)
            {
                if (gemNum > 1) return;
                gemAttrList[gemNum].SetActive(true);
                gemAttrList[gemNum].GetComponent<Text>().text = StaticDataMgr.Instance.GetTextByID("common_attr_speed") + "   +" + gemAttr.speed;
                gemNum++;
            }
        }
    }

    void OnClick(GameObject go)
    {
        if (go.name == reinforcedButton.name)
        {
            equipCallBack.Reinforced(equipDate);  
        }
        else if (go.name == inlayButton.name)
        {
            equipCallBack.Inlay(equipDate);
        }
        else if (go.name == unloadButton.name)
        {
            OnUnloadEquip(equipDate);
        }
        else if (go.name == reloadButton.name)
        {            
           equipCallBack.Replacement(unitDate,itemData.part);
        }
    }

    public void OnUnloadEquip(EquipData equip)
    {
        ItemStaticData itemInfo = StaticDataMgr.Instance.GetItemData(equip.equipId);
            PB.HSEquipMonsterUndress param = new PB.HSEquipMonsterUndress()
            {
                id = equip.id,
            };
            GameApp.Instance.netManager.SendMessage(PB.code.EQUIP_MONSTER_UNDRESS_C.GetHashCode(), param);
    }

    void OnEquipUnloadReturn(ProtocolMessage msg)
    {
        UINetRequest.Close();
        if (msg == null || msg.GetMessageType() == (int)PB.sys.ERROR_CODE)
        {
            return;
        }
        PB.HSEquipMonsterUndressRet result = msg.GetProtocolBody<PB.HSEquipMonsterUndressRet>();
        GameUnit monster = GameDataMgr.Instance.PlayerDataAttr.GetPetWithKey(result.monsterId);
        EquipData equip = GameDataMgr.Instance.PlayerDataAttr.gameEquipData.GetEquip(result.id);
        ItemStaticData itemInfo = StaticDataMgr.Instance.GetItemData(equip.equipId);
        monster.equipList[itemInfo.part] = null;
        equip.monsterId = BattleConst.invalidMonsterID;

        GameEventMgr.Instance.FireEvent(GameEventList.ReloadPetEquipNotify);
        equipCallBack.Unload();
    }

    void OnEnable()
    {
        BindListener();
    }

    void OnDisable()
    {
        UnBindListener();
    }

    void BindListener()
    {
        GameEventMgr.Instance.AddListener<ProtocolMessage>(PB.code.EQUIP_MONSTER_UNDRESS_C.GetHashCode().ToString(), OnEquipUnloadReturn);
        GameEventMgr.Instance.AddListener<ProtocolMessage>(PB.code.EQUIP_MONSTER_UNDRESS_S.GetHashCode().ToString(), OnEquipUnloadReturn);
    }

    void UnBindListener()
    {
        GameEventMgr.Instance.RemoveListener<ProtocolMessage>(PB.code.EQUIP_MONSTER_UNDRESS_C.GetHashCode().ToString(), OnEquipUnloadReturn);
        GameEventMgr.Instance.RemoveListener<ProtocolMessage>(PB.code.EQUIP_MONSTER_UNDRESS_S.GetHashCode().ToString(), OnEquipUnloadReturn);
    }
    
    void Start()
    { 
        EventTriggerListener.Get(reinforcedButton).onClick = OnClick;
        EventTriggerListener.Get(inlayButton).onClick = OnClick;
        EventTriggerListener.Get(unloadButton).onClick = OnClick;
        EventTriggerListener.Get(reloadButton).onClick = OnClick;
        equipTypeTip.text = StaticDataMgr.Instance.GetTextByID("equip_List_zhuangbeileixing")+":";
        equipPowerTip.text = StaticDataMgr.Instance.GetTextByID("equip_forge_zhanli");
        equipLimitTip.text = StaticDataMgr.Instance.GetTextByID("equip_List_xianzhidengji") + ":";
        attributeTextTip.text = StaticDataMgr.Instance.GetTextByID("pet_detail_stage_attr");
        gemTextTip.text = StaticDataMgr.Instance.GetTextByID("equip_gem_casting");
        gemPromptTip.text = StaticDataMgr.Instance.GetTextByID("equip_gem_NotMent");
        equipUninstallTip.text = StaticDataMgr.Instance.GetTextByID("equip_inlay_xiexia");
        StrengthenTip.text = StaticDataMgr.Instance.GetTextByID("equip_forge_dazao");
        gemSetTip.text = StaticDataMgr.Instance.GetTextByID("equip_inlay_xiangqian");
        equipInstallTip.text = StaticDataMgr.Instance.GetTextByID("equip_Change");
    }
}
