
using System.ComponentModel;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Armors {
    public partial class OtomoArmorDat {
        public const uint StructSize = 42;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;

        protected const string Id_displayName = "Id";
        protected const int Id_sortIndex = 50;
        [SortOrder(Id_sortIndex)]
        [DisplayName(Id_displayName)]
        public uint Id {
            get => GetData<uint>(0);
            set {
                if (GetData<uint>(0) == value) return;
                SetData(0, value);
                OnPropertyChanged(nameof(Id));
            }
        }

        protected const string Set_Id_displayName = "Set Id";
        protected const int Set_Id_sortIndex = 100;
        [SortOrder(Set_Id_sortIndex)]
        [DisplayName(Set_Id_displayName)]
        public ushort Set_Id {
            get => GetData<ushort>(4);
            set {
                if (GetData<ushort>(4) == value) return;
                SetData(4, value);
                OnPropertyChanged(nameof(Set_Id));
            }
        }

        protected const string Equip_Slot_displayName = "Equip Slot";
        protected const int Equip_Slot_sortIndex = 150;
        [SortOrder(Equip_Slot_sortIndex)]
        [DisplayName(Equip_Slot_displayName)]
        public MHW_Template.Armors.EquipSlot Equip_Slot {
            get => (MHW_Template.Armors.EquipSlot) GetData<byte>(6);
            set {
                if ((MHW_Template.Armors.EquipSlot) GetData<byte>(6) == value) return;
                SetData(6, (byte) value);
                OnPropertyChanged(nameof(Equip_Slot));
            }
        }

        protected const string Is_Full_Set_Raw_displayName = "Is Full Set Raw";
        protected const int Is_Full_Set_Raw_sortIndex = 200;
        [SortOrder(Is_Full_Set_Raw_sortIndex)]
        [DisplayName(Is_Full_Set_Raw_displayName)]
        protected byte Is_Full_Set_Raw {
            get => GetData<byte>(7);
            set {
                if (GetData<byte>(7) == value) return;
                SetData(7, value);
                OnPropertyChanged(nameof(Is_Full_Set_Raw));
            }
        }

        protected const string Defense_displayName = "Defense";
        protected const int Defense_sortIndex = 250;
        [SortOrder(Defense_sortIndex)]
        [DisplayName(Defense_displayName)]
        public uint Defense {
            get => GetData<uint>(8);
            set {
                if (GetData<uint>(8) == value) return;
                SetData(8, value);
                OnPropertyChanged(nameof(Defense));
            }
        }

        protected const string Rarity_displayName = "Rarity";
        protected const int Rarity_sortIndex = 300;
        [SortOrder(Rarity_sortIndex)]
        [DisplayName(Rarity_displayName)]
        public byte Rarity {
            get => GetData<byte>(12);
            set {
                if (GetData<byte>(12) == value) return;
                SetData(12, value);
                OnPropertyChanged(nameof(Rarity));
            }
        }

        protected const string Order_displayName = "Order";
        protected const int Order_sortIndex = 350;
        [SortOrder(Order_sortIndex)]
        [DisplayName(Order_displayName)]
        public ushort Order {
            get => GetData<ushort>(13);
            set {
                if (GetData<ushort>(13) == value) return;
                SetData(13, value);
                OnPropertyChanged(nameof(Order));
            }
        }

        protected const string Model_Id_displayName = "Model Id";
        protected const int Model_Id_sortIndex = 400;
        [SortOrder(Model_Id_sortIndex)]
        [DisplayName(Model_Id_displayName)]
        public uint Model_Id {
            get => GetData<uint>(15);
            set {
                if (GetData<uint>(15) == value) return;
                SetData(15, value);
                OnPropertyChanged(nameof(Model_Id));
            }
        }

        protected const string Cost_displayName = "Cost";
        protected const int Cost_sortIndex = 450;
        [SortOrder(Cost_sortIndex)]
        [DisplayName(Cost_displayName)]
        public uint Cost {
            get => GetData<uint>(19);
            set {
                if (GetData<uint>(19) == value) return;
                SetData(19, value);
                OnPropertyChanged(nameof(Cost));
            }
        }

        protected const string Variant_displayName = "Variant";
        protected const int Variant_sortIndex = 500;
        [SortOrder(Variant_sortIndex)]
        [DisplayName(Variant_displayName)]
        public byte Variant {
            get => GetData<byte>(23);
            set {
                if (GetData<byte>(23) == value) return;
                SetData(23, value);
                OnPropertyChanged(nameof(Variant));
            }
        }

        protected const string Fire_Res_displayName = "Fire Res";
        protected const int Fire_Res_sortIndex = 550;
        [SortOrder(Fire_Res_sortIndex)]
        [DisplayName(Fire_Res_displayName)]
        public sbyte Fire_Res {
            get => GetData<sbyte>(27);
            set {
                if (GetData<sbyte>(27) == value) return;
                SetData(27, value);
                OnPropertyChanged(nameof(Fire_Res));
            }
        }

        protected const string Water_Res_displayName = "Water Res";
        protected const int Water_Res_sortIndex = 600;
        [SortOrder(Water_Res_sortIndex)]
        [DisplayName(Water_Res_displayName)]
        public sbyte Water_Res {
            get => GetData<sbyte>(28);
            set {
                if (GetData<sbyte>(28) == value) return;
                SetData(28, value);
                OnPropertyChanged(nameof(Water_Res));
            }
        }

        protected const string Ice_Res_displayName = "Ice Res";
        protected const int Ice_Res_sortIndex = 650;
        [SortOrder(Ice_Res_sortIndex)]
        [DisplayName(Ice_Res_displayName)]
        public sbyte Ice_Res {
            get => GetData<sbyte>(29);
            set {
                if (GetData<sbyte>(29) == value) return;
                SetData(29, value);
                OnPropertyChanged(nameof(Ice_Res));
            }
        }

        protected const string Thunder_Res_displayName = "Thunder Res";
        protected const int Thunder_Res_sortIndex = 700;
        [SortOrder(Thunder_Res_sortIndex)]
        [DisplayName(Thunder_Res_displayName)]
        public sbyte Thunder_Res {
            get => GetData<sbyte>(30);
            set {
                if (GetData<sbyte>(30) == value) return;
                SetData(30, value);
                OnPropertyChanged(nameof(Thunder_Res));
            }
        }

        protected const string Dragon_Res_displayName = "Dragon Res";
        protected const int Dragon_Res_sortIndex = 750;
        [SortOrder(Dragon_Res_sortIndex)]
        [DisplayName(Dragon_Res_displayName)]
        public sbyte Dragon_Res {
            get => GetData<sbyte>(31);
            set {
                if (GetData<sbyte>(31) == value) return;
                SetData(31, value);
                OnPropertyChanged(nameof(Dragon_Res));
            }
        }

        protected const string Set_Group_displayName = "Set Group";
        protected const int Set_Group_sortIndex = 800;
        [SortOrder(Set_Group_sortIndex)]
        [DisplayName(Set_Group_displayName)]
        public ushort Set_Group {
            get => GetData<ushort>(36);
            set {
                if (GetData<ushort>(36) == value) return;
                SetData(36, value);
                OnPropertyChanged(nameof(Set_Group));
            }
        }

        protected const string GMD_Name_Index_displayName = "GMD Name Index";
        protected const int GMD_Name_Index_sortIndex = 850;
        [SortOrder(GMD_Name_Index_sortIndex)]
        [DisplayName(GMD_Name_Index_displayName)]
        protected ushort GMD_Name_Index {
            get => GetData<ushort>(38);
            set {
                if (GetData<ushort>(38) == value) return;
                SetData(38, value);
                OnPropertyChanged(nameof(GMD_Name_Index));
            }
        }

        protected const string GMD_Description_Index_displayName = "GMD Description Index";
        protected const int GMD_Description_Index_sortIndex = 900;
        [SortOrder(GMD_Description_Index_sortIndex)]
        [DisplayName(GMD_Description_Index_displayName)]
        protected ushort GMD_Description_Index {
            get => GetData<ushort>(40);
            set {
                if (GetData<ushort>(40) == value) return;
                SetData(40, value);
                OnPropertyChanged(nameof(GMD_Description_Index));
            }
        }
    }
}