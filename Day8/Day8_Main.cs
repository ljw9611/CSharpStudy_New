﻿using System;
using N_StructDemo;
using N_StructArray;
using N_StructParameter;
using N_StructDate;
using N_ConsoleColorDemo;
using N_EnumerationDemo;
using N_EnumIndexChange;
using N_EnumSwitch;

namespace Day8_Main
{
    class Day8_Main
    {
        static void Main()
        {
            //StructDemo.StructDemoEx();
            //StructArray.StructArrayEx();
            //StructParameter.StructParameterEx();

            //StructDate structDate = new StructDate();
            //structDate.StructDateEx();

            //ConsoleColorDemo consoleColorDemo = new();
            //consoleColorDemo.ConsoleColorDemoEx();

            //EnumerationDemo enumerationDemo = new();
            //enumerationDemo.EnumerationDemoEx();

            //EnumIndexChange enumIndexChange = new();
            //enumIndexChange.EnumIndexChangeEx();

            EnumSwitch enumSwitch = new EnumSwitch();
            enumSwitch.EnumSwitchEx();
        }
    }
}