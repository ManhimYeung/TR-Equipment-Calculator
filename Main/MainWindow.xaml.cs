﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace Main
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CharacterClass characters = new CharacterClass();
        HairClass hairItem = new HairClass();
        public MainWindow()
        {

            InitializeComponent();
            CharComboBox.ItemsSource = characters.IDLookup.Keys; //
                                                                 //ItemsSelectionInComboBox();

        }
        //Character ComboBox showing basic stats
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SpeedLabel.Content = characters.SpeedLookup[CharComboBox.Items[CharComboBox.SelectedIndex].ToString()];
            AccelerationLabel.Content = characters.AccelerationLookup[CharComboBox.Items[CharComboBox.SelectedIndex].ToString()];
            PowerLabel.Content = characters.PowerLookup[CharComboBox.Items[CharComboBox.SelectedIndex].ToString()];
            ControlLabel.Content = characters.ControlLookup[CharComboBox.Items[CharComboBox.SelectedIndex].ToString()];
        }

        private void ModeButton_Checked(object sender, RoutedEventArgs e)
        {
            if (CharModeButton.IsChecked == true)
            {

            }
            else if (AvatarModeButton.IsChecked == true)
            {

            }
        }

        #region Gear Selection Radio Buttons
        public enum GearOptions
        {
            HairOption,
            TopOption,
            BottomOption,
            ShoesOption,
            HatOption,
            FaceOption,
            HandOption,
            BackOption,
            NeckOption,
            PetOption,
            SpecialOption,
            WristOption,
            AcceleratorOption,
            TailOption
        }
        GearOptions gearOption;
        private void GearSelectionRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (((RadioButton)sender).IsChecked == true)
            {
                switch (((RadioButton)sender).Name)
                {
                    case "HairRadioButton":
                        gearOption = GearOptions.HairOption;
                        break;
                    case "TopRadioButton":
                        gearOption = GearOptions.TopOption;
                        break;
                    case "BottomRadioButton":
                        gearOption = GearOptions.BottomOption;
                        break;
                    case "ShoesRadioButton":
                        gearOption = GearOptions.ShoesOption;
                        break;
                    case "HatRadioButton":
                        gearOption = GearOptions.HatOption;
                        break;
                    case "FaceRadioButton":
                        gearOption = GearOptions.FaceOption;
                        break;
                    case "HandRadioButton":
                        gearOption = GearOptions.HandOption;
                        break;
                    case "BackRadioButton":
                        gearOption = GearOptions.BackOption;
                        break;
                    case "NeckRadioButton":
                        gearOption = GearOptions.NeckOption;
                        break;
                    case "PetRadioButton":
                        gearOption = GearOptions.PetOption;
                        break;
                    case "SpecialRadioButton":
                        gearOption = GearOptions.SpecialOption;
                        break;
                    case "WristRadioButton":
                        gearOption = GearOptions.WristOption;
                        break;
                    case "AccelerationRadioButton":
                        gearOption = GearOptions.AcceleratorOption;
                        break;
                    case "TailRadioButton":
                        gearOption = GearOptions.TailOption;
                        break;
                }
            }

        }
        #endregion Gear Selection Radio Buttons

        #region Rarity Selection Radio Buttons
        public enum RarityLevels
        {
            NULL,
            C,
            B,
            A,
            S,
            SS,
            SSS
        }
        RarityLevels rarityLevel;
        private void RaritySelectionRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (((RadioButton)sender).IsChecked == true)
            {
                switch (((RadioButton)sender).Name)
                {
                    case "RarityCRadioButton":
                        rarityLevel = RarityLevels.C;
                        break;
                    case "RarityBRadioButton":
                        rarityLevel = RarityLevels.B;
                        break;
                    case "RarityARadioButton":
                        rarityLevel = RarityLevels.A;
                        break;
                    case "RaritySRadioButton":
                        rarityLevel = RarityLevels.S;
                        break;
                    case "RaritySSRadioButton":
                        rarityLevel = RarityLevels.SS;
                        break;
                    case "RaritySSSRadioButton":
                        rarityLevel = RarityLevels.SSS;
                        break;
                }
                ItemsSelectionInComboBox();
            }
        }
        #endregion Rarity Selection Radio Buttons

        public void ItemsSelectionInComboBox()
        {
            switch (gearOption)
            {
                case (GearOptions.HairOption):
                    {
                        switch (rarityLevel)
                        {
                            case (RarityLevels.C):
                                ItemComboBox.ItemsSource = hairItem.CRarityLookup.Keys;
                                break;
                            case (RarityLevels.B):
                                ItemComboBox.ItemsSource = hairItem.BRarityLookup.Keys;
                                break;
                            case (RarityLevels.A):
                                ItemComboBox.ItemsSource = hairItem.ARarityLookup.Keys;
                                break;
                            case (RarityLevels.S):
                                ItemComboBox.ItemsSource = hairItem.SRarityLookup.Keys;
                                break;
                            case (RarityLevels.SS):
                                ItemComboBox.ItemsSource = hairItem.SSRarityLookup.Keys;
                                break;
                            case (RarityLevels.SSS):
                                ItemComboBox.ItemsSource = hairItem.SSSRarityLookup.Keys;
                                break;
                        }
                        break;
                    }

                case (GearOptions.FaceOption):
                    break;
            }
        }

        //shows all stats of each item
        private void ItemComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (gearOption)
            {
                case (GearOptions.HairOption):
                    switch (rarityLevel)
                    {
                        case (RarityLevels.C):
                            if (hairItem.CSpeedLookup.ContainsKey(ItemComboBox.Items[ItemComboBox.SelectedIndex].ToString()) == true)
                            {
                                GSpeedLabel.Content = hairItem.CSpeedLookup[ItemComboBox.Items[ItemComboBox.SelectedIndex].ToString()];
                                GAccelerationLabel.Content = hairItem.CAccelerationLookup[ItemComboBox.Items[ItemComboBox.SelectedIndex].ToString()];
                                GPowerLabel.Content = hairItem.CPowerLookup[ItemComboBox.Items[ItemComboBox.SelectedIndex].ToString()];
                                GControlLabel.Content = hairItem.CControlLookup[ItemComboBox.Items[ItemComboBox.SelectedIndex].ToString()];
                                GRageDurationLabel.Content = hairItem.CRageDurationLookup[ItemComboBox.Items[ItemComboBox.SelectedIndex].ToString()];
                                GRageChargeLabel.Content = hairItem.CRageChargeLookup[ItemComboBox.Items[ItemComboBox.SelectedIndex].ToString()];
                                GEnergyLabel.Content = hairItem.CMaxEnergyLookup[ItemComboBox.Items[ItemComboBox.SelectedIndex].ToString()];
                                GMaxSprintLabel.Content = hairItem.CMaxSprintLookup[ItemComboBox.Items[ItemComboBox.SelectedIndex].ToString()];
                                GForceLabel.Content = hairItem.CForceLookup[ItemComboBox.Items[ItemComboBox.SelectedIndex].ToString()];
                                GLuckLabel.Content = hairItem.CLuckLookup[ItemComboBox.Items[ItemComboBox.SelectedIndex].ToString()];
                                GAvatarLabel.Content = hairItem.CModeLookup[ItemComboBox.Items[ItemComboBox.SelectedIndex].ToString()];
                            }
                            else
                                MessageBox.Show("C Level Hair Error.");
                            break;

                        case (RarityLevels.B):
                            if (hairItem.BSpeedLookup.ContainsKey(ItemComboBox.Items[ItemComboBox.SelectedIndex].ToString()) == true)
                            {
                                GSpeedLabel.Content = hairItem.BSpeedLookup[ItemComboBox.Items[ItemComboBox.SelectedIndex].ToString()];
                                GAccelerationLabel.Content = hairItem.BAccelerationLookup[ItemComboBox.Items[ItemComboBox.SelectedIndex].ToString()];
                                GPowerLabel.Content = hairItem.BPowerLookup[ItemComboBox.Items[ItemComboBox.SelectedIndex].ToString()];
                                GControlLabel.Content = hairItem.BControlLookup[ItemComboBox.Items[ItemComboBox.SelectedIndex].ToString()];
                                GRageDurationLabel.Content = hairItem.BRageDurationLookup[ItemComboBox.Items[ItemComboBox.SelectedIndex].ToString()];
                                GRageChargeLabel.Content = hairItem.BRageChargeLookup[ItemComboBox.Items[ItemComboBox.SelectedIndex].ToString()];
                                GEnergyLabel.Content = hairItem.BMaxEnergyLookup[ItemComboBox.Items[ItemComboBox.SelectedIndex].ToString()];
                                GMaxSprintLabel.Content = hairItem.BMaxSprintLookup[ItemComboBox.Items[ItemComboBox.SelectedIndex].ToString()];
                                GForceLabel.Content = hairItem.BForceLookup[ItemComboBox.Items[ItemComboBox.SelectedIndex].ToString()];
                                GLuckLabel.Content = hairItem.BLuckLookup[ItemComboBox.Items[ItemComboBox.SelectedIndex].ToString()];
                                GAvatarLabel.Content = hairItem.BModeLookup[ItemComboBox.Items[ItemComboBox.SelectedIndex].ToString()];
                            }
                            else
                                MessageBox.Show("B Level Hair Error.");
                            break;
                        case (RarityLevels.A):
                            if (hairItem.ASpeedLookup.ContainsKey(ItemComboBox.Items[ItemComboBox.SelectedIndex].ToString()) == true)
                            {

                            }
                            break;
                        case (RarityLevels.S):
                            if (hairItem.SSSpeedLookup.ContainsKey(ItemComboBox.Items[ItemComboBox.SelectedIndex].ToString()) == true)
                            {

                            }
                            break;
                        case (RarityLevels.SS):
                            if (hairItem.SSSpeedLookup.ContainsKey(ItemComboBox.Items[ItemComboBox.SelectedIndex].ToString()) == true)
                            {
                                GSpeedLabel.Content = hairItem.SSSpeedLookup[ItemComboBox.Items[ItemComboBox.SelectedIndex].ToString()];
                                GAccelerationLabel.Content = hairItem.SSAccelerationLookup[ItemComboBox.Items[ItemComboBox.SelectedIndex].ToString()];
                                GPowerLabel.Content = hairItem.SSPowerLookup[ItemComboBox.Items[ItemComboBox.SelectedIndex].ToString()];
                                GControlLabel.Content = hairItem.SSControlLookup[ItemComboBox.Items[ItemComboBox.SelectedIndex].ToString()];
                                GRageDurationLabel.Content = hairItem.SSRageDurationLookup[ItemComboBox.Items[ItemComboBox.SelectedIndex].ToString()];
                                GRageChargeLabel.Content = hairItem.SSRageChargeLookup[ItemComboBox.Items[ItemComboBox.SelectedIndex].ToString()];
                                GEnergyLabel.Content = hairItem.SSMaxEnergyLookup[ItemComboBox.Items[ItemComboBox.SelectedIndex].ToString()];
                                GMaxSprintLabel.Content = hairItem.SSMaxSprintLookup[ItemComboBox.Items[ItemComboBox.SelectedIndex].ToString()];
                                GForceLabel.Content = hairItem.SSForceLookup[ItemComboBox.Items[ItemComboBox.SelectedIndex].ToString()];
                                GLuckLabel.Content = hairItem.SSLuckLookup[ItemComboBox.Items[ItemComboBox.SelectedIndex].ToString()];
                                GAvatarLabel.Content = hairItem.SSModeLookup[ItemComboBox.Items[ItemComboBox.SelectedIndex].ToString()];
                            }
                            else
                                MessageBox.Show("SS Level Hair Error.");
                                break;
                        case (RarityLevels.SSS):
                            MessageBox.Show("SSS Level Hair items do not exist.");
                            break;
                        default:
                            break;
                    }
                    break;

            }
            
                



        }

        public void EquipedItems()
        {

        }
    }

}