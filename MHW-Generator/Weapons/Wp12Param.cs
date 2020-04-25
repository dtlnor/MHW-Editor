﻿using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Struct_Generation.Multi;

namespace MHW_Generator.Weapons {
    public class Wp12Param : IMultiStruct {
        public static List<MhwMultiStructData.StructData> baseStructs = new List<MhwMultiStructData.StructData> {
            new MhwMultiStructData.StructData("W12p Params (1)", new List<MhwMultiStructData.StructData.Entry> {
                new MhwMultiStructData.StructData.Entry("Weapon", typeof(char), true, typeof(string), arrayCount: 4),
                new MhwMultiStructData.StructData.Entry("Unk 1", typeof(uint)),
                new MhwMultiStructData.StructData.Entry("Unk 2", typeof(uint))
            }, 1),
            new MhwMultiStructData.StructData("Unk Struct 1", new List<MhwMultiStructData.StructData.Entry> {
                new MhwMultiStructData.StructData.Entry("Unk 1", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk 2", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk 3", typeof(byte)),
                new MhwMultiStructData.StructData.Entry("Unk 4", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk 5", typeof(float))
            }, 20),
            new MhwMultiStructData.StructData("W12p Params (2)", new List<MhwMultiStructData.StructData.Entry> {
                new MhwMultiStructData.StructData.Entry("Unk1", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk2", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk3", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk4", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk5", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk6", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk7", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk8", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk9", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk10", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk11", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk12", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk13", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk14", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk15", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk16", typeof(uint)),
                new MhwMultiStructData.StructData.Entry("Unk17", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk18", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk19", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk20", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk21", typeof(byte)),
                new MhwMultiStructData.StructData.Entry("Unk22", typeof(float))
            }, 1, showVertically: true),
            new MhwMultiStructData.StructData("Guard Angles?", new List<MhwMultiStructData.StructData.Entry> {
                new MhwMultiStructData.StructData.Entry("Guard Angle (Both Sides)", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Knockback Threshold Small", typeof(byte)),
                new MhwMultiStructData.StructData.Entry("Knockback Threshold Medium", typeof(byte)),
                new MhwMultiStructData.StructData.Entry("Knockback Threshold Large", typeof(byte))
            }, 2),
            new MhwMultiStructData.StructData("W12p Params (3)", new List<MhwMultiStructData.StructData.Entry> {
                new MhwMultiStructData.StructData.Entry("Unk33", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk34", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk35", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk36", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk37", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk38", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk39", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk40", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk41", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk42", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk43", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk44", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk45", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk46", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk47", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk48", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk49", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk50", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk51", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk52", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk53", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk54", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk55", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk56", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk57", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk58", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk59", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk60", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk61", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk62", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk63", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk64", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk65", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk66", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk67", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk68", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk69", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk70", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk71", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk72", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk73", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk74", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk75", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk76", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk77", typeof(byte)),
                new MhwMultiStructData.StructData.Entry("Unk78", typeof(ushort)),
                new MhwMultiStructData.StructData.Entry("Unk79", typeof(ushort)),
                new MhwMultiStructData.StructData.Entry("Unk80", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk81", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk82", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk83", typeof(byte)),
                new MhwMultiStructData.StructData.Entry("Unk84", typeof(int))
            }, 1, showVertically: true),
            new MhwMultiStructData.StructData("Unk Struct 2", new List<MhwMultiStructData.StructData.Entry> {
                new MhwMultiStructData.StructData.Entry("Unk1", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk2", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk3", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk4", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk5", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk6", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk7", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk8", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk9", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk10", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk11", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk12", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk13", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk14", typeof(byte)),
                new MhwMultiStructData.StructData.Entry("End", typeof(int))
            }, 8),
            new MhwMultiStructData.StructData("W12p Params (4)", new List<MhwMultiStructData.StructData.Entry> {
                new MhwMultiStructData.StructData.Entry("Unk85", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk86", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk87", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk88", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk89", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk90", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk91", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk92", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk93", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk94", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk95", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk96", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk97", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk98", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk99", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk100", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk101", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk102", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk103", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk104", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk105", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk106___s___", typeof(uint)),
                new MhwMultiStructData.StructData.Entry("Unk107", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk108__", typeof(uint)),
                new MhwMultiStructData.StructData.Entry("Unk109", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk110__", typeof(uint)),
                new MhwMultiStructData.StructData.Entry("Unk111", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk112__", typeof(uint)),
                new MhwMultiStructData.StructData.Entry("Unk113___e___", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk114", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk115", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk116", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk117", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk118", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk119", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk120", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk121", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk122", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk123", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk124", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk125", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk126", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk127___s___", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk128", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk129", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk130", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk131", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk132", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk133", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk134", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk135", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk136__", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk137", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk138", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk139", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk140", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk141", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk142", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk143", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk144", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk145", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk146___e___", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk147", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk148", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk149", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk150", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk151", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk152", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk153", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk154", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk155", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk156", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk157", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk158", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk159", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk160", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk161", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk162", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk163", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk164", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk165", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk166", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk167", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk168", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk169", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk170", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk171", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk172", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk173", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk174", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk175", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk176", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk177", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk178", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk179", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk180___s___", typeof(byte)),
                new MhwMultiStructData.StructData.Entry("Unk180", typeof(byte)),
                new MhwMultiStructData.StructData.Entry("Unk181", typeof(byte)),
                new MhwMultiStructData.StructData.Entry("Unk181.1", typeof(byte)),
                new MhwMultiStructData.StructData.Entry("Unk182", typeof(ushort)),
                new MhwMultiStructData.StructData.Entry("Unk183", typeof(ushort)),
                new MhwMultiStructData.StructData.Entry("Unk184", typeof(ushort)),
                new MhwMultiStructData.StructData.Entry("Unk185", typeof(ushort)),
                new MhwMultiStructData.StructData.Entry("Unk186", typeof(ushort)),
                new MhwMultiStructData.StructData.Entry("Unk187", typeof(ushort)),
                new MhwMultiStructData.StructData.Entry("Unk188", typeof(ushort)),
                new MhwMultiStructData.StructData.Entry("Unk189", typeof(ushort)),
                new MhwMultiStructData.StructData.Entry("Unk190", typeof(ushort)),
                new MhwMultiStructData.StructData.Entry("Unk191__", typeof(ushort)),
                new MhwMultiStructData.StructData.Entry("Unk192", typeof(byte)),
                new MhwMultiStructData.StructData.Entry("Unk192.1", typeof(byte)),
                new MhwMultiStructData.StructData.Entry("Unk193", typeof(byte)),
                new MhwMultiStructData.StructData.Entry("Unk193.1", typeof(byte)),
                new MhwMultiStructData.StructData.Entry("Unk194", typeof(ushort)),
                new MhwMultiStructData.StructData.Entry("Unk195", typeof(ushort)),
                new MhwMultiStructData.StructData.Entry("Unk196", typeof(ushort)),
                new MhwMultiStructData.StructData.Entry("Unk197", typeof(ushort)),
                new MhwMultiStructData.StructData.Entry("Unk198", typeof(ushort)),
                new MhwMultiStructData.StructData.Entry("Unk199", typeof(ushort)),
                new MhwMultiStructData.StructData.Entry("Unk200", typeof(ushort)),
                new MhwMultiStructData.StructData.Entry("Unk201", typeof(ushort)),
                new MhwMultiStructData.StructData.Entry("Unk202", typeof(ushort)),
                new MhwMultiStructData.StructData.Entry("Unk203___e___", typeof(ushort)),
                new MhwMultiStructData.StructData.Entry("Unk204", typeof(ushort)),
                new MhwMultiStructData.StructData.Entry("Unk205", typeof(ushort)),
                new MhwMultiStructData.StructData.Entry("Unk206", typeof(ushort)),
                new MhwMultiStructData.StructData.Entry("Unk207", typeof(ushort)),
                new MhwMultiStructData.StructData.Entry("Unk208", typeof(ushort)),
                new MhwMultiStructData.StructData.Entry("Unk209", typeof(ushort)),
                new MhwMultiStructData.StructData.Entry("Unk210", typeof(ushort)),
                new MhwMultiStructData.StructData.Entry("Unk211", typeof(ushort)),
                new MhwMultiStructData.StructData.Entry("Unk212", typeof(ushort)),
                new MhwMultiStructData.StructData.Entry("Unk213", typeof(ushort)),
                new MhwMultiStructData.StructData.Entry("Unk214", typeof(byte)),
                new MhwMultiStructData.StructData.Entry("Unk215", typeof(ushort)),
                new MhwMultiStructData.StructData.Entry("Unk216", typeof(ushort)),
                new MhwMultiStructData.StructData.Entry("Unk217", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk218", typeof(ushort)),
                new MhwMultiStructData.StructData.Entry("Unk219", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk220", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk221", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk222", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk223", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk224", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk225", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk226", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk227", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk228", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk229", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk230", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk231", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk232", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk233", typeof(byte)),
                new MhwMultiStructData.StructData.Entry("Unk234", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk235", typeof(byte)),
                new MhwMultiStructData.StructData.Entry("Unk236", typeof(byte)),
                new MhwMultiStructData.StructData.Entry("Unk237", typeof(byte)),
                new MhwMultiStructData.StructData.Entry("Unk238", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk239", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk240", typeof(uint)),
                new MhwMultiStructData.StructData.Entry("Unk241", typeof(short))
            }, 1, showVertically: true),
            new MhwMultiStructData.StructData("Unk Struct 3", new List<MhwMultiStructData.StructData.Entry> {
                new MhwMultiStructData.StructData.Entry("Unk1", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk2", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk3", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk4", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk5", typeof(float))
            }, 16),
            new MhwMultiStructData.StructData("Unk Struct 4", new List<MhwMultiStructData.StructData.Entry> {
                new MhwMultiStructData.StructData.Entry("Unk1", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk2", typeof(uint)),
                new MhwMultiStructData.StructData.Entry("Unk3", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk4", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk5", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk6", typeof(float))
            }, 4),
            new MhwMultiStructData.StructData("W12p Params (5)", new List<MhwMultiStructData.StructData.Entry> {
                new MhwMultiStructData.StructData.Entry("Unk242", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk243", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk244", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk245", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk246", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk247", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk248", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk249", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk250", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk251", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk252", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk253", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk254", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk255", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk256", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk257", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk258", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk259", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk260", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk261", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk262", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk263", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk264", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk265", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk266", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk267", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk268", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk269", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk270", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk271", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk272", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk273", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk274", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk275", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Close_range_Up_active_range_1", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Close_range_Up_active_range_2", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Close_range_Up_active_range_3", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Close_range_Up_active_range_4", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Close_range_Up_Modifier_1", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Close_range_Up_Modifier_2", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Close_range_Up_Modifier_3", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Close_range_Up_Modifier_4", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Ranged_Attack_Up_active_distance_1", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Ranged_Attack_Up_active_distance_2", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Ranged_Attack_Up_active_distance_3", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Ranged_Attack_Up_active_distance_4", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Ranged_Attack_Up_Modifier_1", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Ranged_Attack_Up_Modifier_2", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Ranged_Attack_Up_Modifier_3", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Ranged_Attack_Up_Modifier_4", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Guard Angle (Both Sides)", typeof(float))
            }, 1, showVertically: true),
            new MhwMultiStructData.StructData("Number of Shield Mods Struct", new List<MhwMultiStructData.StructData.Entry> {
                new MhwMultiStructData.StructData.Entry("Number of Shield Mods", typeof(uint))
            }, 1, true),
            new MhwMultiStructData.StructData("Shield Mods", new List<MhwMultiStructData.StructData.Entry> {
                new MhwMultiStructData.StructData.Entry("Small", typeof(byte)),
                new MhwMultiStructData.StructData.Entry("Medium", typeof(byte)),
                new MhwMultiStructData.StructData.Entry("Large", typeof(byte))
            }, canAddRows: true),
            new MhwMultiStructData.StructData("W12p Params (6)", new List<MhwMultiStructData.StructData.Entry> {
                new MhwMultiStructData.StructData.Entry("Unk277", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk278", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk279", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk280", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk281", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk282", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk283", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk284", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk285", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk286", typeof(float))
            }, 1, showVertically: true),
            new MhwMultiStructData.StructData("Unk Struct 5", new List<MhwMultiStructData.StructData.Entry> {
                new MhwMultiStructData.StructData.Entry("Unk1", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk2", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk3", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Unk4", typeof(float))
            }, 50)
        };

        public MultiStruct Generate() { // .w12p
            var structs = new List<MhwMultiStructData.StructData>();
            structs.AddRange(baseStructs);
            structs.AddRange(new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData("W12p Params (7)", new List<MhwMultiStructData.StructData.Entry> {
                    new MhwMultiStructData.StructData.Entry("Unk287", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Unk288", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Unk289", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Unk290", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Unk291", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Unk292", typeof(float))
                }, 1, showVertically: true)
            });

            return new MultiStruct("MHW_Editor.Weapons", "Wp12Param", new MhwMultiStructData(structs, EncryptionKeys.FILE_EXT_KEY_LOOKUP[".w12p"]));
        }
    }
}