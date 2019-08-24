#region Header
//   Vorspire    _,-'/-'/  OPLGump.cs
//   .      __,-; ,'( '/
//    \.    `-.__`-._`:_,-._       _ , . ``
//     `:-._,------' ` _,`--` -: `_ , ` ,' :
//        `---..__,,--'  (C) 2018  ` -'. -'
//        #  Vita-Nex [http://core.vita-nex.com]  #
//  {o)xxx|===============-   #   -===============|xxx(o}
//        #        The MIT License (MIT)          #
#endregion

#region References
using System;
using System.Drawing;
using System.Reflection;
using System.Linq;

using Server;
using Server.Gumps;

using VitaNex.Text;
#endregion

namespace VitaNex.SuperGumps.UI
{
    public class SettingsGump<T> : SuperGumpList<PropertyInfo>
    {
        public T Object { get; set; }

        public SettingsGump(Mobile user, object obj)
            : base(user)
        {
            CanClose = true;
            CanDispose = true;
            CanMove = true;
            CanResize = true;

            ForceRecompile = true;
        }

        protected virtual bool CanRead(PropertyInfo p)
        {
            if (p == null || !p.CanRead)
            {
                return false;
            }

            var attrs = p.GetCustomAttributes(false);

            foreach (var a in attrs.OfType<CommandPropertyAttribute>())
            {
                if (User.AccessLevel < a.ReadLevel)
                {
                    return false;
                }
            }

            return true;
        }

        protected virtual bool CanWrite(PropertyInfo p)
        {
            if (p == null || !p.CanWrite)
            {
                return false;
            }

            var attrs = p.GetCustomAttributes(false);

            foreach (var a in attrs.OfType<CommandPropertyAttribute>())
            {
                if (User.AccessLevel < a.WriteLevel || a.ReadOnly)
                {
                    return false;
                }
            }

            return true;
        }

        protected bool TryParse<P>(string input, out P value) 
        {
            if (input.TryParse<P>(out value))
            {
                return true;
            }



            return false;
        }

        protected override void CompileList(System.Collections.Generic.List<PropertyInfo> list)
        {
            list.Clear();

            if (Object != null)
            {
                var type = Object.GetType();
                var flags = BindingFlags.Public;

                if (type.IsAbstract && type.IsSealed)
                {
                    flags |= BindingFlags.Static;
                }
                else
                {
                    flags |= BindingFlags.Instance;
                }

                var props = type.GetProperties(flags).AsEnumerable();

                props = props.Where(p => p.CanRead);
                props = props.Where(CanRead);
                
                list.AddRange(props);
            }

            base.CompileList(list);
        }

        protected override void CompileLayout(SuperGumpLayout layout)
        {
            base.CompileLayout(layout);
        }
    }
}