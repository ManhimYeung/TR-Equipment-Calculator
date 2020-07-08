using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class HairClass : Gears
{
    public HairClass()
    {
        C_Hair();
        B_Hair();
        SS_Hair();
    }

    void C_Hair()
    {
        C_Rarity();
        C_Mode();
        C_Speed();
        C_Acceleration();
        C_Power();
        C_Control();
        C_RageDuration();
        C_RageCharge();
        C_MaxEnergy();
        C_MaxSprint();
        C_Force();
        C_Luck();
    }

    #region C_Hair Stats

    #region C_Hair Rarity
    void C_Rarity()
    {
        CRarityLookup["守護者髮型-D"] = 1;
        CRarityLookup["新手訓練髮型(女)"] = 1;
        CRarityLookup["新手訓練髮型(男)"] = 1;
        CRarityLookup["新手冰涼布丁髮型"] = 1;
        CRarityLookup["春季髮型(女)"] = 1;
        CRarityLookup["春季髮型(男)"] = 1;
        CRarityLookup["紫色煙火髮型-D"] = 1;
        CRarityLookup["安琪的頭髮"] = 1;
        CRarityLookup["愛坡的頭髮"] = 1;
        CRarityLookup["墮落的頭髮"] = 1;
        CRarityLookup["魔鬼的頭髮"] = 1;
    }
    #endregion C_Hair Rarity

    #region C_Hair Avatar Mode
    void C_Mode()
    {
        //page 1 row 1
        CModeLookup["守護者髮型-D"] = false;
        CModeLookup["新手訓練髮型(女)"] = true;
        CModeLookup["新手訓練髮型(男)"] = true;
        CModeLookup["新手冰涼布丁髮型"] = false;
        CModeLookup["春季髮型(女)"] = false;
        //page 1 row 2
        CModeLookup["春季髮型(男)"] = false;
        CModeLookup["紫色煙火髮型-D"] = false;
        CModeLookup["安琪的頭髮"] = false;
        CModeLookup["愛坡的頭髮"] = false;
        CModeLookup["墮落的頭髮"] = false;
        //page 1 row 3
        CModeLookup["魔鬼的頭髮"] = false;
    }
    #endregion

    #region C_Hair Speed
    void C_Speed()
    {
        CSpeedLookup["守護者髮型-D"] = 0;
        CSpeedLookup["新手訓練髮型(女)"] = 0;
        CSpeedLookup["新手訓練髮型(男)"] = 0;
        CSpeedLookup["新手冰涼布丁髮型"] = 0;
        CSpeedLookup["春季髮型(女)"] = 0;
        CSpeedLookup["春季髮型(男)"] = 0;
        CSpeedLookup["紫色煙火髮型-D"] = 0;
        CSpeedLookup["安琪的頭髮"] = 0;
        CSpeedLookup["愛坡的頭髮"] = 0;
        CSpeedLookup["墮落的頭髮"] = 0;
        CSpeedLookup["魔鬼的頭髮"] = 0;
    }
    #endregion C_Hair Speed

    #region C_Hair Acceleration
    void C_Acceleration()
    {
        CAccelerationLookup["守護者髮型-D"] = 0;
        CAccelerationLookup["新手訓練髮型(女)"] = 0;
        CAccelerationLookup["新手訓練髮型(男)"] = 0;
        CAccelerationLookup["新手冰涼布丁髮型"] = 0;
        CAccelerationLookup["春季髮型(女)"] = 0;
        CAccelerationLookup["春季髮型(男)"] = 0;
        CAccelerationLookup["紫色煙火髮型-D"] = 0;
        CAccelerationLookup["安琪的頭髮"] = 0;
        CAccelerationLookup["愛坡的頭髮"] = 0;
        CAccelerationLookup["墮落的頭髮"] = 0;
        CAccelerationLookup["魔鬼的頭髮"] = 0;
    }
    #endregion C_Hair Acceleration

    #region C_Hair Power
    public void C_Power()
    {
        CPowerLookup["守護者髮型-D"] = 0;
        CPowerLookup["新手訓練髮型(女)"] = 0;
        CPowerLookup["新手訓練髮型(男)"] = 0;
        CPowerLookup["新手冰涼布丁髮型"] = 0;
        CPowerLookup["春季髮型(女)"] = 0;
        CPowerLookup["春季髮型(男)"] = 0;
        CPowerLookup["紫色煙火髮型-D"] = 0;
        CPowerLookup["安琪的頭髮"] = 0;
        CPowerLookup["愛坡的頭髮"] = 0;
        CPowerLookup["墮落的頭髮"] = 0;
        CPowerLookup["魔鬼的頭髮"] = 0;
    }
    #endregion C_Hair Power

    #region C_Hair Control
    void C_Control()
    {
        CControlLookup["守護者髮型-D"] = 0;
        CControlLookup["新手訓練髮型(女)"] = 0;
        CControlLookup["新手訓練髮型(男)"] = 0;
        CControlLookup["新手冰涼布丁髮型"] = 0;
        CControlLookup["春季髮型(女)"] = 0;
        CControlLookup["春季髮型(男)"] = 0;
        CControlLookup["紫色煙火髮型-D"] = 0;
        CControlLookup["安琪的頭髮"] = 0;
        CControlLookup["愛坡的頭髮"] = 0;
        CControlLookup["墮落的頭髮"] = 0;
        CControlLookup["魔鬼的頭髮"] = 0;
    }
    #endregion C_Hair Control

    #region C_Hair Rage Duration
    void C_RageDuration()
    {
        CRageDurationLookup["守護者髮型-D"] = 3;
        CRageDurationLookup["新手訓練髮型(女)"] = 0;
        CRageDurationLookup["新手訓練髮型(男)"] = 0;
        CRageDurationLookup["新手冰涼布丁髮型"] = 0;
        CRageDurationLookup["春季髮型(女)"] = 0;
        CRageDurationLookup["春季髮型(男)"] = 0;
        CRageDurationLookup["紫色煙火髮型-D"] = 5;
        CRageDurationLookup["安琪的頭髮"] = 0;
        CRageDurationLookup["愛坡的頭髮"] = 0;
        CRageDurationLookup["墮落的頭髮"] = 0;
        CRageDurationLookup["魔鬼的頭髮"] = 0;

        int RageDurationItem1 = CRageDurationLookup["守護者髮型-D"];
        int RageDurationItem2 = CRageDurationLookup["新手訓練髮型(女)"];
        int RageDurationItem3 = CRageDurationLookup["新手訓練髮型(男)"];
        int RageDurationItem4 = CRageDurationLookup["新手冰涼布丁髮型"];
        int RageDurationItem5 = CRageDurationLookup["春季髮型(女)"];
        int RageDurationItem6 = CRageDurationLookup["春季髮型(男)"];
        int RageDurationItem7 = CRageDurationLookup["紫色煙火髮型-D"];
        int RageDurationItem8 = CRageDurationLookup["安琪的頭髮"];
        int RageDurationItem9 = CRageDurationLookup["愛坡的頭髮"];
        int RageDurationItem10 = CRageDurationLookup["墮落的頭髮"];
        int RageDurationItem11 = CRageDurationLookup["魔鬼的頭髮"];
    }
    #endregion Rage Duration

    #region C_Hair Rage Charge
    void C_RageCharge()
    {
        CRageChargeLookup["守護者髮型-D"] = 3;
        CRageChargeLookup["新手訓練髮型(女)"] = 0;
        CRageChargeLookup["新手訓練髮型(男)"] = 0;
        CRageChargeLookup["新手冰涼布丁髮型"] = 0;
        CRageChargeLookup["春季髮型(女)"] = 2;
        CRageChargeLookup["春季髮型(男)"] = 2;
        CRageChargeLookup["紫色煙火髮型-D"] = 5;
        CRageChargeLookup["安琪的頭髮"] = 0;
        CRageChargeLookup["愛坡的頭髮"] = 0;
        CRageChargeLookup["墮落的頭髮"] = 0;
        CRageChargeLookup["魔鬼的頭髮"] = 0;
    }
    #endregion C_Hair Rage Charge

    #region C_Hair Max Energy
    void C_MaxEnergy()
    {
        CMaxEnergyLookup["守護者髮型-D"] = 0;
        CMaxEnergyLookup["新手訓練髮型(女)"] = 0;
        CMaxEnergyLookup["新手訓練髮型(男)"] = 0;
        CMaxEnergyLookup["新手冰涼布丁髮型"] = 0;
        CMaxEnergyLookup["春季髮型(女)"] = 0;
        CMaxEnergyLookup["春季髮型(男)"] = 0;
        CMaxEnergyLookup["紫色煙火髮型-D"] = 0;
        CMaxEnergyLookup["安琪的頭髮"] = 0;
        CMaxEnergyLookup["愛坡的頭髮"] = 0;
        CMaxEnergyLookup["墮落的頭髮"] = 0;
        CMaxEnergyLookup["魔鬼的頭髮"] = 0;
    }
    #endregion C_Hair Max Energy

    #region C_Hair Max Sprint
    void C_MaxSprint()
    {
        CMaxSprintLookup["守護者髮型-D"] = 0;
        CMaxSprintLookup["新手訓練髮型(女)"] = 0;
        CMaxSprintLookup["新手訓練髮型(男)"] = 0;
        CMaxSprintLookup["新手冰涼布丁髮型"] = 0;
        CMaxSprintLookup["春季髮型(女)"] = 0;
        CMaxSprintLookup["春季髮型(男)"] = 0;
        CMaxSprintLookup["紫色煙火髮型-D"] = 0;
        CMaxSprintLookup["安琪的頭髮"] = 0;
        CMaxSprintLookup["愛坡的頭髮"] = 0;
        CMaxSprintLookup["墮落的頭髮"] = 0;
        CMaxSprintLookup["魔鬼的頭髮"] = 0;
    }
    #endregion C_Hair Max Sprint

    #region C_Hair Force
    void C_Force()
    {
        CForceLookup["守護者髮型-D"] = 0;
        CForceLookup["新手訓練髮型(女)"] = 0;
        CForceLookup["新手訓練髮型(男)"] = 0;
        CForceLookup["新手冰涼布丁髮型"] = 0;
        CForceLookup["春季髮型(女)"] = 0;
        CForceLookup["春季髮型(男)"] = 0;
        CForceLookup["紫色煙火髮型-D"] = 0;
        CForceLookup["安琪的頭髮"] = 0;
        CForceLookup["愛坡的頭髮"] = 0;
        CForceLookup["墮落的頭髮"] = 0;
        CForceLookup["魔鬼的頭髮"] = 0;
    }
    #endregion C_Hair Force

    #region C_Hair Luck
    void C_Luck()
    {
        CLuckLookup["守護者髮型-D"] = 0;
        CLuckLookup["新手訓練髮型(女)"] = 0;
        CLuckLookup["新手訓練髮型(男)"] = 0;
        CLuckLookup["新手冰涼布丁髮型"] = 0;
        CLuckLookup["春季髮型(女)"] = 0;
        CLuckLookup["春季髮型(男)"] = 0;
        CLuckLookup["紫色煙火髮型-D"] = 0;
        CLuckLookup["安琪的頭髮"] = 0;
        CLuckLookup["愛坡的頭髮"] = 0;
        CLuckLookup["墮落的頭髮"] = 0;
        CLuckLookup["魔鬼的頭髮"] = 0;
    }
    #endregion Luck

    #endregion C_Hair Stats

    void B_Hair()
    {
        B_Rarity();
        B_Mode();
        B_Speed();
        B_Acceleration();
        B_Power();
        B_Control();
        B_RageDuration();
        B_RageCharge();
        B_MaxEnergy();
        B_Force();
        B_Luck();
    }

    #region B_Hair Stats

    #region B_Hair Rarity
    void B_Rarity()
    {
        //page 1 row 1
        BRarityLookup["時尚休閒髮型"] = 2;
        BRarityLookup["夏日野餐髮型(女)-D"] = 2;
        BRarityLookup["夏日野餐髮型(男)-D"] = 2;
        BRarityLookup["夏日時尚髮型(女)"] = 2;
        BRarityLookup["夏日時尚髮型(男)"] = 2;
        //page 1 row 2
        BRarityLookup["悠閒夏日髮型(女)"] = 2;
        BRarityLookup["悠閒夏日髮型(男)"] = 2;
        BRarityLookup["祭典浴衣髮型(女)-D"] = 2;
        BRarityLookup["祭典浴衣髮型(男)-D"] = 2;
        BRarityLookup["春雨櫻花髮型(女)-D"] = 2;
        //page 1 row 3
        BRarityLookup["春雨櫻花髮型(男)-D"] = 2;
        BRarityLookup["活潑的莉莉髮型-D"] = 2;
        BRarityLookup["貴族少爺路易髮型-D"] = 2;
        BRarityLookup["巧克力馬卡龍髮型-D"] = 2;
        BRarityLookup["啦啦隊長髮型(女)-D"] = 2;
        //page 1 row 4
        BRarityLookup["啦啦隊長髮型(男)-D"] = 2;
        BRarityLookup["花樣新衣髮型(女)-D"] = 2;
        BRarityLookup["花樣新衣髮型(男)-D"] = 2;
        BRarityLookup["禦寒時尚髮型(男)-D"] = 2;
        BRarityLookup["禦寒時尚髮型(女)-D"] = 2;
        //page 1 row 5
        BRarityLookup["雪之精靈髮型-D"] = 2;
        BRarityLookup["王國公主髮型-D"] = 2;
        BRarityLookup["王國公主髮飾"] = 2;
        BRarityLookup["伊諾梅爾髮型-D"] = 2;
        BRarityLookup["Ms. Black髮型-D"] = 2;
        //page 1 row 6
        BRarityLookup["Mr. Black髮型-D"] = 2;
        BRarityLookup["幽靈獵人髮型(女)-D"] = 2;
        BRarityLookup["幽靈獵人髮型(男)-D"] = 2;
        BRarityLookup["深秋約會髮型(女)-D"] = 2;
        BRarityLookup["深秋約會髮型(男)-D"] = 2;

        //page 2 row 1
        BRarityLookup["普拉莉絲髮型(女)-D"] = 2;
        BRarityLookup["普拉莉絲髮型(男)-D"] = 2;
        BRarityLookup["夏夜髮型(女)-D"] = 2;
        BRarityLookup["夏夜髮型(男)-D"] = 2;
        BRarityLookup["森之精靈髮型-D"] = 2;
        //page 2 row 2
        BRarityLookup["地獄使者白髮-D"] = 2;
        BRarityLookup["夏日麻花辮(女)-D"] = 2;
        BRarityLookup["夏日灰髮(男)-D"] = 2;
        BRarityLookup["活潑小紅帽髮型-D"] = 2;
        BRarityLookup["酷帥大野狼髮型-D"] = 2;
        //page 2 row 3
        BRarityLookup["深海刑警髮型-D"] = 2;
        BRarityLookup["幼稚園生髮型(女)"] = 2;
        BRarityLookup["幼稚園生髮型(男)"] = 2;
        BRarityLookup["宴會髮型(女)-D"] = 2;
        BRarityLookup["宴會髮型(男)-D"] = 2;
        //page 2 row 4
        BRarityLookup["童話學園髮型(女)-D"] = 2;
        BRarityLookup["童話學園髮型(男)-D"] = 2;
        BRarityLookup["時尚韓服髮型(男)-D"] = 2;
        BRarityLookup["時尚韓服髮型(女)-D"] = 2;
        BRarityLookup["惡魔靈魂髮型-D"] = 2;
        //page 2 row 5
        BRarityLookup["禦寒髮型-D"] = 2;
        BRarityLookup["高階騎士髮型-D"] = 2;
        BRarityLookup["紫晶銀月髮型-D"] = 2;
        BRarityLookup["王后新娘髮型-D"] = 2;
        BRarityLookup["國王新郎髮型-D"] = 2;
        //page 2 row 6
        BRarityLookup["月兔髮型(男)-D"] = 2;
        BRarityLookup["月兔髮型(女)-D"] = 2;
        BRarityLookup["魔法夏卡爾髮型-D"] = 2;
        BRarityLookup["魔法肯恩髮型-D"] = 2;
        BRarityLookup["水手泳裝髮型(男)-D"] = 2;

        //page 3 row 1
        BRarityLookup["水手泳裝髮型(女)-D"] = 2;
        BRarityLookup["秋日休閒髮型(男)-D"] = 2;
        BRarityLookup["秋日休閒髮型(女)-D"] = 2;
        BRarityLookup["星夢戀人短髮-D"] = 2;
        BRarityLookup["星夢戀人長髮-D"] = 2;
        //page 3 row 2
        BRarityLookup["不完整的童話髮型-D"] = 2;
        BRarityLookup["光輝童話髮型-D"] = 2;
        BRarityLookup["亮白羽絨衣髮型-D"] = 2;
        BRarityLookup["個性羽絨衣髮型-D"] = 2;
        BRarityLookup["黑色童話髮型-D"] = 2;
        //page 3 row 3
        BRarityLookup["兔子管家髮型-D"] = 2;
        BRarityLookup["飛魚髮型-D"] = 2;
        BRarityLookup["道士髮型-D"] = 2;
        BRarityLookup["皇牌玩家髮型-D"] = 2;
        BRarityLookup["藍海水母髮型(女)-D"] = 2;
        //page 3 row 4
        BRarityLookup["藍海水母髮型(男)-D"] = 2;
        BRarityLookup["傳說的人魚髮型-D"] = 2;
        BRarityLookup["森林冒險家髮型-D"] = 2;
        BRarityLookup["日之光輝髮型-D"] = 2;
        BRarityLookup["舞動少年Cap帽(女)-D"] = 2;
        //page 3 row 5
        BRarityLookup["舞動少年Cap帽(男)-D"] = 2;
        BRarityLookup["高級守護者髮型-D"] = 2;
        BRarityLookup["溫馨約會長髮-D"] = 2;
        BRarityLookup["溫馨約會短髮-D"] = 2;
        BRarityLookup["典雅韓式髮型(女)-D"] = 2;
        //page 3 row 6
        BRarityLookup["典雅韓底髮型(男)-D"] = 2;
        BRarityLookup["淡雅韓底髮型(女)-D"] = 2;
        BRarityLookup["淡雅韓底髮型(男)-D"] = 2;
        BRarityLookup["守護妖精髮型-D"] = 2;
        BRarityLookup["女王護衛髮型-D"] = 2;
        //page 4 row 1
        BRarityLookup["冰雪女王髮型-D"] = 2;
        BRarityLookup["柔白雪花髮型-D"] = 2;
        BRarityLookup["甜美淑女髮型-D"] = 2;
        BRarityLookup["白髮女巫髮型-D"] = 2;
        BRarityLookup["黑女巫髮型-D"] = 2;
        //page 4 row 2
        BRarityLookup["萬聖節奸笑南瓜-D"] = 2;
        BRarityLookup["萬聖節大笑南瓜-D"] = 2;
        BRarityLookup["查理的明星髮型-D"] = 2;
        BRarityLookup["查理的藍色精靈髮型"] = 2;
        BRarityLookup["查理的魅影髮型-D"] = 2;
        //page 4 row 3
        BRarityLookup["查理的貴族髮型-D"] = 2;
        BRarityLookup["查理的橙色陽光髮型"] = 2;
        BRarityLookup["查理的冬季精靈髮型"] = 2;
        BRarityLookup["查理的白虎髮型-D"] = 2;
        BRarityLookup["查理的浪漫髮型-D"] = 2;
        //page 4 row 4
        BRarityLookup["查理的麒麟髮型-D"] = 2;
        BRarityLookup["浪漫提琴手的髮型(女)"] = 2;
        BRarityLookup["浪漫提琴手的髮型(男)"] = 2;
        BRarityLookup["冷艷吸血鬼髮型-D"] = 2;
        BRarityLookup["清新活力髮型(女)-P"] = 2;
        //page 4 row 5
        BRarityLookup["清新活力髮型(男)-P"] = 2;
        BRarityLookup["闇影修行者髮型"] = 2;
        BRarityLookup["莉莉的糖果恆星髮型"] = 2;
        BRarityLookup["莉莉的糖果極光髮型"] = 2;
        BRarityLookup["莉莉的狂野學園髮型"] = 2;
        //page 4 row 6
        BRarityLookup["莉莉的暗黑殺手髮型"] = 2;
        BRarityLookup["莉莉的秋天精靈髮型"] = 2;
        BRarityLookup["莉莉的聖龍王髮王"] = 2;
        BRarityLookup["莉莉的甜蜜布丁髮型"] = 2;
        BRarityLookup["莉莉的活力少年髮型"] = 2;

        //page 5 row 1
        BRarityLookup["莉莉的戰鬥士髮型"] = 2;
        BRarityLookup["莉莉的高尚貴族髮型"] = 2;
        BRarityLookup["莉莉的皇族黑夜髮型"] = 2;
        BRarityLookup["深幽婚禮頭紗(女)"] = 2;
        BRarityLookup["粉橙潮女髮型"] = 2;
        //page 5 row 2
        BRarityLookup["粉橙潮男髮型-D"] = 2;
        BRarityLookup["閃亮少女髮型-D"] = 2;
        BRarityLookup["閃亮少男髮型-D"] = 2;
        BRarityLookup["甜蜜布丁髮型"] = 2;
        BRarityLookup["糖果極光髮型"] = 2;
        //page 5 row 3
        BRarityLookup["韓國貴族校服髮型(女)"] = 2;
        BRarityLookup["韓國貴族校服髮型(男)"] = 2;
        BRarityLookup["韓國偶像校服髮型(女)"] = 2;
        BRarityLookup["韓國偶像校服髮型(男)"] = 2;
        BRarityLookup["暗黑魅力髮型-D"] = 2;
        //page 5 row 4
        BRarityLookup["光之魅力髮型-D"] = 2;
        BRarityLookup["綠焰髮型"] = 2;
        BRarityLookup["皇家騎士團髮型-D"] = 2;
        BRarityLookup["橘色陽光髮型(女)"] = 2;
        BRarityLookup["橘色陽光髮型(男)"] = 2;
        //page 5 row 5
        BRarityLookup["摩登少女髮型-D"] = 2;
        BRarityLookup["摩登少年髮型-D"] = 2;
        BRarityLookup["浪漫少女髮型-D"] = 2;
        BRarityLookup["浪漫少年髮型-D"] = 2;
        BRarityLookup["白色情人節Cap帽(男)"] = 2;
        //page 5 row 6
        BRarityLookup["白色情人節Cap帽(女)"] = 2;
        BRarityLookup["清爽春風髮型(女)"] = 2;
        BRarityLookup["清爽春風髮型(男)"] = 2;
        BRarityLookup["天空之國髮型-D(男)"] = 2;
        BRarityLookup["天空之國髮型-D(女)"] = 2;

        //page 6 row 1
        BRarityLookup["異世界髮型-D"] = 2;
        BRarityLookup["異世甲髮型-D"] = 2;
        BRarityLookup["布拉基的髮型-D"] = 2;
        BRarityLookup["聖戰女神髮型-D"] = 2;
        BRarityLookup["凡賽堤髮型-D"] = 2;
        //page 6 row 2
        BRarityLookup["黃金火焰髮型"] = 2;
        BRarityLookup["聖光烈焰髮型"] = 2;
        BRarityLookup["真 ᛫ 女神白焰髮型"] = 2;
        BRarityLookup["安琪公主的頭髮"] = 2;
        BRarityLookup["安琪道路的頭髮"] = 2;
        //page 6 row 3
        BRarityLookup["魔鬼國王的頭髮"] = 2;
        BRarityLookup["魔鬼道路的頭髮"] = 2;
        BRarityLookup["極限藍焰髮型"] = 2;
        BRarityLookup["傳說的火焰髮型"] = 2;
        BRarityLookup["Dr Hell面貝"] = 2;
    }
    #endregion B_Hair Rarity

    #region B_Hair Mode
    void B_Mode()
    {
        //page 1 row 1
        BModeLookup["時尚休閒髮型"] = false;
        BModeLookup["夏日野餐髮型(女)-D"] = false;
        BModeLookup["夏日野餐髮型(男)-D"] = false;
        BModeLookup["夏日時尚髮型(女)"] = false;
        BModeLookup["夏日時尚髮型(男)"] = false;

        //page 1 row 
        BModeLookup["悠閒夏日髮型(女)"] = false;
        BModeLookup["悠閒夏日髮型(男)"] = false;
        BModeLookup["祭典浴衣髮型(女)-D"] = false;
        BModeLookup["祭典浴衣髮型(男)-D"] = false;
        BModeLookup["春雨櫻花髮型(女)-D"] = false;
        //page 1 row 3
        BModeLookup["春雨櫻花髮型(男)-D"] = false;
        BModeLookup["活潑的莉莉髮型-D"] = false;
        BModeLookup["貴族少爺路易髮型-D"] = false;
        BModeLookup["巧克力馬卡龍髮型-D"] = true;
        BModeLookup["啦啦隊長髮型(女)-D"] = false;

        //page 1 row 4
        BModeLookup["啦啦隊長髮型(男)-D"] = false;
        BModeLookup["花樣新衣髮型(女)-D"] = false;
        BModeLookup["花樣新衣髮型(男)-D"] = false;
        BModeLookup["禦寒時尚髮型(男)-D"] = false;
        BModeLookup["禦寒時尚髮型(女)-D"] = false;
        //page 1 row 5
        BModeLookup["雪之精靈髮型-D"] = false;
        BModeLookup["王國公主髮型-D"] = false;
        BModeLookup["王國公主髮飾"] = true;
        BModeLookup["伊諾梅爾髮型-D"] = false;
        BModeLookup["Ms. Black髮型-D"] = false;

        //page 1 row 6
        BModeLookup["Mr. Black髮型-D"] = false;
        BModeLookup["幽靈獵人髮型(女)-D"] = false;
        BModeLookup["幽靈獵人髮型(男)-D"] = false;
        BModeLookup["深秋約會髮型(女)-D"] = false;
        BModeLookup["深秋約會髮型(男)-D"] = false;

        //page false row 1
        BModeLookup["普拉莉絲髮型(女)-D"] = false;
        BModeLookup["普拉莉絲髮型(男)-D"] = false;
        BModeLookup["夏夜髮型(女)-D"] = false;
        BModeLookup["夏夜髮型(男)-D"] = false;
        BModeLookup["森之精靈髮型-D"] = false;
        //page false row false
        BModeLookup["地獄使者白髮-D"] = false;
        BModeLookup["夏日麻花辮(女)-D"] = false;
        BModeLookup["夏日灰髮(男)-D"] = false;
        BModeLookup["活潑小紅帽髮型-D"] = false;
        BModeLookup["酷帥大野狼髮型-D"] = false;
        //page false row 3
        BModeLookup["深海刑警髮型-D"] = false;
        BModeLookup["幼稚園生髮型(女)"] = false;
        BModeLookup["幼稚園生髮型(男)"] = false;
        BModeLookup["宴會髮型(女)-D"] = false;
        BModeLookup["宴會髮型(男)-D"] = false;
        //page false row 4
        BModeLookup["童話學園髮型(女)-D"] = false;
        BModeLookup["童話學園髮型(男)-D"] = false;
        BModeLookup["時尚韓服髮型(男)-D"] = false;
        BModeLookup["時尚韓服髮型(女)-D"] = false;
        BModeLookup["惡魔靈魂髮型-D"] = false;
        //page false row 5
        BModeLookup["禦寒髮型-D"] = false;
        BModeLookup["高階騎士髮型-D"] = false;
        BModeLookup["紫晶銀月髮型-D"] = false;
        BModeLookup["王后新娘髮型-D"] = false;
        BModeLookup["國王新郎髮型-D"] = false;
        //page false row 6
        BModeLookup["月兔髮型(男)-D"] = false;
        BModeLookup["月兔髮型(女)-D"] = false;
        BModeLookup["魔法夏卡爾髮型-D"] = false;
        BModeLookup["魔法肯恩髮型-D"] = false;
        BModeLookup["水手泳裝髮型(男)-D"] = false;

        //page 3 row 1
        BModeLookup["水手泳裝髮型(女)-D"] = false;
        BModeLookup["秋日休閒髮型(男)-D"] = false;
        BModeLookup["秋日休閒髮型(女)-D"] = false;
        BModeLookup["星夢戀人短髮-D"] = false;
        BModeLookup["星夢戀人長髮-D"] = false;
        //page 3 row false
        BModeLookup["不完整的童話髮型-D"] = false;
        BModeLookup["光輝童話髮型-D"] = false;
        BModeLookup["亮白羽絨衣髮型-D"] = false;
        BModeLookup["個性羽絨衣髮型-D"] = false;
        BModeLookup["黑色童話髮型-D"] = false;
        //page 3 row 3
        BModeLookup["兔子管家髮型-D"] = false;
        BModeLookup["飛魚髮型-D"] = false;
        BModeLookup["道士髮型-D"] = false;
        BModeLookup["皇牌玩家髮型-D"] = false;
        BModeLookup["藍海水母髮型(女)-D"] = false;
        //page 3 row 4
        BModeLookup["藍海水母髮型(男)-D"] = false;
        BModeLookup["傳說的人魚髮型-D"] = false;
        BModeLookup["森林冒險家髮型-D"] = false;
        BModeLookup["日之光輝髮型-D"] = false;
        BModeLookup["舞動少年Cap帽(女)-D"] = false;
        //page 3 row 5
        BModeLookup["舞動少年Cap帽(男)-D"] = false;
        BModeLookup["高級守護者髮型-D"] = false;
        BModeLookup["溫馨約會長髮-D"] = false;
        BModeLookup["溫馨約會短髮-D"] = false;
        BModeLookup["典雅韓式髮型(女)-D"] = false;
        //page 3 row 6
        BModeLookup["典雅韓底髮型(男)-D"] = false;
        BModeLookup["淡雅韓底髮型(女)-D"] = false;
        BModeLookup["淡雅韓底髮型(男)-D"] = false;
        BModeLookup["守護妖精髮型-D"] = false;
        BModeLookup["女王護衛髮型-D"] = false;
        //page 4 row 1
        BModeLookup["冰雪女王髮型-D"] = false;
        BModeLookup["柔白雪花髮型-D"] = false;
        BModeLookup["甜美淑女髮型-D"] = false;
        BModeLookup["白髮女巫髮型-D"] = false;
        BModeLookup["黑女巫髮型-D"] = false;
        //page 4 row false
        BModeLookup["萬聖節奸笑南瓜-D"] = false;
        BModeLookup["萬聖節大笑南瓜-D"] = false;
        BModeLookup["查理的明星髮型-D"] = false;
        BModeLookup["查理的藍色精靈髮型"] = false;
        BModeLookup["查理的魅影髮型-D"] = false;
        //page 4 row 3
        BModeLookup["查理的貴族髮型-D"] = false;
        BModeLookup["查理的橙色陽光髮型"] = false;
        BModeLookup["查理的冬季精靈髮型"] = false;
        BModeLookup["查理的白虎髮型-D"] = false;
        BModeLookup["查理的浪漫髮型-D"] = false;
        //page 4 row 4
        BModeLookup["查理的麒麟髮型-D"] = false;
        BModeLookup["浪漫提琴手的髮型(女)"] = false;
        BModeLookup["浪漫提琴手的髮型(男)"] = false;
        BModeLookup["冷艷吸血鬼髮型-D"] = false;
        BModeLookup["清新活力髮型(女)-P"] = false;
        //page 4 row 5
        BModeLookup["清新活力髮型(男)-P"] = false;
        BModeLookup["闇影修行者髮型"] = false;
        BModeLookup["莉莉的糖果恆星髮型"] = false;
        BModeLookup["莉莉的糖果極光髮型"] = false;
        BModeLookup["莉莉的狂野學園髮型"] = false;
        //page 4 row 6
        BModeLookup["莉莉的暗黑殺手髮型"] = false;
        BModeLookup["莉莉的秋天精靈髮型"] = false;
        BModeLookup["莉莉的聖龍王髮王"] = false;
        BModeLookup["莉莉的甜蜜布丁髮型"] = false;
        BModeLookup["莉莉的活力少年髮型"] = false;

        //page 5 row 1
        BModeLookup["莉莉的戰鬥士髮型"] = false;
        BModeLookup["莉莉的高尚貴族髮型"] = false;
        BModeLookup["莉莉的皇族黑夜髮型"] = false;
        BModeLookup["深幽婚禮頭紗(女)"] = false;
        BModeLookup["粉橙潮女髮型"] = false;
        //page 5 row false
        BModeLookup["粉橙潮男髮型-D"] = false;
        BModeLookup["閃亮少女髮型-D"] = false;
        BModeLookup["閃亮少男髮型-D"] = false;
        BModeLookup["甜蜜布丁髮型"] = false;
        BModeLookup["糖果極光髮型"] = false;
        //page 5 row 3
        BModeLookup["韓國貴族校服髮型(女)"] = false;
        BModeLookup["韓國貴族校服髮型(男)"] = false;
        BModeLookup["韓國偶像校服髮型(女)"] = false;
        BModeLookup["韓國偶像校服髮型(男)"] = false;
        BModeLookup["暗黑魅力髮型-D"] = false;
        //page 5 row 4
        BModeLookup["光之魅力髮型-D"] = false;
        BModeLookup["綠焰髮型"] = false;
        BModeLookup["皇家騎士團髮型-D"] = false;
        BModeLookup["橘色陽光髮型(女)"] = false;
        BModeLookup["橘色陽光髮型(男)"] = false;
        //page 5 row 5
        BModeLookup["摩登少女髮型-D"] = false;
        BModeLookup["摩登少年髮型-D"] = false;
        BModeLookup["浪漫少女髮型-D"] = false;
        BModeLookup["浪漫少年髮型-D"] = false;
        BModeLookup["白色情人節Cap帽(男)"] = false;
        //page 5 row 6
        BModeLookup["白色情人節Cap帽(女)"] = false;
        BModeLookup["清爽春風髮型(女)"] = false;
        BModeLookup["清爽春風髮型(男)"] = false;
        BModeLookup["天空之國髮型-D(男)"] = false;
        BModeLookup["天空之國髮型-D(女)"] = false;

        //page 6 row 1
        BModeLookup["異世界髮型-D"] = false;
        BModeLookup["異世甲髮型-D"] = false;
        BModeLookup["布拉基的髮型-D"] = false;
        BModeLookup["聖戰女神髮型-D"] = false;
        BModeLookup["凡賽堤髮型-D"] = false;
        //page 6 row false
        BModeLookup["黃金火焰髮型"] = false;
        BModeLookup["聖光烈焰髮型"] = false;
        BModeLookup["真 ᛫ 女神白焰髮型"] = false;
        BModeLookup["安琪公主的頭髮"] = false;
        BModeLookup["安琪道路的頭髮"] = false;
        //page 6 row 3
        BModeLookup["魔鬼國王的頭髮"] = false;
        BModeLookup["魔鬼道路的頭髮"] = false;
        BModeLookup["極限藍焰髮型"] = false;
        BModeLookup["傳說的火焰髮型"] = false;
        BModeLookup["Dr Hell面貝"] = false;

    }
    #endregion B_Hair Mode

    #region B_Hair Speed
    void B_Speed()
    {
        //page 1 row 1
        BSpeedLookup["時尚休閒髮型"] = 0;
        BSpeedLookup["夏日野餐髮型(女)-D"] = 0;
        BSpeedLookup["夏日野餐髮型(男)-D"] = 0;
        BSpeedLookup["夏日時尚髮型(女)"] = 0;
        BSpeedLookup["夏日時尚髮型(男)"] = 0;

        //page 1 row 0
        BSpeedLookup["悠閒夏日髮型(女)"] = 0;
        BSpeedLookup["悠閒夏日髮型(男)"] = 0;
        BSpeedLookup["祭典浴衣髮型(女)-D"] = 0;
        BSpeedLookup["祭典浴衣髮型(男)-D"] = 0;
        BSpeedLookup["春雨櫻花髮型(女)-D"] = 0;

        //page 1 row 3
        BSpeedLookup["春雨櫻花髮型(男)-D"] = 0;
        BSpeedLookup["活潑的莉莉髮型-D"] = 0;
        BSpeedLookup["貴族少爺路易髮型-D"] = 0;
        BSpeedLookup["巧克力馬卡龍髮型-D"] = 0;
        BSpeedLookup["啦啦隊長髮型(女)-D"] = 0;
        //page 1 row 4
        BSpeedLookup["啦啦隊長髮型(男)-D"] = 0;
        BSpeedLookup["花樣新衣髮型(女)-D"] = 0;
        BSpeedLookup["花樣新衣髮型(男)-D"] = 0;
        BSpeedLookup["禦寒時尚髮型(男)-D"] = 0;
        BSpeedLookup["禦寒時尚髮型(女)-D"] = 0;
        //page 1 row 5
        BSpeedLookup["雪之精靈髮型-D"] = 0;
        BSpeedLookup["王國公主髮型-D"] = 0;
        BSpeedLookup["王國公主髮飾"] = 0;
        BSpeedLookup["伊諾梅爾髮型-D"] = 0;
        BSpeedLookup["Ms. Black髮型-D"] = 0;
        //page 1 row 6
        BSpeedLookup["Mr. Black髮型-D"] = 0;
        BSpeedLookup["幽靈獵人髮型(女)-D"] = 0;
        BSpeedLookup["幽靈獵人髮型(男)-D"] = 0;
        BSpeedLookup["深秋約會髮型(女)-D"] = 0;
        BSpeedLookup["深秋約會髮型(男)-D"] = 0;

        //page 0 row 1
        BSpeedLookup["普拉莉絲髮型(女)-D"] = 0;
        BSpeedLookup["普拉莉絲髮型(男)-D"] = 0;
        BSpeedLookup["夏夜髮型(女)-D"] = 0;
        BSpeedLookup["夏夜髮型(男)-D"] = 0;
        BSpeedLookup["森之精靈髮型-D"] = 0;
        //page 0 row 0
        BSpeedLookup["地獄使者白髮-D"] = 0;
        BSpeedLookup["夏日麻花辮(女)-D"] = 0;
        BSpeedLookup["夏日灰髮(男)-D"] = 0;
        BSpeedLookup["活潑小紅帽髮型-D"] = 0;
        BSpeedLookup["酷帥大野狼髮型-D"] = 0;
        //page 0 row 3
        BSpeedLookup["深海刑警髮型-D"] = 0;
        BSpeedLookup["幼稚園生髮型(女)"] = 0;
        BSpeedLookup["幼稚園生髮型(男)"] = 0;
        BSpeedLookup["宴會髮型(女)-D"] = 0;
        BSpeedLookup["宴會髮型(男)-D"] = 0;
        //page 0 row 4
        BSpeedLookup["童話學園髮型(女)-D"] = 0;
        BSpeedLookup["童話學園髮型(男)-D"] = 0;
        BSpeedLookup["時尚韓服髮型(男)-D"] = 0;
        BSpeedLookup["時尚韓服髮型(女)-D"] = 0;
        BSpeedLookup["惡魔靈魂髮型-D"] = 0;
        //page 0 row 5
        BSpeedLookup["禦寒髮型-D"] = 0;
        BSpeedLookup["高階騎士髮型-D"] = 0;
        BSpeedLookup["紫晶銀月髮型-D"] = 0;
        BSpeedLookup["王后新娘髮型-D"] = 0;
        BSpeedLookup["國王新郎髮型-D"] = 0;
        //page 0 row 6
        BSpeedLookup["月兔髮型(男)-D"] = 0;
        BSpeedLookup["月兔髮型(女)-D"] = 0;
        BSpeedLookup["魔法夏卡爾髮型-D"] = 0;
        BSpeedLookup["魔法肯恩髮型-D"] = 0;
        BSpeedLookup["水手泳裝髮型(男)-D"] = 0;

        //page 3 row 1
        BSpeedLookup["水手泳裝髮型(女)-D"] = 0;
        BSpeedLookup["秋日休閒髮型(男)-D"] = 0;
        BSpeedLookup["秋日休閒髮型(女)-D"] = 0;
        BSpeedLookup["星夢戀人短髮-D"] = 0;
        BSpeedLookup["星夢戀人長髮-D"] = 0;
        //page 3 row 0
        BSpeedLookup["不完整的童話髮型-D"] = 0;
        BSpeedLookup["光輝童話髮型-D"] = 0;
        BSpeedLookup["亮白羽絨衣髮型-D"] = 0;
        BSpeedLookup["個性羽絨衣髮型-D"] = 0;
        BSpeedLookup["黑色童話髮型-D"] = 0;
        //page 3 row 3
        BSpeedLookup["兔子管家髮型-D"] = 0;
        BSpeedLookup["飛魚髮型-D"] = 0;
        BSpeedLookup["道士髮型-D"] = 0;
        BSpeedLookup["皇牌玩家髮型-D"] = 0;
        BSpeedLookup["藍海水母髮型(女)-D"] = 0;
        //page 3 row 4
        BSpeedLookup["藍海水母髮型(男)-D"] = 0;
        BSpeedLookup["傳說的人魚髮型-D"] = 0;
        BSpeedLookup["森林冒險家髮型-D"] = 0;
        BSpeedLookup["日之光輝髮型-D"] = 0;
        BSpeedLookup["舞動少年Cap帽(女)-D"] = 0;
        //page 3 row 5
        BSpeedLookup["舞動少年Cap帽(男)-D"] = 0;
        BSpeedLookup["高級守護者髮型-D"] = 0;
        BSpeedLookup["溫馨約會長髮-D"] = 0;
        BSpeedLookup["溫馨約會短髮-D"] = 0;
        BSpeedLookup["典雅韓式髮型(女)-D"] = 0;
        //page 3 row 6
        BSpeedLookup["典雅韓底髮型(男)-D"] = 0;
        BSpeedLookup["淡雅韓底髮型(女)-D"] = 0;
        BSpeedLookup["淡雅韓底髮型(男)-D"] = 0;
        BSpeedLookup["守護妖精髮型-D"] = 0;
        BSpeedLookup["女王護衛髮型-D"] = 0;
        //page 4 row 1
        BSpeedLookup["冰雪女王髮型-D"] = 0;
        BSpeedLookup["柔白雪花髮型-D"] = 0;
        BSpeedLookup["甜美淑女髮型-D"] = 0;
        BSpeedLookup["白髮女巫髮型-D"] = 0;
        BSpeedLookup["黑女巫髮型-D"] = 1;
        //page 4 row 0
        BSpeedLookup["萬聖節奸笑南瓜-D"] = 0;
        BSpeedLookup["萬聖節大笑南瓜-D"] = 0;
        BSpeedLookup["查理的明星髮型-D"] = 0;
        BSpeedLookup["查理的藍色精靈髮型"] = 0;
        BSpeedLookup["查理的魅影髮型-D"] = 0;
        //page 4 row 3
        BSpeedLookup["查理的貴族髮型-D"] = 0;
        BSpeedLookup["查理的橙色陽光髮型"] = 0;
        BSpeedLookup["查理的冬季精靈髮型"] = 0;
        BSpeedLookup["查理的白虎髮型-D"] = 0;
        BSpeedLookup["查理的浪漫髮型-D"] = 0;
        //page 4 row 4
        BSpeedLookup["查理的麒麟髮型-D"] = 0;
        BSpeedLookup["浪漫提琴手的髮型(女)"] = 0;
        BSpeedLookup["浪漫提琴手的髮型(男)"] = 0;
        BSpeedLookup["冷艷吸血鬼髮型-D"] = 0;
        BSpeedLookup["清新活力髮型(女)-P"] = 0;
        //page 4 row 5
        BSpeedLookup["清新活力髮型(男)-P"] = 0;
        BSpeedLookup["闇影修行者髮型"] = 0;
        BSpeedLookup["莉莉的糖果恆星髮型"] = 0;
        BSpeedLookup["莉莉的糖果極光髮型"] = 0;
        BSpeedLookup["莉莉的狂野學園髮型"] = 0;
        //page 4 row 6
        BSpeedLookup["莉莉的暗黑殺手髮型"] = 0;
        BSpeedLookup["莉莉的秋天精靈髮型"] = 0;
        BSpeedLookup["莉莉的聖龍王髮王"] = 0;
        BSpeedLookup["莉莉的甜蜜布丁髮型"] = 0;
        BSpeedLookup["莉莉的活力少年髮型"] = 0;

        //page 5 row 1
        BSpeedLookup["莉莉的戰鬥士髮型"] = 0;
        BSpeedLookup["莉莉的高尚貴族髮型"] = 0;
        BSpeedLookup["莉莉的皇族黑夜髮型"] = 0;
        BSpeedLookup["深幽婚禮頭紗(女)"] = 0;
        BSpeedLookup["粉橙潮女髮型"] = 0;
        //page 5 row 0
        BSpeedLookup["粉橙潮男髮型-D"] = 0;
        BSpeedLookup["閃亮少女髮型-D"] = 0;
        BSpeedLookup["閃亮少男髮型-D"] = 0;
        BSpeedLookup["甜蜜布丁髮型"] = 0;
        BSpeedLookup["糖果極光髮型"] = 0;
        //page 5 row 3
        BSpeedLookup["韓國貴族校服髮型(女)"] = 0;
        BSpeedLookup["韓國貴族校服髮型(男)"] = 0;
        BSpeedLookup["韓國偶像校服髮型(女)"] = 0;
        BSpeedLookup["韓國偶像校服髮型(男)"] = 0;
        BSpeedLookup["暗黑魅力髮型-D"] = 0;
        //page 5 row 4
        BSpeedLookup["光之魅力髮型-D"] = 0;
        BSpeedLookup["綠焰髮型"] = 0;
        BSpeedLookup["皇家騎士團髮型-D"] = 0;
        BSpeedLookup["橘色陽光髮型(女)"] = 0;
        BSpeedLookup["橘色陽光髮型(男)"] = 0;
        //page 5 row 5
        BSpeedLookup["摩登少女髮型-D"] = 0;
        BSpeedLookup["摩登少年髮型-D"] = 0;
        BSpeedLookup["浪漫少女髮型-D"] = 0;
        BSpeedLookup["浪漫少年髮型-D"] = 0;
        BSpeedLookup["白色情人節Cap帽(男)"] = 0;
        //page 5 row 6
        BSpeedLookup["白色情人節Cap帽(女)"] = 0;
        BSpeedLookup["清爽春風髮型(女)"] = 0;
        BSpeedLookup["清爽春風髮型(男)"] = 0;
        BSpeedLookup["天空之國髮型-D(男)"] = 0;
        BSpeedLookup["天空之國髮型-D(女)"] = 0;

        //page 6 row 1
        BSpeedLookup["異世界髮型-D"] = 0;
        BSpeedLookup["異世甲髮型-D"] = 0;
        BSpeedLookup["布拉基的髮型-D"] = 0;
        BSpeedLookup["聖戰女神髮型-D"] = 0;
        BSpeedLookup["凡賽堤髮型-D"] = 0;
        //page 6 row 0
        BSpeedLookup["黃金火焰髮型"] = 0;
        BSpeedLookup["聖光烈焰髮型"] = 0;
        BSpeedLookup["真 ᛫ 女神白焰髮型"] = 0;
        BSpeedLookup["安琪公主的頭髮"] = 0;
        BSpeedLookup["安琪道路的頭髮"] = 0;
        //page 6 row 3
        BSpeedLookup["魔鬼國王的頭髮"] = 0;
        BSpeedLookup["魔鬼道路的頭髮"] = 0;
        BSpeedLookup["極限藍焰髮型"] = 0;
        BSpeedLookup["傳說的火焰髮型"] = 0;
        BSpeedLookup["Dr Hell面貝"] = 0;
    }
    #endregion B_Hair Speed

    #region B_Hair Acceleration
    void B_Acceleration()
    {
        //page 1 row 1
        BAccelerationLookup["時尚休閒髮型"] = 0;
        BAccelerationLookup["夏日野餐髮型(女)-D"] = 0;
        BAccelerationLookup["夏日野餐髮型(男)-D"] = 0;
        BAccelerationLookup["夏日時尚髮型(女)"] = 0;
        BAccelerationLookup["夏日時尚髮型(男)"] = 0;
        //page 1 row 0
        BAccelerationLookup["悠閒夏日髮型(女)"] = 0;
        BAccelerationLookup["悠閒夏日髮型(男)"] = 0;
        BAccelerationLookup["祭典浴衣髮型(女)-D"] = 0;
        BAccelerationLookup["祭典浴衣髮型(男)-D"] = 0;
        BAccelerationLookup["春雨櫻花髮型(女)-D"] = 0;
        //page 1 row 3
        BAccelerationLookup["春雨櫻花髮型(男)-D"] = 0;
        BAccelerationLookup["活潑的莉莉髮型-D"] = 0;
        BAccelerationLookup["貴族少爺路易髮型-D"] = 0;
        BAccelerationLookup["巧克力馬卡龍髮型-D"] = 0;
        BAccelerationLookup["啦啦隊長髮型(女)-D"] = 0;
        //page 1 row 4
        BAccelerationLookup["啦啦隊長髮型(男)-D"] = 0;
        BAccelerationLookup["花樣新衣髮型(女)-D"] = 0;
        BAccelerationLookup["花樣新衣髮型(男)-D"] = 0;
        BAccelerationLookup["禦寒時尚髮型(男)-D"] = 0;
        BAccelerationLookup["禦寒時尚髮型(女)-D"] = 0;
        //page 1 row 5
        BAccelerationLookup["雪之精靈髮型-D"] = 0;
        BAccelerationLookup["王國公主髮型-D"] = 0;
        BAccelerationLookup["王國公主髮飾"] = 0;
        BAccelerationLookup["伊諾梅爾髮型-D"] = 0;
        BAccelerationLookup["Ms. Black髮型-D"] = 0;
        //page 1 row 6
        BAccelerationLookup["Mr. Black髮型-D"] = 0;
        BAccelerationLookup["幽靈獵人髮型(女)-D"] = 0;
        BAccelerationLookup["幽靈獵人髮型(男)-D"] = 0;
        BAccelerationLookup["深秋約會髮型(女)-D"] = 0;
        BAccelerationLookup["深秋約會髮型(男)-D"] = 0;

        //page 0 row 1
        BAccelerationLookup["普拉莉絲髮型(女)-D"] = 0;
        BAccelerationLookup["普拉莉絲髮型(男)-D"] = 0;
        BAccelerationLookup["夏夜髮型(女)-D"] = 0;
        BAccelerationLookup["夏夜髮型(男)-D"] = 0;
        BAccelerationLookup["森之精靈髮型-D"] = 0;
        //page 0 row 0
        BAccelerationLookup["地獄使者白髮-D"] = 0;
        BAccelerationLookup["夏日麻花辮(女)-D"] = 0;
        BAccelerationLookup["夏日灰髮(男)-D"] = 0;
        BAccelerationLookup["活潑小紅帽髮型-D"] = 0;
        BAccelerationLookup["酷帥大野狼髮型-D"] = 0;
        //page 0 row 3
        BAccelerationLookup["深海刑警髮型-D"] = 0;
        BAccelerationLookup["幼稚園生髮型(女)"] = 0;
        BAccelerationLookup["幼稚園生髮型(男)"] = 0;
        BAccelerationLookup["宴會髮型(女)-D"] = 0;
        BAccelerationLookup["宴會髮型(男)-D"] = 0;
        //page 0 row 4
        BAccelerationLookup["童話學園髮型(女)-D"] = 0;
        BAccelerationLookup["童話學園髮型(男)-D"] = 0;
        BAccelerationLookup["時尚韓服髮型(男)-D"] = 0;
        BAccelerationLookup["時尚韓服髮型(女)-D"] = 0;
        BAccelerationLookup["惡魔靈魂髮型-D"] = 0;
        //page 0 row 5
        BAccelerationLookup["禦寒髮型-D"] = 0;
        BAccelerationLookup["高階騎士髮型-D"] = 0;
        BAccelerationLookup["紫晶銀月髮型-D"] = 0;
        BAccelerationLookup["王后新娘髮型-D"] = 0;
        BAccelerationLookup["國王新郎髮型-D"] = 0;
        //page 0 row 6
        BAccelerationLookup["月兔髮型(男)-D"] = 0;
        BAccelerationLookup["月兔髮型(女)-D"] = 0;
        BAccelerationLookup["魔法夏卡爾髮型-D"] = 0;
        BAccelerationLookup["魔法肯恩髮型-D"] = 0;
        BAccelerationLookup["水手泳裝髮型(男)-D"] = 0;

        //page 3 row 1
        BAccelerationLookup["水手泳裝髮型(女)-D"] = 0;
        BAccelerationLookup["秋日休閒髮型(男)-D"] = 0;
        BAccelerationLookup["秋日休閒髮型(女)-D"] = 0;
        BAccelerationLookup["星夢戀人短髮-D"] = 0;
        BAccelerationLookup["星夢戀人長髮-D"] = 0;
        //page 3 row 0
        BAccelerationLookup["不完整的童話髮型-D"] = 0;
        BAccelerationLookup["光輝童話髮型-D"] = 0;
        BAccelerationLookup["亮白羽絨衣髮型-D"] = 0;
        BAccelerationLookup["個性羽絨衣髮型-D"] = 0;
        BAccelerationLookup["黑色童話髮型-D"] = 0;
        //page 3 row 3
        BAccelerationLookup["兔子管家髮型-D"] = 0;
        BAccelerationLookup["飛魚髮型-D"] = 0;
        BAccelerationLookup["道士髮型-D"] = 0;
        BAccelerationLookup["皇牌玩家髮型-D"] = 0;
        BAccelerationLookup["藍海水母髮型(女)-D"] = 0;
        //page 3 row 4
        BAccelerationLookup["藍海水母髮型(男)-D"] = 0;
        BAccelerationLookup["傳說的人魚髮型-D"] = 0;
        BAccelerationLookup["森林冒險家髮型-D"] = 0;
        BAccelerationLookup["日之光輝髮型-D"] = 0;
        BAccelerationLookup["舞動少年Cap帽(女)-D"] = 0;
        //page 3 row 5
        BAccelerationLookup["舞動少年Cap帽(男)-D"] = 0;
        BAccelerationLookup["高級守護者髮型-D"] = 0;
        BAccelerationLookup["溫馨約會長髮-D"] = 0;
        BAccelerationLookup["溫馨約會短髮-D"] = 0;
        BAccelerationLookup["典雅韓式髮型(女)-D"] = 0;
        //page 3 row 6
        BAccelerationLookup["典雅韓底髮型(男)-D"] = 0;
        BAccelerationLookup["淡雅韓底髮型(女)-D"] = 0;
        BAccelerationLookup["淡雅韓底髮型(男)-D"] = 0;
        BAccelerationLookup["守護妖精髮型-D"] = 0;
        BAccelerationLookup["女王護衛髮型-D"] = 0;
        //page 4 row 1
        BAccelerationLookup["冰雪女王髮型-D"] = 0;
        BAccelerationLookup["柔白雪花髮型-D"] = 0;
        BAccelerationLookup["甜美淑女髮型-D"] = 0;
        BAccelerationLookup["白髮女巫髮型-D"] = 1;
        BAccelerationLookup["黑女巫髮型-D"] = 0;
        //page 4 row 0
        BAccelerationLookup["萬聖節奸笑南瓜-D"] = 0;
        BAccelerationLookup["萬聖節大笑南瓜-D"] = 0;
        BAccelerationLookup["查理的明星髮型-D"] = 0;
        BAccelerationLookup["查理的藍色精靈髮型"] = 0;
        BAccelerationLookup["查理的魅影髮型-D"] = 0;
        //page 4 row 3
        BAccelerationLookup["查理的貴族髮型-D"] = 0;
        BAccelerationLookup["查理的橙色陽光髮型"] = 0;
        BAccelerationLookup["查理的冬季精靈髮型"] = 0;
        BAccelerationLookup["查理的白虎髮型-D"] = 0;
        BAccelerationLookup["查理的浪漫髮型-D"] = 0;
        //page 4 row 4
        BAccelerationLookup["查理的麒麟髮型-D"] = 0;
        BAccelerationLookup["浪漫提琴手的髮型(女)"] = 0;
        BAccelerationLookup["浪漫提琴手的髮型(男)"] = 0;
        BAccelerationLookup["冷艷吸血鬼髮型-D"] = 0;
        BAccelerationLookup["清新活力髮型(女)-P"] = 0;
        //page 4 row 5
        BAccelerationLookup["清新活力髮型(男)-P"] = 0;
        BAccelerationLookup["闇影修行者髮型"] = 0;
        BAccelerationLookup["莉莉的糖果恆星髮型"] = 0;
        BAccelerationLookup["莉莉的糖果極光髮型"] = 0;
        BAccelerationLookup["莉莉的狂野學園髮型"] = 0;
        //page 4 row 6
        BAccelerationLookup["莉莉的暗黑殺手髮型"] = 0;
        BAccelerationLookup["莉莉的秋天精靈髮型"] = 0;
        BAccelerationLookup["莉莉的聖龍王髮王"] = 0;
        BAccelerationLookup["莉莉的甜蜜布丁髮型"] = 0;
        BAccelerationLookup["莉莉的活力少年髮型"] = 0;

        //page 5 row 1
        BAccelerationLookup["莉莉的戰鬥士髮型"] = 0;
        BAccelerationLookup["莉莉的高尚貴族髮型"] = 0;
        BAccelerationLookup["莉莉的皇族黑夜髮型"] = 0;
        BAccelerationLookup["深幽婚禮頭紗(女)"] = 0;
        BAccelerationLookup["粉橙潮女髮型"] = 0;
        //page 5 row 0
        BAccelerationLookup["粉橙潮男髮型-D"] = 0;
        BAccelerationLookup["閃亮少女髮型-D"] = 0;
        BAccelerationLookup["閃亮少男髮型-D"] = 0;
        BAccelerationLookup["甜蜜布丁髮型"] = 0;
        BAccelerationLookup["糖果極光髮型"] = 0;
        //page 5 row 3
        BAccelerationLookup["韓國貴族校服髮型(女)"] = 0;
        BAccelerationLookup["韓國貴族校服髮型(男)"] = 0;
        BAccelerationLookup["韓國偶像校服髮型(女)"] = 0;
        BAccelerationLookup["韓國偶像校服髮型(男)"] = 0;
        BAccelerationLookup["暗黑魅力髮型-D"] = 0;
        //page 5 row 4
        BAccelerationLookup["光之魅力髮型-D"] = 0;
        BAccelerationLookup["綠焰髮型"] = 0;
        BAccelerationLookup["皇家騎士團髮型-D"] = 0;
        BAccelerationLookup["橘色陽光髮型(女)"] = 0;
        BAccelerationLookup["橘色陽光髮型(男)"] = 0;
        //page 5 row 5
        BAccelerationLookup["摩登少女髮型-D"] = 0;
        BAccelerationLookup["摩登少年髮型-D"] = 0;
        BAccelerationLookup["浪漫少女髮型-D"] = 0;
        BAccelerationLookup["浪漫少年髮型-D"] = 0;
        BAccelerationLookup["白色情人節Cap帽(男)"] = 0;
        //page 5 row 6
        BAccelerationLookup["白色情人節Cap帽(女)"] = 0;
        BAccelerationLookup["清爽春風髮型(女)"] = 0;
        BAccelerationLookup["清爽春風髮型(男)"] = 0;
        BAccelerationLookup["天空之國髮型-D(男)"] = 0;
        BAccelerationLookup["天空之國髮型-D(女)"] = 0;

        //page 6 row 1
        BAccelerationLookup["異世界髮型-D"] = 0;
        BAccelerationLookup["異世甲髮型-D"] = 0;
        BAccelerationLookup["布拉基的髮型-D"] = 0;
        BAccelerationLookup["聖戰女神髮型-D"] = 0;
        BAccelerationLookup["凡賽堤髮型-D"] = 0;
        //page 6 row 0
        BAccelerationLookup["黃金火焰髮型"] = 0;
        BAccelerationLookup["聖光烈焰髮型"] = 0;
        BAccelerationLookup["真 ᛫ 女神白焰髮型"] = 0;
        BAccelerationLookup["安琪公主的頭髮"] = 0;
        BAccelerationLookup["安琪道路的頭髮"] = 0;
        //page 6 row 3
        BAccelerationLookup["魔鬼國王的頭髮"] = 0;
        BAccelerationLookup["魔鬼道路的頭髮"] = 0;
        BAccelerationLookup["極限藍焰髮型"] = 0;
        BAccelerationLookup["傳說的火焰髮型"] = 0;
        BAccelerationLookup["Dr Hell面貝"] = 0;
    }
    #endregion B_Hair Acceleration

    #region B_Hair Power
    void B_Power()
    {
        //page 1 row 1
        BPowerLookup["時尚休閒髮型"] = 0;
        BPowerLookup["夏日野餐髮型(女)-D"] = 0;
        BPowerLookup["夏日野餐髮型(男)-D"] = 0;
        BPowerLookup["夏日時尚髮型(女)"] = 0;
        BPowerLookup["夏日時尚髮型(男)"] = 0;
        //page 1 row 0
        BPowerLookup["悠閒夏日髮型(女)"] = 0;
        BPowerLookup["悠閒夏日髮型(男)"] = 0;
        BPowerLookup["祭典浴衣髮型(女)-D"] = 0;
        BPowerLookup["祭典浴衣髮型(男)-D"] = 0;
        BPowerLookup["春雨櫻花髮型(女)-D"] = 0;
        //page 1 row 3
        BPowerLookup["春雨櫻花髮型(男)-D"] = 0;
        BPowerLookup["活潑的莉莉髮型-D"] = 0;
        BPowerLookup["貴族少爺路易髮型-D"] = 0;
        BPowerLookup["巧克力馬卡龍髮型-D"] = 0;
        BPowerLookup["啦啦隊長髮型(女)-D"] = 0;
        //page 1 row 4
        BPowerLookup["啦啦隊長髮型(男)-D"] = 0;
        BPowerLookup["花樣新衣髮型(女)-D"] = 0;
        BPowerLookup["花樣新衣髮型(男)-D"] = 0;
        BPowerLookup["禦寒時尚髮型(男)-D"] = 0;
        BPowerLookup["禦寒時尚髮型(女)-D"] = 0;
        //page 1 row 5
        BPowerLookup["雪之精靈髮型-D"] = 0;
        BPowerLookup["王國公主髮型-D"] = 0;
        BPowerLookup["王國公主髮飾"] = 0;
        BPowerLookup["伊諾梅爾髮型-D"] = 0;
        BPowerLookup["Ms. Black髮型-D"] = 0;
        //page 1 row 6
        BPowerLookup["Mr. Black髮型-D"] = 0;
        BPowerLookup["幽靈獵人髮型(女)-D"] = 0;
        BPowerLookup["幽靈獵人髮型(男)-D"] = 0;
        BPowerLookup["深秋約會髮型(女)-D"] = 0;
        BPowerLookup["深秋約會髮型(男)-D"] = 0;

        //page 0 row 1
        BPowerLookup["普拉莉絲髮型(女)-D"] = 0;
        BPowerLookup["普拉莉絲髮型(男)-D"] = 0;
        BPowerLookup["夏夜髮型(女)-D"] = 0;
        BPowerLookup["夏夜髮型(男)-D"] = 0;
        BPowerLookup["森之精靈髮型-D"] = 0;
        //page 0 row 0
        BPowerLookup["地獄使者白髮-D"] = 0;
        BPowerLookup["夏日麻花辮(女)-D"] = 0;
        BPowerLookup["夏日灰髮(男)-D"] = 0;
        BPowerLookup["活潑小紅帽髮型-D"] = 0;
        BPowerLookup["酷帥大野狼髮型-D"] = 0;
        //page 0 row 3
        BPowerLookup["深海刑警髮型-D"] = 0;
        BPowerLookup["幼稚園生髮型(女)"] = 0;
        BPowerLookup["幼稚園生髮型(男)"] = 0;
        BPowerLookup["宴會髮型(女)-D"] = 0;
        BPowerLookup["宴會髮型(男)-D"] = 0;
        //page 0 row 4
        BPowerLookup["童話學園髮型(女)-D"] = 0;
        BPowerLookup["童話學園髮型(男)-D"] = 0;
        BPowerLookup["時尚韓服髮型(男)-D"] = 0;
        BPowerLookup["時尚韓服髮型(女)-D"] = 0;
        BPowerLookup["惡魔靈魂髮型-D"] = 0;
        //page 0 row 5
        BPowerLookup["禦寒髮型-D"] = 0;
        BPowerLookup["高階騎士髮型-D"] = 0;
        BPowerLookup["紫晶銀月髮型-D"] = 0;
        BPowerLookup["王后新娘髮型-D"] = 0;
        BPowerLookup["國王新郎髮型-D"] = 0;
        //page 0 row 6
        BPowerLookup["月兔髮型(男)-D"] = 0;
        BPowerLookup["月兔髮型(女)-D"] = 0;
        BPowerLookup["魔法夏卡爾髮型-D"] = 0;
        BPowerLookup["魔法肯恩髮型-D"] = 0;
        BPowerLookup["水手泳裝髮型(男)-D"] = 0;

        //page 3 row 1
        BPowerLookup["水手泳裝髮型(女)-D"] = 0;
        BPowerLookup["秋日休閒髮型(男)-D"] = 0;
        BPowerLookup["秋日休閒髮型(女)-D"] = 0;
        BPowerLookup["星夢戀人短髮-D"] = 0;
        BPowerLookup["星夢戀人長髮-D"] = 0;
        //page 3 row 0
        BPowerLookup["不完整的童話髮型-D"] = 0;
        BPowerLookup["光輝童話髮型-D"] = 0;
        BPowerLookup["亮白羽絨衣髮型-D"] = 0;
        BPowerLookup["個性羽絨衣髮型-D"] = 0;
        BPowerLookup["黑色童話髮型-D"] = 0;
        //page 3 row 3
        BPowerLookup["兔子管家髮型-D"] = 0;
        BPowerLookup["飛魚髮型-D"] = 0;
        BPowerLookup["道士髮型-D"] = 0;
        BPowerLookup["皇牌玩家髮型-D"] = 0;
        BPowerLookup["藍海水母髮型(女)-D"] = 0;
        //page 3 row 4
        BPowerLookup["藍海水母髮型(男)-D"] = 0;
        BPowerLookup["傳說的人魚髮型-D"] = 0;
        BPowerLookup["森林冒險家髮型-D"] = 0;
        BPowerLookup["日之光輝髮型-D"] = 0;
        BPowerLookup["舞動少年Cap帽(女)-D"] = 0;
        //page 3 row 5
        BPowerLookup["舞動少年Cap帽(男)-D"] = 0;
        BPowerLookup["高級守護者髮型-D"] = 0;
        BPowerLookup["溫馨約會長髮-D"] = 0;
        BPowerLookup["溫馨約會短髮-D"] = 0;
        BPowerLookup["典雅韓式髮型(女)-D"] = 0;
        //page 3 row 6
        BPowerLookup["典雅韓底髮型(男)-D"] = 0;
        BPowerLookup["淡雅韓底髮型(女)-D"] = 0;
        BPowerLookup["淡雅韓底髮型(男)-D"] = 0;
        BPowerLookup["守護妖精髮型-D"] = 0;
        BPowerLookup["女王護衛髮型-D"] = 0;
        //page 4 row 1
        BPowerLookup["冰雪女王髮型-D"] = 0;
        BPowerLookup["柔白雪花髮型-D"] = 0;
        BPowerLookup["甜美淑女髮型-D"] = 0;
        BPowerLookup["白髮女巫髮型-D"] = 1;
        BPowerLookup["黑女巫髮型-D"] = 0;
        //page 4 row 0
        BPowerLookup["萬聖節奸笑南瓜-D"] = 0;
        BPowerLookup["萬聖節大笑南瓜-D"] = 0;
        BPowerLookup["查理的明星髮型-D"] = 0;
        BPowerLookup["查理的藍色精靈髮型"] = 0;
        BPowerLookup["查理的魅影髮型-D"] = 0;
        //page 4 row 3
        BPowerLookup["查理的貴族髮型-D"] = 0;
        BPowerLookup["查理的橙色陽光髮型"] = 0;
        BPowerLookup["查理的冬季精靈髮型"] = 0;
        BPowerLookup["查理的白虎髮型-D"] = 0;
        BPowerLookup["查理的浪漫髮型-D"] = 0;
        //page 4 row 4
        BPowerLookup["查理的麒麟髮型-D"] = 0;
        BPowerLookup["浪漫提琴手的髮型(女)"] = 0;
        BPowerLookup["浪漫提琴手的髮型(男)"] = 0;
        BPowerLookup["冷艷吸血鬼髮型-D"] = 0;
        BPowerLookup["清新活力髮型(女)-P"] = 0;
        //page 4 row 5
        BPowerLookup["清新活力髮型(男)-P"] = 0;
        BPowerLookup["闇影修行者髮型"] = 0;
        BPowerLookup["莉莉的糖果恆星髮型"] = 0;
        BPowerLookup["莉莉的糖果極光髮型"] = 0;
        BPowerLookup["莉莉的狂野學園髮型"] = 0;
        //page 4 row 6
        BPowerLookup["莉莉的暗黑殺手髮型"] = 0;
        BPowerLookup["莉莉的秋天精靈髮型"] = 0;
        BPowerLookup["莉莉的聖龍王髮王"] = 0;
        BPowerLookup["莉莉的甜蜜布丁髮型"] = 0;
        BPowerLookup["莉莉的活力少年髮型"] = 0;

        //page 5 row 1
        BPowerLookup["莉莉的戰鬥士髮型"] = 0;
        BPowerLookup["莉莉的高尚貴族髮型"] = 0;
        BPowerLookup["莉莉的皇族黑夜髮型"] = 0;
        BPowerLookup["深幽婚禮頭紗(女)"] = 0;
        BPowerLookup["粉橙潮女髮型"] = 0;
        //page 5 row 0
        BPowerLookup["粉橙潮男髮型-D"] = 0;
        BPowerLookup["閃亮少女髮型-D"] = 0;
        BPowerLookup["閃亮少男髮型-D"] = 0;
        BPowerLookup["甜蜜布丁髮型"] = 0;
        BPowerLookup["糖果極光髮型"] = 0;
        //page 5 row 3
        BPowerLookup["韓國貴族校服髮型(女)"] = 0;
        BPowerLookup["韓國貴族校服髮型(男)"] = 0;
        BPowerLookup["韓國偶像校服髮型(女)"] = 0;
        BPowerLookup["韓國偶像校服髮型(男)"] = 0;
        BPowerLookup["暗黑魅力髮型-D"] = 0;
        //page 5 row 4
        BPowerLookup["光之魅力髮型-D"] = 0;
        BPowerLookup["綠焰髮型"] = 0;
        BPowerLookup["皇家騎士團髮型-D"] = 0;
        BPowerLookup["橘色陽光髮型(女)"] = 0;
        BPowerLookup["橘色陽光髮型(男)"] = 0;
        //page 5 row 5
        BPowerLookup["摩登少女髮型-D"] = 0;
        BPowerLookup["摩登少年髮型-D"] = 0;
        BPowerLookup["浪漫少女髮型-D"] = 0;
        BPowerLookup["浪漫少年髮型-D"] = 0;
        BPowerLookup["白色情人節Cap帽(男)"] = 0;
        //page 5 row 6
        BPowerLookup["白色情人節Cap帽(女)"] = 0;
        BPowerLookup["清爽春風髮型(女)"] = 0;
        BPowerLookup["清爽春風髮型(男)"] = 0;
        BPowerLookup["天空之國髮型-D(男)"] = 0;
        BPowerLookup["天空之國髮型-D(女)"] = 0;

        //page 6 row 1
        BPowerLookup["異世界髮型-D"] = 0;
        BPowerLookup["異世甲髮型-D"] = 0;
        BPowerLookup["布拉基的髮型-D"] = 0;
        BPowerLookup["聖戰女神髮型-D"] = 0;
        BPowerLookup["凡賽堤髮型-D"] = 0;
        //page 6 row 0
        BPowerLookup["黃金火焰髮型"] = 0;
        BPowerLookup["聖光烈焰髮型"] = 0;
        BPowerLookup["真 ᛫ 女神白焰髮型"] = 0;
        BPowerLookup["安琪公主的頭髮"] = 0;
        BPowerLookup["安琪道路的頭髮"] = 0;
        //page 6 row 3
        BPowerLookup["魔鬼國王的頭髮"] = 0;
        BPowerLookup["魔鬼道路的頭髮"] = 0;
        BPowerLookup["極限藍焰髮型"] = 0;
        BPowerLookup["傳說的火焰髮型"] = 0;
        BPowerLookup["Dr Hell面貝"] = 0;
    }
    #endregion B_Hair Power

    #region B_Hair Control
    void B_Control()
    {
        //page 1 row 1
        BControlLookup["時尚休閒髮型"] = 0;
        BControlLookup["夏日野餐髮型(女)-D"] = 0;
        BControlLookup["夏日野餐髮型(男)-D"] = 0;
        BControlLookup["夏日時尚髮型(女)"] = 0;
        BControlLookup["夏日時尚髮型(男)"] = 0;
        //page 1 row 0
        BControlLookup["悠閒夏日髮型(女)"] = 0;
        BControlLookup["悠閒夏日髮型(男)"] = 0;
        BControlLookup["祭典浴衣髮型(女)-D"] = 0;
        BControlLookup["祭典浴衣髮型(男)-D"] = 0;
        BControlLookup["春雨櫻花髮型(女)-D"] = 0;
        //page 1 row 3
        BControlLookup["春雨櫻花髮型(男)-D"] = 0;
        BControlLookup["活潑的莉莉髮型-D"] = 0;
        BControlLookup["貴族少爺路易髮型-D"] = 0;
        BControlLookup["巧克力馬卡龍髮型-D"] = 0;
        BControlLookup["啦啦隊長髮型(女)-D"] = 0;
        //page 1 row 4
        BControlLookup["啦啦隊長髮型(男)-D"] = 0;
        BControlLookup["花樣新衣髮型(女)-D"] = 0;
        BControlLookup["花樣新衣髮型(男)-D"] = 0;
        BControlLookup["禦寒時尚髮型(男)-D"] = 0;
        BControlLookup["禦寒時尚髮型(女)-D"] = 0;
        //page 1 row 5
        BControlLookup["雪之精靈髮型-D"] = 0;
        BControlLookup["王國公主髮型-D"] = 0;
        BControlLookup["王國公主髮飾"] = 0;
        BControlLookup["伊諾梅爾髮型-D"] = 0;
        BControlLookup["Ms. Black髮型-D"] = 0;
        //page 1 row 6
        BControlLookup["Mr. Black髮型-D"] = 0;
        BControlLookup["幽靈獵人髮型(女)-D"] = 0;
        BControlLookup["幽靈獵人髮型(男)-D"] = 0;
        BControlLookup["深秋約會髮型(女)-D"] = 0;
        BControlLookup["深秋約會髮型(男)-D"] = 0;

        //page 0 row 1
        BControlLookup["普拉莉絲髮型(女)-D"] = 0;
        BControlLookup["普拉莉絲髮型(男)-D"] = 0;
        BControlLookup["夏夜髮型(女)-D"] = 0;
        BControlLookup["夏夜髮型(男)-D"] = 0;
        BControlLookup["森之精靈髮型-D"] = 0;
        //page 0 row 0
        BControlLookup["地獄使者白髮-D"] = 0;
        BControlLookup["夏日麻花辮(女)-D"] = 0;
        BControlLookup["夏日灰髮(男)-D"] = 0;
        BControlLookup["活潑小紅帽髮型-D"] = 0;
        BControlLookup["酷帥大野狼髮型-D"] = 0;
        //page 0 row 3
        BControlLookup["深海刑警髮型-D"] = 0;
        BControlLookup["幼稚園生髮型(女)"] = 0;
        BControlLookup["幼稚園生髮型(男)"] = 0;
        BControlLookup["宴會髮型(女)-D"] = 0;
        BControlLookup["宴會髮型(男)-D"] = 0;
        //page 0 row 4
        BControlLookup["童話學園髮型(女)-D"] = 0;
        BControlLookup["童話學園髮型(男)-D"] = 0;
        BControlLookup["時尚韓服髮型(男)-D"] = 0;
        BControlLookup["時尚韓服髮型(女)-D"] = 0;
        BControlLookup["惡魔靈魂髮型-D"] = 0;
        //page 0 row 5
        BControlLookup["禦寒髮型-D"] = 0;
        BControlLookup["高階騎士髮型-D"] = 0;
        BControlLookup["紫晶銀月髮型-D"] = 0;
        BControlLookup["王后新娘髮型-D"] = 0;
        BControlLookup["國王新郎髮型-D"] = 0;
        //page 0 row 6
        BControlLookup["月兔髮型(男)-D"] = 0;
        BControlLookup["月兔髮型(女)-D"] = 0;
        BControlLookup["魔法夏卡爾髮型-D"] = 0;
        BControlLookup["魔法肯恩髮型-D"] = 0;
        BControlLookup["水手泳裝髮型(男)-D"] = 0;

        //page 3 row 1
        BControlLookup["水手泳裝髮型(女)-D"] = 0;
        BControlLookup["秋日休閒髮型(男)-D"] = 0;
        BControlLookup["秋日休閒髮型(女)-D"] = 0;
        BControlLookup["星夢戀人短髮-D"] = 0;
        BControlLookup["星夢戀人長髮-D"] = 0;
        //page 3 row 0
        BControlLookup["不完整的童話髮型-D"] = 0;
        BControlLookup["光輝童話髮型-D"] = 0;
        BControlLookup["亮白羽絨衣髮型-D"] = 0;
        BControlLookup["個性羽絨衣髮型-D"] = 0;
        BControlLookup["黑色童話髮型-D"] = 0;
        //page 3 row 3
        BControlLookup["兔子管家髮型-D"] = 0;
        BControlLookup["飛魚髮型-D"] = 0;
        BControlLookup["道士髮型-D"] = 0;
        BControlLookup["皇牌玩家髮型-D"] = 0;
        BControlLookup["藍海水母髮型(女)-D"] = 0;
        //page 3 row 4
        BControlLookup["藍海水母髮型(男)-D"] = 0;
        BControlLookup["傳說的人魚髮型-D"] = 0;
        BControlLookup["森林冒險家髮型-D"] = 0;
        BControlLookup["日之光輝髮型-D"] = 0;
        BControlLookup["舞動少年Cap帽(女)-D"] = 0;
        //page 3 row 5
        BControlLookup["舞動少年Cap帽(男)-D"] = 0;
        BControlLookup["高級守護者髮型-D"] = 0;
        BControlLookup["溫馨約會長髮-D"] = 0;
        BControlLookup["溫馨約會短髮-D"] = 0;
        BControlLookup["典雅韓式髮型(女)-D"] = 0;
        //page 3 row 6
        BControlLookup["典雅韓底髮型(男)-D"] = 0;
        BControlLookup["淡雅韓底髮型(女)-D"] = 0;
        BControlLookup["淡雅韓底髮型(男)-D"] = 0;
        BControlLookup["守護妖精髮型-D"] = 0;
        BControlLookup["女王護衛髮型-D"] = 0;
        //page 4 row 1
        BControlLookup["冰雪女王髮型-D"] = 0;
        BControlLookup["柔白雪花髮型-D"] = 0;
        BControlLookup["甜美淑女髮型-D"] = 0;
        BControlLookup["白髮女巫髮型-D"] = 0;
        BControlLookup["黑女巫髮型-D"] = 0;
        //page 4 row 0
        BControlLookup["萬聖節奸笑南瓜-D"] = 0;
        BControlLookup["萬聖節大笑南瓜-D"] = 0;
        BControlLookup["查理的明星髮型-D"] = 0;
        BControlLookup["查理的藍色精靈髮型"] = 0;
        BControlLookup["查理的魅影髮型-D"] = 0;
        //page 4 row 3
        BControlLookup["查理的貴族髮型-D"] = 0;
        BControlLookup["查理的橙色陽光髮型"] = 0;
        BControlLookup["查理的冬季精靈髮型"] = 0;
        BControlLookup["查理的白虎髮型-D"] = 0;
        BControlLookup["查理的浪漫髮型-D"] = 0;
        //page 4 row 4
        BControlLookup["查理的麒麟髮型-D"] = 0;
        BControlLookup["浪漫提琴手的髮型(女)"] = 0;
        BControlLookup["浪漫提琴手的髮型(男)"] = 0;
        BControlLookup["冷艷吸血鬼髮型-D"] = 0;
        BControlLookup["清新活力髮型(女)-P"] = 0;
        //page 4 row 5
        BControlLookup["清新活力髮型(男)-P"] = 0;
        BControlLookup["闇影修行者髮型"] = 0;
        BControlLookup["莉莉的糖果恆星髮型"] = 0;
        BControlLookup["莉莉的糖果極光髮型"] = 0;
        BControlLookup["莉莉的狂野學園髮型"] = 0;
        //page 4 row 6
        BControlLookup["莉莉的暗黑殺手髮型"] = 0;
        BControlLookup["莉莉的秋天精靈髮型"] = 0;
        BControlLookup["莉莉的聖龍王髮王"] = 0;
        BControlLookup["莉莉的甜蜜布丁髮型"] = 0;
        BControlLookup["莉莉的活力少年髮型"] = 0;

        //page 5 row 1
        BControlLookup["莉莉的戰鬥士髮型"] = 0;
        BControlLookup["莉莉的高尚貴族髮型"] = 0;
        BControlLookup["莉莉的皇族黑夜髮型"] = 0;
        BControlLookup["深幽婚禮頭紗(女)"] = 0;
        BControlLookup["粉橙潮女髮型"] = 0;
        //page 5 row 0
        BControlLookup["粉橙潮男髮型-D"] = 0;
        BControlLookup["閃亮少女髮型-D"] = 0;
        BControlLookup["閃亮少男髮型-D"] = 0;
        BControlLookup["甜蜜布丁髮型"] = 0;
        BControlLookup["糖果極光髮型"] = 0;
        //page 5 row 3
        BControlLookup["韓國貴族校服髮型(女)"] = 0;
        BControlLookup["韓國貴族校服髮型(男)"] = 0;
        BControlLookup["韓國偶像校服髮型(女)"] = 0;
        BControlLookup["韓國偶像校服髮型(男)"] = 0;
        BControlLookup["暗黑魅力髮型-D"] = 0;
        //page 5 row 4
        BControlLookup["光之魅力髮型-D"] = 0;
        BControlLookup["綠焰髮型"] = 0;
        BControlLookup["皇家騎士團髮型-D"] = 0;
        BControlLookup["橘色陽光髮型(女)"] = 0;
        BControlLookup["橘色陽光髮型(男)"] = 0;
        //page 5 row 5
        BControlLookup["摩登少女髮型-D"] = 0;
        BControlLookup["摩登少年髮型-D"] = 0;
        BControlLookup["浪漫少女髮型-D"] = 0;
        BControlLookup["浪漫少年髮型-D"] = 0;
        BControlLookup["白色情人節Cap帽(男)"] = 0;
        //page 5 row 6
        BControlLookup["白色情人節Cap帽(女)"] = 0;
        BControlLookup["清爽春風髮型(女)"] = 0;
        BControlLookup["清爽春風髮型(男)"] = 0;
        BControlLookup["天空之國髮型-D(男)"] = 0;
        BControlLookup["天空之國髮型-D(女)"] = 0;

        //page 6 row 1
        BControlLookup["異世界髮型-D"] = 0;
        BControlLookup["異世甲髮型-D"] = 0;
        BControlLookup["布拉基的髮型-D"] = 0;
        BControlLookup["聖戰女神髮型-D"] = 0;
        BControlLookup["凡賽堤髮型-D"] = 0;
        //page 6 row 0
        BControlLookup["黃金火焰髮型"] = 0;
        BControlLookup["聖光烈焰髮型"] = 0;
        BControlLookup["真 ᛫ 女神白焰髮型"] = 0;
        BControlLookup["安琪公主的頭髮"] = 0;
        BControlLookup["安琪道路的頭髮"] = 0;
        //page 6 row 3
        BControlLookup["魔鬼國王的頭髮"] = 0;
        BControlLookup["魔鬼道路的頭髮"] = 0;
        BControlLookup["極限藍焰髮型"] = 0;
        BControlLookup["傳說的火焰髮型"] = 0;
        BControlLookup["Dr Hell面貝"] = 0;
    }
    #endregion B_Hair Control

    #region B_Hair Rage Duration
    void B_RageDuration()
    {
        //page 1 row 1
        BRageDurationLookup["時尚休閒髮型"] = 8;
        BRageDurationLookup["夏日野餐髮型(女)-D"] = 5;
        BRageDurationLookup["夏日野餐髮型(男)-D"] = 5;
        BRageDurationLookup["夏日時尚髮型(女)"] = 8;
        BRageDurationLookup["夏日時尚髮型(男)"] = 8;
        //page 1 row 0
        BRageDurationLookup["悠閒夏日髮型(女)"] = 8;
        BRageDurationLookup["悠閒夏日髮型(男)"] = 8;
        BRageDurationLookup["祭典浴衣髮型(女)-D"] = 5;
        BRageDurationLookup["祭典浴衣髮型(男)-D"] = 5;
        BRageDurationLookup["春雨櫻花髮型(女)-D"] = 5;
        //page 1 row 3
        BRageDurationLookup["春雨櫻花髮型(男)-D"] = 5;
        BRageDurationLookup["活潑的莉莉髮型-D"] = 5;
        BRageDurationLookup["貴族少爺路易髮型-D"] = 5;
        BRageDurationLookup["巧克力馬卡龍髮型-D"] = 0;
        BRageDurationLookup["啦啦隊長髮型(女)-D"] = 5;
        //page 1 row 4
        BRageDurationLookup["啦啦隊長髮型(男)-D"] = 5;
        BRageDurationLookup["花樣新衣髮型(女)-D"] = 5;
        BRageDurationLookup["花樣新衣髮型(男)-D"] = 5;
        BRageDurationLookup["禦寒時尚髮型(男)-D"] = 8;
        BRageDurationLookup["禦寒時尚髮型(女)-D"] = 8;
        //page 1 row 5
        BRageDurationLookup["雪之精靈髮型-D"] = 8;
        BRageDurationLookup["王國公主髮型-D"] = 5;
        BRageDurationLookup["王國公主髮飾"] = 0;
        BRageDurationLookup["伊諾梅爾髮型-D"] = 8;
        BRageDurationLookup["Ms. Black髮型-D"] = 5;
        //page 1 row 6
        BRageDurationLookup["Mr. Black髮型-D"] = 5;
        BRageDurationLookup["幽靈獵人髮型(女)-D"] = 5;
        BRageDurationLookup["幽靈獵人髮型(男)-D"] = 5;
        BRageDurationLookup["深秋約會髮型(女)-D"] = 5;
        BRageDurationLookup["深秋約會髮型(男)-D"] = 5;

        //page 0 row 1
        BRageDurationLookup["普拉莉絲髮型(女)-D"] = 5;
        BRageDurationLookup["普拉莉絲髮型(男)-D"] = 5;
        BRageDurationLookup["夏夜髮型(女)-D"] = 8;
        BRageDurationLookup["夏夜髮型(男)-D"] = 8;
        BRageDurationLookup["森之精靈髮型-D"] = 8;
        //page 0 row 0
        BRageDurationLookup["地獄使者白髮-D"] = 5;
        BRageDurationLookup["夏日麻花辮(女)-D"] = 5;
        BRageDurationLookup["夏日灰髮(男)-D"] = 5;
        BRageDurationLookup["活潑小紅帽髮型-D"] = 5;
        BRageDurationLookup["酷帥大野狼髮型-D"] = 5;
        //page 0 row 3
        BRageDurationLookup["深海刑警髮型-D"] = 5;
        BRageDurationLookup["幼稚園生髮型(女)"] = 5;
        BRageDurationLookup["幼稚園生髮型(男)"] = 5;
        BRageDurationLookup["宴會髮型(女)-D"] = 5;
        BRageDurationLookup["宴會髮型(男)-D"] = 5;
        //page 0 row 4
        BRageDurationLookup["童話學園髮型(女)-D"] = 5;
        BRageDurationLookup["童話學園髮型(男)-D"] = 5;
        BRageDurationLookup["時尚韓服髮型(男)-D"] = 5;
        BRageDurationLookup["時尚韓服髮型(女)-D"] = 5;
        BRageDurationLookup["惡魔靈魂髮型-D"] = 5;
        //page 0 row 5
        BRageDurationLookup["禦寒髮型-D"] = 8;
        BRageDurationLookup["高階騎士髮型-D"] = 8;
        BRageDurationLookup["紫晶銀月髮型-D"] = 8;
        BRageDurationLookup["王后新娘髮型-D"] = 5;
        BRageDurationLookup["國王新郎髮型-D"] = 5;
        //page 0 row 6
        BRageDurationLookup["月兔髮型(男)-D"] = 5;
        BRageDurationLookup["月兔髮型(女)-D"] = 5;
        BRageDurationLookup["魔法夏卡爾髮型-D"] = 5;
        BRageDurationLookup["魔法肯恩髮型-D"] = 5;
        BRageDurationLookup["水手泳裝髮型(男)-D"] = 5;

        //page 3 row 1
        BRageDurationLookup["水手泳裝髮型(女)-D"] = 5;
        BRageDurationLookup["秋日休閒髮型(男)-D"] = 5;
        BRageDurationLookup["秋日休閒髮型(女)-D"] = 5;
        BRageDurationLookup["星夢戀人短髮-D"] = 5;
        BRageDurationLookup["星夢戀人長髮-D"] = 5;
        //page 3 row 0
        BRageDurationLookup["不完整的童話髮型-D"] = 8;
        BRageDurationLookup["光輝童話髮型-D"] = 8;
        BRageDurationLookup["亮白羽絨衣髮型-D"] = 5;
        BRageDurationLookup["個性羽絨衣髮型-D"] = 5;
        BRageDurationLookup["黑色童話髮型-D"] = 8;
        //page 3 row 3
        BRageDurationLookup["兔子管家髮型-D"] = 8;
        BRageDurationLookup["飛魚髮型-D"] = 8;
        BRageDurationLookup["道士髮型-D"] = 5;
        BRageDurationLookup["皇牌玩家髮型-D"] = 8;
        BRageDurationLookup["藍海水母髮型(女)-D"] = 5;
        //page 3 row 4
        BRageDurationLookup["藍海水母髮型(男)-D"] = 5;
        BRageDurationLookup["傳說的人魚髮型-D"] = 8;
        BRageDurationLookup["森林冒險家髮型-D"] = 8;
        BRageDurationLookup["日之光輝髮型-D"] = 5;
        BRageDurationLookup["舞動少年Cap帽(女)-D"] = 10;
        //page 3 row 5
        BRageDurationLookup["舞動少年Cap帽(男)-D"] = 10;
        BRageDurationLookup["高級守護者髮型-D"] = 5;
        BRageDurationLookup["溫馨約會長髮-D"] = 5;
        BRageDurationLookup["溫馨約會短髮-D"] = 5;
        BRageDurationLookup["典雅韓式髮型(女)-D"] = 5;
        //page 3 row 6
        BRageDurationLookup["典雅韓底髮型(男)-D"] = 5;
        BRageDurationLookup["淡雅韓底髮型(女)-D"] = 5;
        BRageDurationLookup["淡雅韓底髮型(男)-D"] = 5;
        BRageDurationLookup["守護妖精髮型-D"] = 5;
        BRageDurationLookup["女王護衛髮型-D"] = 8;
        //page 4 row 1
        BRageDurationLookup["冰雪女王髮型-D"] = 8;
        BRageDurationLookup["柔白雪花髮型-D"] = 5;
        BRageDurationLookup["甜美淑女髮型-D"] = 5;
        BRageDurationLookup["白髮女巫髮型-D"] = 10;
        BRageDurationLookup["黑女巫髮型-D"] = 10;
        //page 4 row 0
        BRageDurationLookup["萬聖節奸笑南瓜-D"] = 10;
        BRageDurationLookup["萬聖節大笑南瓜-D"] = 10;
        BRageDurationLookup["查理的明星髮型-D"] = 5;
        BRageDurationLookup["查理的藍色精靈髮型"] = 5;
        BRageDurationLookup["查理的魅影髮型-D"] = 5;
        //page 4 row 3
        BRageDurationLookup["查理的貴族髮型-D"] = 5;
        BRageDurationLookup["查理的橙色陽光髮型"] = 5;
        BRageDurationLookup["查理的冬季精靈髮型"] = 5;
        BRageDurationLookup["查理的白虎髮型-D"] = 5;
        BRageDurationLookup["查理的浪漫髮型-D"] = 5;
        //page 4 row 4
        BRageDurationLookup["查理的麒麟髮型-D"] = 5;
        BRageDurationLookup["浪漫提琴手的髮型(女)"] = 5;
        BRageDurationLookup["浪漫提琴手的髮型(男)"] = 5;
        BRageDurationLookup["冷艷吸血鬼髮型-D"] = 8;
        BRageDurationLookup["清新活力髮型(女)-P"] = 5;
        //page 4 row 5
        BRageDurationLookup["清新活力髮型(男)-P"] = 5;
        BRageDurationLookup["闇影修行者髮型"] = 5;
        BRageDurationLookup["莉莉的糖果恆星髮型"] = 5;
        BRageDurationLookup["莉莉的糖果極光髮型"] = 5;
        BRageDurationLookup["莉莉的狂野學園髮型"] = 5;
        //page 4 row 6
        BRageDurationLookup["莉莉的暗黑殺手髮型"] = 5;
        BRageDurationLookup["莉莉的秋天精靈髮型"] = 5;
        BRageDurationLookup["莉莉的聖龍王髮王"] = 5;
        BRageDurationLookup["莉莉的甜蜜布丁髮型"] = 5;
        BRageDurationLookup["莉莉的活力少年髮型"] = 5;

        //page 5 row 1
        BRageDurationLookup["莉莉的戰鬥士髮型"] = 5;
        BRageDurationLookup["莉莉的高尚貴族髮型"] = 5;
        BRageDurationLookup["莉莉的皇族黑夜髮型"] = 5;
        BRageDurationLookup["深幽婚禮頭紗(女)"] = 10;
        BRageDurationLookup["粉橙潮女髮型"] = 5;
        //page 5 row 0
        BRageDurationLookup["粉橙潮男髮型-D"] = 5;
        BRageDurationLookup["閃亮少女髮型-D"] = 5;
        BRageDurationLookup["閃亮少男髮型-D"] = 5;
        BRageDurationLookup["甜蜜布丁髮型"] = 5;
        BRageDurationLookup["糖果極光髮型"] = 5;
        //page 5 row 3
        BRageDurationLookup["韓國貴族校服髮型(女)"] = 5;
        BRageDurationLookup["韓國貴族校服髮型(男)"] = 5;
        BRageDurationLookup["韓國偶像校服髮型(女)"] = 5;
        BRageDurationLookup["韓國偶像校服髮型(男)"] = 5;
        BRageDurationLookup["暗黑魅力髮型-D"] = 5;
        //page 5 row 4
        BRageDurationLookup["光之魅力髮型-D"] = 5;
        BRageDurationLookup["綠焰髮型"] = 10;
        BRageDurationLookup["皇家騎士團髮型-D"] = 10;
        BRageDurationLookup["橘色陽光髮型(女)"] = 0;
        BRageDurationLookup["橘色陽光髮型(男)"] = 0;
        //page 5 row 5
        BRageDurationLookup["摩登少女髮型-D"] = 0;
        BRageDurationLookup["摩登少年髮型-D"] = 0;
        BRageDurationLookup["浪漫少女髮型-D"] = 0;
        BRageDurationLookup["浪漫少年髮型-D"] = 0;
        BRageDurationLookup["白色情人節Cap帽(男)"] = 0;
        //page 5 row 6
        BRageDurationLookup["白色情人節Cap帽(女)"] = 0;
        BRageDurationLookup["清爽春風髮型(女)"] = 0;
        BRageDurationLookup["清爽春風髮型(男)"] = 0;
        BRageDurationLookup["天空之國髮型-D(男)"] = 0;
        BRageDurationLookup["天空之國髮型-D(女)"] = 0;

        //page 6 row 1
        BRageDurationLookup["異世界髮型-D"] = 0;
        BRageDurationLookup["異世甲髮型-D"] = 0;
        BRageDurationLookup["布拉基的髮型-D"] = 0;
        BRageDurationLookup["聖戰女神髮型-D"] = 10;
        BRageDurationLookup["凡賽堤髮型-D"] = 0;
        //page 6 row 0
        BRageDurationLookup["黃金火焰髮型"] = 0;
        BRageDurationLookup["聖光烈焰髮型"] = 0;
        BRageDurationLookup["真 ᛫ 女神白焰髮型"] = 0;
        BRageDurationLookup["安琪公主的頭髮"] = 0;
        BRageDurationLookup["安琪道路的頭髮"] = 0;
        //page 6 row 3
        BRageDurationLookup["魔鬼國王的頭髮"] = 0;
        BRageDurationLookup["魔鬼道路的頭髮"] = 0;
        BRageDurationLookup["極限藍焰髮型"] = 0;
        BRageDurationLookup["傳說的火焰髮型"] = 0;
        BRageDurationLookup["Dr Hell面貝"] = 0;
    }
    #endregion B_Hair Rage Duration

    #region B_Hair Rage Charge
    void B_RageCharge()
    {
        //page 1 row 1
        BRageChargeLookup["時尚休閒髮型"] = 8;
        BRageChargeLookup["夏日野餐髮型(女)-D"] = 5;
        BRageChargeLookup["夏日野餐髮型(男)-D"] = 5;
        BRageChargeLookup["夏日時尚髮型(女)"] = 8;
        BRageChargeLookup["夏日時尚髮型(男)"] = 8;
        //page 1 row 0
        BRageChargeLookup["悠閒夏日髮型(女)"] = 8;
        BRageChargeLookup["悠閒夏日髮型(男)"] = 8;
        BRageChargeLookup["祭典浴衣髮型(女)-D"] = 5;
        BRageChargeLookup["祭典浴衣髮型(男)-D"] = 5;
        BRageChargeLookup["春雨櫻花髮型(女)-D"] = 5;
        //page 1 row 3
        BRageChargeLookup["春雨櫻花髮型(男)-D"] = 5;
        BRageChargeLookup["活潑的莉莉髮型-D"] = 5;
        BRageChargeLookup["貴族少爺路易髮型-D"] = 5;
        BRageChargeLookup["巧克力馬卡龍髮型-D"] = 0;
        BRageChargeLookup["啦啦隊長髮型(女)-D"] = 5;
        //page 1 row 4
        BRageChargeLookup["啦啦隊長髮型(男)-D"] = 5;
        BRageChargeLookup["花樣新衣髮型(女)-D"] = 5;
        BRageChargeLookup["花樣新衣髮型(男)-D"] = 5;
        BRageChargeLookup["禦寒時尚髮型(男)-D"] = 8;
        BRageChargeLookup["禦寒時尚髮型(女)-D"] = 8;
        //page 1 row 5
        BRageChargeLookup["雪之精靈髮型-D"] = 8;
        BRageChargeLookup["王國公主髮型-D"] = 5;
        BRageChargeLookup["王國公主髮飾"] = 0;
        BRageChargeLookup["伊諾梅爾髮型-D"] = 8;
        BRageChargeLookup["Ms. Black髮型-D"] = 5;
        //page 1 row 6
        BRageChargeLookup["Mr. Black髮型-D"] = 5;
        BRageChargeLookup["幽靈獵人髮型(女)-D"] = 5;
        BRageChargeLookup["幽靈獵人髮型(男)-D"] = 5;
        BRageChargeLookup["深秋約會髮型(女)-D"] = 5;
        BRageChargeLookup["深秋約會髮型(男)-D"] = 5;

        //page 0 row 1
        BRageChargeLookup["普拉莉絲髮型(女)-D"] = 5;
        BRageChargeLookup["普拉莉絲髮型(男)-D"] = 5;
        BRageChargeLookup["夏夜髮型(女)-D"] = 8;
        BRageChargeLookup["夏夜髮型(男)-D"] = 8;
        BRageChargeLookup["森之精靈髮型-D"] = 8;
        //page 0 row 0
        BRageChargeLookup["地獄使者白髮-D"] = 5;
        BRageChargeLookup["夏日麻花辮(女)-D"] = 5;
        BRageChargeLookup["夏日灰髮(男)-D"] = 5;
        BRageChargeLookup["活潑小紅帽髮型-D"] = 5;
        BRageChargeLookup["酷帥大野狼髮型-D"] = 5;
        //page 0 row 3
        BRageChargeLookup["深海刑警髮型-D"] = 5;
        BRageChargeLookup["幼稚園生髮型(女)"] = 5;
        BRageChargeLookup["幼稚園生髮型(男)"] = 5;
        BRageChargeLookup["宴會髮型(女)-D"] = 5;
        BRageChargeLookup["宴會髮型(男)-D"] = 5;
        //page 0 row 4
        BRageChargeLookup["童話學園髮型(女)-D"] = 5;
        BRageChargeLookup["童話學園髮型(男)-D"] = 5;
        BRageChargeLookup["時尚韓服髮型(男)-D"] = 5;
        BRageChargeLookup["時尚韓服髮型(女)-D"] = 5;
        BRageChargeLookup["惡魔靈魂髮型-D"] = 5;
        //page 0 row 5
        BRageChargeLookup["禦寒髮型-D"] = 8;
        BRageChargeLookup["高階騎士髮型-D"] = 8;
        BRageChargeLookup["紫晶銀月髮型-D"] = 8;
        BRageChargeLookup["王后新娘髮型-D"] = 5;
        BRageChargeLookup["國王新郎髮型-D"] = 5;
        //page 0 row 6
        BRageChargeLookup["月兔髮型(男)-D"] = 5;
        BRageChargeLookup["月兔髮型(女)-D"] = 5;
        BRageChargeLookup["魔法夏卡爾髮型-D"] = 5;
        BRageChargeLookup["魔法肯恩髮型-D"] = 5;
        BRageChargeLookup["水手泳裝髮型(男)-D"] = 5;

        //page 3 row 1
        BRageChargeLookup["水手泳裝髮型(女)-D"] = 5;
        BRageChargeLookup["秋日休閒髮型(男)-D"] = 5;
        BRageChargeLookup["秋日休閒髮型(女)-D"] = 5;
        BRageChargeLookup["星夢戀人短髮-D"] = 5;
        BRageChargeLookup["星夢戀人長髮-D"] = 5;
        //page 3 row 0
        BRageChargeLookup["不完整的童話髮型-D"] = 8;
        BRageChargeLookup["光輝童話髮型-D"] = 8;
        BRageChargeLookup["亮白羽絨衣髮型-D"] = 5;
        BRageChargeLookup["個性羽絨衣髮型-D"] = 5;
        BRageChargeLookup["黑色童話髮型-D"] = 8;
        //page 3 row 3
        BRageChargeLookup["兔子管家髮型-D"] = 8;
        BRageChargeLookup["飛魚髮型-D"] = 8;
        BRageChargeLookup["道士髮型-D"] = 5;
        BRageChargeLookup["皇牌玩家髮型-D"] = 8;
        BRageChargeLookup["藍海水母髮型(女)-D"] = 5;
        //page 3 row 4
        BRageChargeLookup["藍海水母髮型(男)-D"] = 5;
        BRageChargeLookup["傳說的人魚髮型-D"] = 8;
        BRageChargeLookup["森林冒險家髮型-D"] = 8;
        BRageChargeLookup["日之光輝髮型-D"] = 5;
        BRageChargeLookup["舞動少年Cap帽(女)-D"] = 10;
        //page 3 row 5
        BRageChargeLookup["舞動少年Cap帽(男)-D"] = 10;
        BRageChargeLookup["高級守護者髮型-D"] = 5;
        BRageChargeLookup["溫馨約會長髮-D"] = 5;
        BRageChargeLookup["溫馨約會短髮-D"] = 5;
        BRageChargeLookup["典雅韓式髮型(女)-D"] = 5;
        //page 3 row 6
        BRageChargeLookup["典雅韓底髮型(男)-D"] = 5;
        BRageChargeLookup["淡雅韓底髮型(女)-D"] = 5;
        BRageChargeLookup["淡雅韓底髮型(男)-D"] = 5;
        BRageChargeLookup["守護妖精髮型-D"] = 5;
        BRageChargeLookup["女王護衛髮型-D"] = 8;
        //page 4 row 1
        BRageChargeLookup["冰雪女王髮型-D"] = 8;
        BRageChargeLookup["柔白雪花髮型-D"] = 5;
        BRageChargeLookup["甜美淑女髮型-D"] = 5;
        BRageChargeLookup["白髮女巫髮型-D"] = 10;
        BRageChargeLookup["黑女巫髮型-D"] = 10;
        //page 4 row 0
        BRageChargeLookup["萬聖節奸笑南瓜-D"] = 10;
        BRageChargeLookup["萬聖節大笑南瓜-D"] = 10;
        BRageChargeLookup["查理的明星髮型-D"] = 5;
        BRageChargeLookup["查理的藍色精靈髮型"] = 5;
        BRageChargeLookup["查理的魅影髮型-D"] = 5;
        //page 4 row 3
        BRageChargeLookup["查理的貴族髮型-D"] = 5;
        BRageChargeLookup["查理的橙色陽光髮型"] = 5;
        BRageChargeLookup["查理的冬季精靈髮型"] = 5;
        BRageChargeLookup["查理的白虎髮型-D"] = 5;
        BRageChargeLookup["查理的浪漫髮型-D"] = 5;
        //page 4 row 4
        BRageChargeLookup["查理的麒麟髮型-D"] = 5;
        BRageChargeLookup["浪漫提琴手的髮型(女)"] = 5;
        BRageChargeLookup["浪漫提琴手的髮型(男)"] = 5;
        BRageChargeLookup["冷艷吸血鬼髮型-D"] = 8;
        BRageChargeLookup["清新活力髮型(女)-P"] = 5;
        //page 4 row 5
        BRageChargeLookup["清新活力髮型(男)-P"] = 5;
        BRageChargeLookup["闇影修行者髮型"] = 5;
        BRageChargeLookup["莉莉的糖果恆星髮型"] = 5;
        BRageChargeLookup["莉莉的糖果極光髮型"] = 5;
        BRageChargeLookup["莉莉的狂野學園髮型"] = 5;
        //page 4 row 6
        BRageChargeLookup["莉莉的暗黑殺手髮型"] = 5;
        BRageChargeLookup["莉莉的秋天精靈髮型"] = 5;
        BRageChargeLookup["莉莉的聖龍王髮王"] = 5;
        BRageChargeLookup["莉莉的甜蜜布丁髮型"] = 5;
        BRageChargeLookup["莉莉的活力少年髮型"] = 5;

        //page 5 row 1
        BRageChargeLookup["莉莉的戰鬥士髮型"] = 5;
        BRageChargeLookup["莉莉的高尚貴族髮型"] = 5;
        BRageChargeLookup["莉莉的皇族黑夜髮型"] = 5;
        BRageChargeLookup["深幽婚禮頭紗(女)"] = 10;
        BRageChargeLookup["粉橙潮女髮型"] = 5;
        //page 5 row 0
        BRageChargeLookup["粉橙潮男髮型-D"] = 5;
        BRageChargeLookup["閃亮少女髮型-D"] = 5;
        BRageChargeLookup["閃亮少男髮型-D"] = 5;
        BRageChargeLookup["甜蜜布丁髮型"] = 5;
        BRageChargeLookup["糖果極光髮型"] = 5;
        //page 5 row 3
        BRageChargeLookup["韓國貴族校服髮型(女)"] = 5;
        BRageChargeLookup["韓國貴族校服髮型(男)"] = 5;
        BRageChargeLookup["韓國偶像校服髮型(女)"] = 5;
        BRageChargeLookup["韓國偶像校服髮型(男)"] = 5;
        BRageChargeLookup["暗黑魅力髮型-D"] = 5;
        //page 5 row 4
        BRageChargeLookup["光之魅力髮型-D"] = 5;
        BRageChargeLookup["綠焰髮型"] = 10;
        BRageChargeLookup["皇家騎士團髮型-D"] = 10;
        BRageChargeLookup["橘色陽光髮型(女)"] = 0;
        BRageChargeLookup["橘色陽光髮型(男)"] = 0;
        //page 5 row 5
        BRageChargeLookup["摩登少女髮型-D"] = 0;
        BRageChargeLookup["摩登少年髮型-D"] = 0;
        BRageChargeLookup["浪漫少女髮型-D"] = 0;
        BRageChargeLookup["浪漫少年髮型-D"] = 0;
        BRageChargeLookup["白色情人節Cap帽(男)"] = 0;
        //page 5 row 6
        BRageChargeLookup["白色情人節Cap帽(女)"] = 0;
        BRageChargeLookup["清爽春風髮型(女)"] = 0;
        BRageChargeLookup["清爽春風髮型(男)"] = 0;
        BRageChargeLookup["天空之國髮型-D(男)"] = 0;
        BRageChargeLookup["天空之國髮型-D(女)"] = 0;

        //page 6 row 1
        BRageChargeLookup["異世界髮型-D"] = 0;
        BRageChargeLookup["異世甲髮型-D"] = 0;
        BRageChargeLookup["布拉基的髮型-D"] = 0;
        BRageChargeLookup["聖戰女神髮型-D"] = 10;
        BRageChargeLookup["凡賽堤髮型-D"] = 0;
        //page 6 row 0
        BRageChargeLookup["黃金火焰髮型"] = 0;
        BRageChargeLookup["聖光烈焰髮型"] = 0;
        BRageChargeLookup["真 ᛫ 女神白焰髮型"] = 0;
        BRageChargeLookup["安琪公主的頭髮"] = 0;
        BRageChargeLookup["安琪道路的頭髮"] = 0;
        //page 6 row 3
        BRageChargeLookup["魔鬼國王的頭髮"] = 0;
        BRageChargeLookup["魔鬼道路的頭髮"] = 0;
        BRageChargeLookup["極限藍焰髮型"] = 0;
        BRageChargeLookup["傳說的火焰髮型"] = 0;
        BRageChargeLookup["Dr Hell面貝"] = 0;
    }
    #endregion B_Hair Rage Charge

    #region B_Hair Max Energy
    void B_MaxEnergy()
    {
        //page 1 row 1
        BMaxEnergyLookup["時尚休閒髮型"] = 0;
        BMaxEnergyLookup["夏日野餐髮型(女)-D"] = 0;
        BMaxEnergyLookup["夏日野餐髮型(男)-D"] = 0;
        BMaxEnergyLookup["夏日時尚髮型(女)"] = 0;
        BMaxEnergyLookup["夏日時尚髮型(男)"] = 0;
        //page 1 row 0
        BMaxEnergyLookup["悠閒夏日髮型(女)"] = 0;
        BMaxEnergyLookup["悠閒夏日髮型(男)"] = 0;
        BMaxEnergyLookup["祭典浴衣髮型(女)-D"] = 0;
        BMaxEnergyLookup["祭典浴衣髮型(男)-D"] = 0;
        BMaxEnergyLookup["春雨櫻花髮型(女)-D"] = 0;
        //page 1 row 3
        BMaxEnergyLookup["春雨櫻花髮型(男)-D"] = 0;
        BMaxEnergyLookup["活潑的莉莉髮型-D"] = 0;
        BMaxEnergyLookup["貴族少爺路易髮型-D"] = 0;
        BMaxEnergyLookup["巧克力馬卡龍髮型-D"] = 0;
        BMaxEnergyLookup["啦啦隊長髮型(女)-D"] = 0;
        //page 1 row 4
        BMaxEnergyLookup["啦啦隊長髮型(男)-D"] = 0;
        BMaxEnergyLookup["花樣新衣髮型(女)-D"] = 0;
        BMaxEnergyLookup["花樣新衣髮型(男)-D"] = 0;
        BMaxEnergyLookup["禦寒時尚髮型(男)-D"] = 0;
        BMaxEnergyLookup["禦寒時尚髮型(女)-D"] = 0;
        //page 1 row 5
        BMaxEnergyLookup["雪之精靈髮型-D"] = 0;
        BMaxEnergyLookup["王國公主髮型-D"] = 0;
        BMaxEnergyLookup["王國公主髮飾"] = 0;
        BMaxEnergyLookup["伊諾梅爾髮型-D"] = 0;
        BMaxEnergyLookup["Ms. Black髮型-D"] = 0;
        //page 1 row 6
        BMaxEnergyLookup["Mr. Black髮型-D"] = 0;
        BMaxEnergyLookup["幽靈獵人髮型(女)-D"] = 0;
        BMaxEnergyLookup["幽靈獵人髮型(男)-D"] = 0;
        BMaxEnergyLookup["深秋約會髮型(女)-D"] = 0;
        BMaxEnergyLookup["深秋約會髮型(男)-D"] = 0;

        //page 0 row 1
        BMaxEnergyLookup["普拉莉絲髮型(女)-D"] = 0;
        BMaxEnergyLookup["普拉莉絲髮型(男)-D"] = 0;
        BMaxEnergyLookup["夏夜髮型(女)-D"] = 0;
        BMaxEnergyLookup["夏夜髮型(男)-D"] = 0;
        BMaxEnergyLookup["森之精靈髮型-D"] = 0;
        //page 0 row 0
        BMaxEnergyLookup["地獄使者白髮-D"] = 0;
        BMaxEnergyLookup["夏日麻花辮(女)-D"] = 0;
        BMaxEnergyLookup["夏日灰髮(男)-D"] = 0;
        BMaxEnergyLookup["活潑小紅帽髮型-D"] = 0;
        BMaxEnergyLookup["酷帥大野狼髮型-D"] = 0;
        //page 0 row 3
        BMaxEnergyLookup["深海刑警髮型-D"] = 0;
        BMaxEnergyLookup["幼稚園生髮型(女)"] = 0;
        BMaxEnergyLookup["幼稚園生髮型(男)"] = 0;
        BMaxEnergyLookup["宴會髮型(女)-D"] = 0;
        BMaxEnergyLookup["宴會髮型(男)-D"] = 0;
        //page 0 row 4
        BMaxEnergyLookup["童話學園髮型(女)-D"] = 0;
        BMaxEnergyLookup["童話學園髮型(男)-D"] = 0;
        BMaxEnergyLookup["時尚韓服髮型(男)-D"] = 0;
        BMaxEnergyLookup["時尚韓服髮型(女)-D"] = 0;
        BMaxEnergyLookup["惡魔靈魂髮型-D"] = 0;
        //page 0 row 5
        BMaxEnergyLookup["禦寒髮型-D"] = 0;
        BMaxEnergyLookup["高階騎士髮型-D"] = 0;
        BMaxEnergyLookup["紫晶銀月髮型-D"] = 0;
        BMaxEnergyLookup["王后新娘髮型-D"] = 0;
        BMaxEnergyLookup["國王新郎髮型-D"] = 0;
        //page 0 row 6
        BMaxEnergyLookup["月兔髮型(男)-D"] = 0;
        BMaxEnergyLookup["月兔髮型(女)-D"] = 0;
        BMaxEnergyLookup["魔法夏卡爾髮型-D"] = 0;
        BMaxEnergyLookup["魔法肯恩髮型-D"] = 0;
        BMaxEnergyLookup["水手泳裝髮型(男)-D"] = 0;

        //page 3 row 1
        BMaxEnergyLookup["水手泳裝髮型(女)-D"] = 0;
        BMaxEnergyLookup["秋日休閒髮型(男)-D"] = 0;
        BMaxEnergyLookup["秋日休閒髮型(女)-D"] = 0;
        BMaxEnergyLookup["星夢戀人短髮-D"] = 0;
        BMaxEnergyLookup["星夢戀人長髮-D"] = 0;
        //page 3 row 0
        BMaxEnergyLookup["不完整的童話髮型-D"] = 0;
        BMaxEnergyLookup["光輝童話髮型-D"] = 0;
        BMaxEnergyLookup["亮白羽絨衣髮型-D"] = 0;
        BMaxEnergyLookup["個性羽絨衣髮型-D"] = 0;
        BMaxEnergyLookup["黑色童話髮型-D"] = 0;
        //page 3 row 3
        BMaxEnergyLookup["兔子管家髮型-D"] = 0;
        BMaxEnergyLookup["飛魚髮型-D"] = 0;
        BMaxEnergyLookup["道士髮型-D"] = 0;
        BMaxEnergyLookup["皇牌玩家髮型-D"] = 0;
        BMaxEnergyLookup["藍海水母髮型(女)-D"] = 0;
        //page 3 row 4
        BMaxEnergyLookup["藍海水母髮型(男)-D"] = 0;
        BMaxEnergyLookup["傳說的人魚髮型-D"] = 0;
        BMaxEnergyLookup["森林冒險家髮型-D"] = 0;
        BMaxEnergyLookup["日之光輝髮型-D"] = 0;
        BMaxEnergyLookup["舞動少年Cap帽(女)-D"] = 0;
        //page 3 row 5
        BMaxEnergyLookup["舞動少年Cap帽(男)-D"] = 0;
        BMaxEnergyLookup["高級守護者髮型-D"] = 0;
        BMaxEnergyLookup["溫馨約會長髮-D"] = 0;
        BMaxEnergyLookup["溫馨約會短髮-D"] = 0;
        BMaxEnergyLookup["典雅韓式髮型(女)-D"] = 0;
        //page 3 row 6
        BMaxEnergyLookup["典雅韓底髮型(男)-D"] = 0;
        BMaxEnergyLookup["淡雅韓底髮型(女)-D"] = 0;
        BMaxEnergyLookup["淡雅韓底髮型(男)-D"] = 0;
        BMaxEnergyLookup["守護妖精髮型-D"] = 0;
        BMaxEnergyLookup["女王護衛髮型-D"] = 0;
        //page 4 row 1
        BMaxEnergyLookup["冰雪女王髮型-D"] = 0;
        BMaxEnergyLookup["柔白雪花髮型-D"] = 0;
        BMaxEnergyLookup["甜美淑女髮型-D"] = 0;
        BMaxEnergyLookup["白髮女巫髮型-D"] = 0;
        BMaxEnergyLookup["黑女巫髮型-D"] = 0;
        //page 4 row 0
        BMaxEnergyLookup["萬聖節奸笑南瓜-D"] = 0;
        BMaxEnergyLookup["萬聖節大笑南瓜-D"] = 0;
        BMaxEnergyLookup["查理的明星髮型-D"] = 0;
        BMaxEnergyLookup["查理的藍色精靈髮型"] = 0;
        BMaxEnergyLookup["查理的魅影髮型-D"] = 0;
        //page 4 row 3
        BMaxEnergyLookup["查理的貴族髮型-D"] = 0;
        BMaxEnergyLookup["查理的橙色陽光髮型"] = 0;
        BMaxEnergyLookup["查理的冬季精靈髮型"] = 0;
        BMaxEnergyLookup["查理的白虎髮型-D"] = 0;
        BMaxEnergyLookup["查理的浪漫髮型-D"] = 0;
        //page 4 row 4
        BMaxEnergyLookup["查理的麒麟髮型-D"] = 0;
        BMaxEnergyLookup["浪漫提琴手的髮型(女)"] = 0;
        BMaxEnergyLookup["浪漫提琴手的髮型(男)"] = 0;
        BMaxEnergyLookup["冷艷吸血鬼髮型-D"] = 0;
        BMaxEnergyLookup["清新活力髮型(女)-P"] = 0;
        //page 4 row 5
        BMaxEnergyLookup["清新活力髮型(男)-P"] = 0;
        BMaxEnergyLookup["闇影修行者髮型"] = 0;
        BMaxEnergyLookup["莉莉的糖果恆星髮型"] = 0;
        BMaxEnergyLookup["莉莉的糖果極光髮型"] = 0;
        BMaxEnergyLookup["莉莉的狂野學園髮型"] = 0;
        //page 4 row 6
        BMaxEnergyLookup["莉莉的暗黑殺手髮型"] = 0;
        BMaxEnergyLookup["莉莉的秋天精靈髮型"] = 0;
        BMaxEnergyLookup["莉莉的聖龍王髮王"] = 0;
        BMaxEnergyLookup["莉莉的甜蜜布丁髮型"] = 0;
        BMaxEnergyLookup["莉莉的活力少年髮型"] = 0;

        //page 5 row 1
        BMaxEnergyLookup["莉莉的戰鬥士髮型"] = 0;
        BMaxEnergyLookup["莉莉的高尚貴族髮型"] = 0;
        BMaxEnergyLookup["莉莉的皇族黑夜髮型"] = 0;
        BMaxEnergyLookup["深幽婚禮頭紗(女)"] = 0;
        BMaxEnergyLookup["粉橙潮女髮型"] = 0;
        //page 5 row 0
        BMaxEnergyLookup["粉橙潮男髮型-D"] = 0;
        BMaxEnergyLookup["閃亮少女髮型-D"] = 0;
        BMaxEnergyLookup["閃亮少男髮型-D"] = 0;
        BMaxEnergyLookup["甜蜜布丁髮型"] = 0;
        BMaxEnergyLookup["糖果極光髮型"] = 0;
        //page 5 row 3
        BMaxEnergyLookup["韓國貴族校服髮型(女)"] = 0;
        BMaxEnergyLookup["韓國貴族校服髮型(男)"] = 0;
        BMaxEnergyLookup["韓國偶像校服髮型(女)"] = 0;
        BMaxEnergyLookup["韓國偶像校服髮型(男)"] = 0;
        BMaxEnergyLookup["暗黑魅力髮型-D"] = 0;
        //page 5 row 4
        BMaxEnergyLookup["光之魅力髮型-D"] = 0;
        BMaxEnergyLookup["綠焰髮型"] = 0;
        BMaxEnergyLookup["皇家騎士團髮型-D"] = 0;
        BMaxEnergyLookup["橘色陽光髮型(女)"] = 0;
        BMaxEnergyLookup["橘色陽光髮型(男)"] = 0;
        //page 5 row 5
        BMaxEnergyLookup["摩登少女髮型-D"] = 0;
        BMaxEnergyLookup["摩登少年髮型-D"] = 0;
        BMaxEnergyLookup["浪漫少女髮型-D"] = 0;
        BMaxEnergyLookup["浪漫少年髮型-D"] = 0;
        BMaxEnergyLookup["白色情人節Cap帽(男)"] = 0;
        //page 5 row 6
        BMaxEnergyLookup["白色情人節Cap帽(女)"] = 0;
        BMaxEnergyLookup["清爽春風髮型(女)"] = 0;
        BMaxEnergyLookup["清爽春風髮型(男)"] = 0;
        BMaxEnergyLookup["天空之國髮型-D(男)"] = 0;
        BMaxEnergyLookup["天空之國髮型-D(女)"] = 0;

        //page 6 row 1
        BMaxEnergyLookup["異世界髮型-D"] = 0;
        BMaxEnergyLookup["異世甲髮型-D"] = 0;
        BMaxEnergyLookup["布拉基的髮型-D"] = 0;
        BMaxEnergyLookup["聖戰女神髮型-D"] = 0;
        BMaxEnergyLookup["凡賽堤髮型-D"] = 0;
        //page 6 row 0
        BMaxEnergyLookup["黃金火焰髮型"] = 0;
        BMaxEnergyLookup["聖光烈焰髮型"] = 0;
        BMaxEnergyLookup["真 ᛫ 女神白焰髮型"] = 0;
        BMaxEnergyLookup["安琪公主的頭髮"] = 0;
        BMaxEnergyLookup["安琪道路的頭髮"] = 0;
        //page 6 row 3
        BMaxEnergyLookup["魔鬼國王的頭髮"] = 0;
        BMaxEnergyLookup["魔鬼道路的頭髮"] = 0;
        BMaxEnergyLookup["極限藍焰髮型"] = 0;
        BMaxEnergyLookup["傳說的火焰髮型"] = 0;
        BMaxEnergyLookup["Dr Hell面貝"] = 0;
    }
    #endregion B_Hair Max Energy

    #region B_Hair Max Sprint
    void B_MaxSprint()
    {
        //page 1 row 1
        BMaxSprintLookup["時尚休閒髮型"] = 0;
        BMaxSprintLookup["夏日野餐髮型(女)-D"] = 0;
        BMaxSprintLookup["夏日野餐髮型(男)-D"] = 0;
        BMaxSprintLookup["夏日時尚髮型(女)"] = 0;
        BMaxSprintLookup["夏日時尚髮型(男)"] = 0;
        //page 1 row 0
        BMaxSprintLookup["悠閒夏日髮型(女)"] = 0;
        BMaxSprintLookup["悠閒夏日髮型(男)"] = 0;
        BMaxSprintLookup["祭典浴衣髮型(女)-D"] = 0;
        BMaxSprintLookup["祭典浴衣髮型(男)-D"] = 0;
        BMaxSprintLookup["春雨櫻花髮型(女)-D"] = 0;
        //page 1 row 3
        BMaxSprintLookup["春雨櫻花髮型(男)-D"] = 0;
        BMaxSprintLookup["活潑的莉莉髮型-D"] = 0;
        BMaxSprintLookup["貴族少爺路易髮型-D"] = 0;
        BMaxSprintLookup["巧克力馬卡龍髮型-D"] = 0;
        BMaxSprintLookup["啦啦隊長髮型(女)-D"] = 0;
        //page 1 row 4
        BMaxSprintLookup["啦啦隊長髮型(男)-D"] = 0;
        BMaxSprintLookup["花樣新衣髮型(女)-D"] = 0;
        BMaxSprintLookup["花樣新衣髮型(男)-D"] = 0;
        BMaxSprintLookup["禦寒時尚髮型(男)-D"] = 0;
        BMaxSprintLookup["禦寒時尚髮型(女)-D"] = 0;
        //page 1 row 5
        BMaxSprintLookup["雪之精靈髮型-D"] = 0;
        BMaxSprintLookup["王國公主髮型-D"] = 0;
        BMaxSprintLookup["王國公主髮飾"] = 0;
        BMaxSprintLookup["伊諾梅爾髮型-D"] = 0;
        BMaxSprintLookup["Ms. Black髮型-D"] = 0;
        //page 1 row 6
        BMaxSprintLookup["Mr. Black髮型-D"] = 0;
        BMaxSprintLookup["幽靈獵人髮型(女)-D"] = 0;
        BMaxSprintLookup["幽靈獵人髮型(男)-D"] = 0;
        BMaxSprintLookup["深秋約會髮型(女)-D"] = 0;
        BMaxSprintLookup["深秋約會髮型(男)-D"] = 0;

        //page 0 row 1
        BMaxSprintLookup["普拉莉絲髮型(女)-D"] = 0;
        BMaxSprintLookup["普拉莉絲髮型(男)-D"] = 0;
        BMaxSprintLookup["夏夜髮型(女)-D"] = 0;
        BMaxSprintLookup["夏夜髮型(男)-D"] = 0;
        BMaxSprintLookup["森之精靈髮型-D"] = 0;
        //page 0 row 0
        BMaxSprintLookup["地獄使者白髮-D"] = 0;
        BMaxSprintLookup["夏日麻花辮(女)-D"] = 0;
        BMaxSprintLookup["夏日灰髮(男)-D"] = 0;
        BMaxSprintLookup["活潑小紅帽髮型-D"] = 0;
        BMaxSprintLookup["酷帥大野狼髮型-D"] = 0;
        //page 0 row 3
        BMaxSprintLookup["深海刑警髮型-D"] = 0;
        BMaxSprintLookup["幼稚園生髮型(女)"] = 0;
        BMaxSprintLookup["幼稚園生髮型(男)"] = 0;
        BMaxSprintLookup["宴會髮型(女)-D"] = 0;
        BMaxSprintLookup["宴會髮型(男)-D"] = 0;
        //page 0 row 4
        BMaxSprintLookup["童話學園髮型(女)-D"] = 0;
        BMaxSprintLookup["童話學園髮型(男)-D"] = 0;
        BMaxSprintLookup["時尚韓服髮型(男)-D"] = 0;
        BMaxSprintLookup["時尚韓服髮型(女)-D"] = 0;
        BMaxSprintLookup["惡魔靈魂髮型-D"] = 0;
        //page 0 row 5
        BMaxSprintLookup["禦寒髮型-D"] = 0;
        BMaxSprintLookup["高階騎士髮型-D"] = 0;
        BMaxSprintLookup["紫晶銀月髮型-D"] = 0;
        BMaxSprintLookup["王后新娘髮型-D"] = 0;
        BMaxSprintLookup["國王新郎髮型-D"] = 0;
        //page 0 row 6
        BMaxSprintLookup["月兔髮型(男)-D"] = 0;
        BMaxSprintLookup["月兔髮型(女)-D"] = 0;
        BMaxSprintLookup["魔法夏卡爾髮型-D"] = 0;
        BMaxSprintLookup["魔法肯恩髮型-D"] = 0;
        BMaxSprintLookup["水手泳裝髮型(男)-D"] = 0;

        //page 3 row 1
        BMaxSprintLookup["水手泳裝髮型(女)-D"] = 0;
        BMaxSprintLookup["秋日休閒髮型(男)-D"] = 0;
        BMaxSprintLookup["秋日休閒髮型(女)-D"] = 0;
        BMaxSprintLookup["星夢戀人短髮-D"] = 0;
        BMaxSprintLookup["星夢戀人長髮-D"] = 0;
        //page 3 row 0
        BMaxSprintLookup["不完整的童話髮型-D"] = 0;
        BMaxSprintLookup["光輝童話髮型-D"] = 0;
        BMaxSprintLookup["亮白羽絨衣髮型-D"] = 0;
        BMaxSprintLookup["個性羽絨衣髮型-D"] = 0;
        BMaxSprintLookup["黑色童話髮型-D"] = 0;
        //page 3 row 3
        BMaxSprintLookup["兔子管家髮型-D"] = 0;
        BMaxSprintLookup["飛魚髮型-D"] = 0;
        BMaxSprintLookup["道士髮型-D"] = 0;
        BMaxSprintLookup["皇牌玩家髮型-D"] = 0;
        BMaxSprintLookup["藍海水母髮型(女)-D"] = 0;
        //page 3 row 4
        BMaxSprintLookup["藍海水母髮型(男)-D"] = 0;
        BMaxSprintLookup["傳說的人魚髮型-D"] = 0;
        BMaxSprintLookup["森林冒險家髮型-D"] = 0;
        BMaxSprintLookup["日之光輝髮型-D"] = 0;
        BMaxSprintLookup["舞動少年Cap帽(女)-D"] = 0;
        //page 3 row 5
        BMaxSprintLookup["舞動少年Cap帽(男)-D"] = 0;
        BMaxSprintLookup["高級守護者髮型-D"] = 0;
        BMaxSprintLookup["溫馨約會長髮-D"] = 0;
        BMaxSprintLookup["溫馨約會短髮-D"] = 0;
        BMaxSprintLookup["典雅韓式髮型(女)-D"] = 0;
        //page 3 row 6
        BMaxSprintLookup["典雅韓底髮型(男)-D"] = 0;
        BMaxSprintLookup["淡雅韓底髮型(女)-D"] = 0;
        BMaxSprintLookup["淡雅韓底髮型(男)-D"] = 0;
        BMaxSprintLookup["守護妖精髮型-D"] = 0;
        BMaxSprintLookup["女王護衛髮型-D"] = 0;
        //page 4 row 1
        BMaxSprintLookup["冰雪女王髮型-D"] = 0;
        BMaxSprintLookup["柔白雪花髮型-D"] = 0;
        BMaxSprintLookup["甜美淑女髮型-D"] = 0;
        BMaxSprintLookup["白髮女巫髮型-D"] = 0;
        BMaxSprintLookup["黑女巫髮型-D"] = 0;
        //page 4 row 0
        BMaxSprintLookup["萬聖節奸笑南瓜-D"] = 0;
        BMaxSprintLookup["萬聖節大笑南瓜-D"] = 0;
        BMaxSprintLookup["查理的明星髮型-D"] = 0;
        BMaxSprintLookup["查理的藍色精靈髮型"] = 0;
        BMaxSprintLookup["查理的魅影髮型-D"] = 0;
        //page 4 row 3
        BMaxSprintLookup["查理的貴族髮型-D"] = 0;
        BMaxSprintLookup["查理的橙色陽光髮型"] = 0;
        BMaxSprintLookup["查理的冬季精靈髮型"] = 0;
        BMaxSprintLookup["查理的白虎髮型-D"] = 0;
        BMaxSprintLookup["查理的浪漫髮型-D"] = 0;
        //page 4 row 4
        BMaxSprintLookup["查理的麒麟髮型-D"] = 0;
        BMaxSprintLookup["浪漫提琴手的髮型(女)"] = 0;
        BMaxSprintLookup["浪漫提琴手的髮型(男)"] = 0;
        BMaxSprintLookup["冷艷吸血鬼髮型-D"] = 0;
        BMaxSprintLookup["清新活力髮型(女)-P"] = 0;
        //page 4 row 5
        BMaxSprintLookup["清新活力髮型(男)-P"] = 0;
        BMaxSprintLookup["闇影修行者髮型"] = 0;
        BMaxSprintLookup["莉莉的糖果恆星髮型"] = 0;
        BMaxSprintLookup["莉莉的糖果極光髮型"] = 0;
        BMaxSprintLookup["莉莉的狂野學園髮型"] = 0;
        //page 4 row 6
        BMaxSprintLookup["莉莉的暗黑殺手髮型"] = 0;
        BMaxSprintLookup["莉莉的秋天精靈髮型"] = 0;
        BMaxSprintLookup["莉莉的聖龍王髮王"] = 0;
        BMaxSprintLookup["莉莉的甜蜜布丁髮型"] = 0;
        BMaxSprintLookup["莉莉的活力少年髮型"] = 0;

        //page 5 row 1
        BMaxSprintLookup["莉莉的戰鬥士髮型"] = 0;
        BMaxSprintLookup["莉莉的高尚貴族髮型"] = 0;
        BMaxSprintLookup["莉莉的皇族黑夜髮型"] = 0;
        BMaxSprintLookup["深幽婚禮頭紗(女)"] = 0;
        BMaxSprintLookup["粉橙潮女髮型"] = 0;
        //page 5 row 0
        BMaxSprintLookup["粉橙潮男髮型-D"] = 0;
        BMaxSprintLookup["閃亮少女髮型-D"] = 0;
        BMaxSprintLookup["閃亮少男髮型-D"] = 0;
        BMaxSprintLookup["甜蜜布丁髮型"] = 0;
        BMaxSprintLookup["糖果極光髮型"] = 0;
        //page 5 row 3
        BMaxSprintLookup["韓國貴族校服髮型(女)"] = 0;
        BMaxSprintLookup["韓國貴族校服髮型(男)"] = 0;
        BMaxSprintLookup["韓國偶像校服髮型(女)"] = 0;
        BMaxSprintLookup["韓國偶像校服髮型(男)"] = 0;
        BMaxSprintLookup["暗黑魅力髮型-D"] = 0;
        //page 5 row 4
        BMaxSprintLookup["光之魅力髮型-D"] = 0;
        BMaxSprintLookup["綠焰髮型"] = 0;
        BMaxSprintLookup["皇家騎士團髮型-D"] = 0;
        BMaxSprintLookup["橘色陽光髮型(女)"] = 0;
        BMaxSprintLookup["橘色陽光髮型(男)"] = 0;
        //page 5 row 5
        BMaxSprintLookup["摩登少女髮型-D"] = 0;
        BMaxSprintLookup["摩登少年髮型-D"] = 0;
        BMaxSprintLookup["浪漫少女髮型-D"] = 0;
        BMaxSprintLookup["浪漫少年髮型-D"] = 0;
        BMaxSprintLookup["白色情人節Cap帽(男)"] = 0;
        //page 5 row 6
        BMaxSprintLookup["白色情人節Cap帽(女)"] = 0;
        BMaxSprintLookup["清爽春風髮型(女)"] = 0;
        BMaxSprintLookup["清爽春風髮型(男)"] = 0;
        BMaxSprintLookup["天空之國髮型-D(男)"] = 0;
        BMaxSprintLookup["天空之國髮型-D(女)"] = 0;

        //page 6 row 1
        BMaxSprintLookup["異世界髮型-D"] = 0;
        BMaxSprintLookup["異世甲髮型-D"] = 0;
        BMaxSprintLookup["布拉基的髮型-D"] = 0;
        BMaxSprintLookup["聖戰女神髮型-D"] = 0;
        BMaxSprintLookup["凡賽堤髮型-D"] = 0;
        //page 6 row 0
        BMaxSprintLookup["黃金火焰髮型"] = 0;
        BMaxSprintLookup["聖光烈焰髮型"] = 0;
        BMaxSprintLookup["真 ᛫ 女神白焰髮型"] = 0;
        BMaxSprintLookup["安琪公主的頭髮"] = 0;
        BMaxSprintLookup["安琪道路的頭髮"] = 0;
        //page 6 row 3
        BMaxSprintLookup["魔鬼國王的頭髮"] = 0;
        BMaxSprintLookup["魔鬼道路的頭髮"] = 0;
        BMaxSprintLookup["極限藍焰髮型"] = 0;
        BMaxSprintLookup["傳說的火焰髮型"] = 0;
        BMaxSprintLookup["Dr Hell面貝"] = 0;
    }
    #endregion B_Hair Max Sprint

    #region B_Hair Force
    void B_Force()
    {
        //page 1 row 1
        BForceLookup["時尚休閒髮型"] = 0;
        BForceLookup["夏日野餐髮型(女)-D"] = 0;
        BForceLookup["夏日野餐髮型(男)-D"] = 0;
        BForceLookup["夏日時尚髮型(女)"] = 0;
        BForceLookup["夏日時尚髮型(男)"] = 0;
        //page 1 row 0
        BForceLookup["悠閒夏日髮型(女)"] = 0;
        BForceLookup["悠閒夏日髮型(男)"] = 0;
        BForceLookup["祭典浴衣髮型(女)-D"] = 0;
        BForceLookup["祭典浴衣髮型(男)-D"] = 0;
        BForceLookup["春雨櫻花髮型(女)-D"] = 0;
        //page 1 row 3
        BForceLookup["春雨櫻花髮型(男)-D"] = 0;
        BForceLookup["活潑的莉莉髮型-D"] = 0;
        BForceLookup["貴族少爺路易髮型-D"] = 0;
        BForceLookup["巧克力馬卡龍髮型-D"] = 0;
        BForceLookup["啦啦隊長髮型(女)-D"] = 0;
        //page 1 row 4
        BForceLookup["啦啦隊長髮型(男)-D"] = 0;
        BForceLookup["花樣新衣髮型(女)-D"] = 0;
        BForceLookup["花樣新衣髮型(男)-D"] = 0;
        BForceLookup["禦寒時尚髮型(男)-D"] = 0;
        BForceLookup["禦寒時尚髮型(女)-D"] = 0;
        //page 1 row 5
        BForceLookup["雪之精靈髮型-D"] = 0;
        BForceLookup["王國公主髮型-D"] = 0;
        BForceLookup["王國公主髮飾"] = 0;
        BForceLookup["伊諾梅爾髮型-D"] = 0;
        BForceLookup["Ms. Black髮型-D"] = 0;
        //page 1 row 6
        BForceLookup["Mr. Black髮型-D"] = 0;
        BForceLookup["幽靈獵人髮型(女)-D"] = 0;
        BForceLookup["幽靈獵人髮型(男)-D"] = 0;
        BForceLookup["深秋約會髮型(女)-D"] = 0;
        BForceLookup["深秋約會髮型(男)-D"] = 0;

        //page 0 row 1
        BForceLookup["普拉莉絲髮型(女)-D"] = 0;
        BForceLookup["普拉莉絲髮型(男)-D"] = 0;
        BForceLookup["夏夜髮型(女)-D"] = 0;
        BForceLookup["夏夜髮型(男)-D"] = 0;
        BForceLookup["森之精靈髮型-D"] = 0;
        //page 0 row 0
        BForceLookup["地獄使者白髮-D"] = 0;
        BForceLookup["夏日麻花辮(女)-D"] = 0;
        BForceLookup["夏日灰髮(男)-D"] = 0;
        BForceLookup["活潑小紅帽髮型-D"] = 0;
        BForceLookup["酷帥大野狼髮型-D"] = 0;
        //page 0 row 3
        BForceLookup["深海刑警髮型-D"] = 0;
        BForceLookup["幼稚園生髮型(女)"] = 0;
        BForceLookup["幼稚園生髮型(男)"] = 0;
        BForceLookup["宴會髮型(女)-D"] = 0;
        BForceLookup["宴會髮型(男)-D"] = 0;
        //page 0 row 4
        BForceLookup["童話學園髮型(女)-D"] = 0;
        BForceLookup["童話學園髮型(男)-D"] = 0;
        BForceLookup["時尚韓服髮型(男)-D"] = 0;
        BForceLookup["時尚韓服髮型(女)-D"] = 0;
        BForceLookup["惡魔靈魂髮型-D"] = 0;
        //page 0 row 5
        BForceLookup["禦寒髮型-D"] = 0;
        BForceLookup["高階騎士髮型-D"] = 0;
        BForceLookup["紫晶銀月髮型-D"] = 0;
        BForceLookup["王后新娘髮型-D"] = 0;
        BForceLookup["國王新郎髮型-D"] = 0;
        //page 0 row 6
        BForceLookup["月兔髮型(男)-D"] = 0;
        BForceLookup["月兔髮型(女)-D"] = 0;
        BForceLookup["魔法夏卡爾髮型-D"] = 0;
        BForceLookup["魔法肯恩髮型-D"] = 0;
        BForceLookup["水手泳裝髮型(男)-D"] = 0;

        //page 3 row 1
        BForceLookup["水手泳裝髮型(女)-D"] = 0;
        BForceLookup["秋日休閒髮型(男)-D"] = 0;
        BForceLookup["秋日休閒髮型(女)-D"] = 0;
        BForceLookup["星夢戀人短髮-D"] = 0;
        BForceLookup["星夢戀人長髮-D"] = 0;
        //page 3 row 0
        BForceLookup["不完整的童話髮型-D"] = 0;
        BForceLookup["光輝童話髮型-D"] = 0;
        BForceLookup["亮白羽絨衣髮型-D"] = 0;
        BForceLookup["個性羽絨衣髮型-D"] = 0;
        BForceLookup["黑色童話髮型-D"] = 0;
        //page 3 row 3
        BForceLookup["兔子管家髮型-D"] = 0;
        BForceLookup["飛魚髮型-D"] = 0;
        BForceLookup["道士髮型-D"] = 0;
        BForceLookup["皇牌玩家髮型-D"] = 0;
        BForceLookup["藍海水母髮型(女)-D"] = 0;
        //page 3 row 4
        BForceLookup["藍海水母髮型(男)-D"] = 0;
        BForceLookup["傳說的人魚髮型-D"] = 0;
        BForceLookup["森林冒險家髮型-D"] = 0;
        BForceLookup["日之光輝髮型-D"] = 0;
        BForceLookup["舞動少年Cap帽(女)-D"] = 0;
        //page 3 row 5
        BForceLookup["舞動少年Cap帽(男)-D"] = 0;
        BForceLookup["高級守護者髮型-D"] = 0;
        BForceLookup["溫馨約會長髮-D"] = 0;
        BForceLookup["溫馨約會短髮-D"] = 0;
        BForceLookup["典雅韓式髮型(女)-D"] = 0;
        //page 3 row 6
        BForceLookup["典雅韓底髮型(男)-D"] = 0;
        BForceLookup["淡雅韓底髮型(女)-D"] = 0;
        BForceLookup["淡雅韓底髮型(男)-D"] = 0;
        BForceLookup["守護妖精髮型-D"] = 0;
        BForceLookup["女王護衛髮型-D"] = 0;
        //page 4 row 1
        BForceLookup["冰雪女王髮型-D"] = 0;
        BForceLookup["柔白雪花髮型-D"] = 0;
        BForceLookup["甜美淑女髮型-D"] = 0;
        BForceLookup["白髮女巫髮型-D"] = 0;
        BForceLookup["黑女巫髮型-D"] = 0;
        //page 4 row 0
        BForceLookup["萬聖節奸笑南瓜-D"] = 0;
        BForceLookup["萬聖節大笑南瓜-D"] = 0;
        BForceLookup["查理的明星髮型-D"] = 0;
        BForceLookup["查理的藍色精靈髮型"] = 0;
        BForceLookup["查理的魅影髮型-D"] = 0;
        //page 4 row 3
        BForceLookup["查理的貴族髮型-D"] = 0;
        BForceLookup["查理的橙色陽光髮型"] = 0;
        BForceLookup["查理的冬季精靈髮型"] = 0;
        BForceLookup["查理的白虎髮型-D"] = 0;
        BForceLookup["查理的浪漫髮型-D"] = 0;
        //page 4 row 4
        BForceLookup["查理的麒麟髮型-D"] = 0;
        BForceLookup["浪漫提琴手的髮型(女)"] = 0;
        BForceLookup["浪漫提琴手的髮型(男)"] = 0;
        BForceLookup["冷艷吸血鬼髮型-D"] = 0;
        BForceLookup["清新活力髮型(女)-P"] = 0;
        //page 4 row 5
        BForceLookup["清新活力髮型(男)-P"] = 0;
        BForceLookup["闇影修行者髮型"] = 0;
        BForceLookup["莉莉的糖果恆星髮型"] = 0;
        BForceLookup["莉莉的糖果極光髮型"] = 0;
        BForceLookup["莉莉的狂野學園髮型"] = 0;
        //page 4 row 6
        BForceLookup["莉莉的暗黑殺手髮型"] = 0;
        BForceLookup["莉莉的秋天精靈髮型"] = 0;
        BForceLookup["莉莉的聖龍王髮王"] = 0;
        BForceLookup["莉莉的甜蜜布丁髮型"] = 0;
        BForceLookup["莉莉的活力少年髮型"] = 0;

        //page 5 row 1
        BForceLookup["莉莉的戰鬥士髮型"] = 0;
        BForceLookup["莉莉的高尚貴族髮型"] = 0;
        BForceLookup["莉莉的皇族黑夜髮型"] = 0;
        BForceLookup["深幽婚禮頭紗(女)"] = 0;
        BForceLookup["粉橙潮女髮型"] = 0;
        //page 5 row 0
        BForceLookup["粉橙潮男髮型-D"] = 0;
        BForceLookup["閃亮少女髮型-D"] = 0;
        BForceLookup["閃亮少男髮型-D"] = 0;
        BForceLookup["甜蜜布丁髮型"] = 0;
        BForceLookup["糖果極光髮型"] = 0;
        //page 5 row 3
        BForceLookup["韓國貴族校服髮型(女)"] = 0;
        BForceLookup["韓國貴族校服髮型(男)"] = 0;
        BForceLookup["韓國偶像校服髮型(女)"] = 0;
        BForceLookup["韓國偶像校服髮型(男)"] = 0;
        BForceLookup["暗黑魅力髮型-D"] = 0;
        //page 5 row 4
        BForceLookup["光之魅力髮型-D"] = 0;
        BForceLookup["綠焰髮型"] = 0;
        BForceLookup["皇家騎士團髮型-D"] = 0;
        BForceLookup["橘色陽光髮型(女)"] = 0;
        BForceLookup["橘色陽光髮型(男)"] = 0;
        //page 5 row 5
        BForceLookup["摩登少女髮型-D"] = 0;
        BForceLookup["摩登少年髮型-D"] = 0;
        BForceLookup["浪漫少女髮型-D"] = 0;
        BForceLookup["浪漫少年髮型-D"] = 0;
        BForceLookup["白色情人節Cap帽(男)"] = 0;
        //page 5 row 6
        BForceLookup["白色情人節Cap帽(女)"] = 0;
        BForceLookup["清爽春風髮型(女)"] = 0;
        BForceLookup["清爽春風髮型(男)"] = 0;
        BForceLookup["天空之國髮型-D(男)"] = 0;
        BForceLookup["天空之國髮型-D(女)"] = 0;

        //page 6 row 1
        BForceLookup["異世界髮型-D"] = 0;
        BForceLookup["異世甲髮型-D"] = 0;
        BForceLookup["布拉基的髮型-D"] = 0;
        BForceLookup["聖戰女神髮型-D"] = 0;
        BForceLookup["凡賽堤髮型-D"] = 0;
        //page 6 row 0
        BForceLookup["黃金火焰髮型"] = 0;
        BForceLookup["聖光烈焰髮型"] = 0;
        BForceLookup["真 ᛫ 女神白焰髮型"] = 0;
        BForceLookup["安琪公主的頭髮"] = 0;
        BForceLookup["安琪道路的頭髮"] = 0;
        //page 6 row 3
        BForceLookup["魔鬼國王的頭髮"] = 0;
        BForceLookup["魔鬼道路的頭髮"] = 0;
        BForceLookup["極限藍焰髮型"] = 0;
        BForceLookup["傳說的火焰髮型"] = 0;
        BForceLookup["Dr Hell面貝"] = 0;
    }
    #endregion B_Hair Force

    #region B_Hair Luck
    void B_Luck()
    {
        //page 1 row 1
        BLuckLookup["時尚休閒髮型"] = 20;
        BLuckLookup["夏日野餐髮型(女)-D"] = 15;
        BLuckLookup["夏日野餐髮型(男)-D"] = 15;
        BLuckLookup["夏日時尚髮型(女)"] = 20;
        BLuckLookup["夏日時尚髮型(男)"] = 20;
        //page 1 row 0
        BLuckLookup["悠閒夏日髮型(女)"] = 20;
        BLuckLookup["悠閒夏日髮型(男)"] = 20;
        BLuckLookup["祭典浴衣髮型(女)-D"] = 10;
        BLuckLookup["祭典浴衣髮型(男)-D"] = 10;
        BLuckLookup["春雨櫻花髮型(女)-D"] = 10;
        //page 1 row 3
        BLuckLookup["春雨櫻花髮型(男)-D"] = 10;
        BLuckLookup["活潑的莉莉髮型-D"] = 10;
        BLuckLookup["貴族少爺路易髮型-D"] = 10;
        BLuckLookup["巧克力馬卡龍髮型-D"] = 10;
        BLuckLookup["啦啦隊長髮型(女)-D"] = 10;
        //page 1 row 4
        BLuckLookup["啦啦隊長髮型(男)-D"] = 10;
        BLuckLookup["花樣新衣髮型(女)-D"] = 15;
        BLuckLookup["花樣新衣髮型(男)-D"] = 20;
        BLuckLookup["禦寒時尚髮型(男)-D"] = 20;
        BLuckLookup["禦寒時尚髮型(女)-D"] = 20;
        //page 1 row 5
        BLuckLookup["雪之精靈髮型-D"] = 20;
        BLuckLookup["王國公主髮型-D"] = 20;
        BLuckLookup["王國公主髮飾"] = 10;
        BLuckLookup["伊諾梅爾髮型-D"] = 20;
        BLuckLookup["Ms. Black髮型-D"] = 15;
        //page 1 row 6
        BLuckLookup["Mr. Black髮型-D"] = 15;
        BLuckLookup["幽靈獵人髮型(女)-D"] = 10;
        BLuckLookup["幽靈獵人髮型(男)-D"] = 10;
        BLuckLookup["深秋約會髮型(女)-D"] = 10;
        BLuckLookup["深秋約會髮型(男)-D"] = 10;

        //page 0 row 1
        BLuckLookup["普拉莉絲髮型(女)-D"] = 15;
        BLuckLookup["普拉莉絲髮型(男)-D"] = 15;
        BLuckLookup["夏夜髮型(女)-D"] = 20;
        BLuckLookup["夏夜髮型(男)-D"] = 20;
        BLuckLookup["森之精靈髮型-D"] = 20;
        //page 0 row 0
        BLuckLookup["地獄使者白髮-D"] = 20;
        BLuckLookup["夏日麻花辮(女)-D"] = 10;
        BLuckLookup["夏日灰髮(男)-D"] = 10;
        BLuckLookup["活潑小紅帽髮型-D"] = 10;
        BLuckLookup["酷帥大野狼髮型-D"] = 10;
        //page 0 row 3
        BLuckLookup["深海刑警髮型-D"] = 20;
        BLuckLookup["幼稚園生髮型(女)"] = 10;
        BLuckLookup["幼稚園生髮型(男)"] = 10;
        BLuckLookup["宴會髮型(女)-D"] = 10;
        BLuckLookup["宴會髮型(男)-D"] = 10;
        //page 0 row 4
        BLuckLookup["童話學園髮型(女)-D"] = 10;
        BLuckLookup["童話學園髮型(男)-D"] = 10;
        BLuckLookup["時尚韓服髮型(男)-D"] = 10;
        BLuckLookup["時尚韓服髮型(女)-D"] = 10;
        BLuckLookup["惡魔靈魂髮型-D"] = 0;
        //page 0 row 5
        BLuckLookup["禦寒髮型-D"] = 20;
        BLuckLookup["高階騎士髮型-D"] = 20;
        BLuckLookup["紫晶銀月髮型-D"] = 20;
        BLuckLookup["王后新娘髮型-D"] = 10;
        BLuckLookup["國王新郎髮型-D"] = 10;
        //page 0 row 6
        BLuckLookup["月兔髮型(男)-D"] = 10;
        BLuckLookup["月兔髮型(女)-D"] = 10;
        BLuckLookup["魔法夏卡爾髮型-D"] = 20;
        BLuckLookup["魔法肯恩髮型-D"] = 20;
        BLuckLookup["水手泳裝髮型(男)-D"] = 20;

        //page 3 row 1
        BLuckLookup["水手泳裝髮型(女)-D"] = 20;
        BLuckLookup["秋日休閒髮型(男)-D"] = 20;
        BLuckLookup["秋日休閒髮型(女)-D"] = 20;
        BLuckLookup["星夢戀人短髮-D"] = 0;
        BLuckLookup["星夢戀人長髮-D"] = 0;
        //page 3 row 0
        BLuckLookup["不完整的童話髮型-D"] = 20;
        BLuckLookup["光輝童話髮型-D"] = 20;
        BLuckLookup["亮白羽絨衣髮型-D"] = 40;
        BLuckLookup["個性羽絨衣髮型-D"] = 40;
        BLuckLookup["黑色童話髮型-D"] = 20;
        //page 3 row 3
        BLuckLookup["兔子管家髮型-D"] = 20;
        BLuckLookup["飛魚髮型-D"] = 20;
        BLuckLookup["道士髮型-D"] = 0;
        BLuckLookup["皇牌玩家髮型-D"] = 50;
        BLuckLookup["藍海水母髮型(女)-D"] = 0;
        //page 3 row 4
        BLuckLookup["藍海水母髮型(男)-D"] = 0;
        BLuckLookup["傳說的人魚髮型-D"] = 50;
        BLuckLookup["森林冒險家髮型-D"] = 50;
        BLuckLookup["日之光輝髮型-D"] = 0;
        BLuckLookup["舞動少年Cap帽(女)-D"] = 0;
        //page 3 row 5
        BLuckLookup["舞動少年Cap帽(男)-D"] = 0;
        BLuckLookup["高級守護者髮型-D"] = 0;
        BLuckLookup["溫馨約會長髮-D"] = 0;
        BLuckLookup["溫馨約會短髮-D"] = 0;
        BLuckLookup["典雅韓式髮型(女)-D"] = 0;
        //page 3 row 6
        BLuckLookup["典雅韓底髮型(男)-D"] = 0;
        BLuckLookup["淡雅韓底髮型(女)-D"] = 0;
        BLuckLookup["淡雅韓底髮型(男)-D"] = 0;
        BLuckLookup["守護妖精髮型-D"] = 20;
        BLuckLookup["女王護衛髮型-D"] = 20;
        //page 4 row 1
        BLuckLookup["冰雪女王髮型-D"] = 20;
        BLuckLookup["柔白雪花髮型-D"] = 0;
        BLuckLookup["甜美淑女髮型-D"] = 0;
        BLuckLookup["白髮女巫髮型-D"] = 50;
        BLuckLookup["黑女巫髮型-D"] = 50;
        //page 4 row 0
        BLuckLookup["萬聖節奸笑南瓜-D"] = 30;
        BLuckLookup["萬聖節大笑南瓜-D"] = 30;
        BLuckLookup["查理的明星髮型-D"] = 20;
        BLuckLookup["查理的藍色精靈髮型"] = 20;
        BLuckLookup["查理的魅影髮型-D"] = 20;
        //page 4 row 3
        BLuckLookup["查理的貴族髮型-D"] = 20;
        BLuckLookup["查理的橙色陽光髮型"] = 20;
        BLuckLookup["查理的冬季精靈髮型"] = 20;
        BLuckLookup["查理的白虎髮型-D"] = 20;
        BLuckLookup["查理的浪漫髮型-D"] = 20;
        //page 4 row 4
        BLuckLookup["查理的麒麟髮型-D"] = 20;
        BLuckLookup["浪漫提琴手的髮型(女)"] = 0;
        BLuckLookup["浪漫提琴手的髮型(男)"] = 0;
        BLuckLookup["冷艷吸血鬼髮型-D"] = 20;
        BLuckLookup["清新活力髮型(女)-P"] = 0;
        //page 4 row 5
        BLuckLookup["清新活力髮型(男)-P"] = 0;
        BLuckLookup["闇影修行者髮型"] = 0;
        BLuckLookup["莉莉的糖果恆星髮型"] = 20;
        BLuckLookup["莉莉的糖果極光髮型"] = 20;
        BLuckLookup["莉莉的狂野學園髮型"] = 20;
        //page 4 row 6
        BLuckLookup["莉莉的暗黑殺手髮型"] = 20;
        BLuckLookup["莉莉的秋天精靈髮型"] = 20;
        BLuckLookup["莉莉的聖龍王髮王"] = 20;
        BLuckLookup["莉莉的甜蜜布丁髮型"] = 20;
        BLuckLookup["莉莉的活力少年髮型"] = 20;

        //page 5 row 1
        BLuckLookup["莉莉的戰鬥士髮型"] = 20;
        BLuckLookup["莉莉的高尚貴族髮型"] = 20;
        BLuckLookup["莉莉的皇族黑夜髮型"] = 20;
        BLuckLookup["深幽婚禮頭紗(女)"] = 0;
        BLuckLookup["粉橙潮女髮型"] = 0;
        //page 5 row 0
        BLuckLookup["粉橙潮男髮型-D"] = 0;
        BLuckLookup["閃亮少女髮型-D"] = 0;
        BLuckLookup["閃亮少男髮型-D"] = 0;
        BLuckLookup["甜蜜布丁髮型"] = 0;
        BLuckLookup["糖果極光髮型"] = 0;
        //page 5 row 3
        BLuckLookup["韓國貴族校服髮型(女)"] = 0;
        BLuckLookup["韓國貴族校服髮型(男)"] = 0;
        BLuckLookup["韓國偶像校服髮型(女)"] = 0;
        BLuckLookup["韓國偶像校服髮型(男)"] = 0;
        BLuckLookup["暗黑魅力髮型-D"] = 0;
        //page 5 row 4
        BLuckLookup["光之魅力髮型-D"] = 0;
        BLuckLookup["綠焰髮型"] = 0;
        BLuckLookup["皇家騎士團髮型-D"] = 0;
        BLuckLookup["橘色陽光髮型(女)"] = 0;
        BLuckLookup["橘色陽光髮型(男)"] = 0;
        //page 5 row 5
        BLuckLookup["摩登少女髮型-D"] = 0;
        BLuckLookup["摩登少年髮型-D"] = 0;
        BLuckLookup["浪漫少女髮型-D"] = 0;
        BLuckLookup["浪漫少年髮型-D"] = 0;
        BLuckLookup["白色情人節Cap帽(男)"] = 0;
        //page 5 row 6
        BLuckLookup["白色情人節Cap帽(女)"] = 0;
        BLuckLookup["清爽春風髮型(女)"] = 0;
        BLuckLookup["清爽春風髮型(男)"] = 0;
        BLuckLookup["天空之國髮型-D(男)"] = 0;
        BLuckLookup["天空之國髮型-D(女)"] = 0;

        //page 6 row 1
        BLuckLookup["異世界髮型-D"] = 0;
        BLuckLookup["異世甲髮型-D"] = 0;
        BLuckLookup["布拉基的髮型-D"] = 0;
        BLuckLookup["聖戰女神髮型-D"] = 0;
        BLuckLookup["凡賽堤髮型-D"] = 0;
        //page 6 row 0
        BLuckLookup["黃金火焰髮型"] = 0;
        BLuckLookup["聖光烈焰髮型"] = 0;
        BLuckLookup["真 ᛫ 女神白焰髮型"] = 0;
        BLuckLookup["安琪公主的頭髮"] = 0;
        BLuckLookup["安琪道路的頭髮"] = 0;
        //page 6 row 3
        BLuckLookup["魔鬼國王的頭髮"] = 0;
        BLuckLookup["魔鬼道路的頭髮"] = 0;
        BLuckLookup["極限藍焰髮型"] = 0;
        BLuckLookup["傳說的火焰髮型"] = 0;
        BLuckLookup["Dr Hell面貝"] = 0;
    }
    #endregion B_Hair Luck

    #endregion B_Hair Stats

    void SS_Hair()
    {
        SS_Rarity();
        SS_Speed();
        SS_Mode();
        SS_Speed();
        SS_Acceleration();
        SS_Power();
        SS_Control();
    }

    #region SS_Hair Stats

    #region SS_Hair Rarity
    void SS_Rarity()
    {
        SSRarityLookup["梅賽德斯髮型-D"] = 5;
        SSRarityLookup["化裝舞會髮型"] = 5;
        SSRarityLookup["宮廷遠征使者髮型"] = 5;
        SSRarityLookup["暮色夢夜髮型(男)"] = 5;
        SSRarityLookup["暮色夢夜髮型(女)"] = 5;

        SSRarityLookup["日蝕髮型-D"] = 5;
        SSRarityLookup["黑金天使髮型-D"] = 5;
        SSRarityLookup["晨曦破曉髮型-D"] = 5;
        SSRarityLookup["夜幕降臨髮型-D"] = 5;
        SSRarityLookup["混沌大師髮型-D"] = 5;

        SSRarityLookup["挑戰者髮型-D"] = 5;
        SSRarityLookup["璀璨的光芒髮型-D"] = 5;
        SSRarityLookup["皇家騎士髮型-D"] = 5;
        SSRarityLookup["不祥的暗黑髮型-D"] = 5;
        SSRarityLookup["皇家護衛髮型(男)-D"] = 5;

        SSRarityLookup["皇家護衛髮型(女)-D"] = 5;
        SSRarityLookup["覺醒 ‧ 馭龍頭盔-D"] = 5;
        SSRarityLookup["克羅諾斯的髮型-D"] = 5;
        SSRarityLookup["極 ‧ 馭龍騎士頭盔-D"] = 5;
    }
    #endregion SS_Hair Rarity

    #region SS_Hair Avatar Mode
    void SS_Mode()
    {
        SSModeLookup["梅賽德斯髮型-D"] = false;
        SSModeLookup["化裝舞會髮型"] = false;
        SSModeLookup["宮廷遠征使者髮型"] = false;
        SSModeLookup["暮色夢夜髮型(男)"] = false;
        SSModeLookup["暮色夢夜髮型(女)"] = false;
          
        SSModeLookup["日蝕髮型-D"] = false;
        SSModeLookup["黑金天使髮型-D"] = false;
        SSModeLookup["晨曦破曉髮型-D"] = false;
        SSModeLookup["夜幕降臨髮型-D"] = false;
        SSModeLookup["混沌大師髮型-D"] = false;
          
        SSModeLookup["挑戰者髮型-D"] = false;
        SSModeLookup["璀璨的光芒髮型-D"] = false;
        SSModeLookup["皇家騎士髮型-D"] = false;
        SSModeLookup["不祥的暗黑髮型-D"] = false;
        SSModeLookup["皇家護衛髮型(男)-D"] = false;
          
        SSModeLookup["皇家護衛髮型(女)-D"] = false;
        SSModeLookup["覺醒 ‧ 馭龍頭盔-D"] = false;
        SSModeLookup["克羅諾斯的髮型-D"] = false;
        SSModeLookup["極 ‧ 馭龍騎士頭盔-D"] = false;
    }
    #endregion SS_Hair Avatar Mode

    #region SS_Hair Speed
    void SS_Speed()
    {
        SSSpeedLookup["梅賽德斯髮型-D"] = 0;
        SSSpeedLookup["化裝舞會髮型"] = 0;
        SSSpeedLookup["宮廷遠征使者髮型"] = 1;
        SSSpeedLookup["暮色夢夜髮型(男)"] = 1;
        SSSpeedLookup["暮色夢夜髮型(女)"] = 1;
          
        SSSpeedLookup["日蝕髮型-D"] = 1;
        SSSpeedLookup["黑金天使髮型-D"] = 0;
        SSSpeedLookup["晨曦破曉髮型-D"] = 0;
        SSSpeedLookup["夜幕降臨髮型-D"] = 0;
        SSSpeedLookup["混沌大師髮型-D"] = 1;
          
        SSSpeedLookup["挑戰者髮型-D"] = 0;
        SSSpeedLookup["璀璨的光芒髮型-D"] = 1;
        SSSpeedLookup["皇家騎士髮型-D"] = 0;
        SSSpeedLookup["不祥的暗黑髮型-D"] = 1;
        SSSpeedLookup["皇家護衛髮型(男)-D"] = 0;
          
        SSSpeedLookup["皇家護衛髮型(女)-D"] = 0;
        SSSpeedLookup["覺醒 ‧ 馭龍頭盔-D"] = 0;
        SSSpeedLookup["克羅諾斯的髮型-D"] = 1;
        SSSpeedLookup["極 ‧ 馭龍騎士頭盔-D"] = 0;
    }
    #endregion SS_Hair Speed

    #region SS_Hair Acceleration
    void SS_Acceleration()
    {
        SSAccelerationLookup["梅賽德斯髮型-D"] = 1;
        SSAccelerationLookup["化裝舞會髮型"] = 1;
        SSAccelerationLookup["宮廷遠征使者髮型"] = 0;
        SSAccelerationLookup["暮色夢夜髮型(男)"] = 0;
        SSAccelerationLookup["暮色夢夜髮型(女)"] = 0;

        SSAccelerationLookup["日蝕髮型-D"] = 0;
        SSAccelerationLookup["黑金天使髮型-D"] = 0;
        SSAccelerationLookup["晨曦破曉髮型-D"] = 0;
        SSAccelerationLookup["夜幕降臨髮型-D"] = 1;
        SSAccelerationLookup["混沌大師髮型-D"] = 0;

        SSAccelerationLookup["挑戰者髮型-D"] = 0;
        SSAccelerationLookup["璀璨的光芒髮型-D"] = 0;
        SSAccelerationLookup["皇家騎士髮型-D"] = 0;
        SSAccelerationLookup["不祥的暗黑髮型-D"] = 0;
        SSAccelerationLookup["皇家護衛髮型(男)-D"] = 0;

        SSAccelerationLookup["皇家護衛髮型(女)-D"] = 0;
        SSAccelerationLookup["覺醒 ‧ 馭龍頭盔-D"] = 0;
        SSAccelerationLookup["克羅諾斯的髮型-D"] = 0;
        SSAccelerationLookup["極 ‧ 馭龍騎士頭盔-D"] = 2;
    }
    #endregion SS_Hair Acceleration

    #region SS_Hair Power
    void SS_Power()
    {
        SSPowerLookup["梅賽德斯髮型-D"] = 0;
        SSPowerLookup["化裝舞會髮型"] = 0;
        SSPowerLookup["宮廷遠征使者髮型"] = 0;
        SSPowerLookup["暮色夢夜髮型(男)"] = 0;
        SSPowerLookup["暮色夢夜髮型(女)"] = 0;
          
        SSPowerLookup["日蝕髮型-D"] = 0;
        SSPowerLookup["黑金天使髮型-D"] = 1;
        SSPowerLookup["晨曦破曉髮型-D"] = 0;
        SSPowerLookup["夜幕降臨髮型-D"] = 0;
        SSPowerLookup["混沌大師髮型-D"] = 0;
          
        SSPowerLookup["挑戰者髮型-D"] = 0;
        SSPowerLookup["璀璨的光芒髮型-D"] = 1;
        SSPowerLookup["皇家騎士髮型-D"] = 1;
        SSPowerLookup["不祥的暗黑髮型-D"] = 2;
        SSPowerLookup["皇家護衛髮型(男)-D"] = 0;
          
        SSPowerLookup["皇家護衛髮型(女)-D"] = 0;
        SSPowerLookup["覺醒 ‧ 馭龍頭盔-D"] = 1;
        SSPowerLookup["克羅諾斯的髮型-D"] = 0;
        SSPowerLookup["極 ‧ 馭龍騎士頭盔-D"] = 0;
    }
    #endregion SS_Hair Power

    #region SS_Hair Control
    void SS_Control()
    {
        SSControlLookup["梅賽德斯髮型-D"] = 0;
        SSControlLookup["化裝舞會髮型"] = 0;
        SSControlLookup["宮廷遠征使者髮型"] = 0;
        SSControlLookup["暮色夢夜髮型(男)"] = 0;
        SSControlLookup["暮色夢夜髮型(女)"] = 0;
          
        SSControlLookup["日蝕髮型-D"] = 0;
        SSControlLookup["黑金天使髮型-D"] = 0;
        SSControlLookup["晨曦破曉髮型-D"] = 1;
        SSControlLookup["夜幕降臨髮型-D"] = 0;
        SSControlLookup["混沌大師髮型-D"] = 0;
          
        SSControlLookup["挑戰者髮型-D"] = 1;
        SSControlLookup["璀璨的光芒髮型-D"] = 0;
        SSControlLookup["皇家騎士髮型-D"] = 0;
        SSControlLookup["不祥的暗黑髮型-D"] = 0;
        SSControlLookup["皇家護衛髮型(男)-D"] = 1;
          
        SSControlLookup["皇家護衛髮型(女)-D"] = 1;
        SSControlLookup["覺醒 ‧ 馭龍頭盔-D"] = 1;
        SSControlLookup["克羅諾斯的髮型-D"] = 0;
        SSControlLookup["極 ‧ 馭龍騎士頭盔-D"] = 0;
    }
    #endregion SS_Hair Control

    #region SS_Hair Rage Duration
    void SS_RageDuration()
    {
        SSRageDurationLookup["梅賽德斯髮型-D"] = 10;
        SSRageDurationLookup["化裝舞會髮型"] = 10;
        SSRageDurationLookup["宮廷遠征使者髮型"] = 10;
        SSRageDurationLookup["暮色夢夜髮型(男)"] = 10;
        SSRageDurationLookup["暮色夢夜髮型(女)"] = 10;

        SSRageDurationLookup["日蝕髮型-D"] = 10;
        SSRageDurationLookup["黑金天使髮型-D"] = 10;
        SSRageDurationLookup["晨曦破曉髮型-D"] = 10;
        SSRageDurationLookup["夜幕降臨髮型-D"] = 10;
        SSRageDurationLookup["混沌大師髮型-D"] = 10;
          
        SSRageDurationLookup["挑戰者髮型-D"] = 10;
        SSRageDurationLookup["璀璨的光芒髮型-D"] = 0;
        SSRageDurationLookup["皇家騎士髮型-D"] = 10;
        SSRageDurationLookup["不祥的暗黑髮型-D"] = 0;
        SSRageDurationLookup["皇家護衛髮型(男)-D"] = 10;
          
        SSRageDurationLookup["皇家護衛髮型(女)-D"] = 10;
        SSRageDurationLookup["覺醒 ‧ 馭龍頭盔-D"] = 20;
        SSRageDurationLookup["克羅諾斯的髮型-D"] = 10;
        SSRageDurationLookup["極 ‧ 馭龍騎士頭盔-D"] = 20;
    }
    #endregion SS_Hair Stats


}

