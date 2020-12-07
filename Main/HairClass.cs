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
        A_Hair();
        S_Hair();
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
        B_MaxSprint();
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

    void A_Hair()
    {
        A_Rarity();
        A_Mode();
        A_Speed();
        A_Acceleration();
        A_Power();
        A_Control();
        A_RageDuration();
        A_RageCharge();
        A_MaxEnergy();
        A_MaxSprint();
        A_Force();
        A_Luck();
    }
    #region A_Hair Stats
    void A_Rarity()
    {
        //page 1
        ARarityLookup["十鬼夜行髮型-D"] = 3;
        ARarityLookup["白魔法髮型-D"] = 3;
        ARarityLookup["黑魔法髮型-D"] = 3;
        ARarityLookup["神諭聖光髮型-D"] = 3;
        ARarityLookup["魔龍貴族髮型-D"] = 3;

        ARarityLookup["幻想獨角獸髮型-D"] = 3;
        ARarityLookup["外星兔髮型-D"] = 3;
        ARarityLookup["湛藍海軍學員髮型-D"] = 3;
        ARarityLookup["棉花糖睡衣髮型(女)-D"] = 3;
        ARarityLookup["棉花糖睡衣髮型(男)-D"] = 3;

        ARarityLookup["西洋棋國王髮型-D"] = 3;
        ARarityLookup["靈獸髮型-D"] = 3;
        ARarityLookup["西洋棋士兵髮型-D"] = 3;
        ARarityLookup["網球手髮型-D"] = 3;
        ARarityLookup["西洋棋城堡髮型-D"] = 3;

        ARarityLookup["西洋棋騎士髮型-D"] = 3;
        ARarityLookup["舞台偶像髮型(女)-D"] = 3;
        ARarityLookup["舞台偶像髮型(男)-D"] = 3;
        ARarityLookup["西洋棋主教髮型-D"] = 3;
        ARarityLookup["西洋棋皇后髮型-D"] = 3;

        ARarityLookup["懶人訓練髮型-D"] = 3;
        ARarityLookup["菁英訓練髮型-D"] = 3;
        ARarityLookup["世界髮型-D"] = 3;
        ARarityLookup["正義髮型-D"] = 3;
        ARarityLookup["白夜叉髮型-D"] = 3;

        ARarityLookup["月亮髮型-D"] = 3;
        ARarityLookup["惡魔髮型-D"] = 3;
        ARarityLookup["惡魔騎士髮型-D"] = 3;
        ARarityLookup["天使騎士髮型-D"] = 3;
        ARarityLookup["命運髮型-D"] = 3;
        //page 2
        ARarityLookup["戀人髮型-D"] = 3;
        ARarityLookup["夢想兔子髮型-D"] = 3;
        ARarityLookup["力量髮型-D"] = 3;
        ARarityLookup["太陽髮型-D"] = 3;
        ARarityLookup["皇帝髮型-D"] = 3;

        ARarityLookup["死神髮型-D"] = 3;
        ARarityLookup["星星髮型-D"] = 3;
        ARarityLookup["蘭斯洛特的髮型-D"] = 3;
        ARarityLookup["梅林的髮型-D"] = 3;
        ARarityLookup["亞瑟的髮型-D"] = 3;

        ARarityLookup["女祭司髮型-D"] = 3;
        ARarityLookup["別西卜髮型-D"] = 3;
        ARarityLookup["卡麥爾髮型-D"] = 3;
        ARarityLookup["Dr.Hell髮型-D"] = 3;
        ARarityLookup["安德烈的貴族髮型-D"] = 3;

        ARarityLookup["安德烈的閃亮髮型-D"] = 3;
        ARarityLookup["安德烈的時尚髮型-D"] = 3;
        ARarityLookup["安德烈的猴子髮型-D"] = 3;
        ARarityLookup["安德烈的派對髮型-D"] = 3;
        ARarityLookup["安德烈的耀日髮型-D"] = 3;

        ARarityLookup["安德烈的緋紅髮型-D"] = 3;
        ARarityLookup["安德烈的高傲髮型-D"] = 3;
        ARarityLookup["安德烈的陽光髮型-D"] = 3;
        ARarityLookup["安德烈的黝黑髮型-D"] = 3;
        ARarityLookup["莉莉絲的髮型-D"] = 3;

        ARarityLookup["加百列髮型-D"] = 3;
        ARarityLookup["寶物獵人髮型"] = 3;
        ARarityLookup["摩洛髮型-D"] = 3;
        ARarityLookup["烏列爾髮型-D"] = 3;
        ARarityLookup["威力隆髮型-D"] = 3;
        //page 3
        ARarityLookup["白燐髮型-D"] = 3;
        ARarityLookup["米迦勒髮型-D"] = 3;
        ARarityLookup["彼列髮型-D"] = 3;
        ARarityLookup["炫紫鑄造者髮型-D"] = 3;
        ARarityLookup["純白鑄造者髮型-D"] = 3;

        ARarityLookup["暗黑鑄造者髮型-D"] = 3;
        ARarityLookup["蒼藍鑄造者髮型-D"] = 3;
        ARarityLookup["赤紅鑄造者髮型-D"] = 3;
        ARarityLookup["妮克斯的髮型"] = 3;
        ARarityLookup["拉貴爾髮型-D"] = 3;

        ARarityLookup["普路托髮型-D"] = 3;
        ARarityLookup["闇影龍戰士頭盔-D"] = 3;
        ARarityLookup["霜雪龍戰士頭盔-D"] = 3;
        ARarityLookup["赤焰龍戰士頭盔-D"] = 3;
        ARarityLookup["夜煞黑燐之厄運 ‧ 破局"] = 3;

        ARarityLookup["拉斐爾髮型-D"] = 3;
        ARarityLookup["貝斯塔的髮型-D"] = 3;
        ARarityLookup["月之永恆髮型-D"] = 3;
        ARarityLookup["青燐髮型-D"] = 3;
        ARarityLookup["赫梅拉髮型-D"] = 3;

        ARarityLookup["大師級守護者髮型-D"] = 3;
        ARarityLookup["奧羅拉的髮型-D"] = 3;
        ARarityLookup["紅燐髮型-D"] = 3;
        ARarityLookup["青春歲月校服髮型A-D"] = 3;
        ARarityLookup["甜蜜約會髮型A"] = 3;

        ARarityLookup["燦爛雪花髮型-D"] = 3;
        ARarityLookup["幻彩甜夢髮型-D"] = 3;
        ARarityLookup["翱翔機師髮型-D"] = 3;
        ARarityLookup["奇妙魔術師髮型-D"] = 3;
        ARarityLookup["貴族主僕髮型-D"] = 3;
        //page 4
        ARarityLookup["童話主廚髮型-D"] = 3;
        ARarityLookup["幽靈教主髮型-D"] = 3;
        ARarityLookup["莉莉的情人節Cap帽"] = 3;
        ARarityLookup["藍色精靈髮型-D"] = 3;
        ARarityLookup["優雅婚禮髮型-D"] = 3;

        ARarityLookup["狂野初中生髮型-D"] = 3;
        ARarityLookup["天忍聖守 ‧ 訣"] = 3;
        ARarityLookup["暗黑殺手髮型-D"] = 3;
        ARarityLookup["麒麟的神豔"] = 3;
        ARarityLookup["糖果恆星髮型-D"] = 3;

        ARarityLookup["聖亳王之怒 ‧ 起始"] = 3;
        ARarityLookup["玄武之靈羽"] = 3;
        ARarityLookup["朱雀之髮冠"] = 3;
        ARarityLookup["白虎之牙"] = 3;
        ARarityLookup["青龍的風聲"] = 3;

        ARarityLookup["冬天妖精髮型"] = 3;
        ARarityLookup["雷之子索爾髮型-D"] = 3;
        ARarityLookup["暗黑貴族魔法髮型"] = 3;
        ARarityLookup["Dr.Hell 黑色面具"] = 3;
        ARarityLookup["Ark魔鬼的王冠"] = 3;

        ARarityLookup["Ark天使的王冠"] = 3;
        ARarityLookup["黑色火焰髮型"] = 3;
        ARarityLookup["泰國校服女生髮型-D"] = 3;
        ARarityLookup["泰國校服男生髮型-D"] = 3;

    }

    void A_Mode()
    {
        //page 1
        AModeLookup["十鬼夜行髮型-D"] = false;
        AModeLookup["白魔法髮型-D"] = false;
        AModeLookup["黑魔法髮型-D"] = false;
        AModeLookup["神諭聖光髮型-D"] = false;
        AModeLookup["魔龍貴族髮型-D"] = false;
         
        AModeLookup["幻想獨角獸髮型-D"] = false;
        AModeLookup["外星兔髮型-D"] = false;
        AModeLookup["湛藍海軍學員髮型-D"] = false;
        AModeLookup["棉花糖睡衣髮型(女)-D"] = false;
        AModeLookup["棉花糖睡衣髮型(男)-D"] = false;
         
        AModeLookup["西洋棋國王髮型-D"] = false;
        AModeLookup["靈獸髮型-D"] = false;
        AModeLookup["西洋棋士兵髮型-D"] = false;
        AModeLookup["網球手髮型-D"] = false;
        AModeLookup["西洋棋城堡髮型-D"] = false;
         
        AModeLookup["西洋棋騎士髮型-D"] = false;
        AModeLookup["舞台偶像髮型(女)-D"] = false;
        AModeLookup["舞台偶像髮型(男)-D"] = false;
        AModeLookup["西洋棋主教髮型-D"] = false;
        AModeLookup["西洋棋皇后髮型-D"] = false;
         
        AModeLookup["懶人訓練髮型-D"] = false;
        AModeLookup["菁英訓練髮型-D"] = false;
        AModeLookup["世界髮型-D"] = false;
        AModeLookup["正義髮型-D"] = false;
        AModeLookup["白夜叉髮型-D"] = false;
         
        AModeLookup["月亮髮型-D"] = false;
        AModeLookup["惡魔髮型-D"] = false;
        AModeLookup["惡魔騎士髮型-D"] = false;
        AModeLookup["天使騎士髮型-D"] = false;
        AModeLookup["命運髮型-D"] = false;
        //page 2
        AModeLookup["戀人髮型-D"] = false;
        AModeLookup["夢想兔子髮型-D"] = false;
        AModeLookup["力量髮型-D"] = false;
        AModeLookup["太陽髮型-D"] = false;
        AModeLookup["皇帝髮型-D"] = false;
         
        AModeLookup["死神髮型-D"] = false;
        AModeLookup["星星髮型-D"] = false;
        AModeLookup["蘭斯洛特的髮型-D"] = false;
        AModeLookup["梅林的髮型-D"] = false;
        AModeLookup["亞瑟的髮型-D"] = false;
         
        AModeLookup["女祭司髮型-D"] = false;
        AModeLookup["別西卜髮型-D"] = false;
        AModeLookup["卡麥爾髮型-D"] = false;
        AModeLookup["Dr.Hell髮型-D"] = false;
        AModeLookup["安德烈的貴族髮型-D"] = false;
         
        AModeLookup["安德烈的閃亮髮型-D"] = false;
        AModeLookup["安德烈的時尚髮型-D"] = false;
        AModeLookup["安德烈的猴子髮型-D"] = false;
        AModeLookup["安德烈的派對髮型-D"] = false;
        AModeLookup["安德烈的耀日髮型-D"] = false;
         
        AModeLookup["安德烈的緋紅髮型-D"] = false;
        AModeLookup["安德烈的高傲髮型-D"] = false;
        AModeLookup["安德烈的陽光髮型-D"] = false;
        AModeLookup["安德烈的黝黑髮型-D"] = false;
        AModeLookup["莉莉絲的髮型-D"] = false;
         
        AModeLookup["加百列髮型-D"] = false;
        AModeLookup["寶物獵人髮型"] = false;
        AModeLookup["摩洛髮型-D"] = false;
        AModeLookup["烏列爾髮型-D"] = false;
        AModeLookup["威力隆髮型-D"] = false;
        //page 3
        AModeLookup["白燐髮型-D"] = false;
        AModeLookup["米迦勒髮型-D"] = false;
        AModeLookup["彼列髮型-D"] = false;
        AModeLookup["炫紫鑄造者髮型-D"] = false;
        AModeLookup["純白鑄造者髮型-D"] = false;
         
        AModeLookup["暗黑鑄造者髮型-D"] = false;
        AModeLookup["蒼藍鑄造者髮型-D"] = false;
        AModeLookup["赤紅鑄造者髮型-D"] = false;
        AModeLookup["妮克斯的髮型"] = false;
        AModeLookup["拉貴爾髮型-D"] = false;
         
        AModeLookup["普路托髮型-D"] = false;
        AModeLookup["闇影龍戰士頭盔-D"] = false;
        AModeLookup["霜雪龍戰士頭盔-D"] = false;
        AModeLookup["赤焰龍戰士頭盔-D"] = false;
        AModeLookup["夜煞黑燐之厄運 ‧ 破局"] = false;
         
        AModeLookup["拉斐爾髮型-D"] = false;
        AModeLookup["貝斯塔的髮型-D"] = false;
        AModeLookup["月之永恆髮型-D"] = false;
        AModeLookup["青燐髮型-D"] = false;
        AModeLookup["赫梅拉髮型-D"] = false;
         
        AModeLookup["大師級守護者髮型-D"] = false;
        AModeLookup["奧羅拉的髮型-D"] = false;
        AModeLookup["紅燐髮型-D"] = false;
        AModeLookup["青春歲月校服髮型A-D"] = false;
        AModeLookup["甜蜜約會髮型A"] = false;
         
        AModeLookup["燦爛雪花髮型-D"] = false;
        AModeLookup["幻彩甜夢髮型-D"] = false;
        AModeLookup["翱翔機師髮型-D"] = false;
        AModeLookup["奇妙魔術師髮型-D"] = false;
        AModeLookup["貴族主僕髮型-D"] = false;
        //page 4
        AModeLookup["童話主廚髮型-D"] = false;
        AModeLookup["幽靈教主髮型-D"] = false;
        AModeLookup["莉莉的情人節Cap帽"] = false;
        AModeLookup["藍色精靈髮型-D"] = false;
        AModeLookup["優雅婚禮髮型-D"] = false;
         
        AModeLookup["狂野初中生髮型-D"] = false;
        AModeLookup["天忍聖守 ‧ 訣"] = false;
        AModeLookup["暗黑殺手髮型-D"] = false;
        AModeLookup["麒麟的神豔"] = false;
        AModeLookup["糖果恆星髮型-D"] = false;
         
        AModeLookup["聖亳王之怒 ‧ 起始"] = false;
        AModeLookup["玄武之靈羽"] = false;
        AModeLookup["朱雀之髮冠"] = false;
        AModeLookup["白虎之牙"] = false;
        AModeLookup["青龍的風聲"] = false;
         
        AModeLookup["冬天妖精髮型"] = false;
        AModeLookup["雷之子索爾髮型-D"] = false;
        AModeLookup["暗黑貴族魔法髮型"] = false;
        AModeLookup["Dr.Hell 黑色面具"] = false;
        AModeLookup["Ark魔鬼的王冠"] = false;
         
        AModeLookup["Ark天使的王冠"] = false;
        AModeLookup["黑色火焰髮型"] = false;
        AModeLookup["泰國校服女生髮型-D"] = false;
        AModeLookup["泰國校服男生髮型-D"] = false;
    }

    void A_Speed()
    {
        //page 1
        ASpeedLookup["十鬼夜行髮型-D"] = 0;
        ASpeedLookup["白魔法髮型-D"] = 0;
        ASpeedLookup["黑魔法髮型-D"] = 0;
        ASpeedLookup["神諭聖光髮型-D"] = 0;
        ASpeedLookup["魔龍貴族髮型-D"] = 0;
         
        ASpeedLookup["幻想獨角獸髮型-D"] = 0;
        ASpeedLookup["外星兔髮型-D"] = 0;
        ASpeedLookup["湛藍海軍學員髮型-D"] = 0;
        ASpeedLookup["棉花糖睡衣髮型(女)-D"] = 0;
        ASpeedLookup["棉花糖睡衣髮型(男)-D"] = 0;
         
        ASpeedLookup["西洋棋國王髮型-D"] = 0;
        ASpeedLookup["靈獸髮型-D"] = 0;
        ASpeedLookup["西洋棋士兵髮型-D"] = 0;
        ASpeedLookup["網球手髮型-D"] = 0;
        ASpeedLookup["西洋棋城堡髮型-D"] = 0;
         
        ASpeedLookup["西洋棋騎士髮型-D"] = 0;
        ASpeedLookup["舞台偶像髮型(女)-D"] = 0;
        ASpeedLookup["舞台偶像髮型(男)-D"] = 0;
        ASpeedLookup["西洋棋主教髮型-D"] = 0;
        ASpeedLookup["西洋棋皇后髮型-D"] = 0;
         
        ASpeedLookup["懶人訓練髮型-D"] = 0;
        ASpeedLookup["菁英訓練髮型-D"] = 0;
        ASpeedLookup["世界髮型-D"] = 0;
        ASpeedLookup["正義髮型-D"] = 0;
        ASpeedLookup["白夜叉髮型-D"] = 0;
         
        ASpeedLookup["月亮髮型-D"] = 0;
        ASpeedLookup["惡魔髮型-D"] = 0;
        ASpeedLookup["惡魔騎士髮型-D"] = 0;
        ASpeedLookup["天使騎士髮型-D"] = 0;
        ASpeedLookup["命運髮型-D"] = 0;
        //page 2
        ASpeedLookup["戀人髮型-D"] = 0;
        ASpeedLookup["夢想兔子髮型-D"] = 0;
        ASpeedLookup["力量髮型-D"] = 0;
        ASpeedLookup["太陽髮型-D"] = 0;
        ASpeedLookup["皇帝髮型-D"] = 0;
         
        ASpeedLookup["死神髮型-D"] = 0;
        ASpeedLookup["星星髮型-D"] = 0;
        ASpeedLookup["蘭斯洛特的髮型-D"] = 0;
        ASpeedLookup["梅林的髮型-D"] = 0;
        ASpeedLookup["亞瑟的髮型-D"] = 0;
         
        ASpeedLookup["女祭司髮型-D"] = 0;
        ASpeedLookup["別西卜髮型-D"] = 0;
        ASpeedLookup["卡麥爾髮型-D"] = 0;
        ASpeedLookup["Dr.Hell髮型-D"] = 0;
        ASpeedLookup["安德烈的貴族髮型-D"] = 0;
         
        ASpeedLookup["安德烈的閃亮髮型-D"] = 0;
        ASpeedLookup["安德烈的時尚髮型-D"] = 0;
        ASpeedLookup["安德烈的猴子髮型-D"] = 0;
        ASpeedLookup["安德烈的派對髮型-D"] = 0;
        ASpeedLookup["安德烈的耀日髮型-D"] = 0;
                                       
        ASpeedLookup["安德烈的緋紅髮型-D"] = 0;
        ASpeedLookup["安德烈的高傲髮型-D"] = 0;
        ASpeedLookup["安德烈的陽光髮型-D"] = 0;
        ASpeedLookup["安德烈的黝黑髮型-D"] = 0;
        ASpeedLookup["莉莉絲的髮型-D"] = 0;
         
        ASpeedLookup["加百列髮型-D"] = 0;
        ASpeedLookup["寶物獵人髮型"] = 0;
        ASpeedLookup["摩洛髮型-D"] = 0;
        ASpeedLookup["烏列爾髮型-D"] = 0;
        ASpeedLookup["威力隆髮型-D"] = 0;
        //page 3
        ASpeedLookup["白燐髮型-D"] = 0;
        ASpeedLookup["米迦勒髮型-D"] = 0;
        ASpeedLookup["彼列髮型-D"] = 0;
        ASpeedLookup["炫紫鑄造者髮型-D"] = 0;
        ASpeedLookup["純白鑄造者髮型-D"] = 0;
         
        ASpeedLookup["暗黑鑄造者髮型-D"] = 0;
        ASpeedLookup["蒼藍鑄造者髮型-D"] = 0;
        ASpeedLookup["赤紅鑄造者髮型-D"] = 0;
        ASpeedLookup["妮克斯的髮型"] = 0;
        ASpeedLookup["拉貴爾髮型-D"] = 0;
         
        ASpeedLookup["普路托髮型-D"] = 0;
        ASpeedLookup["闇影龍戰士頭盔-D"] = 0;
        ASpeedLookup["霜雪龍戰士頭盔-D"] = 0;
        ASpeedLookup["赤焰龍戰士頭盔-D"] = 1;
        ASpeedLookup["夜煞黑燐之厄運 ‧ 破局"] = 0;
         
        ASpeedLookup["拉斐爾髮型-D"] = 0;
        ASpeedLookup["貝斯塔的髮型-D"] = 0;
        ASpeedLookup["月之永恆髮型-D"] = 0;
        ASpeedLookup["青燐髮型-D"] = 0;
        ASpeedLookup["赫梅拉髮型-D"] = 0;
         
        ASpeedLookup["大師級守護者髮型-D"] = 0;
        ASpeedLookup["奧羅拉的髮型-D"] = 0;
        ASpeedLookup["紅燐髮型-D"] = 0;
        ASpeedLookup["青春歲月校服髮型A-D"] = 0;
        ASpeedLookup["甜蜜約會髮型A"] = 0;
         
        ASpeedLookup["燦爛雪花髮型-D"] = 0;
        ASpeedLookup["幻彩甜夢髮型-D"] = 0;
        ASpeedLookup["翱翔機師髮型-D"] = 0;
        ASpeedLookup["奇妙魔術師髮型-D"] = 0;
        ASpeedLookup["貴族主僕髮型-D"] = 0;
        //page 4
        ASpeedLookup["童話主廚髮型-D"] = 0;
        ASpeedLookup["幽靈教主髮型-D"] = 0;
        ASpeedLookup["莉莉的情人節Cap帽"] = 0;
        ASpeedLookup["藍色精靈髮型-D"] = 0;
        ASpeedLookup["優雅婚禮髮型-D"] = 0;
         
        ASpeedLookup["狂野初中生髮型-D"] = 0;
        ASpeedLookup["天忍聖守 ‧ 訣"] = 0;
        ASpeedLookup["暗黑殺手髮型-D"] = 0;
        ASpeedLookup["麒麟的神豔"] = 0;
        ASpeedLookup["糖果恆星髮型-D"] = 0;
         
        ASpeedLookup["聖亳王之怒 ‧ 起始"] = 0;
        ASpeedLookup["玄武之靈羽"] = 0;
        ASpeedLookup["朱雀之髮冠"] = 0;
        ASpeedLookup["白虎之牙"] = 0;
        ASpeedLookup["青龍的風聲"] = 0;
         
        ASpeedLookup["冬天妖精髮型"] = 0;
        ASpeedLookup["雷之子索爾髮型-D"] = 0;
        ASpeedLookup["暗黑貴族魔法髮型"] = 0;
        ASpeedLookup["Dr.Hell 黑色面具"] = 0;
        ASpeedLookup["Ark魔鬼的王冠"] = 0;
         
        ASpeedLookup["Ark天使的王冠"] = 0;
        ASpeedLookup["黑色火焰髮型"] = 0;
        ASpeedLookup["泰國校服女生髮型-D"] = 1;
        ASpeedLookup["泰國校服男生髮型-D"] = 1;
    }

    void A_Acceleration()
    {
        //page 1
        AAccelerationLookup["十鬼夜行髮型-D"] = 0;
        AAccelerationLookup["白魔法髮型-D"] = 0;
        AAccelerationLookup["黑魔法髮型-D"] = 0;
        AAccelerationLookup["神諭聖光髮型-D"] = 0;
        AAccelerationLookup["魔龍貴族髮型-D"] = 0;
         
        AAccelerationLookup["幻想獨角獸髮型-D"] = 0;
        AAccelerationLookup["外星兔髮型-D"] = 0;
        AAccelerationLookup["湛藍海軍學員髮型-D"] = 0;
        AAccelerationLookup["棉花糖睡衣髮型(女)-D"] = 0;
        AAccelerationLookup["棉花糖睡衣髮型(男)-D"] = 0;
         
        AAccelerationLookup["西洋棋國王髮型-D"] = 0;
        AAccelerationLookup["靈獸髮型-D"] = 0;
        AAccelerationLookup["西洋棋士兵髮型-D"] = 0;
        AAccelerationLookup["網球手髮型-D"] = 0;
        AAccelerationLookup["西洋棋城堡髮型-D"] = 0;
         
        AAccelerationLookup["西洋棋騎士髮型-D"] = 0;
        AAccelerationLookup["舞台偶像髮型(女)-D"] = 0;
        AAccelerationLookup["舞台偶像髮型(男)-D"] = 0;
        AAccelerationLookup["西洋棋主教髮型-D"] = 0;
        AAccelerationLookup["西洋棋皇后髮型-D"] = 0;
         
        AAccelerationLookup["懶人訓練髮型-D"] = 0;
        AAccelerationLookup["菁英訓練髮型-D"] = 0;
        AAccelerationLookup["世界髮型-D"] = 0;
        AAccelerationLookup["正義髮型-D"] = 0;
        AAccelerationLookup["白夜叉髮型-D"] = 0;
         
        AAccelerationLookup["月亮髮型-D"] = 0;
        AAccelerationLookup["惡魔髮型-D"] = 0;
        AAccelerationLookup["惡魔騎士髮型-D"] = 0;
        AAccelerationLookup["天使騎士髮型-D"] = 0;
        AAccelerationLookup["命運髮型-D"] = 0;
        //page 2
        AAccelerationLookup["戀人髮型-D"] = 0;
        AAccelerationLookup["夢想兔子髮型-D"] = 0;
        AAccelerationLookup["力量髮型-D"] = 0;
        AAccelerationLookup["太陽髮型-D"] = 0;
        AAccelerationLookup["皇帝髮型-D"] = 0;
         
        AAccelerationLookup["死神髮型-D"] = 0;
        AAccelerationLookup["星星髮型-D"] = 0;
        AAccelerationLookup["蘭斯洛特的髮型-D"] = 0;
        AAccelerationLookup["梅林的髮型-D"] = 0;
        AAccelerationLookup["亞瑟的髮型-D"] = 0;
         
        AAccelerationLookup["女祭司髮型-D"] = 0;
        AAccelerationLookup["別西卜髮型-D"] = 0;
        AAccelerationLookup["卡麥爾髮型-D"] = 0;
        AAccelerationLookup["Dr.Hell髮型-D"] = 0;
        AAccelerationLookup["安德烈的貴族髮型-D"] = 0;
         
        AAccelerationLookup["安德烈的閃亮髮型-D"] = 0;
        AAccelerationLookup["安德烈的時尚髮型-D"] = 0;
        AAccelerationLookup["安德烈的猴子髮型-D"] = 0;
        AAccelerationLookup["安德烈的派對髮型-D"] = 0;
        AAccelerationLookup["安德烈的耀日髮型-D"] = 0;
         
        AAccelerationLookup["安德烈的緋紅髮型-D"] = 0;
        AAccelerationLookup["安德烈的高傲髮型-D"] = 0;
        AAccelerationLookup["安德烈的陽光髮型-D"] = 0;
        AAccelerationLookup["安德烈的黝黑髮型-D"] = 0;
        AAccelerationLookup["莉莉絲的髮型-D"] = 0;
         
        AAccelerationLookup["加百列髮型-D"] = 0;
        AAccelerationLookup["寶物獵人髮型"] = 0;
        AAccelerationLookup["摩洛髮型-D"] = 0;
        AAccelerationLookup["烏列爾髮型-D"] = 0;
        AAccelerationLookup["威力隆髮型-D"] = 0;
        //page 3
        AAccelerationLookup["白燐髮型-D"] = 0;
        AAccelerationLookup["米迦勒髮型-D"] = 0;
        AAccelerationLookup["彼列髮型-D"] = 0;
        AAccelerationLookup["炫紫鑄造者髮型-D"] = 0;
        AAccelerationLookup["純白鑄造者髮型-D"] = 0;
         
        AAccelerationLookup["暗黑鑄造者髮型-D"] = 0;
        AAccelerationLookup["蒼藍鑄造者髮型-D"] = 0;
        AAccelerationLookup["赤紅鑄造者髮型-D"] = 0;
        AAccelerationLookup["妮克斯的髮型"] = 0;
        AAccelerationLookup["拉貴爾髮型-D"] = 0;
         
        AAccelerationLookup["普路托髮型-D"] = 0;
        AAccelerationLookup["闇影龍戰士頭盔-D"] = 0;
        AAccelerationLookup["霜雪龍戰士頭盔-D"] = 1;
        AAccelerationLookup["赤焰龍戰士頭盔-D"] = 0;
        AAccelerationLookup["夜煞黑燐之厄運 ‧ 破局"] = 0;
         
        AAccelerationLookup["拉斐爾髮型-D"] = 0;
        AAccelerationLookup["貝斯塔的髮型-D"] = 0;
        AAccelerationLookup["月之永恆髮型-D"] = 0;
        AAccelerationLookup["青燐髮型-D"] = 0;
        AAccelerationLookup["赫梅拉髮型-D"] = 0;
         
        AAccelerationLookup["大師級守護者髮型-D"] = 0;
        AAccelerationLookup["奧羅拉的髮型-D"] = 0;
        AAccelerationLookup["紅燐髮型-D"] = 0;
        AAccelerationLookup["青春歲月校服髮型A-D"] = 0;
        AAccelerationLookup["甜蜜約會髮型A"] = 0;
         
        AAccelerationLookup["燦爛雪花髮型-D"] = 0;
        AAccelerationLookup["幻彩甜夢髮型-D"] = 0;
        AAccelerationLookup["翱翔機師髮型-D"] = 0;
        AAccelerationLookup["奇妙魔術師髮型-D"] = 0;
        AAccelerationLookup["貴族主僕髮型-D"] = 0;
        //page 4
        AAccelerationLookup["童話主廚髮型-D"] = 0;
        AAccelerationLookup["幽靈教主髮型-D"] = 0;
        AAccelerationLookup["莉莉的情人節Cap帽"] = 0;
        AAccelerationLookup["藍色精靈髮型-D"] = 0;
        AAccelerationLookup["優雅婚禮髮型-D"] = 0;
         
        AAccelerationLookup["狂野初中生髮型-D"] = 0;
        AAccelerationLookup["天忍聖守 ‧ 訣"] = 0;
        AAccelerationLookup["暗黑殺手髮型-D"] = 0;
        AAccelerationLookup["麒麟的神豔"] = 0;
        AAccelerationLookup["糖果恆星髮型-D"] = 0;
         
        AAccelerationLookup["聖亳王之怒 ‧ 起始"] = 0;
        AAccelerationLookup["玄武之靈羽"] = 0;
        AAccelerationLookup["朱雀之髮冠"] = 0;
        AAccelerationLookup["白虎之牙"] = 0;
        AAccelerationLookup["青龍的風聲"] = 0;
         
        AAccelerationLookup["冬天妖精髮型"] = 0;
        AAccelerationLookup["雷之子索爾髮型-D"] = 0;
        AAccelerationLookup["暗黑貴族魔法髮型"] = 0;
        AAccelerationLookup["Dr.Hell 黑色面具"] = 0;
        AAccelerationLookup["Ark魔鬼的王冠"] = 0;
         
        AAccelerationLookup["Ark天使的王冠"] = 0;
        AAccelerationLookup["黑色火焰髮型"] = 0;
        AAccelerationLookup["泰國校服女生髮型-D"] = 0;
        AAccelerationLookup["泰國校服男生髮型-D"] = 0;
    }

    void A_Power()
    {
        //page 1
        APowerLookup["十鬼夜行髮型-D"] = 0;
        APowerLookup["白魔法髮型-D"] = 0;
        APowerLookup["黑魔法髮型-D"] = 0;
        APowerLookup["神諭聖光髮型-D"] = 0;
        APowerLookup["魔龍貴族髮型-D"] = 0;
         
        APowerLookup["幻想獨角獸髮型-D"] = 0;
        APowerLookup["外星兔髮型-D"] = 0;
        APowerLookup["湛藍海軍學員髮型-D"] = 0;
        APowerLookup["棉花糖睡衣髮型(女)-D"] = 0;
        APowerLookup["棉花糖睡衣髮型(男)-D"] = 0;
         
        APowerLookup["西洋棋國王髮型-D"] = 0;
        APowerLookup["靈獸髮型-D"] = 0;
        APowerLookup["西洋棋士兵髮型-D"] = 0;
        APowerLookup["網球手髮型-D"] = 0;
        APowerLookup["西洋棋城堡髮型-D"] = 0;
         
        APowerLookup["西洋棋騎士髮型-D"] = 0;
        APowerLookup["舞台偶像髮型(女)-D"] = 0;
        APowerLookup["舞台偶像髮型(男)-D"] = 0;
        APowerLookup["西洋棋主教髮型-D"] = 0;
        APowerLookup["西洋棋皇后髮型-D"] = 0;
         
        APowerLookup["懶人訓練髮型-D"] = 0;
        APowerLookup["菁英訓練髮型-D"] = 0;
        APowerLookup["世界髮型-D"] = 0;
        APowerLookup["正義髮型-D"] = 0;
        APowerLookup["白夜叉髮型-D"] = 0;
         
        APowerLookup["月亮髮型-D"] = 0;
        APowerLookup["惡魔髮型-D"] = 0;
        APowerLookup["惡魔騎士髮型-D"] = 0;
        APowerLookup["天使騎士髮型-D"] = 0;
        APowerLookup["命運髮型-D"] = 0;
        //page 2
        APowerLookup["戀人髮型-D"] = 0;
        APowerLookup["夢想兔子髮型-D"] = 0;
        APowerLookup["力量髮型-D"] = 0;
        APowerLookup["太陽髮型-D"] = 0;
        APowerLookup["皇帝髮型-D"] = 0;
         
        APowerLookup["死神髮型-D"] = 0;
        APowerLookup["星星髮型-D"] = 0;
        APowerLookup["蘭斯洛特的髮型-D"] = 0;
        APowerLookup["梅林的髮型-D"] = 0;
        APowerLookup["亞瑟的髮型-D"] = 0;
         
        APowerLookup["女祭司髮型-D"] = 0;
        APowerLookup["別西卜髮型-D"] = 0;
        APowerLookup["卡麥爾髮型-D"] = 0;
        APowerLookup["Dr.Hell髮型-D"] = 0;
        APowerLookup["安德烈的貴族髮型-D"] = 0;
         
        APowerLookup["安德烈的閃亮髮型-D"] = 0;
        APowerLookup["安德烈的時尚髮型-D"] = 0;
        APowerLookup["安德烈的猴子髮型-D"] = 0;
        APowerLookup["安德烈的派對髮型-D"] = 0;
        APowerLookup["安德烈的耀日髮型-D"] = 0;
         
        APowerLookup["安德烈的緋紅髮型-D"] = 0;
        APowerLookup["安德烈的高傲髮型-D"] = 0;
        APowerLookup["安德烈的陽光髮型-D"] = 0;
        APowerLookup["安德烈的黝黑髮型-D"] = 0;
        APowerLookup["莉莉絲的髮型-D"] = 0;
         
        APowerLookup["加百列髮型-D"] = 0;
        APowerLookup["寶物獵人髮型"] = 0;
        APowerLookup["摩洛髮型-D"] = 0;
        APowerLookup["烏列爾髮型-D"] = 0;
        APowerLookup["威力隆髮型-D"] = 0;
        //page 3
        APowerLookup["白燐髮型-D"] = 0;
        APowerLookup["米迦勒髮型-D"] = 0;
        APowerLookup["彼列髮型-D"] = 0;
        APowerLookup["炫紫鑄造者髮型-D"] = 0;
        APowerLookup["純白鑄造者髮型-D"] = 0;
         
        APowerLookup["暗黑鑄造者髮型-D"] = 0;
        APowerLookup["蒼藍鑄造者髮型-D"] = 0;
        APowerLookup["赤紅鑄造者髮型-D"] = 0;
        APowerLookup["妮克斯的髮型"] = 0;
        APowerLookup["拉貴爾髮型-D"] = 0;
         
        APowerLookup["普路托髮型-D"] = 0;
        APowerLookup["闇影龍戰士頭盔-D"] = 1;
        APowerLookup["霜雪龍戰士頭盔-D"] = 0;
        APowerLookup["赤焰龍戰士頭盔-D"] = 0;
        APowerLookup["夜煞黑燐之厄運 ‧ 破局"] = 0;
         
        APowerLookup["拉斐爾髮型-D"] = 0;
        APowerLookup["貝斯塔的髮型-D"] = 0;
        APowerLookup["月之永恆髮型-D"] = 0;
        APowerLookup["青燐髮型-D"] = 0;
        APowerLookup["赫梅拉髮型-D"] = 0;
         
        APowerLookup["大師級守護者髮型-D"] = 0;
        APowerLookup["奧羅拉的髮型-D"] = 0;
        APowerLookup["紅燐髮型-D"] = 0;
        APowerLookup["青春歲月校服髮型A-D"] = 0;
        APowerLookup["甜蜜約會髮型A"] = 0;
         
        APowerLookup["燦爛雪花髮型-D"] = 0;
        APowerLookup["幻彩甜夢髮型-D"] = 0;
        APowerLookup["翱翔機師髮型-D"] = 0;
        APowerLookup["奇妙魔術師髮型-D"] = 0;
        APowerLookup["貴族主僕髮型-D"] = 0;
        //page 4
        APowerLookup["童話主廚髮型-D"] = 0;
        APowerLookup["幽靈教主髮型-D"] = 0;
        APowerLookup["莉莉的情人節Cap帽"] = 0;
        APowerLookup["藍色精靈髮型-D"] = 0;
        APowerLookup["優雅婚禮髮型-D"] = 0;
         
        APowerLookup["狂野初中生髮型-D"] = 0;
        APowerLookup["天忍聖守 ‧ 訣"] = 0;
        APowerLookup["暗黑殺手髮型-D"] = 0;
        APowerLookup["麒麟的神豔"] = 0;
        APowerLookup["糖果恆星髮型-D"] = 0;
         
        APowerLookup["聖亳王之怒 ‧ 起始"] = 0;
        APowerLookup["玄武之靈羽"] = 0;
        APowerLookup["朱雀之髮冠"] = 0;
        APowerLookup["白虎之牙"] = 0;
        APowerLookup["青龍的風聲"] = 0;
         
        APowerLookup["冬天妖精髮型"] = 0;
        APowerLookup["雷之子索爾髮型-D"] = 0;
        APowerLookup["暗黑貴族魔法髮型"] = 0;
        APowerLookup["Dr.Hell 黑色面具"] = 0;
        APowerLookup["Ark魔鬼的王冠"] = 0;
         
        APowerLookup["Ark天使的王冠"] = 0;
        APowerLookup["黑色火焰髮型"] = 0;
        APowerLookup["泰國校服女生髮型-D"] = 0;
        APowerLookup["泰國校服男生髮型-D"] = 0;
    }

    void A_Control()
    {
        //page 1
        AControlLookup["十鬼夜行髮型-D"] = 0;
        AControlLookup["白魔法髮型-D"] = 0;
        AControlLookup["黑魔法髮型-D"] = 0;
        AControlLookup["神諭聖光髮型-D"] = 0;
        AControlLookup["魔龍貴族髮型-D"] = 0;
         
        AControlLookup["幻想獨角獸髮型-D"] = 0;
        AControlLookup["外星兔髮型-D"] = 0;
        AControlLookup["湛藍海軍學員髮型-D"] = 0;
        AControlLookup["棉花糖睡衣髮型(女)-D"] = 0;
        AControlLookup["棉花糖睡衣髮型(男)-D"] = 0;
         
        AControlLookup["西洋棋國王髮型-D"] = 0;
        AControlLookup["靈獸髮型-D"] = 0;
        AControlLookup["西洋棋士兵髮型-D"] = 0;
        AControlLookup["網球手髮型-D"] = 0;
        AControlLookup["西洋棋城堡髮型-D"] = 0;
         
        AControlLookup["西洋棋騎士髮型-D"] = 0;
        AControlLookup["舞台偶像髮型(女)-D"] = 0;
        AControlLookup["舞台偶像髮型(男)-D"] = 0;
        AControlLookup["西洋棋主教髮型-D"] = 0;
        AControlLookup["西洋棋皇后髮型-D"] = 0;
         
        AControlLookup["懶人訓練髮型-D"] = 0;
        AControlLookup["菁英訓練髮型-D"] = 0;
        AControlLookup["世界髮型-D"] = 0;
        AControlLookup["正義髮型-D"] = 0;
        AControlLookup["白夜叉髮型-D"] = 0;
         
        AControlLookup["月亮髮型-D"] = 0;
        AControlLookup["惡魔髮型-D"] = 0;
        AControlLookup["惡魔騎士髮型-D"] = 0;
        AControlLookup["天使騎士髮型-D"] = 0;
        AControlLookup["命運髮型-D"] = 0;
        //page 2
        AControlLookup["戀人髮型-D"] = 0;
        AControlLookup["夢想兔子髮型-D"] = 0;
        AControlLookup["力量髮型-D"] = 0;
        AControlLookup["太陽髮型-D"] = 0;
        AControlLookup["皇帝髮型-D"] = 0;
         
        AControlLookup["死神髮型-D"] = 0;
        AControlLookup["星星髮型-D"] = 0;
        AControlLookup["蘭斯洛特的髮型-D"] = 0;
        AControlLookup["梅林的髮型-D"] = 0;
        AControlLookup["亞瑟的髮型-D"] = 0;
         
        AControlLookup["女祭司髮型-D"] = 0;
        AControlLookup["別西卜髮型-D"] = 0;
        AControlLookup["卡麥爾髮型-D"] = 0;
        AControlLookup["Dr.Hell髮型-D"] = 0;
        AControlLookup["安德烈的貴族髮型-D"] = 0;
         
        AControlLookup["安德烈的閃亮髮型-D"] = 0;
        AControlLookup["安德烈的時尚髮型-D"] = 0;
        AControlLookup["安德烈的猴子髮型-D"] = 0;
        AControlLookup["安德烈的派對髮型-D"] = 0;
        AControlLookup["安德烈的耀日髮型-D"] = 0;
         
        AControlLookup["安德烈的緋紅髮型-D"] = 0;
        AControlLookup["安德烈的高傲髮型-D"] = 0;
        AControlLookup["安德烈的陽光髮型-D"] = 0;
        AControlLookup["安德烈的黝黑髮型-D"] = 0;
        AControlLookup["莉莉絲的髮型-D"] = 0;
         
        AControlLookup["加百列髮型-D"] = 0;
        AControlLookup["寶物獵人髮型"] = 0;
        AControlLookup["摩洛髮型-D"] = 0;
        AControlLookup["烏列爾髮型-D"] = 0;
        AControlLookup["威力隆髮型-D"] = 0;
        //page 3
        AControlLookup["白燐髮型-D"] = 0;
        AControlLookup["米迦勒髮型-D"] = 0;
        AControlLookup["彼列髮型-D"] = 0;
        AControlLookup["炫紫鑄造者髮型-D"] = 0;
        AControlLookup["純白鑄造者髮型-D"] = 0;
         
        AControlLookup["暗黑鑄造者髮型-D"] = 0;
        AControlLookup["蒼藍鑄造者髮型-D"] = 0;
        AControlLookup["赤紅鑄造者髮型-D"] = 0;
        AControlLookup["妮克斯的髮型"] = 0;
        AControlLookup["拉貴爾髮型-D"] = 0;
         
        AControlLookup["普路托髮型-D"] = 0;
        AControlLookup["闇影龍戰士頭盔-D"] = 0;
        AControlLookup["霜雪龍戰士頭盔-D"] = 0;
        AControlLookup["赤焰龍戰士頭盔-D"] = 0;
        AControlLookup["夜煞黑燐之厄運 ‧ 破局"] = 0;
         
        AControlLookup["拉斐爾髮型-D"] = 0;
        AControlLookup["貝斯塔的髮型-D"] = 0;
        AControlLookup["月之永恆髮型-D"] = 0;
        AControlLookup["青燐髮型-D"] = 0;
        AControlLookup["赫梅拉髮型-D"] = 0;
         
        AControlLookup["大師級守護者髮型-D"] = 0;
        AControlLookup["奧羅拉的髮型-D"] = 0;
        AControlLookup["紅燐髮型-D"] = 0;
        AControlLookup["青春歲月校服髮型A-D"] = 0;
        AControlLookup["甜蜜約會髮型A"] = 0;
         
        AControlLookup["燦爛雪花髮型-D"] = 0;
        AControlLookup["幻彩甜夢髮型-D"] = 0;
        AControlLookup["翱翔機師髮型-D"] = 0;
        AControlLookup["奇妙魔術師髮型-D"] = 0;
        AControlLookup["貴族主僕髮型-D"] = 0;
        //page 4
        AControlLookup["童話主廚髮型-D"] = 0;
        AControlLookup["幽靈教主髮型-D"] = 0;
        AControlLookup["莉莉的情人節Cap帽"] = 0;
        AControlLookup["藍色精靈髮型-D"] = 0;
        AControlLookup["優雅婚禮髮型-D"] = 0;
         
        AControlLookup["狂野初中生髮型-D"] = 0;
        AControlLookup["天忍聖守 ‧ 訣"] = 0;
        AControlLookup["暗黑殺手髮型-D"] = 0;
        AControlLookup["麒麟的神豔"] = 0;
        AControlLookup["糖果恆星髮型-D"] = 0;
         
        AControlLookup["聖亳王之怒 ‧ 起始"] = 0;
        AControlLookup["玄武之靈羽"] = 0;
        AControlLookup["朱雀之髮冠"] = 0;
        AControlLookup["白虎之牙"] = 0;
        AControlLookup["青龍的風聲"] = 0;
         
        AControlLookup["冬天妖精髮型"] = 0;
        AControlLookup["雷之子索爾髮型-D"] = 0;
        AControlLookup["暗黑貴族魔法髮型"] = 0;
        AControlLookup["Dr.Hell 黑色面具"] = 0;
        AControlLookup["Ark魔鬼的王冠"] = 0;
         
        AControlLookup["Ark天使的王冠"] = 0;
        AControlLookup["黑色火焰髮型"] = 0;
        AControlLookup["泰國校服女生髮型-D"] = 0;
        AControlLookup["泰國校服男生髮型-D"] = 0;
    }

    void A_RageDuration()
    {
        //page 1
        ARageDurationLookup["十鬼夜行髮型-D"] = 8;
        ARageDurationLookup["白魔法髮型-D"] = 0;
        ARageDurationLookup["黑魔法髮型-D"] = 0;
        ARageDurationLookup["神諭聖光髮型-D"] = 15;
        ARageDurationLookup["魔龍貴族髮型-D"] = 8;
         
        ARageDurationLookup["幻想獨角獸髮型-D"] = 10;
        ARageDurationLookup["外星兔髮型-D"] = 5;
        ARageDurationLookup["湛藍海軍學員髮型-D"] = 8;
        ARageDurationLookup["棉花糖睡衣髮型(女)-D"] = 8;
        ARageDurationLookup["棉花糖睡衣髮型(男)-D"] = 8;
         
        ARageDurationLookup["西洋棋國王髮型-D"] = 10;
        ARageDurationLookup["靈獸髮型-D"] = 5;
        ARageDurationLookup["西洋棋士兵髮型-D"] = 10;
        ARageDurationLookup["網球手髮型-D"] = 8;
        ARageDurationLookup["西洋棋城堡髮型-D"] = 10;
         
        ARageDurationLookup["西洋棋騎士髮型-D"] = 10;
        ARageDurationLookup["舞台偶像髮型(女)-D"] = 10;
        ARageDurationLookup["舞台偶像髮型(男)-D"] = 10;
        ARageDurationLookup["西洋棋主教髮型-D"] = 10;
        ARageDurationLookup["西洋棋皇后髮型-D"] = 10;
         
        ARageDurationLookup["懶人訓練髮型-D"] = 8;
        ARageDurationLookup["菁英訓練髮型-D"] = 8;
        ARageDurationLookup["世界髮型-D"] = 10;
        ARageDurationLookup["正義髮型-D"] = 10;
        ARageDurationLookup["白夜叉髮型-D"] = 8;
         
        ARageDurationLookup["月亮髮型-D"] = 10;
        ARageDurationLookup["惡魔髮型-D"] = 10;
        ARageDurationLookup["惡魔騎士髮型-D"] = 8;
        ARageDurationLookup["天使騎士髮型-D"] = 8;
        ARageDurationLookup["命運髮型-D"] = 10;
        //page 2
        ARageDurationLookup["戀人髮型-D"] = 10;
        ARageDurationLookup["夢想兔子髮型-D"] = 5;
        ARageDurationLookup["力量髮型-D"] = 10;
        ARageDurationLookup["太陽髮型-D"] = 10;
        ARageDurationLookup["皇帝髮型-D"] = 10;
         
        ARageDurationLookup["死神髮型-D"] = 10;
        ARageDurationLookup["星星髮型-D"] = 10;
        ARageDurationLookup["蘭斯洛特的髮型-D"] = 5;
        ARageDurationLookup["梅林的髮型-D"] = 10;
        ARageDurationLookup["亞瑟的髮型-D"] = 8;
         
        ARageDurationLookup["女祭司髮型-D"] = 10;
        ARageDurationLookup["別西卜髮型-D"] = 10;
        ARageDurationLookup["卡麥爾髮型-D"] = 10;
        ARageDurationLookup["Dr.Hell髮型-D"] = 5;
        ARageDurationLookup["安德烈的貴族髮型-D"] = 0;
         
        ARageDurationLookup["安德烈的閃亮髮型-D"] = 0;
        ARageDurationLookup["安德烈的時尚髮型-D"] = 0;
        ARageDurationLookup["安德烈的猴子髮型-D"] = 0;
        ARageDurationLookup["安德烈的派對髮型-D"] = 0;
        ARageDurationLookup["安德烈的耀日髮型-D"] = 0;
         
        ARageDurationLookup["安德烈的緋紅髮型-D"] = 0;
        ARageDurationLookup["安德烈的高傲髮型-D"] = 0;
        ARageDurationLookup["安德烈的陽光髮型-D"] = 0;
        ARageDurationLookup["安德烈的黝黑髮型-D"] = 0;
        ARageDurationLookup["莉莉絲的髮型-D"] = 10;
         
        ARageDurationLookup["加百列髮型-D"] = 10;
        ARageDurationLookup["寶物獵人髮型"] = 10;
        ARageDurationLookup["摩洛髮型-D"] = 10;
        ARageDurationLookup["烏列爾髮型-D"] = 10;
        ARageDurationLookup["威力隆髮型-D"] = 10;
        //page 3
        ARageDurationLookup["白燐髮型-D"] = 5;
        ARageDurationLookup["米迦勒髮型-D"] = 10;
        ARageDurationLookup["彼列髮型-D"] = 10;
        ARageDurationLookup["炫紫鑄造者髮型-D"] = 5;
        ARageDurationLookup["純白鑄造者髮型-D"] = 5;
         
        ARageDurationLookup["暗黑鑄造者髮型-D"] = 5;
        ARageDurationLookup["蒼藍鑄造者髮型-D"] = 5;
        ARageDurationLookup["赤紅鑄造者髮型-D"] = 5;
        ARageDurationLookup["妮克斯的髮型"] = 5;
        ARageDurationLookup["拉貴爾髮型-D"] = 10;
         
        ARageDurationLookup["普路托髮型-D"] = 10;
        ARageDurationLookup["闇影龍戰士頭盔-D"] = 10;
        ARageDurationLookup["霜雪龍戰士頭盔-D"] = 10;
        ARageDurationLookup["赤焰龍戰士頭盔-D"] = 10;
        ARageDurationLookup["夜煞黑燐之厄運 ‧ 破局"] = 5;
         
        ARageDurationLookup["拉斐爾髮型-D"] = 10;
        ARageDurationLookup["貝斯塔的髮型-D"] = 5;
        ARageDurationLookup["月之永恆髮型-D"] = 10;
        ARageDurationLookup["青燐髮型-D"] = 5;
        ARageDurationLookup["赫梅拉髮型-D"] = 5;
         
        ARageDurationLookup["大師級守護者髮型-D"] = 10;
        ARageDurationLookup["奧羅拉的髮型-D"] = 5;
        ARageDurationLookup["紅燐髮型-D"] = 5;
        ARageDurationLookup["青春歲月校服髮型A-D"] = 5;
        ARageDurationLookup["甜蜜約會髮型A"] = 5;
         
        ARageDurationLookup["燦爛雪花髮型-D"] = 10;
        ARageDurationLookup["幻彩甜夢髮型-D"] = 5;
        ARageDurationLookup["翱翔機師髮型-D"] = 5;
        ARageDurationLookup["奇妙魔術師髮型-D"] = 5;
        ARageDurationLookup["貴族主僕髮型-D"] = 5;
        //page 4
        ARageDurationLookup["童話主廚髮型-D"] = 5;
        ARageDurationLookup["幽靈教主髮型-D"] = 10;
        ARageDurationLookup["莉莉的情人節Cap帽"] = 8;
        ARageDurationLookup["藍色精靈髮型-D"] = 10;
        ARageDurationLookup["優雅婚禮髮型-D"] = 5;
         
        ARageDurationLookup["狂野初中生髮型-D"] = 10;
        ARageDurationLookup["天忍聖守 ‧ 訣"] = 5;
        ARageDurationLookup["暗黑殺手髮型-D"] = 5;
        ARageDurationLookup["麒麟的神豔"] = 5;
        ARageDurationLookup["糖果恆星髮型-D"] = 10;
         
        ARageDurationLookup["聖亳王之怒 ‧ 起始"] = 5;
        ARageDurationLookup["玄武之靈羽"] = 5;
        ARageDurationLookup["朱雀之髮冠"] = 5;
        ARageDurationLookup["白虎之牙"] = 5;
        ARageDurationLookup["青龍的風聲"] = 5;
         
        ARageDurationLookup["冬天妖精髮型"] = 0;
        ARageDurationLookup["雷之子索爾髮型-D"] = 10;
        ARageDurationLookup["暗黑貴族魔法髮型"] = 0;
        ARageDurationLookup["Dr.Hell 黑色面具"] = 0;
        ARageDurationLookup["Ark魔鬼的王冠"] = 0;
         
        ARageDurationLookup["Ark天使的王冠"] = 0;
        ARageDurationLookup["黑色火焰髮型"] = 5;
        ARageDurationLookup["泰國校服女生髮型-D"] = 10;
        ARageDurationLookup["泰國校服男生髮型-D"] = 10;
    }

    void A_RageCharge()
    {

    }

    void A_MaxEnergy()
    {

    }

    void A_MaxSprint()
    {

    }

    void A_Force()
    {

    }

    void A_Luck()
    {

    }
    #endregion A_Hair Stats

    void S_Hair()
    {
        S_Rarity();
        S_Mode();
        S_Speed();
        S_Acceleration();
        S_Power();
        S_Control();
        S_RageDuration();
        S_RageCharge();
        S_MaxEnergy();
        S_MaxSprint();
        S_Force();
        S_Luck();
    }

    void S_Rarity()
    {
        //Page 1
        SRarityLookup["百鬼夜行髮型-D"] = 4;
        SRarityLookup["白魔法髮型-D"] = 4;
        SRarityLookup["黑魔法髮型-D"] = 4;
        SRarityLookup["黑白天鵝髮型-D"] = 4;
        SRarityLookup["遠航探險家髮型-D"] = 4;

        SRarityLookup["閃耀星空髮型-D"] = 4;
        SRarityLookup["失憶患者髮型-D"] = 4;
        SRarityLookup["惡夢醫生髮型-D"] = 4;
        SRarityLookup["夏日校服髮型-D"] = 4;
        SRarityLookup["柏勒洛豐髮型-D"] = 4;

        SRarityLookup["中華旗袍髮型(男)-D"] = 4;
        SRarityLookup["中華旗袍髮型(女)-D"] = 4;
        SRarityLookup["勝利女神髮型-D"] = 4;
        SRarityLookup["懶人髮型-D"] = 4;
        SRarityLookup["菁英髮型-D"] = 4;

        SRarityLookup["愚者髮型-D"] = 4;
        SRarityLookup["灰姑娘髮型-D"] = 4;
        SRarityLookup["野獸之王髮型-D"] = 4;
        SRarityLookup["九尾狐影月髮型-D"] = 4;
        SRarityLookup["九尾狐陽焰髮型-D"] = 4;

        SRarityLookup["白雪公主髮型-D"] = 4;
        SRarityLookup["惡魔貴族髮型"] = 4;
        SRarityLookup["天使貴族髮型"] = 4;
        SRarityLookup["垂鐘花髮型-D"] = 4;
        SRarityLookup["茉莉髮型-D"] = 4;

        SRarityLookup["玫瑰妖精髮型-D"] = 4;
        SRarityLookup["鈴蘭髮型-D"] = 4;
        SRarityLookup["白衣患者髮型-D"] = 4;
        SRarityLookup["惡夢博士髮型-D"] = 4;
        SRarityLookup["夢幻髮型-D"] = 4;
        //Page 2
        SRarityLookup["茶花髮型-D"] = 4;
        SRarityLookup["雛菊髮型-D"] = 4;
        SRarityLookup["勿忘草髮型-D"] = 4;
        SRarityLookup["玫瑰騎士髮型-D"] = 4;
        SRarityLookup["雪狼髮型-D"] = 4;

        SRarityLookup["水仙髮型-D"] = 4;
        SRarityLookup["安圖莎的髮型-D"] = 4;
        SRarityLookup["棉花髮型-D"] = 4;
        SRarityLookup["塔羅小丑的散漫-D"] = 4;
        SRarityLookup["翠菊髮型-D"] = 4;

        SRarityLookup["海芋髮型-D"] = 4;
        SRarityLookup["龍膽髮型-D"] = 4;
        SRarityLookup["魔法艾洛髮型-D"] = 4;
        SRarityLookup["向日葵髮型-D"] = 4;
        SRarityLookup["幽藍天鵝髮型-D"] = 4;

        SRarityLookup["安德烈的魅力髮型-D"] = 4;
        SRarityLookup["羊咩咩髮型-D"] = 4;
        SRarityLookup["馬拉高髮型-D"] = 4;
        SRarityLookup["蛇寶寶髮型-D"] = 4;
        SRarityLookup["小龍兒髮型-D"] = 4;

        SRarityLookup["純潔白燐髮型-D"] = 4;
        SRarityLookup["小雪兔髮型-D"] = 4;
        SRarityLookup["夢幻鑄造者髮型-D"] = 4;
        SRarityLookup["叛胖虎髮型-D"] = 4;
        SRarityLookup["黑鳳凰頭盔-D"] = 4;

        SRarityLookup["牛奶仔髮型-D"] = 4;
        SRarityLookup["闇影龍騎士頭盔-D"] = 4;
        SRarityLookup["霜雪龍騎士頭盔-D"] = 4;
        SRarityLookup["赤焰龍騎士頭盔-D"] = 4;
        SRarityLookup["榮譽騎士髮型-D"] = 4;
        //Page 3
        SRarityLookup["吱吱鼠髮型-D"] = 4;
        SRarityLookup["豬太郎髮型-D"] = 4;
        SRarityLookup["夜煞黑燐之厄運 ‧ 壞滅"] = 4;
        SRarityLookup["路西法的墮落-D"] = 4;
        SRarityLookup["汪汪狗髮型-D"] = 4;

        SRarityLookup["跍跍雞髮型-D"] = 4;
        SRarityLookup["頑皮猴髮型-D"] = 4;
        SRarityLookup["優雅青燐髮型-D"] = 4;
        SRarityLookup["宙斯髮型-D"] = 4;
        SRarityLookup["雅典娜髮型-D"] = 4;

        SRarityLookup["秀麗紅燐髮型-D"] = 4;
        SRarityLookup["赫密斯髮型-D"] = 4;
        SRarityLookup["青春歲月校服髮型S-D"] = 4;
        SRarityLookup["阿芙蘿黛蒂髮型-D"] = 4;
        SRarityLookup["甜蜜約會髮型S"] = 4;

        SRarityLookup["阿瑞斯髮型-D"] = 4;
        SRarityLookup["赫拉的髮型-D"] = 4;
        SRarityLookup["星空奇夢髮型-D"] = 4;
        SRarityLookup["赫淮斯托斯髮型-D"] = 4;
        SRarityLookup["翱翔機師髮型S-D"] = 4;

        SRarityLookup["查理的辮子髮型-D"] = 4;
        SRarityLookup["阿提密斯髮型-D"] = 4;
        SRarityLookup["夢幻魔利師髮型-D"] = 4;
        SRarityLookup["帝奧尼索斯髮型-D"] = 4;
        SRarityLookup["皇窒主僕髮型-D"] = 4;

        SRarityLookup["波塞頓髮型-D"] = 4;
        SRarityLookup["五星童話主廚髮型-D"] = 4;
        SRarityLookup["狄密特髮型-D"] = 4;
        SRarityLookup["莉莉的命運髮型"] = 4;
        SRarityLookup["阿波羅髮型-D"] = 4;
        //Page 4
        SRarityLookup["夢想雨衣髮型-D"] = 4;
        SRarityLookup["華麗婚禮髮型-D"] = 4;
        SRarityLookup["狂野高中生髮型-D"] = 4;
        SRarityLookup["天御聖守 ‧ 訣"] = 4;
        SRarityLookup["麒麟的神豔 ‧ 神蹟"] = 4;

        SRarityLookup["聖亳王之怒 ‧ 終焉"] = 4;
        SRarityLookup["玄武之靈羽 ‧ 神威"] = 4;
        SRarityLookup["極光髮型"] = 4;
        SRarityLookup["朱雀之髮冠 ‧ 究極"] = 4;
        SRarityLookup["白虎之牙 ‧ 真打"] = 4;

        SRarityLookup["青龍的風聲 ‧ 極-D"] = 4;
        SRarityLookup["冰封精靈髮型"] = 4;
        SRarityLookup["星之碎片魔法髮型"] = 4;
    }

    void S_Mode()
    {/*
        //Page 1
        SModeLookup["百鬼夜行髮型-D"] = 4;
        SModeLookup["白魔法髮型-D"] = 4;
        SModeLookup["黑魔法髮型-D"] = 4;
        SModeLookup["黑白天鵝髮型-D"] = 4;
        SModeLookup["遠航探險家髮型-D"] = 4;
         
        SModeLookup["閃耀星空髮型-D"] = 4;
        SModeLookup["失憶患者髮型-D"] = 4;
        SModeLookup["惡夢醫生髮型-D"] = 4;
        SModeLookup["夏日校服髮型-D"] = 4;
        SModeLookup["柏勒洛豐髮型-D"] = 4;
         
        SModeLookup["中華旗袍髮型(男)-D"] = 4;
        SModeLookup["中華旗袍髮型(女)-D"] = 4;
        SModeLookup["勝利女神髮型-D"] = 4;
        SModeLookup["懶人髮型-D"] = 4;
        SModeLookup["菁英髮型-D"] = 4;
         
        SModeLookup["愚者髮型-D"] = 4;
        SModeLookup["灰姑娘髮型-D"] = 4;
        SModeLookup["野獸之王髮型-D"] = 4;
        SModeLookup["九尾狐影月髮型-D"] = 4;
        SModeLookup["九尾狐陽焰髮型-D"] = 4;
         
        SModeLookup["白雪公主髮型-D"] = 4;
        SModeLookup["惡魔貴族髮型"] = 4;
        SModeLookup["天使貴族髮型"] = 4;
        SModeLookup["垂鐘花髮型-D"] = 4;
        SModeLookup["茉莉髮型-D"] = 4;
         
        SModeLookup["玫瑰妖精髮型-D"] = 4;
        SModeLookup["鈴蘭髮型-D"] = 4;
        SModeLookup["白衣患者髮型-D"] = 4;
        SModeLookup["惡夢博士髮型-D"] = 4;
        SModeLookup["夢幻髮型-D"] = 4;
        //Page 2
        SModeLookup["茶花髮型-D"] = 4;
        SModeLookup["雛菊髮型-D"] = 4;
        SModeLookup["勿忘草髮型-D"] = 4;
        SModeLookup["玫瑰騎士髮型-D"] = 4;
        SModeLookup["雪狼髮型-D"] = 4;
         
        SModeLookup["水仙髮型-D"] = 4;
        SModeLookup["安圖莎的髮型-D"] = 4;
        SModeLookup["棉花髮型-D"] = 4;
        SModeLookup["塔羅小丑的散漫-D"] = 4;
        SModeLookup["翠菊髮型-D"] = 4;
         
        SModeLookup["海芋髮型-D"] = 4;
        SModeLookup["龍膽髮型-D"] = 4;
        SModeLookup["魔法艾洛髮型-D"] = 4;
        SModeLookup["向日葵髮型-D"] = 4;
        SModeLookup["幽藍天鵝髮型-D"] = 4;
         
        SModeLookup["安德烈的魅力髮型-D"] = 4;
        SModeLookup["羊咩咩髮型-D"] = 4;
        SModeLookup["馬拉高髮型-D"] = 4;
        SModeLookup["蛇寶寶髮型-D"] = 4;
        SModeLookup["小龍兒髮型-D"] = 4;
         
        SModeLookup["純潔白燐髮型-D"] = 4;
        SModeLookup["小雪兔髮型-D"] = 4;
        SModeLookup["夢幻鑄造者髮型-D"] = 4;
        SModeLookup["叛胖虎髮型-D"] = 4;
        SModeLookup["黑鳳凰頭盔-D"] = 4;
         
        SModeLookup["牛奶仔髮型-D"] = 4;
        SModeLookup["闇影龍騎士頭盔-D"] = 4;
        SModeLookup["霜雪龍騎士頭盔-D"] = 4;
        SModeLookup["赤焰龍騎士頭盔-D"] = 4;
        SModeLookup["榮譽騎士髮型-D"] = 4;
        //Page 3
        SModeLookup["吱吱鼠髮型-D"] = 4;
        SModeLookup["豬太郎髮型-D"] = 4;
        SModeLookup["夜煞黑燐之厄運 ‧ 壞滅"] = 4;
        SModeLookup["路西法的墮落-D"] = 4;
        SModeLookup["汪汪狗髮型-D"] = 4;
         
        SModeLookup["跍跍雞髮型-D"] = 4;
        SModeLookup["頑皮猴髮型-D"] = 4;
        SModeLookup["優雅青燐髮型-D"] = 4;
        SModeLookup["宙斯髮型-D"] = 4;
        SModeLookup["雅典娜髮型-D"] = 4;
         
        SModeLookup["秀麗紅燐髮型-D"] = 4;
        SModeLookup["赫密斯髮型-D"] = 4;
        SModeLookup["青春歲月校服髮型S-D"] = 4;
        SModeLookup["阿芙蘿黛蒂髮型-D"] = 4;
        SModeLookup["甜蜜約會髮型S"] = 4;
         
        SModeLookup["阿瑞斯髮型-D"] = 4;
        SModeLookup["赫拉的髮型-D"] = 4;
        SModeLookup["星空奇夢髮型-D"] = 4;
        SModeLookup["赫淮斯托斯髮型-D"] = 4;
        SModeLookup["翱翔機師髮型S-D"] = 4;
         
        SModeLookup["查理的辮子髮型-D"] = 4;
        SModeLookup["阿提密斯髮型-D"] = 4;
        SModeLookup["夢幻魔利師髮型-D"] = 4;
        SModeLookup["帝奧尼索斯髮型-D"] = 4;
        SModeLookup["皇窒主僕髮型-D"] = 4;
         
        SModeLookup["波塞頓髮型-D"] = 4;
        SModeLookup["五星童話主廚髮型-D"] = 4;
        SModeLookup["狄密特髮型-D"] = 4;
        SModeLookup["莉莉的命運髮型"] = 4;
        SModeLookup["阿波羅髮型-D"] = 4;
        //Page 4
        SModeLookup["夢想雨衣髮型-D"] = 4;
        SModeLookup["華麗婚禮髮型-D"] = 4;
        SModeLookup["狂野高中生髮型-D"] = 4;
        SModeLookup["天御聖守 ‧ 訣"] = 4;
        SModeLookup["麒麟的神豔 ‧ 神蹟"] = 4;
         
        SModeLookup["聖亳王之怒 ‧ 終焉"] = 4;
        SModeLookup["玄武之靈羽 ‧ 神威"] = 4;
        SModeLookup["極光髮型"] = 4;
        SModeLookup["朱雀之髮冠 ‧ 究極"] = 4;
        SModeLookup["白虎之牙 ‧ 真打"] = 4;
         
        SModeLookup["青龍的風聲 ‧ 極-D"] = 4;
        SModeLookup["冰封精靈髮型"] = 4;
        SModeLookup["星之碎片魔法髮型"] = 4;
        */
    }

    void S_Speed()
    {
        //Page 1
        SSpeedLookup["百鬼夜行髮型-D"] = 4;
        SSpeedLookup["白魔法髮型-D"] = 4;
        SSpeedLookup["黑魔法髮型-D"] = 4;
        SSpeedLookup["黑白天鵝髮型-D"] = 4;
        SSpeedLookup["遠航探險家髮型-D"] = 4;
         
        SSpeedLookup["閃耀星空髮型-D"] = 4;
        SSpeedLookup["失憶患者髮型-D"] = 4;
        SSpeedLookup["惡夢醫生髮型-D"] = 4;
        SSpeedLookup["夏日校服髮型-D"] = 4;
        SSpeedLookup["柏勒洛豐髮型-D"] = 4;
         
        SSpeedLookup["中華旗袍髮型(男)-D"] = 4;
        SSpeedLookup["中華旗袍髮型(女)-D"] = 4;
        SSpeedLookup["勝利女神髮型-D"] = 4;
        SSpeedLookup["懶人髮型-D"] = 4;
        SSpeedLookup["菁英髮型-D"] = 4;
         
        SSpeedLookup["愚者髮型-D"] = 4;
        SSpeedLookup["灰姑娘髮型-D"] = 4;
        SSpeedLookup["野獸之王髮型-D"] = 4;
        SSpeedLookup["九尾狐影月髮型-D"] = 4;
        SSpeedLookup["九尾狐陽焰髮型-D"] = 4;
         
        SSpeedLookup["白雪公主髮型-D"] = 4;
        SSpeedLookup["惡魔貴族髮型"] = 4;
        SSpeedLookup["天使貴族髮型"] = 4;
        SSpeedLookup["垂鐘花髮型-D"] = 4;
        SSpeedLookup["茉莉髮型-D"] = 4;
         
        SSpeedLookup["玫瑰妖精髮型-D"] = 4;
        SSpeedLookup["鈴蘭髮型-D"] = 4;
        SSpeedLookup["白衣患者髮型-D"] = 4;
        SSpeedLookup["惡夢博士髮型-D"] = 4;
        SSpeedLookup["夢幻髮型-D"] = 4;
        //Page 2
        SSpeedLookup["茶花髮型-D"] = 4;
        SSpeedLookup["雛菊髮型-D"] = 4;
        SSpeedLookup["勿忘草髮型-D"] = 4;
        SSpeedLookup["玫瑰騎士髮型-D"] = 4;
        SSpeedLookup["雪狼髮型-D"] = 4;
         
        SSpeedLookup["水仙髮型-D"] = 4;
        SSpeedLookup["安圖莎的髮型-D"] = 4;
        SSpeedLookup["棉花髮型-D"] = 4;
        SSpeedLookup["塔羅小丑的散漫-D"] = 4;
        SSpeedLookup["翠菊髮型-D"] = 4;
         
        SSpeedLookup["海芋髮型-D"] = 4;
        SSpeedLookup["龍膽髮型-D"] = 4;
        SSpeedLookup["魔法艾洛髮型-D"] = 4;
        SSpeedLookup["向日葵髮型-D"] = 4;
        SSpeedLookup["幽藍天鵝髮型-D"] = 4;
         
        SSpeedLookup["安德烈的魅力髮型-D"] = 4;
        SSpeedLookup["羊咩咩髮型-D"] = 4;
        SSpeedLookup["馬拉高髮型-D"] = 4;
        SSpeedLookup["蛇寶寶髮型-D"] = 4;
        SSpeedLookup["小龍兒髮型-D"] = 4;
         
        SSpeedLookup["純潔白燐髮型-D"] = 4;
        SSpeedLookup["小雪兔髮型-D"] = 4;
        SSpeedLookup["夢幻鑄造者髮型-D"] = 4;
        SSpeedLookup["叛胖虎髮型-D"] = 4;
        SSpeedLookup["黑鳳凰頭盔-D"] = 4;
         
        SSpeedLookup["牛奶仔髮型-D"] = 4;
        SSpeedLookup["闇影龍騎士頭盔-D"] = 4;
        SSpeedLookup["霜雪龍騎士頭盔-D"] = 4;
        SSpeedLookup["赤焰龍騎士頭盔-D"] = 4;
        SSpeedLookup["榮譽騎士髮型-D"] = 4;
        //Page 3
        SSpeedLookup["吱吱鼠髮型-D"] = 4;
        SSpeedLookup["豬太郎髮型-D"] = 4;
        SSpeedLookup["夜煞黑燐之厄運 ‧ 壞滅"] = 4;
        SSpeedLookup["路西法的墮落-D"] = 4;
        SSpeedLookup["汪汪狗髮型-D"] = 4;
         
        SSpeedLookup["跍跍雞髮型-D"] = 4;
        SSpeedLookup["頑皮猴髮型-D"] = 4;
        SSpeedLookup["優雅青燐髮型-D"] = 4;
        SSpeedLookup["宙斯髮型-D"] = 4;
        SSpeedLookup["雅典娜髮型-D"] = 4;
         
        SSpeedLookup["秀麗紅燐髮型-D"] = 4;
        SSpeedLookup["赫密斯髮型-D"] = 4;
        SSpeedLookup["青春歲月校服髮型S-D"] = 4;
        SSpeedLookup["阿芙蘿黛蒂髮型-D"] = 4;
        SSpeedLookup["甜蜜約會髮型S"] = 4;
         
        SSpeedLookup["阿瑞斯髮型-D"] = 4;
        SSpeedLookup["赫拉的髮型-D"] = 4;
        SSpeedLookup["星空奇夢髮型-D"] = 4;
        SSpeedLookup["赫淮斯托斯髮型-D"] = 4;
        SSpeedLookup["翱翔機師髮型S-D"] = 4;
         
        SSpeedLookup["查理的辮子髮型-D"] = 4;
        SSpeedLookup["阿提密斯髮型-D"] = 4;
        SSpeedLookup["夢幻魔利師髮型-D"] = 4;
        SSpeedLookup["帝奧尼索斯髮型-D"] = 4;
        SSpeedLookup["皇窒主僕髮型-D"] = 4;
         
        SSpeedLookup["波塞頓髮型-D"] = 4;
        SSpeedLookup["五星童話主廚髮型-D"] = 4;
        SSpeedLookup["狄密特髮型-D"] = 4;
        SSpeedLookup["莉莉的命運髮型"] = 4;
        SSpeedLookup["阿波羅髮型-D"] = 4;
        //Page 4
        SSpeedLookup["夢想雨衣髮型-D"] = 4;
        SSpeedLookup["華麗婚禮髮型-D"] = 4;
        SSpeedLookup["狂野高中生髮型-D"] = 4;
        SSpeedLookup["天御聖守 ‧ 訣"] = 4;
        SSpeedLookup["麒麟的神豔 ‧ 神蹟"] = 4;
         
        SSpeedLookup["聖亳王之怒 ‧ 終焉"] = 4;
        SSpeedLookup["玄武之靈羽 ‧ 神威"] = 4;
        SSpeedLookup["極光髮型"] = 4;
        SSpeedLookup["朱雀之髮冠 ‧ 究極"] = 4;
        SSpeedLookup["白虎之牙 ‧ 真打"] = 4;
         
        SSpeedLookup["青龍的風聲 ‧ 極-D"] = 4;
        SSpeedLookup["冰封精靈髮型"] = 4;
        SSpeedLookup["星之碎片魔法髮型"] = 4;
    }

    void S_Acceleration()
    {
        //Page 1
        SAccelerationLookup["百鬼夜行髮型-D"] = 4;
        SAccelerationLookup["白魔法髮型-D"] = 4;
        SAccelerationLookup["黑魔法髮型-D"] = 4;
        SAccelerationLookup["黑白天鵝髮型-D"] = 4;
        SAccelerationLookup["遠航探險家髮型-D"] = 4;
         
        SAccelerationLookup["閃耀星空髮型-D"] = 4;
        SAccelerationLookup["失憶患者髮型-D"] = 4;
        SAccelerationLookup["惡夢醫生髮型-D"] = 4;
        SAccelerationLookup["夏日校服髮型-D"] = 4;
        SAccelerationLookup["柏勒洛豐髮型-D"] = 4;
         
        SAccelerationLookup["中華旗袍髮型(男)-D"] = 4;
        SAccelerationLookup["中華旗袍髮型(女)-D"] = 4;
        SAccelerationLookup["勝利女神髮型-D"] = 4;
        SAccelerationLookup["懶人髮型-D"] = 4;
        SAccelerationLookup["菁英髮型-D"] = 4;
         
        SAccelerationLookup["愚者髮型-D"] = 4;
        SAccelerationLookup["灰姑娘髮型-D"] = 4;
        SAccelerationLookup["野獸之王髮型-D"] = 4;
        SAccelerationLookup["九尾狐影月髮型-D"] = 4;
        SAccelerationLookup["九尾狐陽焰髮型-D"] = 4;
         
        SAccelerationLookup["白雪公主髮型-D"] = 4;
        SAccelerationLookup["惡魔貴族髮型"] = 4;
        SAccelerationLookup["天使貴族髮型"] = 4;
        SAccelerationLookup["垂鐘花髮型-D"] = 4;
        SAccelerationLookup["茉莉髮型-D"] = 4;
         
        SAccelerationLookup["玫瑰妖精髮型-D"] = 4;
        SAccelerationLookup["鈴蘭髮型-D"] = 4;
        SAccelerationLookup["白衣患者髮型-D"] = 4;
        SAccelerationLookup["惡夢博士髮型-D"] = 4;
        SAccelerationLookup["夢幻髮型-D"] = 4;
        //Page 2
        SAccelerationLookup["茶花髮型-D"] = 4;
        SAccelerationLookup["雛菊髮型-D"] = 4;
        SAccelerationLookup["勿忘草髮型-D"] = 4;
        SAccelerationLookup["玫瑰騎士髮型-D"] = 4;
        SAccelerationLookup["雪狼髮型-D"] = 4;
         
        SAccelerationLookup["水仙髮型-D"] = 4;
        SAccelerationLookup["安圖莎的髮型-D"] = 4;
        SAccelerationLookup["棉花髮型-D"] = 4;
        SAccelerationLookup["塔羅小丑的散漫-D"] = 4;
        SAccelerationLookup["翠菊髮型-D"] = 4;
         
        SAccelerationLookup["海芋髮型-D"] = 4;
        SAccelerationLookup["龍膽髮型-D"] = 4;
        SAccelerationLookup["魔法艾洛髮型-D"] = 4;
        SAccelerationLookup["向日葵髮型-D"] = 4;
        SAccelerationLookup["幽藍天鵝髮型-D"] = 4;
         
        SAccelerationLookup["安德烈的魅力髮型-D"] = 4;
        SAccelerationLookup["羊咩咩髮型-D"] = 4;
        SAccelerationLookup["馬拉高髮型-D"] = 4;
        SAccelerationLookup["蛇寶寶髮型-D"] = 4;
        SAccelerationLookup["小龍兒髮型-D"] = 4;
         
        SAccelerationLookup["純潔白燐髮型-D"] = 4;
        SAccelerationLookup["小雪兔髮型-D"] = 4;
        SAccelerationLookup["夢幻鑄造者髮型-D"] = 4;
        SAccelerationLookup["叛胖虎髮型-D"] = 4;
        SAccelerationLookup["黑鳳凰頭盔-D"] = 4;
         
        SAccelerationLookup["牛奶仔髮型-D"] = 4;
        SAccelerationLookup["闇影龍騎士頭盔-D"] = 4;
        SAccelerationLookup["霜雪龍騎士頭盔-D"] = 4;
        SAccelerationLookup["赤焰龍騎士頭盔-D"] = 4;
        SAccelerationLookup["榮譽騎士髮型-D"] = 4;
        //Page 3
        SAccelerationLookup["吱吱鼠髮型-D"] = 4;
        SAccelerationLookup["豬太郎髮型-D"] = 4;
        SAccelerationLookup["夜煞黑燐之厄運 ‧ 壞滅"] = 4;
        SAccelerationLookup["路西法的墮落-D"] = 4;
        SAccelerationLookup["汪汪狗髮型-D"] = 4;
         
        SAccelerationLookup["跍跍雞髮型-D"] = 4;
        SAccelerationLookup["頑皮猴髮型-D"] = 4;
        SAccelerationLookup["優雅青燐髮型-D"] = 4;
        SAccelerationLookup["宙斯髮型-D"] = 4;
        SAccelerationLookup["雅典娜髮型-D"] = 4;
         
        SAccelerationLookup["秀麗紅燐髮型-D"] = 4;
        SAccelerationLookup["赫密斯髮型-D"] = 4;
        SAccelerationLookup["青春歲月校服髮型S-D"] = 4;
        SAccelerationLookup["阿芙蘿黛蒂髮型-D"] = 4;
        SAccelerationLookup["甜蜜約會髮型S"] = 4;
         
        SAccelerationLookup["阿瑞斯髮型-D"] = 4;
        SAccelerationLookup["赫拉的髮型-D"] = 4;
        SAccelerationLookup["星空奇夢髮型-D"] = 4;
        SAccelerationLookup["赫淮斯托斯髮型-D"] = 4;
        SAccelerationLookup["翱翔機師髮型S-D"] = 4;
         
        SAccelerationLookup["查理的辮子髮型-D"] = 4;
        SAccelerationLookup["阿提密斯髮型-D"] = 4;
        SAccelerationLookup["夢幻魔利師髮型-D"] = 4;
        SAccelerationLookup["帝奧尼索斯髮型-D"] = 4;
        SAccelerationLookup["皇窒主僕髮型-D"] = 4;
         
        SAccelerationLookup["波塞頓髮型-D"] = 4;
        SAccelerationLookup["五星童話主廚髮型-D"] = 4;
        SAccelerationLookup["狄密特髮型-D"] = 4;
        SAccelerationLookup["莉莉的命運髮型"] = 4;
        SAccelerationLookup["阿波羅髮型-D"] = 4;
        //Page 4
        SAccelerationLookup["夢想雨衣髮型-D"] = 4;
        SAccelerationLookup["華麗婚禮髮型-D"] = 4;
        SAccelerationLookup["狂野高中生髮型-D"] = 4;
        SAccelerationLookup["天御聖守 ‧ 訣"] = 4;
        SAccelerationLookup["麒麟的神豔 ‧ 神蹟"] = 4;
         
        SAccelerationLookup["聖亳王之怒 ‧ 終焉"] = 4;
        SAccelerationLookup["玄武之靈羽 ‧ 神威"] = 4;
        SAccelerationLookup["極光髮型"] = 4;
        SAccelerationLookup["朱雀之髮冠 ‧ 究極"] = 4;
        SAccelerationLookup["白虎之牙 ‧ 真打"] = 4;
         
        SAccelerationLookup["青龍的風聲 ‧ 極-D"] = 4;
        SAccelerationLookup["冰封精靈髮型"] = 4;
        SAccelerationLookup["星之碎片魔法髮型"] = 4;
    }

    void S_Power()
    {
        //Page 1
        SPowerLookup["百鬼夜行髮型-D"] = 4;
        SPowerLookup["白魔法髮型-D"] = 4;
        SPowerLookup["黑魔法髮型-D"] = 4;
        SPowerLookup["黑白天鵝髮型-D"] = 4;
        SPowerLookup["遠航探險家髮型-D"] = 4;
         
        SPowerLookup["閃耀星空髮型-D"] = 4;
        SPowerLookup["失憶患者髮型-D"] = 4;
        SPowerLookup["惡夢醫生髮型-D"] = 4;
        SPowerLookup["夏日校服髮型-D"] = 4;
        SPowerLookup["柏勒洛豐髮型-D"] = 4;
         
        SPowerLookup["中華旗袍髮型(男)-D"] = 4;
        SPowerLookup["中華旗袍髮型(女)-D"] = 4;
        SPowerLookup["勝利女神髮型-D"] = 4;
        SPowerLookup["懶人髮型-D"] = 4;
        SPowerLookup["菁英髮型-D"] = 4;
         
        SPowerLookup["愚者髮型-D"] = 4;
        SPowerLookup["灰姑娘髮型-D"] = 4;
        SPowerLookup["野獸之王髮型-D"] = 4;
        SPowerLookup["九尾狐影月髮型-D"] = 4;
        SPowerLookup["九尾狐陽焰髮型-D"] = 4;
         
        SPowerLookup["白雪公主髮型-D"] = 4;
        SPowerLookup["惡魔貴族髮型"] = 4;
        SPowerLookup["天使貴族髮型"] = 4;
        SPowerLookup["垂鐘花髮型-D"] = 4;
        SPowerLookup["茉莉髮型-D"] = 4;
         
        SPowerLookup["玫瑰妖精髮型-D"] = 4;
        SPowerLookup["鈴蘭髮型-D"] = 4;
        SPowerLookup["白衣患者髮型-D"] = 4;
        SPowerLookup["惡夢博士髮型-D"] = 4;
        SPowerLookup["夢幻髮型-D"] = 4;
        //Page 2
        SPowerLookup["茶花髮型-D"] = 4;
        SPowerLookup["雛菊髮型-D"] = 4;
        SPowerLookup["勿忘草髮型-D"] = 4;
        SPowerLookup["玫瑰騎士髮型-D"] = 4;
        SPowerLookup["雪狼髮型-D"] = 4;
         
        SPowerLookup["水仙髮型-D"] = 4;
        SPowerLookup["安圖莎的髮型-D"] = 4;
        SPowerLookup["棉花髮型-D"] = 4;
        SPowerLookup["塔羅小丑的散漫-D"] = 4;
        SPowerLookup["翠菊髮型-D"] = 4;
         
        SPowerLookup["海芋髮型-D"] = 4;
        SPowerLookup["龍膽髮型-D"] = 4;
        SPowerLookup["魔法艾洛髮型-D"] = 4;
        SPowerLookup["向日葵髮型-D"] = 4;
        SPowerLookup["幽藍天鵝髮型-D"] = 4;
         
        SPowerLookup["安德烈的魅力髮型-D"] = 4;
        SPowerLookup["羊咩咩髮型-D"] = 4;
        SPowerLookup["馬拉高髮型-D"] = 4;
        SPowerLookup["蛇寶寶髮型-D"] = 4;
        SPowerLookup["小龍兒髮型-D"] = 4;
         
        SPowerLookup["純潔白燐髮型-D"] = 4;
        SPowerLookup["小雪兔髮型-D"] = 4;
        SPowerLookup["夢幻鑄造者髮型-D"] = 4;
        SPowerLookup["叛胖虎髮型-D"] = 4;
        SPowerLookup["黑鳳凰頭盔-D"] = 4;
         
        SPowerLookup["牛奶仔髮型-D"] = 4;
        SPowerLookup["闇影龍騎士頭盔-D"] = 4;
        SPowerLookup["霜雪龍騎士頭盔-D"] = 4;
        SPowerLookup["赤焰龍騎士頭盔-D"] = 4;
        SPowerLookup["榮譽騎士髮型-D"] = 4;
        //Page 3
        SPowerLookup["吱吱鼠髮型-D"] = 4;
        SPowerLookup["豬太郎髮型-D"] = 4;
        SPowerLookup["夜煞黑燐之厄運 ‧ 壞滅"] = 4;
        SPowerLookup["路西法的墮落-D"] = 4;
        SPowerLookup["汪汪狗髮型-D"] = 4;
         
        SPowerLookup["跍跍雞髮型-D"] = 4;
        SPowerLookup["頑皮猴髮型-D"] = 4;
        SPowerLookup["優雅青燐髮型-D"] = 4;
        SPowerLookup["宙斯髮型-D"] = 4;
        SPowerLookup["雅典娜髮型-D"] = 4;
         
        SPowerLookup["秀麗紅燐髮型-D"] = 4;
        SPowerLookup["赫密斯髮型-D"] = 4;
        SPowerLookup["青春歲月校服髮型S-D"] = 4;
        SPowerLookup["阿芙蘿黛蒂髮型-D"] = 4;
        SPowerLookup["甜蜜約會髮型S"] = 4;
         
        SPowerLookup["阿瑞斯髮型-D"] = 4;
        SPowerLookup["赫拉的髮型-D"] = 4;
        SPowerLookup["星空奇夢髮型-D"] = 4;
        SPowerLookup["赫淮斯托斯髮型-D"] = 4;
        SPowerLookup["翱翔機師髮型S-D"] = 4;
         
        SPowerLookup["查理的辮子髮型-D"] = 4;
        SPowerLookup["阿提密斯髮型-D"] = 4;
        SPowerLookup["夢幻魔利師髮型-D"] = 4;
        SPowerLookup["帝奧尼索斯髮型-D"] = 4;
        SPowerLookup["皇窒主僕髮型-D"] = 4;
         
        SPowerLookup["波塞頓髮型-D"] = 4;
        SPowerLookup["五星童話主廚髮型-D"] = 4;
        SPowerLookup["狄密特髮型-D"] = 4;
        SPowerLookup["莉莉的命運髮型"] = 4;
        SPowerLookup["阿波羅髮型-D"] = 4;
        //Page 4
        SPowerLookup["夢想雨衣髮型-D"] = 4;
        SPowerLookup["華麗婚禮髮型-D"] = 4;
        SPowerLookup["狂野高中生髮型-D"] = 4;
        SPowerLookup["天御聖守 ‧ 訣"] = 4;
        SPowerLookup["麒麟的神豔 ‧ 神蹟"] = 4;
         
        SPowerLookup["聖亳王之怒 ‧ 終焉"] = 4;
        SPowerLookup["玄武之靈羽 ‧ 神威"] = 4;
        SPowerLookup["極光髮型"] = 4;
        SPowerLookup["朱雀之髮冠 ‧ 究極"] = 4;
        SPowerLookup["白虎之牙 ‧ 真打"] = 4;
         
        SPowerLookup["青龍的風聲 ‧ 極-D"] = 4;
        SPowerLookup["冰封精靈髮型"] = 4;
        SPowerLookup["星之碎片魔法髮型"] = 4;
    }

    void S_Control()
    {
        //Page 1
        SControlLookup["百鬼夜行髮型-D"] = 4;
        SControlLookup["白魔法髮型-D"] = 4;
        SControlLookup["黑魔法髮型-D"] = 4;
        SControlLookup["黑白天鵝髮型-D"] = 4;
        SControlLookup["遠航探險家髮型-D"] = 4;
         
        SControlLookup["閃耀星空髮型-D"] = 4;
        SControlLookup["失憶患者髮型-D"] = 4;
        SControlLookup["惡夢醫生髮型-D"] = 4;
        SControlLookup["夏日校服髮型-D"] = 4;
        SControlLookup["柏勒洛豐髮型-D"] = 4;
         
        SControlLookup["中華旗袍髮型(男)-D"] = 4;
        SControlLookup["中華旗袍髮型(女)-D"] = 4;
        SControlLookup["勝利女神髮型-D"] = 4;
        SControlLookup["懶人髮型-D"] = 4;
        SControlLookup["菁英髮型-D"] = 4;
         
        SControlLookup["愚者髮型-D"] = 4;
        SControlLookup["灰姑娘髮型-D"] = 4;
        SControlLookup["野獸之王髮型-D"] = 4;
        SControlLookup["九尾狐影月髮型-D"] = 4;
        SControlLookup["九尾狐陽焰髮型-D"] = 4;
         
        SControlLookup["白雪公主髮型-D"] = 4;
        SControlLookup["惡魔貴族髮型"] = 4;
        SControlLookup["天使貴族髮型"] = 4;
        SControlLookup["垂鐘花髮型-D"] = 4;
        SControlLookup["茉莉髮型-D"] = 4;
         
        SControlLookup["玫瑰妖精髮型-D"] = 4;
        SControlLookup["鈴蘭髮型-D"] = 4;
        SControlLookup["白衣患者髮型-D"] = 4;
        SControlLookup["惡夢博士髮型-D"] = 4;
        SControlLookup["夢幻髮型-D"] = 4;
        //Page 2
        SControlLookup["茶花髮型-D"] = 4;
        SControlLookup["雛菊髮型-D"] = 4;
        SControlLookup["勿忘草髮型-D"] = 4;
        SControlLookup["玫瑰騎士髮型-D"] = 4;
        SControlLookup["雪狼髮型-D"] = 4;
         
        SControlLookup["水仙髮型-D"] = 4;
        SControlLookup["安圖莎的髮型-D"] = 4;
        SControlLookup["棉花髮型-D"] = 4;
        SControlLookup["塔羅小丑的散漫-D"] = 4;
        SControlLookup["翠菊髮型-D"] = 4;
         
        SControlLookup["海芋髮型-D"] = 4;
        SControlLookup["龍膽髮型-D"] = 4;
        SControlLookup["魔法艾洛髮型-D"] = 4;
        SControlLookup["向日葵髮型-D"] = 4;
        SControlLookup["幽藍天鵝髮型-D"] = 4;
         
        SControlLookup["安德烈的魅力髮型-D"] = 4;
        SControlLookup["羊咩咩髮型-D"] = 4;
        SControlLookup["馬拉高髮型-D"] = 4;
        SControlLookup["蛇寶寶髮型-D"] = 4;
        SControlLookup["小龍兒髮型-D"] = 4;
         
        SControlLookup["純潔白燐髮型-D"] = 4;
        SControlLookup["小雪兔髮型-D"] = 4;
        SControlLookup["夢幻鑄造者髮型-D"] = 4;
        SControlLookup["叛胖虎髮型-D"] = 4;
        SControlLookup["黑鳳凰頭盔-D"] = 4;
         
        SControlLookup["牛奶仔髮型-D"] = 4;
        SControlLookup["闇影龍騎士頭盔-D"] = 4;
        SControlLookup["霜雪龍騎士頭盔-D"] = 4;
        SControlLookup["赤焰龍騎士頭盔-D"] = 4;
        SControlLookup["榮譽騎士髮型-D"] = 4;
        //Page 3
        SControlLookup["吱吱鼠髮型-D"] = 4;
        SControlLookup["豬太郎髮型-D"] = 4;
        SControlLookup["夜煞黑燐之厄運 ‧ 壞滅"] = 4;
        SControlLookup["路西法的墮落-D"] = 4;
        SControlLookup["汪汪狗髮型-D"] = 4;
         
        SControlLookup["跍跍雞髮型-D"] = 4;
        SControlLookup["頑皮猴髮型-D"] = 4;
        SControlLookup["優雅青燐髮型-D"] = 4;
        SControlLookup["宙斯髮型-D"] = 4;
        SControlLookup["雅典娜髮型-D"] = 4;
         
        SControlLookup["秀麗紅燐髮型-D"] = 4;
        SControlLookup["赫密斯髮型-D"] = 4;
        SControlLookup["青春歲月校服髮型S-D"] = 4;
        SControlLookup["阿芙蘿黛蒂髮型-D"] = 4;
        SControlLookup["甜蜜約會髮型S"] = 4;
         
        SControlLookup["阿瑞斯髮型-D"] = 4;
        SControlLookup["赫拉的髮型-D"] = 4;
        SControlLookup["星空奇夢髮型-D"] = 4;
        SControlLookup["赫淮斯托斯髮型-D"] = 4;
        SControlLookup["翱翔機師髮型S-D"] = 4;
         
        SControlLookup["查理的辮子髮型-D"] = 4;
        SControlLookup["阿提密斯髮型-D"] = 4;
        SControlLookup["夢幻魔利師髮型-D"] = 4;
        SControlLookup["帝奧尼索斯髮型-D"] = 4;
        SControlLookup["皇窒主僕髮型-D"] = 4;
         
        SControlLookup["波塞頓髮型-D"] = 4;
        SControlLookup["五星童話主廚髮型-D"] = 4;
        SControlLookup["狄密特髮型-D"] = 4;
        SControlLookup["莉莉的命運髮型"] = 4;
        SControlLookup["阿波羅髮型-D"] = 4;
        //Page 4
        SControlLookup["夢想雨衣髮型-D"] = 4;
        SControlLookup["華麗婚禮髮型-D"] = 4;
        SControlLookup["狂野高中生髮型-D"] = 4;
        SControlLookup["天御聖守 ‧ 訣"] = 4;
        SControlLookup["麒麟的神豔 ‧ 神蹟"] = 4;
         
        SControlLookup["聖亳王之怒 ‧ 終焉"] = 4;
        SControlLookup["玄武之靈羽 ‧ 神威"] = 4;
        SControlLookup["極光髮型"] = 4;
        SControlLookup["朱雀之髮冠 ‧ 究極"] = 4;
        SControlLookup["白虎之牙 ‧ 真打"] = 4;
         
        SControlLookup["青龍的風聲 ‧ 極-D"] = 4;
        SControlLookup["冰封精靈髮型"] = 4;
        SControlLookup["星之碎片魔法髮型"] = 4;
    }

    void S_RageDuration()
    {
        //Page 1
        SRageDurationLookup["百鬼夜行髮型-D"] = 4;
        SRageDurationLookup["白魔法髮型-D"] = 4;
        SRageDurationLookup["黑魔法髮型-D"] = 4;
        SRageDurationLookup["黑白天鵝髮型-D"] = 4;
        SRageDurationLookup["遠航探險家髮型-D"] = 4;
         
        SRageDurationLookup["閃耀星空髮型-D"] = 4;
        SRageDurationLookup["失憶患者髮型-D"] = 4;
        SRageDurationLookup["惡夢醫生髮型-D"] = 4;
        SRageDurationLookup["夏日校服髮型-D"] = 4;
        SRageDurationLookup["柏勒洛豐髮型-D"] = 4;
         
        SRageDurationLookup["中華旗袍髮型(男)-D"] = 4;
        SRageDurationLookup["中華旗袍髮型(女)-D"] = 4;
        SRageDurationLookup["勝利女神髮型-D"] = 4;
        SRageDurationLookup["懶人髮型-D"] = 4;
        SRageDurationLookup["菁英髮型-D"] = 4;
         
        SRageDurationLookup["愚者髮型-D"] = 4;
        SRageDurationLookup["灰姑娘髮型-D"] = 4;
        SRageDurationLookup["野獸之王髮型-D"] = 4;
        SRageDurationLookup["九尾狐影月髮型-D"] = 4;
        SRageDurationLookup["九尾狐陽焰髮型-D"] = 4;
         
        SRageDurationLookup["白雪公主髮型-D"] = 4;
        SRageDurationLookup["惡魔貴族髮型"] = 4;
        SRageDurationLookup["天使貴族髮型"] = 4;
        SRageDurationLookup["垂鐘花髮型-D"] = 4;
        SRageDurationLookup["茉莉髮型-D"] = 4;
         
        SRageDurationLookup["玫瑰妖精髮型-D"] = 4;
        SRageDurationLookup["鈴蘭髮型-D"] = 4;
        SRageDurationLookup["白衣患者髮型-D"] = 4;
        SRageDurationLookup["惡夢博士髮型-D"] = 4;
        SRageDurationLookup["夢幻髮型-D"] = 4;
        //Page 2
        SRageDurationLookup["茶花髮型-D"] = 4;
        SRageDurationLookup["雛菊髮型-D"] = 4;
        SRageDurationLookup["勿忘草髮型-D"] = 4;
        SRageDurationLookup["玫瑰騎士髮型-D"] = 4;
        SRageDurationLookup["雪狼髮型-D"] = 4;
         
        SRageDurationLookup["水仙髮型-D"] = 4;
        SRageDurationLookup["安圖莎的髮型-D"] = 4;
        SRageDurationLookup["棉花髮型-D"] = 4;
        SRageDurationLookup["塔羅小丑的散漫-D"] = 4;
        SRageDurationLookup["翠菊髮型-D"] = 4;
         
        SRageDurationLookup["海芋髮型-D"] = 4;
        SRageDurationLookup["龍膽髮型-D"] = 4;
        SRageDurationLookup["魔法艾洛髮型-D"] = 4;
        SRageDurationLookup["向日葵髮型-D"] = 4;
        SRageDurationLookup["幽藍天鵝髮型-D"] = 4;
         
        SRageDurationLookup["安德烈的魅力髮型-D"] = 4;
        SRageDurationLookup["羊咩咩髮型-D"] = 4;
        SRageDurationLookup["馬拉高髮型-D"] = 4;
        SRageDurationLookup["蛇寶寶髮型-D"] = 4;
        SRageDurationLookup["小龍兒髮型-D"] = 4;
         
        SRageDurationLookup["純潔白燐髮型-D"] = 4;
        SRageDurationLookup["小雪兔髮型-D"] = 4;
        SRageDurationLookup["夢幻鑄造者髮型-D"] = 4;
        SRageDurationLookup["叛胖虎髮型-D"] = 4;
        SRageDurationLookup["黑鳳凰頭盔-D"] = 4;
         
        SRageDurationLookup["牛奶仔髮型-D"] = 4;
        SRageDurationLookup["闇影龍騎士頭盔-D"] = 4;
        SRageDurationLookup["霜雪龍騎士頭盔-D"] = 4;
        SRageDurationLookup["赤焰龍騎士頭盔-D"] = 4;
        SRageDurationLookup["榮譽騎士髮型-D"] = 4;
        //Page 3
        SRageDurationLookup["吱吱鼠髮型-D"] = 4;
        SRageDurationLookup["豬太郎髮型-D"] = 4;
        SRageDurationLookup["夜煞黑燐之厄運 ‧ 壞滅"] = 4;
        SRageDurationLookup["路西法的墮落-D"] = 4;
        SRageDurationLookup["汪汪狗髮型-D"] = 4;
         
        SRageDurationLookup["跍跍雞髮型-D"] = 4;
        SRageDurationLookup["頑皮猴髮型-D"] = 4;
        SRageDurationLookup["優雅青燐髮型-D"] = 4;
        SRageDurationLookup["宙斯髮型-D"] = 4;
        SRageDurationLookup["雅典娜髮型-D"] = 4;
         
        SRageDurationLookup["秀麗紅燐髮型-D"] = 4;
        SRageDurationLookup["赫密斯髮型-D"] = 4;
        SRageDurationLookup["青春歲月校服髮型S-D"] = 4;
        SRageDurationLookup["阿芙蘿黛蒂髮型-D"] = 4;
        SRageDurationLookup["甜蜜約會髮型S"] = 4;
         
        SRageDurationLookup["阿瑞斯髮型-D"] = 4;
        SRageDurationLookup["赫拉的髮型-D"] = 4;
        SRageDurationLookup["星空奇夢髮型-D"] = 4;
        SRageDurationLookup["赫淮斯托斯髮型-D"] = 4;
        SRageDurationLookup["翱翔機師髮型S-D"] = 4;
         
        SRageDurationLookup["查理的辮子髮型-D"] = 4;
        SRageDurationLookup["阿提密斯髮型-D"] = 4;
        SRageDurationLookup["夢幻魔利師髮型-D"] = 4;
        SRageDurationLookup["帝奧尼索斯髮型-D"] = 4;
        SRageDurationLookup["皇窒主僕髮型-D"] = 4;
         
        SRageDurationLookup["波塞頓髮型-D"] = 4;
        SRageDurationLookup["五星童話主廚髮型-D"] = 4;
        SRageDurationLookup["狄密特髮型-D"] = 4;
        SRageDurationLookup["莉莉的命運髮型"] = 4;
        SRageDurationLookup["阿波羅髮型-D"] = 4;
        //Page 4
        SRageDurationLookup["夢想雨衣髮型-D"] = 4;
        SRageDurationLookup["華麗婚禮髮型-D"] = 4;
        SRageDurationLookup["狂野高中生髮型-D"] = 4;
        SRageDurationLookup["天御聖守 ‧ 訣"] = 4;
        SRageDurationLookup["麒麟的神豔 ‧ 神蹟"] = 4;
         
        SRageDurationLookup["聖亳王之怒 ‧ 終焉"] = 4;
        SRageDurationLookup["玄武之靈羽 ‧ 神威"] = 4;
        SRageDurationLookup["極光髮型"] = 4;
        SRageDurationLookup["朱雀之髮冠 ‧ 究極"] = 4;
        SRageDurationLookup["白虎之牙 ‧ 真打"] = 4;
         
        SRageDurationLookup["青龍的風聲 ‧ 極-D"] = 4;
        SRageDurationLookup["冰封精靈髮型"] = 4;
        SRageDurationLookup["星之碎片魔法髮型"] = 4;
    }

    void S_RageCharge()
    {
        //Page 1
        SRageDurationLookup["百鬼夜行髮型-D"] = 4;
        SRageDurationLookup["白魔法髮型-D"] = 4;
        SRageDurationLookup["黑魔法髮型-D"] = 4;
        SRageDurationLookup["黑白天鵝髮型-D"] = 4;
        SRageDurationLookup["遠航探險家髮型-D"] = 4;
         
        SRageDurationLookup["閃耀星空髮型-D"] = 4;
        SRageDurationLookup["失憶患者髮型-D"] = 4;
        SRageDurationLookup["惡夢醫生髮型-D"] = 4;
        SRageDurationLookup["夏日校服髮型-D"] = 4;
        SRageDurationLookup["柏勒洛豐髮型-D"] = 4;
         
        SRageDurationLookup["中華旗袍髮型(男)-D"] = 4;
        SRageDurationLookup["中華旗袍髮型(女)-D"] = 4;
        SRageDurationLookup["勝利女神髮型-D"] = 4;
        SRageDurationLookup["懶人髮型-D"] = 4;
        SRageDurationLookup["菁英髮型-D"] = 4;
         
        SRageDurationLookup["愚者髮型-D"] = 4;
        SRageDurationLookup["灰姑娘髮型-D"] = 4;
        SRageDurationLookup["野獸之王髮型-D"] = 4;
        SRageDurationLookup["九尾狐影月髮型-D"] = 4;
        SRageDurationLookup["九尾狐陽焰髮型-D"] = 4;
         
        SRageDurationLookup["白雪公主髮型-D"] = 4;
        SRageDurationLookup["惡魔貴族髮型"] = 4;
        SRageDurationLookup["天使貴族髮型"] = 4;
        SRageDurationLookup["垂鐘花髮型-D"] = 4;
        SRageDurationLookup["茉莉髮型-D"] = 4;
         
        SRageDurationLookup["玫瑰妖精髮型-D"] = 4;
        SRageDurationLookup["鈴蘭髮型-D"] = 4;
        SRageDurationLookup["白衣患者髮型-D"] = 4;
        SRageDurationLookup["惡夢博士髮型-D"] = 4;
        SRageDurationLookup["夢幻髮型-D"] = 4;
        //Page 2
        SRageDurationLookup["茶花髮型-D"] = 4;
        SRageDurationLookup["雛菊髮型-D"] = 4;
        SRageDurationLookup["勿忘草髮型-D"] = 4;
        SRageDurationLookup["玫瑰騎士髮型-D"] = 4;
        SRageDurationLookup["雪狼髮型-D"] = 4;
         
        SRageDurationLookup["水仙髮型-D"] = 4;
        SRageDurationLookup["安圖莎的髮型-D"] = 4;
        SRageDurationLookup["棉花髮型-D"] = 4;
        SRageDurationLookup["塔羅小丑的散漫-D"] = 4;
        SRageDurationLookup["翠菊髮型-D"] = 4;
         
        SRageDurationLookup["海芋髮型-D"] = 4;
        SRageDurationLookup["龍膽髮型-D"] = 4;
        SRageDurationLookup["魔法艾洛髮型-D"] = 4;
        SRageDurationLookup["向日葵髮型-D"] = 4;
        SRageDurationLookup["幽藍天鵝髮型-D"] = 4;
         
        SRageDurationLookup["安德烈的魅力髮型-D"] = 4;
        SRageDurationLookup["羊咩咩髮型-D"] = 4;
        SRageDurationLookup["馬拉高髮型-D"] = 4;
        SRageDurationLookup["蛇寶寶髮型-D"] = 4;
        SRageDurationLookup["小龍兒髮型-D"] = 4;
         
        SRageDurationLookup["純潔白燐髮型-D"] = 4;
        SRageDurationLookup["小雪兔髮型-D"] = 4;
        SRageDurationLookup["夢幻鑄造者髮型-D"] = 4;
        SRageDurationLookup["叛胖虎髮型-D"] = 4;
        SRageDurationLookup["黑鳳凰頭盔-D"] = 4;
         
        SRageDurationLookup["牛奶仔髮型-D"] = 4;
        SRageDurationLookup["闇影龍騎士頭盔-D"] = 4;
        SRageDurationLookup["霜雪龍騎士頭盔-D"] = 4;
        SRageDurationLookup["赤焰龍騎士頭盔-D"] = 4;
        SRageDurationLookup["榮譽騎士髮型-D"] = 4;
        //Page 3
        SRageDurationLookup["吱吱鼠髮型-D"] = 4;
        SRageDurationLookup["豬太郎髮型-D"] = 4;
        SRageDurationLookup["夜煞黑燐之厄運 ‧ 壞滅"] = 4;
        SRageDurationLookup["路西法的墮落-D"] = 4;
        SRageDurationLookup["汪汪狗髮型-D"] = 4;
         
        SRageDurationLookup["跍跍雞髮型-D"] = 4;
        SRageDurationLookup["頑皮猴髮型-D"] = 4;
        SRageDurationLookup["優雅青燐髮型-D"] = 4;
        SRageDurationLookup["宙斯髮型-D"] = 4;
        SRageDurationLookup["雅典娜髮型-D"] = 4;
         
        SRageDurationLookup["秀麗紅燐髮型-D"] = 4;
        SRageDurationLookup["赫密斯髮型-D"] = 4;
        SRageDurationLookup["青春歲月校服髮型S-D"] = 4;
        SRageDurationLookup["阿芙蘿黛蒂髮型-D"] = 4;
        SRageDurationLookup["甜蜜約會髮型S"] = 4;
         
        SRageDurationLookup["阿瑞斯髮型-D"] = 4;
        SRageDurationLookup["赫拉的髮型-D"] = 4;
        SRageDurationLookup["星空奇夢髮型-D"] = 4;
        SRageDurationLookup["赫淮斯托斯髮型-D"] = 4;
        SRageDurationLookup["翱翔機師髮型S-D"] = 4;
         
        SRageDurationLookup["查理的辮子髮型-D"] = 4;
        SRageDurationLookup["阿提密斯髮型-D"] = 4;
        SRageDurationLookup["夢幻魔利師髮型-D"] = 4;
        SRageDurationLookup["帝奧尼索斯髮型-D"] = 4;
        SRageDurationLookup["皇窒主僕髮型-D"] = 4;
         
        SRageDurationLookup["波塞頓髮型-D"] = 4;
        SRageDurationLookup["五星童話主廚髮型-D"] = 4;
        SRageDurationLookup["狄密特髮型-D"] = 4;
        SRageDurationLookup["莉莉的命運髮型"] = 4;
        SRageDurationLookup["阿波羅髮型-D"] = 4;
        //Page 4
        SRageDurationLookup["夢想雨衣髮型-D"] = 4;
        SRageDurationLookup["華麗婚禮髮型-D"] = 4;
        SRageDurationLookup["狂野高中生髮型-D"] = 4;
        SRageDurationLookup["天御聖守 ‧ 訣"] = 4;
        SRageDurationLookup["麒麟的神豔 ‧ 神蹟"] = 4;
         
        SRageDurationLookup["聖亳王之怒 ‧ 終焉"] = 4;
        SRageDurationLookup["玄武之靈羽 ‧ 神威"] = 4;
        SRageDurationLookup["極光髮型"] = 4;
        SRageDurationLookup["朱雀之髮冠 ‧ 究極"] = 4;
        SRageDurationLookup["白虎之牙 ‧ 真打"] = 4;
         
        SRageDurationLookup["青龍的風聲 ‧ 極-D"] = 4;
        SRageDurationLookup["冰封精靈髮型"] = 4;
        SRageDurationLookup["星之碎片魔法髮型"] = 4;
    }

    void S_MaxEnergy()
    {
        //Page 1
        SRageDurationLookup["百鬼夜行髮型-D"] = 4;
        SRageDurationLookup["白魔法髮型-D"] = 4;
        SRageDurationLookup["黑魔法髮型-D"] = 4;
        SRageDurationLookup["黑白天鵝髮型-D"] = 4;
        SRageDurationLookup["遠航探險家髮型-D"] = 4;
         
        SRageDurationLookup["閃耀星空髮型-D"] = 4;
        SRageDurationLookup["失憶患者髮型-D"] = 4;
        SRageDurationLookup["惡夢醫生髮型-D"] = 4;
        SRageDurationLookup["夏日校服髮型-D"] = 4;
        SRageDurationLookup["柏勒洛豐髮型-D"] = 4;
         
        SRageDurationLookup["中華旗袍髮型(男)-D"] = 4;
        SRageDurationLookup["中華旗袍髮型(女)-D"] = 4;
        SRageDurationLookup["勝利女神髮型-D"] = 4;
        SRageDurationLookup["懶人髮型-D"] = 4;
        SRageDurationLookup["菁英髮型-D"] = 4;
         
        SRageDurationLookup["愚者髮型-D"] = 4;
        SRageDurationLookup["灰姑娘髮型-D"] = 4;
        SRageDurationLookup["野獸之王髮型-D"] = 4;
        SRageDurationLookup["九尾狐影月髮型-D"] = 4;
        SRageDurationLookup["九尾狐陽焰髮型-D"] = 4;
         
        SRageDurationLookup["白雪公主髮型-D"] = 4;
        SRageDurationLookup["惡魔貴族髮型"] = 4;
        SRageDurationLookup["天使貴族髮型"] = 4;
        SRageDurationLookup["垂鐘花髮型-D"] = 4;
        SRageDurationLookup["茉莉髮型-D"] = 4;
         
        SRageDurationLookup["玫瑰妖精髮型-D"] = 4;
        SRageDurationLookup["鈴蘭髮型-D"] = 4;
        SRageDurationLookup["白衣患者髮型-D"] = 4;
        SRageDurationLookup["惡夢博士髮型-D"] = 4;
        SRageDurationLookup["夢幻髮型-D"] = 4;
        //Page 2
        SRageDurationLookup["茶花髮型-D"] = 4;
        SRageDurationLookup["雛菊髮型-D"] = 4;
        SRageDurationLookup["勿忘草髮型-D"] = 4;
        SRageDurationLookup["玫瑰騎士髮型-D"] = 4;
        SRageDurationLookup["雪狼髮型-D"] = 4;
         
        SRageDurationLookup["水仙髮型-D"] = 4;
        SRageDurationLookup["安圖莎的髮型-D"] = 4;
        SRageDurationLookup["棉花髮型-D"] = 4;
        SRageDurationLookup["塔羅小丑的散漫-D"] = 4;
        SRageDurationLookup["翠菊髮型-D"] = 4;
         
        SRageDurationLookup["海芋髮型-D"] = 4;
        SRageDurationLookup["龍膽髮型-D"] = 4;
        SRageDurationLookup["魔法艾洛髮型-D"] = 4;
        SRageDurationLookup["向日葵髮型-D"] = 4;
        SRageDurationLookup["幽藍天鵝髮型-D"] = 4;
         
        SRageDurationLookup["安德烈的魅力髮型-D"] = 4;
        SRageDurationLookup["羊咩咩髮型-D"] = 4;
        SRageDurationLookup["馬拉高髮型-D"] = 4;
        SRageDurationLookup["蛇寶寶髮型-D"] = 4;
        SRageDurationLookup["小龍兒髮型-D"] = 4;
         
        SRageDurationLookup["純潔白燐髮型-D"] = 4;
        SRageDurationLookup["小雪兔髮型-D"] = 4;
        SRageDurationLookup["夢幻鑄造者髮型-D"] = 4;
        SRageDurationLookup["叛胖虎髮型-D"] = 4;
        SRageDurationLookup["黑鳳凰頭盔-D"] = 4;
         
        SRageDurationLookup["牛奶仔髮型-D"] = 4;
        SRageDurationLookup["闇影龍騎士頭盔-D"] = 4;
        SRageDurationLookup["霜雪龍騎士頭盔-D"] = 4;
        SRageDurationLookup["赤焰龍騎士頭盔-D"] = 4;
        SRageDurationLookup["榮譽騎士髮型-D"] = 4;
        //Page 3
        SRageDurationLookup["吱吱鼠髮型-D"] = 4;
        SRageDurationLookup["豬太郎髮型-D"] = 4;
        SRageDurationLookup["夜煞黑燐之厄運 ‧ 壞滅"] = 4;
        SRageDurationLookup["路西法的墮落-D"] = 4;
        SRageDurationLookup["汪汪狗髮型-D"] = 4;
         
        SRageDurationLookup["跍跍雞髮型-D"] = 4;
        SRageDurationLookup["頑皮猴髮型-D"] = 4;
        SRageDurationLookup["優雅青燐髮型-D"] = 4;
        SRageDurationLookup["宙斯髮型-D"] = 4;
        SRageDurationLookup["雅典娜髮型-D"] = 4;
         
        SRageDurationLookup["秀麗紅燐髮型-D"] = 4;
        SRageDurationLookup["赫密斯髮型-D"] = 4;
        SRageDurationLookup["青春歲月校服髮型S-D"] = 4;
        SRageDurationLookup["阿芙蘿黛蒂髮型-D"] = 4;
        SRageDurationLookup["甜蜜約會髮型S"] = 4;
         
        SRageDurationLookup["阿瑞斯髮型-D"] = 4;
        SRageDurationLookup["赫拉的髮型-D"] = 4;
        SRageDurationLookup["星空奇夢髮型-D"] = 4;
        SRageDurationLookup["赫淮斯托斯髮型-D"] = 4;
        SRageDurationLookup["翱翔機師髮型S-D"] = 4;
         
        SRageDurationLookup["查理的辮子髮型-D"] = 4;
        SRageDurationLookup["阿提密斯髮型-D"] = 4;
        SRageDurationLookup["夢幻魔利師髮型-D"] = 4;
        SRageDurationLookup["帝奧尼索斯髮型-D"] = 4;
        SRageDurationLookup["皇窒主僕髮型-D"] = 4;
         
        SRageDurationLookup["波塞頓髮型-D"] = 4;
        SRageDurationLookup["五星童話主廚髮型-D"] = 4;
        SRageDurationLookup["狄密特髮型-D"] = 4;
        SRageDurationLookup["莉莉的命運髮型"] = 4;
        SRageDurationLookup["阿波羅髮型-D"] = 4;
        //Page 4
        SRageDurationLookup["夢想雨衣髮型-D"] = 4;
        SRageDurationLookup["華麗婚禮髮型-D"] = 4;
        SRageDurationLookup["狂野高中生髮型-D"] = 4;
        SRageDurationLookup["天御聖守 ‧ 訣"] = 4;
        SRageDurationLookup["麒麟的神豔 ‧ 神蹟"] = 4;
         
        SRageDurationLookup["聖亳王之怒 ‧ 終焉"] = 4;
        SRageDurationLookup["玄武之靈羽 ‧ 神威"] = 4;
        SRageDurationLookup["極光髮型"] = 4;
        SRageDurationLookup["朱雀之髮冠 ‧ 究極"] = 4;
        SRageDurationLookup["白虎之牙 ‧ 真打"] = 4;
         
        SRageDurationLookup["青龍的風聲 ‧ 極-D"] = 4;
        SRageDurationLookup["冰封精靈髮型"] = 4;
        SRageDurationLookup["星之碎片魔法髮型"] = 4;
    }

    void S_MaxSprint()
    {
        //Page 1
        SMaxSprintLookup["百鬼夜行髮型-D"] = 4;
        SMaxSprintLookup["白魔法髮型-D"] = 4;
        SMaxSprintLookup["黑魔法髮型-D"] = 4;
        SMaxSprintLookup["黑白天鵝髮型-D"] = 4;
        SMaxSprintLookup["遠航探險家髮型-D"] = 4;
         
        SMaxSprintLookup["閃耀星空髮型-D"] = 4;
        SMaxSprintLookup["失憶患者髮型-D"] = 4;
        SMaxSprintLookup["惡夢醫生髮型-D"] = 4;
        SMaxSprintLookup["夏日校服髮型-D"] = 4;
        SMaxSprintLookup["柏勒洛豐髮型-D"] = 4;
         
        SMaxSprintLookup["中華旗袍髮型(男)-D"] = 4;
        SMaxSprintLookup["中華旗袍髮型(女)-D"] = 4;
        SMaxSprintLookup["勝利女神髮型-D"] = 4;
        SMaxSprintLookup["懶人髮型-D"] = 4;
        SMaxSprintLookup["菁英髮型-D"] = 4;
         
        SMaxSprintLookup["愚者髮型-D"] = 4;
        SMaxSprintLookup["灰姑娘髮型-D"] = 4;
        SMaxSprintLookup["野獸之王髮型-D"] = 4;
        SMaxSprintLookup["九尾狐影月髮型-D"] = 4;
        SMaxSprintLookup["九尾狐陽焰髮型-D"] = 4;
         
        SMaxSprintLookup["白雪公主髮型-D"] = 4;
        SMaxSprintLookup["惡魔貴族髮型"] = 4;
        SMaxSprintLookup["天使貴族髮型"] = 4;
        SMaxSprintLookup["垂鐘花髮型-D"] = 4;
        SMaxSprintLookup["茉莉髮型-D"] = 4;
         
        SMaxSprintLookup["玫瑰妖精髮型-D"] = 4;
        SMaxSprintLookup["鈴蘭髮型-D"] = 4;
        SMaxSprintLookup["白衣患者髮型-D"] = 4;
        SMaxSprintLookup["惡夢博士髮型-D"] = 4;
        SMaxSprintLookup["夢幻髮型-D"] = 4;
        //Page 2
        SMaxSprintLookup["茶花髮型-D"] = 4;
        SMaxSprintLookup["雛菊髮型-D"] = 4;
        SMaxSprintLookup["勿忘草髮型-D"] = 4;
        SMaxSprintLookup["玫瑰騎士髮型-D"] = 4;
        SMaxSprintLookup["雪狼髮型-D"] = 4;
         
        SMaxSprintLookup["水仙髮型-D"] = 4;
        SMaxSprintLookup["安圖莎的髮型-D"] = 4;
        SMaxSprintLookup["棉花髮型-D"] = 4;
        SMaxSprintLookup["塔羅小丑的散漫-D"] = 4;
        SMaxSprintLookup["翠菊髮型-D"] = 4;
         
        SMaxSprintLookup["海芋髮型-D"] = 4;
        SMaxSprintLookup["龍膽髮型-D"] = 4;
        SMaxSprintLookup["魔法艾洛髮型-D"] = 4;
        SMaxSprintLookup["向日葵髮型-D"] = 4;
        SMaxSprintLookup["幽藍天鵝髮型-D"] = 4;
         
        SMaxSprintLookup["安德烈的魅力髮型-D"] = 4;
        SMaxSprintLookup["羊咩咩髮型-D"] = 4;
        SMaxSprintLookup["馬拉高髮型-D"] = 4;
        SMaxSprintLookup["蛇寶寶髮型-D"] = 4;
        SMaxSprintLookup["小龍兒髮型-D"] = 4;
         
        SMaxSprintLookup["純潔白燐髮型-D"] = 4;
        SMaxSprintLookup["小雪兔髮型-D"] = 4;
        SMaxSprintLookup["夢幻鑄造者髮型-D"] = 4;
        SMaxSprintLookup["叛胖虎髮型-D"] = 4;
        SMaxSprintLookup["黑鳳凰頭盔-D"] = 4;
         
        SMaxSprintLookup["牛奶仔髮型-D"] = 4;
        SMaxSprintLookup["闇影龍騎士頭盔-D"] = 4;
        SMaxSprintLookup["霜雪龍騎士頭盔-D"] = 4;
        SMaxSprintLookup["赤焰龍騎士頭盔-D"] = 4;
        SMaxSprintLookup["榮譽騎士髮型-D"] = 4;
        //Page 3
        SMaxSprintLookup["吱吱鼠髮型-D"] = 4;
        SMaxSprintLookup["豬太郎髮型-D"] = 4;
        SMaxSprintLookup["夜煞黑燐之厄運 ‧ 壞滅"] = 4;
        SMaxSprintLookup["路西法的墮落-D"] = 4;
        SMaxSprintLookup["汪汪狗髮型-D"] = 4;
         
        SMaxSprintLookup["跍跍雞髮型-D"] = 4;
        SMaxSprintLookup["頑皮猴髮型-D"] = 4;
        SMaxSprintLookup["優雅青燐髮型-D"] = 4;
        SMaxSprintLookup["宙斯髮型-D"] = 4;
        SMaxSprintLookup["雅典娜髮型-D"] = 4;
         
        SMaxSprintLookup["秀麗紅燐髮型-D"] = 4;
        SMaxSprintLookup["赫密斯髮型-D"] = 4;
        SMaxSprintLookup["青春歲月校服髮型S-D"] = 4;
        SMaxSprintLookup["阿芙蘿黛蒂髮型-D"] = 4;
        SMaxSprintLookup["甜蜜約會髮型S"] = 4;
         
        SMaxSprintLookup["阿瑞斯髮型-D"] = 4;
        SMaxSprintLookup["赫拉的髮型-D"] = 4;
        SMaxSprintLookup["星空奇夢髮型-D"] = 4;
        SMaxSprintLookup["赫淮斯托斯髮型-D"] = 4;
        SMaxSprintLookup["翱翔機師髮型S-D"] = 4;
         
        SMaxSprintLookup["查理的辮子髮型-D"] = 4;
        SMaxSprintLookup["阿提密斯髮型-D"] = 4;
        SMaxSprintLookup["夢幻魔利師髮型-D"] = 4;
        SMaxSprintLookup["帝奧尼索斯髮型-D"] = 4;
        SMaxSprintLookup["皇窒主僕髮型-D"] = 4;
         
        SMaxSprintLookup["波塞頓髮型-D"] = 4;
        SMaxSprintLookup["五星童話主廚髮型-D"] = 4;
        SMaxSprintLookup["狄密特髮型-D"] = 4;
        SMaxSprintLookup["莉莉的命運髮型"] = 4;
        SMaxSprintLookup["阿波羅髮型-D"] = 4;
        //Page 4
        SMaxSprintLookup["夢想雨衣髮型-D"] = 4;
        SMaxSprintLookup["華麗婚禮髮型-D"] = 4;
        SMaxSprintLookup["狂野高中生髮型-D"] = 4;
        SMaxSprintLookup["天御聖守 ‧ 訣"] = 4;
        SMaxSprintLookup["麒麟的神豔 ‧ 神蹟"] = 4;
         
        SMaxSprintLookup["聖亳王之怒 ‧ 終焉"] = 4;
        SMaxSprintLookup["玄武之靈羽 ‧ 神威"] = 4;
        SMaxSprintLookup["極光髮型"] = 4;
        SMaxSprintLookup["朱雀之髮冠 ‧ 究極"] = 4;
        SMaxSprintLookup["白虎之牙 ‧ 真打"] = 4;
         
        SMaxSprintLookup["青龍的風聲 ‧ 極-D"] = 4;
        SMaxSprintLookup["冰封精靈髮型"] = 4;
        SMaxSprintLookup["星之碎片魔法髮型"] = 4;
    }

    void S_Force()
    {
        //Page 1
        SForceLookup["百鬼夜行髮型-D"] = 4;
        SForceLookup["白魔法髮型-D"] = 4;
        SForceLookup["黑魔法髮型-D"] = 4;
        SForceLookup["黑白天鵝髮型-D"] = 4;
        SForceLookup["遠航探險家髮型-D"] = 4;
         
        SForceLookup["閃耀星空髮型-D"] = 4;
        SForceLookup["失憶患者髮型-D"] = 4;
        SForceLookup["惡夢醫生髮型-D"] = 4;
        SForceLookup["夏日校服髮型-D"] = 4;
        SForceLookup["柏勒洛豐髮型-D"] = 4;
         
        SForceLookup["中華旗袍髮型(男)-D"] = 4;
        SForceLookup["中華旗袍髮型(女)-D"] = 4;
        SForceLookup["勝利女神髮型-D"] = 4;
        SForceLookup["懶人髮型-D"] = 4;
        SForceLookup["菁英髮型-D"] = 4;
         
        SForceLookup["愚者髮型-D"] = 4;
        SForceLookup["灰姑娘髮型-D"] = 4;
        SForceLookup["野獸之王髮型-D"] = 4;
        SForceLookup["九尾狐影月髮型-D"] = 4;
        SForceLookup["九尾狐陽焰髮型-D"] = 4;
         
        SForceLookup["白雪公主髮型-D"] = 4;
        SForceLookup["惡魔貴族髮型"] = 4;
        SForceLookup["天使貴族髮型"] = 4;
        SForceLookup["垂鐘花髮型-D"] = 4;
        SForceLookup["茉莉髮型-D"] = 4;
         
        SForceLookup["玫瑰妖精髮型-D"] = 4;
        SForceLookup["鈴蘭髮型-D"] = 4;
        SForceLookup["白衣患者髮型-D"] = 4;
        SForceLookup["惡夢博士髮型-D"] = 4;
        SForceLookup["夢幻髮型-D"] = 4;
        //Page 2
        SForceLookup["茶花髮型-D"] = 4;
        SForceLookup["雛菊髮型-D"] = 4;
        SForceLookup["勿忘草髮型-D"] = 4;
        SForceLookup["玫瑰騎士髮型-D"] = 4;
        SForceLookup["雪狼髮型-D"] = 4;
         
        SForceLookup["水仙髮型-D"] = 4;
        SForceLookup["安圖莎的髮型-D"] = 4;
        SForceLookup["棉花髮型-D"] = 4;
        SForceLookup["塔羅小丑的散漫-D"] = 4;
        SForceLookup["翠菊髮型-D"] = 4;
         
        SForceLookup["海芋髮型-D"] = 4;
        SForceLookup["龍膽髮型-D"] = 4;
        SForceLookup["魔法艾洛髮型-D"] = 4;
        SForceLookup["向日葵髮型-D"] = 4;
        SForceLookup["幽藍天鵝髮型-D"] = 4;
         
        SForceLookup["安德烈的魅力髮型-D"] = 4;
        SForceLookup["羊咩咩髮型-D"] = 4;
        SForceLookup["馬拉高髮型-D"] = 4;
        SForceLookup["蛇寶寶髮型-D"] = 4;
        SForceLookup["小龍兒髮型-D"] = 4;
         
        SForceLookup["純潔白燐髮型-D"] = 4;
        SForceLookup["小雪兔髮型-D"] = 4;
        SForceLookup["夢幻鑄造者髮型-D"] = 4;
        SForceLookup["叛胖虎髮型-D"] = 4;
        SForceLookup["黑鳳凰頭盔-D"] = 4;
         
        SForceLookup["牛奶仔髮型-D"] = 4;
        SForceLookup["闇影龍騎士頭盔-D"] = 4;
        SForceLookup["霜雪龍騎士頭盔-D"] = 4;
        SForceLookup["赤焰龍騎士頭盔-D"] = 4;
        SForceLookup["榮譽騎士髮型-D"] = 4;
        //Page 3
        SForceLookup["吱吱鼠髮型-D"] = 4;
        SForceLookup["豬太郎髮型-D"] = 4;
        SForceLookup["夜煞黑燐之厄運 ‧ 壞滅"] = 4;
        SForceLookup["路西法的墮落-D"] = 4;
        SForceLookup["汪汪狗髮型-D"] = 4;
         
        SForceLookup["跍跍雞髮型-D"] = 4;
        SForceLookup["頑皮猴髮型-D"] = 4;
        SForceLookup["優雅青燐髮型-D"] = 4;
        SForceLookup["宙斯髮型-D"] = 4;
        SForceLookup["雅典娜髮型-D"] = 4;
         
        SForceLookup["秀麗紅燐髮型-D"] = 4;
        SForceLookup["赫密斯髮型-D"] = 4;
        SForceLookup["青春歲月校服髮型S-D"] = 4;
        SForceLookup["阿芙蘿黛蒂髮型-D"] = 4;
        SForceLookup["甜蜜約會髮型S"] = 4;
         
        SForceLookup["阿瑞斯髮型-D"] = 4;
        SForceLookup["赫拉的髮型-D"] = 4;
        SForceLookup["星空奇夢髮型-D"] = 4;
        SForceLookup["赫淮斯托斯髮型-D"] = 4;
        SForceLookup["翱翔機師髮型S-D"] = 4;
         
        SForceLookup["查理的辮子髮型-D"] = 4;
        SForceLookup["阿提密斯髮型-D"] = 4;
        SForceLookup["夢幻魔利師髮型-D"] = 4;
        SForceLookup["帝奧尼索斯髮型-D"] = 4;
        SForceLookup["皇窒主僕髮型-D"] = 4;
         
        SForceLookup["波塞頓髮型-D"] = 4;
        SForceLookup["五星童話主廚髮型-D"] = 4;
        SForceLookup["狄密特髮型-D"] = 4;
        SForceLookup["莉莉的命運髮型"] = 4;
        SForceLookup["阿波羅髮型-D"] = 4;
        //Page 4
        SForceLookup["夢想雨衣髮型-D"] = 4;
        SForceLookup["華麗婚禮髮型-D"] = 4;
        SForceLookup["狂野高中生髮型-D"] = 4;
        SForceLookup["天御聖守 ‧ 訣"] = 4;
        SForceLookup["麒麟的神豔 ‧ 神蹟"] = 4;
         
        SForceLookup["聖亳王之怒 ‧ 終焉"] = 4;
        SForceLookup["玄武之靈羽 ‧ 神威"] = 4;
        SForceLookup["極光髮型"] = 4;
        SForceLookup["朱雀之髮冠 ‧ 究極"] = 4;
        SForceLookup["白虎之牙 ‧ 真打"] = 4;
         
        SForceLookup["青龍的風聲 ‧ 極-D"] = 4;
        SForceLookup["冰封精靈髮型"] = 4;
        SForceLookup["星之碎片魔法髮型"] = 4;
    }

    void S_Luck()
    {
        //Page 1
        SLuckLookup["百鬼夜行髮型-D"] = 4;
        SLuckLookup["白魔法髮型-D"] = 4;
        SLuckLookup["黑魔法髮型-D"] = 4;
        SLuckLookup["黑白天鵝髮型-D"] = 4;
        SLuckLookup["遠航探險家髮型-D"] = 4;
         
        SLuckLookup["閃耀星空髮型-D"] = 4;
        SLuckLookup["失憶患者髮型-D"] = 4;
        SLuckLookup["惡夢醫生髮型-D"] = 4;
        SLuckLookup["夏日校服髮型-D"] = 4;
        SLuckLookup["柏勒洛豐髮型-D"] = 4;
         
        SLuckLookup["中華旗袍髮型(男)-D"] = 4;
        SLuckLookup["中華旗袍髮型(女)-D"] = 4;
        SLuckLookup["勝利女神髮型-D"] = 4;
        SLuckLookup["懶人髮型-D"] = 4;
        SLuckLookup["菁英髮型-D"] = 4;
         
        SLuckLookup["愚者髮型-D"] = 4;
        SLuckLookup["灰姑娘髮型-D"] = 4;
        SLuckLookup["野獸之王髮型-D"] = 4;
        SLuckLookup["九尾狐影月髮型-D"] = 4;
        SLuckLookup["九尾狐陽焰髮型-D"] = 4;
         
        SLuckLookup["白雪公主髮型-D"] = 4;
        SLuckLookup["惡魔貴族髮型"] = 4;
        SLuckLookup["天使貴族髮型"] = 4;
        SLuckLookup["垂鐘花髮型-D"] = 4;
        SLuckLookup["茉莉髮型-D"] = 4;
         
        SLuckLookup["玫瑰妖精髮型-D"] = 4;
        SLuckLookup["鈴蘭髮型-D"] = 4;
        SLuckLookup["白衣患者髮型-D"] = 4;
        SLuckLookup["惡夢博士髮型-D"] = 4;
        SLuckLookup["夢幻髮型-D"] = 4;
        //Page 2
        SLuckLookup["茶花髮型-D"] = 4;
        SLuckLookup["雛菊髮型-D"] = 4;
        SLuckLookup["勿忘草髮型-D"] = 4;
        SLuckLookup["玫瑰騎士髮型-D"] = 4;
        SLuckLookup["雪狼髮型-D"] = 4;
         
        SLuckLookup["水仙髮型-D"] = 4;
        SLuckLookup["安圖莎的髮型-D"] = 4;
        SLuckLookup["棉花髮型-D"] = 4;
        SLuckLookup["塔羅小丑的散漫-D"] = 4;
        SLuckLookup["翠菊髮型-D"] = 4;
         
        SLuckLookup["海芋髮型-D"] = 4;
        SLuckLookup["龍膽髮型-D"] = 4;
        SLuckLookup["魔法艾洛髮型-D"] = 4;
        SLuckLookup["向日葵髮型-D"] = 4;
        SLuckLookup["幽藍天鵝髮型-D"] = 4;
         
        SLuckLookup["安德烈的魅力髮型-D"] = 4;
        SLuckLookup["羊咩咩髮型-D"] = 4;
        SLuckLookup["馬拉高髮型-D"] = 4;
        SLuckLookup["蛇寶寶髮型-D"] = 4;
        SLuckLookup["小龍兒髮型-D"] = 4;
         
        SLuckLookup["純潔白燐髮型-D"] = 4;
        SLuckLookup["小雪兔髮型-D"] = 4;
        SLuckLookup["夢幻鑄造者髮型-D"] = 4;
        SLuckLookup["叛胖虎髮型-D"] = 4;
        SLuckLookup["黑鳳凰頭盔-D"] = 4;
         
        SLuckLookup["牛奶仔髮型-D"] = 4;
        SLuckLookup["闇影龍騎士頭盔-D"] = 4;
        SLuckLookup["霜雪龍騎士頭盔-D"] = 4;
        SLuckLookup["赤焰龍騎士頭盔-D"] = 4;
        SLuckLookup["榮譽騎士髮型-D"] = 4;
        //Page 3
        SLuckLookup["吱吱鼠髮型-D"] = 4;
        SLuckLookup["豬太郎髮型-D"] = 4;
        SLuckLookup["夜煞黑燐之厄運 ‧ 壞滅"] = 4;
        SLuckLookup["路西法的墮落-D"] = 4;
        SLuckLookup["汪汪狗髮型-D"] = 4;
         
        SLuckLookup["跍跍雞髮型-D"] = 4;
        SLuckLookup["頑皮猴髮型-D"] = 4;
        SLuckLookup["優雅青燐髮型-D"] = 4;
        SLuckLookup["宙斯髮型-D"] = 4;
        SLuckLookup["雅典娜髮型-D"] = 4;
         
        SLuckLookup["秀麗紅燐髮型-D"] = 4;
        SLuckLookup["赫密斯髮型-D"] = 4;
        SLuckLookup["青春歲月校服髮型S-D"] = 4;
        SLuckLookup["阿芙蘿黛蒂髮型-D"] = 4;
        SLuckLookup["甜蜜約會髮型S"] = 4;
         
        SLuckLookup["阿瑞斯髮型-D"] = 4;
        SLuckLookup["赫拉的髮型-D"] = 4;
        SLuckLookup["星空奇夢髮型-D"] = 4;
        SLuckLookup["赫淮斯托斯髮型-D"] = 4;
        SLuckLookup["翱翔機師髮型S-D"] = 4;
         
        SLuckLookup["查理的辮子髮型-D"] = 4;
        SLuckLookup["阿提密斯髮型-D"] = 4;
        SLuckLookup["夢幻魔利師髮型-D"] = 4;
        SLuckLookup["帝奧尼索斯髮型-D"] = 4;
        SLuckLookup["皇窒主僕髮型-D"] = 4;
         
        SLuckLookup["波塞頓髮型-D"] = 4;
        SLuckLookup["五星童話主廚髮型-D"] = 4;
        SLuckLookup["狄密特髮型-D"] = 4;
        SLuckLookup["莉莉的命運髮型"] = 4;
        SLuckLookup["阿波羅髮型-D"] = 4;
        //Page 4
        SLuckLookup["夢想雨衣髮型-D"] = 4;
        SLuckLookup["華麗婚禮髮型-D"] = 4;
        SLuckLookup["狂野高中生髮型-D"] = 4;
        SLuckLookup["天御聖守 ‧ 訣"] = 4;
        SLuckLookup["麒麟的神豔 ‧ 神蹟"] = 4;
         
        SLuckLookup["聖亳王之怒 ‧ 終焉"] = 4;
        SLuckLookup["玄武之靈羽 ‧ 神威"] = 4;
        SLuckLookup["極光髮型"] = 4;
        SLuckLookup["朱雀之髮冠 ‧ 究極"] = 4;
        SLuckLookup["白虎之牙 ‧ 真打"] = 4;
         
        SLuckLookup["青龍的風聲 ‧ 極-D"] = 4;
        SLuckLookup["冰封精靈髮型"] = 4;
        SLuckLookup["星之碎片魔法髮型"] = 4;
    }

    void SS_Hair()
    {
        SS_Rarity();
        SS_Mode();
        SS_Speed();
        SS_Acceleration();
        SS_Power();
        SS_Control();
        SS_RageDuration();
        SS_RageCharge();
        SS_MaxEnergy();
        SS_MaxSprint();
        SS_Force();
        SS_Luck();
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
        SSModeLookup["璀璨的光芒髮型-D"] = true;
        SSModeLookup["皇家騎士髮型-D"] = false;
        SSModeLookup["不祥的暗黑髮型-D"] = true;
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
    #endregion SS_Hair Rage Duration

    #region SS_Hair Rage Charge
    void SS_RageCharge()
    {
        SSRageChargeLookup["梅賽德斯髮型-D"] = 10;
        SSRageChargeLookup["化裝舞會髮型"] = 10;
        SSRageChargeLookup["宮廷遠征使者髮型"] = 10;
        SSRageChargeLookup["暮色夢夜髮型(男)"] = 10;
        SSRageChargeLookup["暮色夢夜髮型(女)"] = 10;
              
        SSRageChargeLookup["日蝕髮型-D"] = 10;
        SSRageChargeLookup["黑金天使髮型-D"] = 10;
        SSRageChargeLookup["晨曦破曉髮型-D"] = 10;
        SSRageChargeLookup["夜幕降臨髮型-D"] = 10;
        SSRageChargeLookup["混沌大師髮型-D"] = 10;
              
        SSRageChargeLookup["挑戰者髮型-D"] = 10;
        SSRageChargeLookup["璀璨的光芒髮型-D"] = 0;
        SSRageChargeLookup["皇家騎士髮型-D"] = 10;
        SSRageChargeLookup["不祥的暗黑髮型-D"] = 0;
        SSRageChargeLookup["皇家護衛髮型(男)-D"] = 10;
              
        SSRageChargeLookup["皇家護衛髮型(女)-D"] = 10;
        SSRageChargeLookup["覺醒 ‧ 馭龍頭盔-D"] = 20;
        SSRageChargeLookup["克羅諾斯的髮型-D"] = 10;
        SSRageChargeLookup["極 ‧ 馭龍騎士頭盔-D"] = 20;
    }
    #endregion SS_Hair Rage Charge

    #region SS_Hair Max Energy
    void SS_MaxEnergy()
    {
        SSMaxEnergyLookup["梅賽德斯髮型-D"] = 0;
        SSMaxEnergyLookup["化裝舞會髮型"] = 0;
        SSMaxEnergyLookup["宮廷遠征使者髮型"] = 0;
        SSMaxEnergyLookup["暮色夢夜髮型(男)"] = 0;
        SSMaxEnergyLookup["暮色夢夜髮型(女)"] = 0;
          
        SSMaxEnergyLookup["日蝕髮型-D"] = 0; 
        SSMaxEnergyLookup["黑金天使髮型-D"] = 0;
        SSMaxEnergyLookup["晨曦破曉髮型-D"] = 0;
        SSMaxEnergyLookup["夜幕降臨髮型-D"] = 0;
        SSMaxEnergyLookup["混沌大師髮型-D"] = 0;
          
        SSMaxEnergyLookup["挑戰者髮型-D"] = 0;
        SSMaxEnergyLookup["璀璨的光芒髮型-D"] = 0;
        SSMaxEnergyLookup["皇家騎士髮型-D"] = 0;
        SSMaxEnergyLookup["不祥的暗黑髮型-D"] = 0;
        SSMaxEnergyLookup["皇家護衛髮型(男)-D"] = 0;
          
        SSMaxEnergyLookup["皇家護衛髮型(女)-D"] = 0;
        SSMaxEnergyLookup["覺醒 ‧ 馭龍頭盔-D"] = 0;
        SSMaxEnergyLookup["克羅諾斯的髮型-D"] = 0;
        SSMaxEnergyLookup["極 ‧ 馭龍騎士頭盔-D"] = 0;
    }
    #endregion SS_Hair Max Energy

    #region SS_Hair Max Sprint
    void SS_MaxSprint()
    {
        SSMaxSprintLookup["梅賽德斯髮型-D"] = 0;
        SSMaxSprintLookup["化裝舞會髮型"] = 0;
        SSMaxSprintLookup["宮廷遠征使者髮型"] = 0;
        SSMaxSprintLookup["暮色夢夜髮型(男)"] = 0;
        SSMaxSprintLookup["暮色夢夜髮型(女)"] = 0;
             
        SSMaxSprintLookup["日蝕髮型-D"] = 0;
        SSMaxSprintLookup["黑金天使髮型-D"] = 0;
        SSMaxSprintLookup["晨曦破曉髮型-D"] = 0;
        SSMaxSprintLookup["夜幕降臨髮型-D"] = 0;
        SSMaxSprintLookup["混沌大師髮型-D"] = 0;
             
        SSMaxSprintLookup["挑戰者髮型-D"] = 0;
        SSMaxSprintLookup["璀璨的光芒髮型-D"] = 0;
        SSMaxSprintLookup["皇家騎士髮型-D"] = 0;
        SSMaxSprintLookup["不祥的暗黑髮型-D"] = 0;
        SSMaxSprintLookup["皇家護衛髮型(男)-D"] = 0;
             
        SSMaxSprintLookup["皇家護衛髮型(女)-D"] = 0;
        SSMaxSprintLookup["覺醒 ‧ 馭龍頭盔-D"] = 0;
        SSMaxSprintLookup["克羅諾斯的髮型-D"] = 0;
        SSMaxSprintLookup["極 ‧ 馭龍騎士頭盔-D"] = 0;
    }
    #endregion SS_Hair Max Sprint

    #region SS_Hair Force
    void SS_Force()
    {
        SSForceLookup["梅賽德斯髮型-D"] = 0;
        SSForceLookup["化裝舞會髮型"] = 0;
        SSForceLookup["宮廷遠征使者髮型"] = 0;
        SSForceLookup["暮色夢夜髮型(男)"] = 0;
        SSForceLookup["暮色夢夜髮型(女)"] = 0;
          
        SSForceLookup["日蝕髮型-D"] = 0;
        SSForceLookup["黑金天使髮型-D"] = 0;
        SSForceLookup["晨曦破曉髮型-D"] = 0;
        SSForceLookup["夜幕降臨髮型-D"] = 0;
        SSForceLookup["混沌大師髮型-D"] = 0;
          
        SSForceLookup["挑戰者髮型-D"] = 0;
        SSForceLookup["璀璨的光芒髮型-D"] = 0;
        SSForceLookup["皇家騎士髮型-D"] = 0;
        SSForceLookup["不祥的暗黑髮型-D"] = 0;
        SSForceLookup["皇家護衛髮型(男)-D"] = 0;
          
        SSForceLookup["皇家護衛髮型(女)-D"] = 0;
        SSForceLookup["覺醒 ‧ 馭龍頭盔-D"] = 0;
        SSForceLookup["克羅諾斯的髮型-D"] = 0;
        SSForceLookup["極 ‧ 馭龍騎士頭盔-D"] = 0;
    }
    #endregion SS_Hair Force

    #region SS_Hair Luck
    void SS_Luck()
    {
        SSLuckLookup["梅賽德斯髮型-D"] = 80;
        SSLuckLookup["化裝舞會髮型"] = 80;
        SSLuckLookup["宮廷遠征使者髮型"] = 80;
        SSLuckLookup["暮色夢夜髮型(男)"] = 80;
        SSLuckLookup["暮色夢夜髮型(女)"] = 80;
          
        SSLuckLookup["日蝕髮型-D"] = 80;
        SSLuckLookup["黑金天使髮型-D"] = 80;
        SSLuckLookup["晨曦破曉髮型-D"] = 80;
        SSLuckLookup["夜幕降臨髮型-D"] = 80;
        SSLuckLookup["混沌大師髮型-D"] = 80;
          
        SSLuckLookup["挑戰者髮型-D"] = 0;
        SSLuckLookup["璀璨的光芒髮型-D"] = 50;
        SSLuckLookup["皇家騎士髮型-D"] = 80;
        SSLuckLookup["不祥的暗黑髮型-D"] = 50;
        SSLuckLookup["皇家護衛髮型(男)-D"] = 0;
          
        SSLuckLookup["皇家護衛髮型(女)-D"] = 0;
        SSLuckLookup["覺醒 ‧ 馭龍頭盔-D"] = 0;
        SSLuckLookup["克羅諾斯的髮型-D"] = 80;
        SSLuckLookup["極 ‧ 馭龍騎士頭盔-D"] = 0;
    }
    #endregion SS_Hair Luck

    #endregion SS_Hair Stats


}

