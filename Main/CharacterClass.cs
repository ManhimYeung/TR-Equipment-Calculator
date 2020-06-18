using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CharacterClass
{
    public CharacterClass()
    {
        IDIndex();
        SpeedIndex();
        AccelerationIndex();
        PowerIndex();
        ControlIndex();
    }

    #region Characters ID
    public Dictionary<string, int> IDLookup = new Dictionary<string, int>();
    public void IDIndex()
    {
        IDLookup["光光"] = 1;
        IDLookup["明明"] = 2;
        IDLookup["莉娜"] = 3;
        IDLookup["大隻仔"] = 4;
        IDLookup["蒂蒂"] = 5;
        IDLookup["納魯西斯"] = 6;
        IDLookup["琪琪"] = 7;
        IDLookup["軒少"] = 8;
        IDLookup["影子(軒少)"] = 9;
        IDLookup["Kay(安琪)"] = 10;
        IDLookup["占"] = 11;
        IDLookup["雪姬"] = 12;
        IDLookup["映雪"] = 13;
        IDLookup["阿貝爾"] = 14;
        IDLookup["夏魯"] = 15;
        IDLookup["維拉"] = 16;
        IDLookup["孫悟空"] = 17;
        IDLookup["阿修"] = 18;
        IDLookup["星淚"] = 19;
        IDLookup["小櫻"] = 20;
        IDLookup["R"] = 21;
        IDLookup["夏郎"] = 22;
        IDLookup["LaLa"] = 23;
        int IDChar1 = IDLookup["光光"];
        int IDChar2 = IDLookup["明明"];
        int IDChar3 = IDLookup["莉娜"];
        int IDChar4 = IDLookup["大隻仔"];
        int IDChar5 = IDLookup["蒂蒂"];
        int IDChar6 = IDLookup["納魯西斯"];
        int IDChar7 = IDLookup["琪琪"];
        int IDChar8 = IDLookup["軒少"];
        int IDChar9 = IDLookup["影子(軒少)"];
        int IDChar10 = IDLookup["Kay(安琪)"];
        int IDChar11 = IDLookup["占"];
        int IDChar12 = IDLookup["雪姬"];
        int IDChar13 = IDLookup["映雪"];
        int IDChar14 = IDLookup["阿貝爾"];
        int IDChar15 = IDLookup["夏魯"];
        int IDChar16 = IDLookup["維拉"];
        int IDChar17 = IDLookup["孫悟空"];
        int IDChar18 = IDLookup["阿修"];
        int IDChar19 = IDLookup["星淚"];
        int IDChar20 = IDLookup["小櫻"];
        int IDChar21 = IDLookup["R"];
        int IDChar22 = IDLookup["夏郎"];
        int IDChar23 = IDLookup["LaLa"];
    }
    #endregion Characters ID

    #region Characters Speed
    public Dictionary<string, int> SpeedLookup = new Dictionary<string, int>();
    public void SpeedIndex()
    {
        SpeedLookup["光光"] = 3;
        SpeedLookup["明明"] = 3;
        SpeedLookup["莉娜"] = 1;
        SpeedLookup["大隻仔"] = 5;
        SpeedLookup["蒂蒂"] = 4;
        SpeedLookup["納魯西斯"] = 6;
        SpeedLookup["琪琪"] = 2;
        SpeedLookup["軒少"] = 4;
        SpeedLookup["影子(軒少)"] = 6;
        SpeedLookup["Kay(安琪)"] = 5;
        SpeedLookup["占"] = 5;
        SpeedLookup["雪姬"] = 6;
        SpeedLookup["映雪"] = 1;
        SpeedLookup["阿貝爾"] = 4;
        SpeedLookup["夏魯"] = 5;
        SpeedLookup["維拉"] = 6;
        SpeedLookup["孫悟空"] = 5;
        SpeedLookup["阿修"] = 6;
        SpeedLookup["星淚"] = 4;
        SpeedLookup["小櫻"] = 5;
        SpeedLookup["R"] = 6;
        SpeedLookup["夏郎"] = 4;
        SpeedLookup["LaLa"] = 5;
        int speedChar1 = SpeedLookup["光光"];
        int speedChar2 = SpeedLookup["明明"];
        int speedChar3 = SpeedLookup["莉娜"];
        int speedChar4 = SpeedLookup["大隻仔"];
        int speedChar5 = SpeedLookup["蒂蒂"];
        int speedChar6 = SpeedLookup["納魯西斯"];
        int speedChar7 = SpeedLookup["琪琪"];
        int speedChar8 = SpeedLookup["軒少"];
        int speedChar9 = SpeedLookup["影子(軒少)"];
        int speedChar10 = SpeedLookup["Kay(安琪)"];
        int speedChar11 = SpeedLookup["占"];
        int speedChar12 = SpeedLookup["雪姬"];
        int speedChar13 = SpeedLookup["映雪"];
        int speedChar14 = SpeedLookup["阿貝爾"];
        int speedChar15 = SpeedLookup["夏魯"];
        int speedChar16 = SpeedLookup["維拉"];
        int speedChar17 = SpeedLookup["孫悟空"];
        int speedChar18 = SpeedLookup["阿修"];
        int speedChar19 = SpeedLookup["星淚"];
        int speedChar20 = SpeedLookup["小櫻"];
        int speedChar21 = SpeedLookup["R"];
        int speedChar22 = SpeedLookup["夏郎"];
        int speedChar23 = SpeedLookup["LaLa"];
    }
    #endregion Characters Speed

    #region Characters Acceleration
    public Dictionary<string, int> AccelerationLookup = new Dictionary<string, int>();
    public void AccelerationIndex()
    {
        AccelerationLookup["光光"] = 3;
        AccelerationLookup["明明"] = 3;
        AccelerationLookup["莉娜"] = 6;
        AccelerationLookup["大隻仔"] = 2;
        AccelerationLookup["蒂蒂"] = 2;
        AccelerationLookup["納魯西斯"] = 1;
        AccelerationLookup["琪琪"] = 5;
        AccelerationLookup["軒少"] = 3;
        AccelerationLookup["影子(軒少)"] = 3;
        AccelerationLookup["Kay(安琪)"] = 3;
        AccelerationLookup["占"] = 5;
        AccelerationLookup["雪姬"] = 1;
        AccelerationLookup["映雪"] = 5;
        AccelerationLookup["阿貝爾"] = 5;
        AccelerationLookup["夏魯"] = 3;
        AccelerationLookup["維拉"] = 5;
        AccelerationLookup["孫悟空"] = 4;
        AccelerationLookup["阿修"] = 3;
        AccelerationLookup["星淚"] = 4;
        AccelerationLookup["小櫻"] = 6;
        AccelerationLookup["R"] = 1;
        AccelerationLookup["夏郎"] = 4;
        AccelerationLookup["LaLa"] = 2;
        int AcceChar1 = AccelerationLookup["光光"];
        int AcceChar2 = AccelerationLookup["明明"];
        int AcceChar3 = AccelerationLookup["莉娜"];
        int AcceChar4 = AccelerationLookup["大隻仔"];
        int AcceChar5 = AccelerationLookup["蒂蒂"];
        int AcceChar6 = AccelerationLookup["納魯西斯"];
        int AcceChar7 = AccelerationLookup["琪琪"];
        int AcceChar8 = AccelerationLookup["軒少"];
        int AcceChar9 = AccelerationLookup["影子(軒少)"];
        int AcceChar10 = AccelerationLookup["Kay(安琪)"];
        int AcceChar11 = AccelerationLookup["占"];
        int AcceChar12 = AccelerationLookup["雪姬"];
        int AcceChar13 = AccelerationLookup["映雪"];
        int AcceChar14 = AccelerationLookup["阿貝爾"];
        int AcceChar15 = AccelerationLookup["夏魯"];
        int AcceChar16 = AccelerationLookup["維拉"];
        int AcceChar17 = AccelerationLookup["孫悟空"];
        int AcceChar18 = AccelerationLookup["阿修"];
        int AcceChar19 = AccelerationLookup["星淚"];
        int AcceChar20 = AccelerationLookup["小櫻"];
        int AcceChar21 = AccelerationLookup["R"];
        int AcceChar22 = AccelerationLookup["夏郎"];
        int AcceChar23 = AccelerationLookup["LaLa"];
    }
    #endregion Characters Acceleration

    #region Characters Power
    public Dictionary<string, int> PowerLookup = new Dictionary<string, int>();
    public void PowerIndex()
    {
        PowerLookup["光光"] = 3;
        PowerLookup["明明"] = 2;
        PowerLookup["莉娜"] = 2;
        PowerLookup["大隻仔"] = 6;
        PowerLookup["蒂蒂"] = 3;
        PowerLookup["納魯西斯"] = 3;
        PowerLookup["琪琪"] = 1;
        PowerLookup["軒少"] = 5;
        PowerLookup["影子(軒少)"] = 4;
        PowerLookup["Kay(安琪)"] = 2;
        PowerLookup["占"] = 2;
        PowerLookup["雪姬"] = 2;
        PowerLookup["映雪"] = 5;
        PowerLookup["阿貝爾"] = 3;
        PowerLookup["夏魯"] = 4;
        PowerLookup["維拉"] = 2;
        PowerLookup["孫悟空"] = 3;
        PowerLookup["阿修"] = 2;
        PowerLookup["星淚"] = 3;
        PowerLookup["小櫻"] = 2;
        PowerLookup["R"] = 6;
        PowerLookup["夏郎"] = 4;
        PowerLookup["LaLa"] = 4;
        int PowerChar1 = PowerLookup["光光"];
        int PowerChar2 = PowerLookup["明明"];
        int PowerChar3 = PowerLookup["莉娜"];
        int PowerChar4 = PowerLookup["大隻仔"];
        int PowerChar5 = PowerLookup["蒂蒂"];
        int PowerChar6 = PowerLookup["納魯西斯"];
        int PowerChar7 = PowerLookup["琪琪"];
        int PowerChar8 = PowerLookup["軒少"];
        int PowerChar9 = PowerLookup["影子(軒少)"];
        int PowerChar10 = PowerLookup["Kay(安琪)"];
        int PowerChar11 = PowerLookup["占"];
        int PowerChar12 = PowerLookup["雪姬"];
        int PowerChar13 = PowerLookup["映雪"];
        int PowerChar14 = PowerLookup["阿貝爾"];
        int PowerChar15 = PowerLookup["夏魯"];
        int PowerChar16 = PowerLookup["維拉"];
        int PowerChar17 = PowerLookup["孫悟空"];
        int PowerChar18 = PowerLookup["阿修"];
        int PowerChar19 = PowerLookup["星淚"];
        int PowerChar20 = PowerLookup["小櫻"];
        int PowerChar21 = PowerLookup["R"];
        int PowerChar22 = PowerLookup["夏郎"];
        int PowerChar23 = PowerLookup["LaLa"];
    }
    #endregion Characters Power

    #region Characters Control
    public Dictionary<string, int> ControlLookup = new Dictionary<string, int>();
    public void ControlIndex()
    {
        ControlLookup["光光"] = 3;
        ControlLookup["明明"] = 4;
        ControlLookup["莉娜"] = 5;
        ControlLookup["大隻仔"] = 1;
        ControlLookup["蒂蒂"] = 3;
        ControlLookup["納魯西斯"] = 4;
        ControlLookup["琪琪"] = 6;
        ControlLookup["軒少"] = 2;
        ControlLookup["影子(軒少)"] = 2;
        ControlLookup["Kay(安琪)"] = 4;
        ControlLookup["占"] = 2;
        ControlLookup["雪姬"] = 5;
        ControlLookup["映雪"] = 4;
        ControlLookup["阿貝爾"] = 2;
        ControlLookup["夏魯"] = 2;
        ControlLookup["維拉"] = 1;
        ControlLookup["孫悟空"] = 2;
        ControlLookup["阿修"] = 3;
        ControlLookup["星淚"] = 3;
        ControlLookup["小櫻"] = 1;
        ControlLookup["R"] = 1;
        ControlLookup["夏郎"] = 2;
        ControlLookup["LaLa"] = 3;
        int ControlChar1 = ControlLookup["光光"];
        int ControlChar2 = ControlLookup["明明"];
        int ControlChar3 = ControlLookup["莉娜"];
        int ControlChar4 = ControlLookup["大隻仔"];
        int ControlChar5 = ControlLookup["蒂蒂"];
        int ControlChar6 = ControlLookup["納魯西斯"];
        int ControlChar7 = ControlLookup["琪琪"];
        int ControlChar8 = ControlLookup["軒少"];
        int ControlChar9 = ControlLookup["影子(軒少)"];
        int ControlChar10 = ControlLookup["Kay(安琪)"];
        int ControlChar11 = ControlLookup["占"];
        int ControlChar12 = ControlLookup["雪姬"];
        int ControlChar13 = ControlLookup["映雪"];
        int ControlChar14 = ControlLookup["阿貝爾"];
        int ControlChar15 = ControlLookup["夏魯"];
        int ControlChar16 = ControlLookup["維拉"];
        int ControlChar17 = ControlLookup["孫悟空"];
        int ControlChar18 = ControlLookup["阿修"];
        int ControlChar19 = ControlLookup["星淚"];
        int ControlChar20 = ControlLookup["小櫻"];
        int ControlChar21 = ControlLookup["R"];
        int ControlChar22 = ControlLookup["夏郎"];
        int ControlChar23 = ControlLookup["LaLa"];
    }
    #endregion Characters Control
}

