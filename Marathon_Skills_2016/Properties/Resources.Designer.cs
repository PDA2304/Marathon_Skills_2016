﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Marathon_Skills_2016.Properties {
    using System;
    
    
    /// <summary>
    ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    /// </summary>
    // Этот класс создан автоматически классом StronglyTypedResourceBuilder
    // с помощью такого средства, как ResGen или Visual Studio.
    // Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    // с параметром /str или перестройте свой проект VS.
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
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Marathon_Skills_2016.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Перезаписывает свойство CurrentUICulture текущего потока для всех
        ///   обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
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
        ///   Ищет локализованную строку, похожую на Data Source=DESKTOP-1CRVPTK\ISIP_D_A_PAHOMOV;Initial Catalog=MarathonSkills2016;Integrated Security=True.
        /// </summary>
        internal static string connection {
            get {
                return ResourceManager.GetString("connection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на select * from Country.
        /// </summary>
        internal static string sql_country {
            get {
                return ResourceManager.GetString("sql_country", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на SELECT        TOP (100) PERCENT dbo.Role.RoleId, CONCAT(dbo.[User].FirstName, &apos; &apos;, dbo.[User].LastName, &apos; - &apos;, dbo.RegistrationEvent.BibNumber, &apos; (&apos;, dbo.Country.CountryCode, &apos;)&apos;) AS Expr1, dbo.Charity.CharityName, 
        ///                         dbo.Charity.CharityLogo, dbo.Charity.CharityDescription
        ///FROM            dbo.Country INNER JOIN
        ///                         dbo.Runner ON dbo.Country.CountryCode = dbo.Runner.CountryCode INNER JOIN
        ///                         dbo.Registration ON dbo.Runner.RunnerId = dbo.Re [остаток строки не уместился]&quot;;.
        /// </summary>
        internal static string sql_select_Runner_Sponsor {
            get {
                return ResourceManager.GetString("sql_select_Runner_Sponsor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Поиск локализованного ресурса типа System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap unnamed {
            get {
                object obj = ResourceManager.GetObject("unnamed", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}
