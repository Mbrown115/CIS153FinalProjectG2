﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CIS153_GitHubFinal.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CIS153_GitHubFinal.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.IO.UnmanagedMemoryStream similar to System.IO.MemoryStream.
        /// </summary>
        internal static System.IO.UnmanagedMemoryStream alert1 {
            get {
                return ResourceManager.GetStream("alert1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap ArcadeScreen_Crop {
            get {
                object obj = ResourceManager.GetObject("ArcadeScreen_Crop", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap ArcadeScreen_Crop_Purple {
            get {
                object obj = ResourceManager.GetObject("ArcadeScreen_Crop_Purple", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap ArcadeScreen_screenimage_ref {
            get {
                object obj = ResourceManager.GetObject("ArcadeScreen_screenimage_ref", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap ArcadeScreen_screenimage_ref_2 {
            get {
                object obj = ResourceManager.GetObject("ArcadeScreen_screenimage_ref_2", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap Connect4_21 {
            get {
                object obj = ResourceManager.GetObject("Connect4_21", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.IO.UnmanagedMemoryStream similar to System.IO.MemoryStream.
        /// </summary>
        internal static System.IO.UnmanagedMemoryStream connect4_Sound {
            get {
                return ResourceManager.GetStream("connect4_Sound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap finalGreen {
            get {
                object obj = ResourceManager.GetObject("finalGreen", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap FinalPlayer_Opng {
            get {
                object obj = ResourceManager.GetObject("FinalPlayer_Opng", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap FinalPlayer_Xpng {
            get {
                object obj = ResourceManager.GetObject("FinalPlayer_Xpng", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connect 4 Program Instructions:,
        ///
        ///Starting a Game:,
        ///	1. Select the size of your game board by selecting the number of cells in each column and row from the dropdown, 
        ///	   menu on the title screen.,
        ///	2. Select your opponent:,
        ///		- 2 Player - Play against another human., 
        ///		- x/o - Computer oponent playing as the selcted player (Player X goes first).,
        ///	3. Click &apos;Start Game&apos;.,
        ///
        ///Other Options:,
        ///	- At any time, you can select &apos;Leader Board&apos; to view the Win/Lose records of human players Vs. the computer [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Instructions {
            get {
                return ResourceManager.GetString("Instructions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connect 4 Rules,
        ///
        ///Objective:,
        ///	Be the first player to connect 4 of the same color tokens in a row to win the game!,
        ///
        ///How to Play:,
        ///	- Player &apos;X&apos; goes first, if you select &apos;X&apos; as your computer opponent, the computer will make the first move., 
        ///	- Players (or player and computer) alternate turns, and only one cell can be selected during each turn.,
        ///	- Cells are filled by &apos;dropping&apos; your token into the selected column. When you select a column your token will, 
        ///	  fall to the lowest open cell. You can [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Rules {
            get {
                return ResourceManager.GetString("Rules", resourceCulture);
            }
        }
    }
}
