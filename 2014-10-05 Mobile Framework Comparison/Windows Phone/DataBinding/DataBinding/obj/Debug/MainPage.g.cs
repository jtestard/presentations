﻿#pragma checksum "D:\Active Source HG\MSDN\DataBinding\DataBinding\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "41E0528F51F19EED1BF7C8F42462C73E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace DataBinding {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock NamePrompt;
        
        internal System.Windows.Controls.TextBlock SexPrompt;
        
        internal System.Windows.Controls.TextBlock HeightPrompt;
        
        internal System.Windows.Controls.TextBlock FavoritePrompt;
        
        internal System.Windows.Controls.TextBox Name;
        
        internal System.Windows.Controls.StackPanel BeardStackPanel;
        
        internal System.Windows.Controls.CheckBox Moustache;
        
        internal System.Windows.Controls.CheckBox Goatee;
        
        internal System.Windows.Controls.StackPanel SexStackPanel;
        
        internal System.Windows.Controls.RadioButton Male;
        
        internal System.Windows.Controls.RadioButton Female;
        
        internal System.Windows.Controls.StackPanel HeightStackPanel;
        
        internal System.Windows.Controls.Primitives.ToggleButton Favorite;
        
        internal System.Windows.Controls.Slider Likeability;
        
        internal System.Windows.Controls.StackPanel LikeabilityPercentStackPanel;
        
        internal System.Windows.Controls.TextBlock SliderValue;
        
        internal System.Windows.Controls.Button Next;
        
        internal System.Windows.Controls.Button Change;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/DataBinding;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.NamePrompt = ((System.Windows.Controls.TextBlock)(this.FindName("NamePrompt")));
            this.SexPrompt = ((System.Windows.Controls.TextBlock)(this.FindName("SexPrompt")));
            this.HeightPrompt = ((System.Windows.Controls.TextBlock)(this.FindName("HeightPrompt")));
            this.FavoritePrompt = ((System.Windows.Controls.TextBlock)(this.FindName("FavoritePrompt")));
            this.Name = ((System.Windows.Controls.TextBox)(this.FindName("Name")));
            this.BeardStackPanel = ((System.Windows.Controls.StackPanel)(this.FindName("BeardStackPanel")));
            this.Moustache = ((System.Windows.Controls.CheckBox)(this.FindName("Moustache")));
            this.Goatee = ((System.Windows.Controls.CheckBox)(this.FindName("Goatee")));
            this.SexStackPanel = ((System.Windows.Controls.StackPanel)(this.FindName("SexStackPanel")));
            this.Male = ((System.Windows.Controls.RadioButton)(this.FindName("Male")));
            this.Female = ((System.Windows.Controls.RadioButton)(this.FindName("Female")));
            this.HeightStackPanel = ((System.Windows.Controls.StackPanel)(this.FindName("HeightStackPanel")));
            this.Favorite = ((System.Windows.Controls.Primitives.ToggleButton)(this.FindName("Favorite")));
            this.Likeability = ((System.Windows.Controls.Slider)(this.FindName("Likeability")));
            this.LikeabilityPercentStackPanel = ((System.Windows.Controls.StackPanel)(this.FindName("LikeabilityPercentStackPanel")));
            this.SliderValue = ((System.Windows.Controls.TextBlock)(this.FindName("SliderValue")));
            this.Next = ((System.Windows.Controls.Button)(this.FindName("Next")));
            this.Change = ((System.Windows.Controls.Button)(this.FindName("Change")));
        }
    }
}

